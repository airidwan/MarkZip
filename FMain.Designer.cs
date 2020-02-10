namespace MarkZip {
    partial class FMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProccessZip = new MetroFramework.Controls.MetroButton();
            this.textDestFolder = new MetroFramework.Controls.MetroTextBox();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.btnSetDest = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.bsFileSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSourceFiles = new MarkZip.data.DsSourceFiles();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.noDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listFilesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSourceFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.btnProccessZip, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textDestFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetDest, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroGrid1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 399);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnProccessZip
            // 
            this.btnProccessZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnProccessZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProccessZip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProccessZip.Location = new System.Drawing.Point(508, 3);
            this.btnProccessZip.Name = "btnProccessZip";
            this.btnProccessZip.Size = new System.Drawing.Size(79, 24);
            this.btnProccessZip.TabIndex = 4;
            this.btnProccessZip.Text = "Zip";
            this.btnProccessZip.UseCustomBackColor = true;
            this.btnProccessZip.UseCustomForeColor = true;
            this.btnProccessZip.UseSelectable = true;
            this.btnProccessZip.UseStyleColors = true;
            this.btnProccessZip.Click += new System.EventHandler(this.btnProccessZip_Click);
            // 
            // textDestFolder
            // 
            // 
            // 
            // 
            this.textDestFolder.CustomButton.Image = null;
            this.textDestFolder.CustomButton.Location = new System.Drawing.Point(307, 2);
            this.textDestFolder.CustomButton.Name = "";
            this.textDestFolder.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.textDestFolder.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.textDestFolder.CustomButton.TabIndex = 1;
            this.textDestFolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textDestFolder.CustomButton.UseSelectable = true;
            this.textDestFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SelectedPath", true));
            this.textDestFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDestFolder.Lines = new string[0];
            this.textDestFolder.Location = new System.Drawing.Point(173, 3);
            this.textDestFolder.MaxLength = 32767;
            this.textDestFolder.Name = "textDestFolder";
            this.textDestFolder.PasswordChar = '\0';
            this.textDestFolder.PromptText = "Path Folder";
            this.textDestFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textDestFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textDestFolder.SelectedText = "";
            this.textDestFolder.SelectionLength = 0;
            this.textDestFolder.SelectionStart = 0;
            this.textDestFolder.ShortcutsEnabled = true;
            this.textDestFolder.ShowButton = true;
            this.textDestFolder.Size = new System.Drawing.Size(329, 24);
            this.textDestFolder.Style = MetroFramework.MetroColorStyle.Purple;
            this.textDestFolder.TabIndex = 5;
            this.textDestFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDestFolder.UseSelectable = true;
            this.textDestFolder.UseStyleColors = true;
            this.textDestFolder.WaterMark = "Path Folder";
            this.textDestFolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textDestFolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textDestFolder.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.textDestFolder_ButtonClick);
            this.textDestFolder.TextChanged += new System.EventHandler(this.textDestFolder_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(79, 24);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add Files";
            this.BtnAdd.UseCustomBackColor = true;
            this.BtnAdd.UseCustomForeColor = true;
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.UseStyleColors = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSetDest
            // 
            this.btnSetDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSetDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetDest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetDest.Location = new System.Drawing.Point(88, 3);
            this.btnSetDest.Name = "btnSetDest";
            this.btnSetDest.Size = new System.Drawing.Size(79, 24);
            this.btnSetDest.TabIndex = 6;
            this.btnSetDest.Text = "Dest Folder";
            this.btnSetDest.UseCustomBackColor = true;
            this.btnSetDest.UseCustomForeColor = true;
            this.btnSetDest.UseSelectable = true;
            this.btnSetDest.UseStyleColors = true;
            this.btnSetDest.Click += new System.EventHandler(this.btnSetDest_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeight = 25;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn1,
            this.listFilesDataGridViewTextBoxColumn1,
            this.zipDataGridViewTextBoxColumn1});
            this.tableLayoutPanel1.SetColumnSpan(this.metroGrid1, 4);
            this.metroGrid1.DataSource = this.bsFileSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 33);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 24;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(584, 363);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            this.metroGrid1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.metroGrid1_UserDeletedRow);
            // 
            // bsFileSource
            // 
            this.bsFileSource.DataMember = "DtListFiles";
            this.bsFileSource.DataSource = this.dsSourceFiles;
            this.bsFileSource.Sort = "No";
            // 
            // dsSourceFiles
            // 
            this.dsSourceFiles.DataSetName = "DsSourceFiles";
            this.dsSourceFiles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_7zip_16px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_new_window_16px.png");
            this.imageList1.Images.SetKeyName(2, "icons8_open_in_browser_16px.png");
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            // 
            // noDataGridViewTextBoxColumn1
            // 
            this.noDataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn1.FillWeight = 30F;
            this.noDataGridViewTextBoxColumn1.Frozen = true;
            this.noDataGridViewTextBoxColumn1.HeaderText = "No";
            this.noDataGridViewTextBoxColumn1.Name = "noDataGridViewTextBoxColumn1";
            this.noDataGridViewTextBoxColumn1.ReadOnly = true;
            this.noDataGridViewTextBoxColumn1.Width = 30;
            // 
            // listFilesDataGridViewTextBoxColumn1
            // 
            this.listFilesDataGridViewTextBoxColumn1.DataPropertyName = "ListFiles";
            this.listFilesDataGridViewTextBoxColumn1.FillWeight = 500F;
            this.listFilesDataGridViewTextBoxColumn1.HeaderText = "ListFiles";
            this.listFilesDataGridViewTextBoxColumn1.MinimumWidth = 500;
            this.listFilesDataGridViewTextBoxColumn1.Name = "listFilesDataGridViewTextBoxColumn1";
            this.listFilesDataGridViewTextBoxColumn1.Width = 500;
            // 
            // zipDataGridViewTextBoxColumn1
            // 
            this.zipDataGridViewTextBoxColumn1.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn1.FalseValue = "0";
            this.zipDataGridViewTextBoxColumn1.FillWeight = 30F;
            this.zipDataGridViewTextBoxColumn1.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn1.IndeterminateValue = "0";
            this.zipDataGridViewTextBoxColumn1.MinimumWidth = 30;
            this.zipDataGridViewTextBoxColumn1.Name = "zipDataGridViewTextBoxColumn1";
            this.zipDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zipDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zipDataGridViewTextBoxColumn1.TrueValue = "1";
            this.zipDataGridViewTextBoxColumn1.Width = 30;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Purple;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(5, 68);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(590, 10);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MarkZip.ViewServices.MarkZipRepo);
            this.bindingSource1.Sort = "";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(600, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 783);
            this.MinimumSize = new System.Drawing.Size(600, 483);
            this.Name = "FMain";
            this.Padding = new System.Windows.Forms.Padding(5, 68, 5, 6);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "MarkZip";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSourceFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bsFileSource;
        private data.DsSourceFiles dsSourceFiles;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton btnProccessZip;
        private MetroFramework.Controls.MetroTextBox textDestFolder;
        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroButton btnSetDest;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listFilesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zipDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

