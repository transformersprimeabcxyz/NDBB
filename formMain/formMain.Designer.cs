namespace NDBB
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namespaceListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nativesListView = new System.Windows.Forms.ListView();
            this.colHash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbnRadioButton = new System.Windows.Forms.RadioButton();
            this.sbhRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNativesFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNativesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNativesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedNativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPedModeslToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionRTB = new System.Windows.Forms.RichTextBox();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadFromFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.descriptionRTB);
            this.splitContainer1.Size = new System.Drawing.Size(752, 636);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(752, 385);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namespaceListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Namespaces";
            // 
            // namespaceListBox
            // 
            this.namespaceListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namespaceListBox.FormattingEnabled = true;
            this.namespaceListBox.Location = new System.Drawing.Point(3, 16);
            this.namespaceListBox.Name = "namespaceListBox";
            this.namespaceListBox.Size = new System.Drawing.Size(156, 366);
            this.namespaceListBox.TabIndex = 0;
            this.namespaceListBox.SelectedIndexChanged += new System.EventHandler(this.namespaceListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nativesListView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 338);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Native Functions";
            // 
            // nativesListView
            // 
            this.nativesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.nativesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHash,
            this.colName,
            this.colResult});
            this.nativesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nativesListView.FullRowSelect = true;
            this.nativesListView.GridLines = true;
            this.nativesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.nativesListView.HideSelection = false;
            this.nativesListView.Location = new System.Drawing.Point(3, 16);
            this.nativesListView.MultiSelect = false;
            this.nativesListView.Name = "nativesListView";
            this.nativesListView.Size = new System.Drawing.Size(580, 319);
            this.nativesListView.TabIndex = 0;
            this.nativesListView.UseCompatibleStateImageBehavior = false;
            this.nativesListView.View = System.Windows.Forms.View.Details;
            this.nativesListView.SelectedIndexChanged += new System.EventHandler(this.nativesListView_SelectedIndexChanged);
            // 
            // colHash
            // 
            this.colHash.Text = "Hash";
            this.colHash.Width = 150;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 320;
            // 
            // colResult
            // 
            this.colResult.Text = "Result";
            this.colResult.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sbnRadioButton);
            this.groupBox2.Controls.Add(this.sbhRadioButton);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 47);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // sbnRadioButton
            // 
            this.sbnRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbnRadioButton.AutoSize = true;
            this.sbnRadioButton.Checked = true;
            this.sbnRadioButton.Location = new System.Drawing.Point(370, 20);
            this.sbnRadioButton.Name = "sbnRadioButton";
            this.sbnRadioButton.Size = new System.Drawing.Size(68, 17);
            this.sbnRadioButton.TabIndex = 3;
            this.sbnRadioButton.TabStop = true;
            this.sbnRadioButton.Text = "By Name";
            this.sbnRadioButton.UseVisualStyleBackColor = true;
            // 
            // sbhRadioButton
            // 
            this.sbhRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbhRadioButton.AutoSize = true;
            this.sbhRadioButton.Location = new System.Drawing.Point(444, 20);
            this.sbhRadioButton.Name = "sbhRadioButton";
            this.sbhRadioButton.Size = new System.Drawing.Size(65, 17);
            this.sbhRadioButton.TabIndex = 2;
            this.sbhRadioButton.TabStop = true;
            this.sbhRadioButton.Text = "By Hash";
            this.sbhRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(515, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(59, 21);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(358, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNativesFromDBToolStripMenuItem,
            this.updateNativesToolStripMenuItem,
            this.exportNativesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadNativesFromDBToolStripMenuItem
            // 
            this.loadNativesFromDBToolStripMenuItem.Name = "loadNativesFromDBToolStripMenuItem";
            this.loadNativesFromDBToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.loadNativesFromDBToolStripMenuItem.Text = "Load Natives From File";
            this.loadNativesFromDBToolStripMenuItem.Click += new System.EventHandler(this.loadNativesFromDBToolStripMenuItem_Click);
            // 
            // updateNativesToolStripMenuItem
            // 
            this.updateNativesToolStripMenuItem.Name = "updateNativesToolStripMenuItem";
            this.updateNativesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.updateNativesToolStripMenuItem.Text = "Update Natives";
            this.updateNativesToolStripMenuItem.Click += new System.EventHandler(this.updateNativesToolStripMenuItem_Click);
            // 
            // exportNativesToolStripMenuItem
            // 
            this.exportNativesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem,
            this.cHeaderToolStripMenuItem});
            this.exportNativesToolStripMenuItem.Name = "exportNativesToolStripMenuItem";
            this.exportNativesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exportNativesToolStripMenuItem.Text = "Export Natives";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // cHeaderToolStripMenuItem
            // 
            this.cHeaderToolStripMenuItem.Name = "cHeaderToolStripMenuItem";
            this.cHeaderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cHeaderToolStripMenuItem.Text = "C++ Header";
            this.cHeaderToolStripMenuItem.Click += new System.EventHandler(this.cHeaderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.editSelectedNativeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.copyToolStripMenuItem.Text = "Copy Selected Native";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // editSelectedNativeToolStripMenuItem
            // 
            this.editSelectedNativeToolStripMenuItem.Name = "editSelectedNativeToolStripMenuItem";
            this.editSelectedNativeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editSelectedNativeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.editSelectedNativeToolStripMenuItem.Text = "Edit Selected Native";
            this.editSelectedNativeToolStripMenuItem.Click += new System.EventHandler(this.editSelectedNativeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfPedModeslToolStripMenuItem,
            this.vehicleModelsToolStripMenuItem,
            this.weaponsToolStripMenuItem,
            this.typesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // listOfPedModeslToolStripMenuItem
            // 
            this.listOfPedModeslToolStripMenuItem.Enabled = false;
            this.listOfPedModeslToolStripMenuItem.Name = "listOfPedModeslToolStripMenuItem";
            this.listOfPedModeslToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listOfPedModeslToolStripMenuItem.Text = "Ped Models";
            // 
            // vehicleModelsToolStripMenuItem
            // 
            this.vehicleModelsToolStripMenuItem.Enabled = false;
            this.vehicleModelsToolStripMenuItem.Name = "vehicleModelsToolStripMenuItem";
            this.vehicleModelsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.vehicleModelsToolStripMenuItem.Text = "Vehicle Models";
            // 
            // weaponsToolStripMenuItem
            // 
            this.weaponsToolStripMenuItem.Enabled = false;
            this.weaponsToolStripMenuItem.Name = "weaponsToolStripMenuItem";
            this.weaponsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.weaponsToolStripMenuItem.Text = "Weapons";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Enabled = false;
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.typesToolStripMenuItem.Text = "Types";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Enabled = false;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRTB.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRTB.Location = new System.Drawing.Point(0, 0);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.ReadOnly = true;
            this.descriptionRTB.Size = new System.Drawing.Size(752, 223);
            this.descriptionRTB.TabIndex = 0;
            this.descriptionRTB.Text = "";
            this.descriptionRTB.WordWrap = false;
            // 
            // loadFromFileDialog
            // 
            this.loadFromFileDialog.DefaultExt = "json";
            this.loadFromFileDialog.FileName = "natives";
            this.loadFromFileDialog.Filter = "JSON|*.json";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 636);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(768, 675);
            this.Name = "formMain";
            this.Text = "NDBB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox namespaceListBox;
        private System.Windows.Forms.ListView nativesListView;
        private System.Windows.Forms.RadioButton sbnRadioButton;
        private System.Windows.Forms.RadioButton sbhRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNativesFromDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateNativesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportNativesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPedModeslToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleModelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colHash;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colResult;
        private System.Windows.Forms.ToolStripMenuItem editSelectedNativeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.OpenFileDialog loadFromFileDialog;
    }
}

