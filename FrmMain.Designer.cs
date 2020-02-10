namespace MarkZip {
    partial class FrmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSetDest = new System.Windows.Forms.Button();
            this.textDestFolder = new System.Windows.Forms.TextBox();
            this.btnProccessZip = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listFilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsFileSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSourceFiles = new MarkZip.data.DsSourceFiles();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSourceFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetDest, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textDestFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProccessZip, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.ImageIndex = 1;
            this.BtnAdd.ImageList = this.imageList1;
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(59, 24);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_7zip_16px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_new_window_16px.png");
            this.imageList1.Images.SetKeyName(2, "icons8_open_in_browser_16px.png");
            // 
            // btnSetDest
            // 
            this.btnSetDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetDest.ImageIndex = 2;
            this.btnSetDest.ImageList = this.imageList1;
            this.btnSetDest.Location = new System.Drawing.Point(68, 3);
            this.btnSetDest.Name = "btnSetDest";
            this.btnSetDest.Size = new System.Drawing.Size(79, 24);
            this.btnSetDest.TabIndex = 1;
            this.btnSetDest.Text = "Dest Folder";
            this.btnSetDest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetDest.UseVisualStyleBackColor = true;
            this.btnSetDest.Click += new System.EventHandler(this.btnSetDest_Click);
            // 
            // textDestFolder
            // 
            this.textDestFolder.BackColor = System.Drawing.SystemColors.InfoText;
            this.textDestFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDestFolder.ForeColor = System.Drawing.SystemColors.Info;
            this.textDestFolder.Location = new System.Drawing.Point(153, 3);
            this.textDestFolder.Multiline = true;
            this.textDestFolder.Name = "textDestFolder";
            this.textDestFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textDestFolder.Size = new System.Drawing.Size(340, 24);
            this.textDestFolder.TabIndex = 2;
            this.textDestFolder.TextChanged += new System.EventHandler(this.textDestFolder_TextChanged);
            // 
            // btnProccessZip
            // 
            this.btnProccessZip.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProccessZip.ImageIndex = 0;
            this.btnProccessZip.ImageList = this.imageList1;
            this.btnProccessZip.Location = new System.Drawing.Point(499, 3);
            this.btnProccessZip.Name = "btnProccessZip";
            this.btnProccessZip.Size = new System.Drawing.Size(84, 24);
            this.btnProccessZip.TabIndex = 1;
            this.btnProccessZip.Text = "Proccess";
            this.btnProccessZip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProccessZip.UseVisualStyleBackColor = true;
            this.btnProccessZip.Click += new System.EventHandler(this.btnProccessZip_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.listFilesDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvList, 4);
            this.dgvList.DataSource = this.bsFileSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 33);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.Size = new System.Drawing.Size(580, 406);
            this.dgvList.TabIndex = 3;
            this.dgvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 40;
            // 
            // listFilesDataGridViewTextBoxColumn
            // 
            this.listFilesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.listFilesDataGridViewTextBoxColumn.DataPropertyName = "ListFiles";
            this.listFilesDataGridViewTextBoxColumn.HeaderText = "ListFiles";
            this.listFilesDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.listFilesDataGridViewTextBoxColumn.Name = "listFilesDataGridViewTextBoxColumn";
            this.listFilesDataGridViewTextBoxColumn.ReadOnly = true;
            this.listFilesDataGridViewTextBoxColumn.Width = 400;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.FalseValue = "0";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.IndeterminateValue = "0";
            this.zipDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            this.zipDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.zipDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zipDataGridViewTextBoxColumn.TrueValue = "1";
            this.zipDataGridViewTextBoxColumn.Width = 30;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blazip";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSourceFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnSetDest;
        private System.Windows.Forms.TextBox textDestFolder;
        private System.Windows.Forms.Button btnProccessZip;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.BindingSource bsFileSource;
        private data.DsSourceFiles dsSourceFiles;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listFilesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zipDataGridViewTextBoxColumn;
    }
}

