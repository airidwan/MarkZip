using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using MarkZip.data;
using System.Diagnostics;

namespace MarkZip {
    public partial class FrmMain:Form {
        public FrmMain() {
            InitializeComponent();
            dsPathConfig = $@".\{dsSourceFiles.DataSetName}.xsd";
        }
        string dsPathConfig = string.Empty;
        DsSourceFiles.ParameterRow drParamFolder => dsSourceFiles.Parameter.AsEnumerable().FirstOrDefault(r => r.Grup == "Config" && r.Nama == "DestinationFolder");

 
        #region COntrol
        private void FrmMain_Load(object sender, EventArgs e) {
            LoadConfig();
        }
        protected override void OnClosing(CancelEventArgs e) {
            Save();
        }
        private void BtnAdd_Click(object sender, EventArgs e) {
            AddFiles();
        }

        private void btnSetDest_Click(object sender, EventArgs e) {
            SelectDestFolder();
        }

        private void btnProccessZip_Click(object sender, EventArgs e) {
            if(SaveValidate())
                Proccess();
            else
                MessageBox.Show("Faillure");
        }
        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if(dsSourceFiles.HasChanges()) {
                Save();
            }
        }
        #endregion
        #region Services Method
        void LoadConfig() {
            if(!File.Exists(dsPathConfig)) {
                if(drParamFolder == null) {
                    dsSourceFiles.Parameter.Rows.Add("Config", "DestinationFolder", $@"{Directory.GetCurrentDirectory()}\FileZip.zip");
                    dsSourceFiles.Parameter.AcceptChanges();
                }
                dsSourceFiles.WriteXml(dsPathConfig, XmlWriteMode.WriteSchema);
            }

            dsSourceFiles.ReadXml(dsPathConfig, XmlReadMode.ReadSchema);
            textDestFolder.Text = drParamFolder?.Nilai;


        }
        void Save() {
            drParamFolder.Nilai = textDestFolder.Text;
            if(dsSourceFiles.HasChanges()) {
                dsSourceFiles.AcceptChanges();
                dsSourceFiles.WriteXml(dsPathConfig, XmlWriteMode.WriteSchema);
            }
        }
        void AddFiles() {
            using(var ofd = new OpenFileDialog() { Multiselect = true }) {
                if(ofd.ShowDialog() == DialogResult.OK) {
                    foreach(var folderFile in ofd.FileNames) {
                        //fileZipModel.TargetFiles.Add(folderFile);
                        dsSourceFiles.DtListFiles.Rows.Add(null, folderFile, 1);
                    }
                }
            }
        }
        void SelectDestFolder() {
            using(var sfdZipfile = new SaveFileDialog() { Filter = "Zip Files|*.zip|All Files|*.*" }) {
                if(sfdZipfile.ShowDialog() == DialogResult.OK) {
                    textDestFolder.Text = sfdZipfile.FileName;
                }
            }
        }
        void Proccess() {
            try {
                var fileList = dsSourceFiles.DtListFiles.Rows.Cast<DataRow>().ToList().Select(x => x.Field<string>(dsSourceFiles.DtListFiles.ListFilesColumn));
                using(var zip = ZipFile.Open(drParamFolder?.Nilai, ZipArchiveMode.Create)) {
                    foreach(var file in fileList) {
                        zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
                    }
                }
                MessageBox.Show("Done");
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }
        bool SaveValidate() {
            return (drParamFolder != null && dsSourceFiles.DtListFiles.Rows.Count > 0);
        }
        #endregion

        private void textDestFolder_TextChanged(object sender, EventArgs e) {
            if(drParamFolder != null)
                drParamFolder.Nilai = textDestFolder.Text;

        }
    }
}
