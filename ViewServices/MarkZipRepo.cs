using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarkZip.data;

namespace MarkZip.ViewServices {
    public class MarkZipRepo:INotifyPropertyChanged {
        #region Fields
        string dsPathConfig;
        private string _SelectedPath = string.Empty;
        private DsSourceFiles _dsSourceFiles = new DsSourceFiles();
        #endregion
        #region Properties
        public string SelectedPath {
            get { return _SelectedPath; }
            set { if(value != _SelectedPath) { _SelectedPath = value; OnPropertyChanged(); } }
        }
        public DsSourceFiles dsSourceFiles {
            get { return _dsSourceFiles; }
            set { if(value != _dsSourceFiles) { _dsSourceFiles = value; OnPropertyChanged(); } }
        }
        #endregion
        #region inotifChangedEvent
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName()] string name = null) {
            if(name != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
        #region Constructor
        public MarkZipRepo(DsSourceFiles dsSource, string _pathConfig) {
            dsPathConfig = _pathConfig; dsSourceFiles = dsSource;
        }
        public MarkZipRepo() {
            dsPathConfig = $@".\{dsSourceFiles.DataSetName}.xsd";
        }
        #endregion
        #region Services Method
        public DsSourceFiles.ParameterRow drParamFolder => dsSourceFiles.Parameter.AsEnumerable().FirstOrDefault(r => r.Grup == "Config" && r.Nama == "DestinationFolder");

        public void LoadConfig() {
            if(!File.Exists(dsPathConfig)) {
                if(drParamFolder == null) {
                    dsSourceFiles.Parameter.Rows.Add("Config", "DestinationFolder", $@"{Directory.GetCurrentDirectory()}\FileZip.zip");
                    dsSourceFiles.Parameter.AcceptChanges();
                }
                dsSourceFiles.WriteXml(dsPathConfig, XmlWriteMode.WriteSchema);
            }

            dsSourceFiles.ReadXml(dsPathConfig, XmlReadMode.ReadSchema);
            SelectedPath = drParamFolder?.Nilai;


        }
        public void Save() {
            drParamFolder.Nilai = SelectedPath;
            if(dsSourceFiles.HasChanges()) {
                dsSourceFiles.AcceptChanges();
                dsSourceFiles.WriteXml(dsPathConfig, XmlWriteMode.WriteSchema);
            }

        }
        public void AddFiles() {
            using(var ofd = new System.Windows.Forms.OpenFileDialog() { Multiselect = true }) {
                if(ofd.ShowDialog() == DialogResult.OK) {
                    foreach(var folderFile in ofd.FileNames) {
                        dsSourceFiles.DtListFiles.Rows.Add(null, folderFile, 1);
                    }
                }
            }
        }
        public void SelectDestFolder() {
            using(var sfdZipfile = new SaveFileDialog() { Filter = "Zip Files|*.zip|All Files|*.*" }) {
                if(sfdZipfile.ShowDialog() == DialogResult.OK) {
                    SelectedPath = sfdZipfile.FileName;
                }
            }
        }
        public void Proccess() {
            try {
                var fileList = dsSourceFiles.DtListFiles.Rows.Cast<DataRow>().ToList().Select(x => x.Field<string>(dsSourceFiles.DtListFiles.ListFilesColumn));
                using(var zip = ZipFile.Open(drParamFolder?.Nilai, ZipArchiveMode.Create)) {
                    foreach(var row in dsSourceFiles.DtListFiles.AsEnumerable().ToList()) {
                        if(row.Zip == 1)
                            zip.CreateEntryFromFile(row.ListFiles, Path.GetFileName(row.ListFiles), CompressionLevel.Optimal);

                    }
                }
                MessageBox.Show("Done");
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }
        public bool SaveValidate() {
            return (drParamFolder != null && dsSourceFiles.DtListFiles.Rows.Count > 0);
        }
        #endregion
    }
}
