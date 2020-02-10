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
using MarkZip.ViewServices;

namespace MarkZip {
    public partial class FMain:MetroFramework.Forms.MetroForm {
        string dsPathConfig = string.Empty;
        MarkZipRepo markZipRepo { get; set; }
        public FMain() {
            InitializeComponent();
            dsPathConfig = $@".\{dsSourceFiles.DataSetName}.xsd";
            markZipRepo = new MarkZipRepo(dsSourceFiles, dsPathConfig);
            bindingSource1.DataSource = markZipRepo;
            //this.Padding = new Padding(5, 20, 5, 5);
        }
        #region COntrol
        private void FrmMain_Load(object sender, EventArgs e) {
            markZipRepo.LoadConfig();
            Debug.WriteLine($"---->{Properties.Resources.ResourceManager.GetObject("MetroFramework.Design.dll")}");
            Debug.WriteLine($"---->{Properties.Resources.ResourceManager.GetString("MetroFramework.Design.dll")}");
        }
        protected override void OnClosing(CancelEventArgs e) {
            markZipRepo.Save();
        }
        private void BtnAdd_Click(object sender, EventArgs e) {
            markZipRepo.AddFiles();
        }

        private void btnSetDest_Click(object sender, EventArgs e) {
            markZipRepo.SelectDestFolder();
        }

        private void btnProccessZip_Click(object sender, EventArgs e) {
            if(markZipRepo.SaveValidate())
                markZipRepo.Proccess();
            else
                MessageBox.Show("Faillure");
        }
        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if(dsSourceFiles.HasChanges()) {
                markZipRepo.Save();
            }
        }
  
    
        private void textDestFolder_TextChanged(object sender, EventArgs e) {
            if(markZipRepo.drParamFolder != null)
                markZipRepo.drParamFolder.Nilai = textDestFolder.Text;
        }

        private void textDestFolder_ButtonClick(object sender, EventArgs e) {
            try {
                var folderPath = Path.GetDirectoryName(textDestFolder.Text);
                if(Directory.Exists(folderPath)) {
                    ProcessStartInfo startInfo = new ProcessStartInfo {
                        Arguments = folderPath,
                        FileName = "explorer.exe"
                    };

                    Process.Start(startInfo);
                } else {
                    MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
                }
            } catch(Exception ex) {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void metroGrid1_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
          
                markZipRepo.Save();
        }
        #endregion
    }
}
