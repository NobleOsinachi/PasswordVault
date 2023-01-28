﻿using ReaLTaiizor.Controls;

namespace WinformPasswordVault
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.materialTextBoxFilter = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.poisonGridVault = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.poisonContextMenuStripGrid = new ReaLTaiizor.Controls.PoisonContextMenuStrip(this.components);
            this.supprimerLélémentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageFirefox = new System.Windows.Forms.TabPage();
            this.checkedListBoxMdpFireFox = new System.Windows.Forms.CheckedListBox();
            this.buttonViewFirefox = new System.Windows.Forms.Button();
            this.labelViewFirefox = new System.Windows.Forms.Label();
            this.buttonImportFromFirefox = new System.Windows.Forms.Button();
            this.labelImportFromFirefox = new System.Windows.Forms.Label();
            this.tabPageOption = new System.Windows.Forms.TabPage();
            this.groupBoxMyPassword = new System.Windows.Forms.GroupBox();
            this.groupBoxTranslateMsg = new System.Windows.Forms.GroupBox();
            this.labelMsgAddDoneTitle = new System.Windows.Forms.Label();
            this.labelMsgAddDone = new System.Windows.Forms.Label();
            this.labelMsgImportTitle = new System.Windows.Forms.Label();
            this.labelMsgImport = new System.Windows.Forms.Label();
            this.labelGridKeyword = new System.Windows.Forms.Label();
            this.labelGridData = new System.Windows.Forms.Label();
            this.labelGridPassword = new System.Windows.Forms.Label();
            this.labelGridLogin = new System.Windows.Forms.Label();
            this.labelMsgPasswordTitle = new System.Windows.Forms.Label();
            this.labelMsgPassword = new System.Windows.Forms.Label();
            this.textBoxMdpKeyword = new System.Windows.Forms.TextBox();
            this.labelMdpKeyword = new System.Windows.Forms.Label();
            this.textBoxMdpData = new System.Windows.Forms.TextBox();
            this.labelMdpData = new System.Windows.Forms.Label();
            this.textBoxMdpPassword = new System.Windows.Forms.TextBox();
            this.labelMdpPassword = new System.Windows.Forms.Label();
            this.textBoxMdpLogin = new System.Windows.Forms.TextBox();
            this.labelMdpLogin = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabPageSaveManagement = new System.Windows.Forms.TabPage();
            this.materialButtonSave = new ReaLTaiizor.Controls.MaterialButton();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.imageListTabCtrl = new System.Windows.Forms.ImageList(this.components);
            this.myVaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonGridVault)).BeginInit();
            this.poisonContextMenuStripGrid.SuspendLayout();
            this.tabPageFirefox.SuspendLayout();
            this.tabPageOption.SuspendLayout();
            this.groupBoxMyPassword.SuspendLayout();
            this.groupBoxTranslateMsg.SuspendLayout();
            this.tabPageSaveManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myVaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSearch);
            this.tabControlMain.Controls.Add(this.tabPageFirefox);
            this.tabControlMain.Controls.Add(this.tabPageOption);
            this.tabControlMain.Controls.Add(this.tabPageSaveManagement);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Depth = 0;
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.ImageList = this.imageListTabCtrl;
            this.tabControlMain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageSearch.Controls.Add(this.pictureBoxLogo);
            this.tabPageSearch.Controls.Add(this.materialTextBoxFilter);
            this.tabPageSearch.Controls.Add(this.poisonGridVault);
            resources.ApplyResources(this.tabPageSearch, "tabPageSearch");
            this.tabPageSearch.Name = "tabPageSearch";
            // 
            // pictureBoxLogo
            // 
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // materialTextBoxFilter
            // 
            this.materialTextBoxFilter.AnimateReadOnly = false;
            this.materialTextBoxFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBoxFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            resources.ApplyResources(this.materialTextBoxFilter, "materialTextBoxFilter");
            this.materialTextBoxFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialTextBoxFilter.Depth = 0;
            this.materialTextBoxFilter.HideSelection = true;
            this.materialTextBoxFilter.LeadingIcon = null;
            this.materialTextBoxFilter.MaxLength = 50;
            this.materialTextBoxFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialTextBoxFilter.Name = "materialTextBoxFilter";
            this.materialTextBoxFilter.PasswordChar = '\0';
            this.materialTextBoxFilter.ReadOnly = false;
            this.materialTextBoxFilter.SelectedText = "";
            this.materialTextBoxFilter.SelectionLength = 0;
            this.materialTextBoxFilter.SelectionStart = 0;
            this.materialTextBoxFilter.ShortcutsEnabled = true;
            this.materialTextBoxFilter.TabStop = false;
            this.materialTextBoxFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxFilter.TrailingIcon = global::WinformPasswordVault.Properties.Resources.save;
            this.materialTextBoxFilter.UseSystemPasswordChar = false;
            this.materialTextBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // poisonGridVault
            // 
            this.poisonGridVault.AllowUserToAddRows = false;
            this.poisonGridVault.AllowUserToDeleteRows = false;
            this.poisonGridVault.AllowUserToResizeRows = false;
            resources.ApplyResources(this.poisonGridVault, "poisonGridVault");
            this.poisonGridVault.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.poisonGridVault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonGridVault.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonGridVault.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(101)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonGridVault.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonGridVault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonGridVault.ContextMenuStrip = this.poisonContextMenuStripGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(101)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonGridVault.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonGridVault.EnableHeadersVisualStyles = false;
            this.poisonGridVault.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.poisonGridVault.MultiSelect = false;
            this.poisonGridVault.Name = "poisonGridVault";
            this.poisonGridVault.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(101)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonGridVault.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonGridVault.RowHeadersVisible = false;
            this.poisonGridVault.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonGridVault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.poisonGridVault.ShowCellErrors = false;
            this.poisonGridVault.ShowCellToolTips = false;
            this.poisonGridVault.ShowEditingIcon = false;
            this.poisonGridVault.ShowRowErrors = false;
            // 
            // poisonContextMenuStripGrid
            // 
            this.poisonContextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerLélémentToolStripMenuItem1});
            this.poisonContextMenuStripGrid.Name = "poisonContextMenuStripGrid";
            resources.ApplyResources(this.poisonContextMenuStripGrid, "poisonContextMenuStripGrid");
            // 
            // supprimerLélémentToolStripMenuItem1
            // 
            this.supprimerLélémentToolStripMenuItem1.Image = global::WinformPasswordVault.Properties.Resources.save;
            this.supprimerLélémentToolStripMenuItem1.Name = "supprimerLélémentToolStripMenuItem1";
            resources.ApplyResources(this.supprimerLélémentToolStripMenuItem1, "supprimerLélémentToolStripMenuItem1");
            this.supprimerLélémentToolStripMenuItem1.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // tabPageFirefox
            // 
            this.tabPageFirefox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageFirefox.Controls.Add(this.pictureBox1);
            this.tabPageFirefox.Controls.Add(this.checkedListBoxMdpFireFox);
            this.tabPageFirefox.Controls.Add(this.buttonViewFirefox);
            this.tabPageFirefox.Controls.Add(this.labelViewFirefox);
            this.tabPageFirefox.Controls.Add(this.buttonImportFromFirefox);
            this.tabPageFirefox.Controls.Add(this.labelImportFromFirefox);
            resources.ApplyResources(this.tabPageFirefox, "tabPageFirefox");
            this.tabPageFirefox.Name = "tabPageFirefox";
            // 
            // checkedListBoxMdpFireFox
            // 
            resources.ApplyResources(this.checkedListBoxMdpFireFox, "checkedListBoxMdpFireFox");
            this.checkedListBoxMdpFireFox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListBoxMdpFireFox.FormattingEnabled = true;
            this.checkedListBoxMdpFireFox.Name = "checkedListBoxMdpFireFox";
            // 
            // buttonViewFirefox
            // 
            this.buttonViewFirefox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.buttonViewFirefox, "buttonViewFirefox");
            this.buttonViewFirefox.Name = "buttonViewFirefox";
            this.buttonViewFirefox.UseVisualStyleBackColor = false;
            this.buttonViewFirefox.Click += new System.EventHandler(this.buttonShowImportData_Click);
            // 
            // labelViewFirefox
            // 
            resources.ApplyResources(this.labelViewFirefox, "labelViewFirefox");
            this.labelViewFirefox.Name = "labelViewFirefox";
            // 
            // buttonImportFromFirefox
            // 
            this.buttonImportFromFirefox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.buttonImportFromFirefox, "buttonImportFromFirefox");
            this.buttonImportFromFirefox.Name = "buttonImportFromFirefox";
            this.buttonImportFromFirefox.UseVisualStyleBackColor = false;
            this.buttonImportFromFirefox.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // labelImportFromFirefox
            // 
            resources.ApplyResources(this.labelImportFromFirefox, "labelImportFromFirefox");
            this.labelImportFromFirefox.Name = "labelImportFromFirefox";
            // 
            // tabPageOption
            // 
            this.tabPageOption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageOption.Controls.Add(this.pictureBox2);
            this.tabPageOption.Controls.Add(this.groupBoxMyPassword);
            this.tabPageOption.Controls.Add(this.buttonAdd);
            resources.ApplyResources(this.tabPageOption, "tabPageOption");
            this.tabPageOption.Name = "tabPageOption";
            // 
            // groupBoxMyPassword
            // 
            resources.ApplyResources(this.groupBoxMyPassword, "groupBoxMyPassword");
            this.groupBoxMyPassword.Controls.Add(this.groupBoxTranslateMsg);
            this.groupBoxMyPassword.Controls.Add(this.textBoxMdpKeyword);
            this.groupBoxMyPassword.Controls.Add(this.labelMdpKeyword);
            this.groupBoxMyPassword.Controls.Add(this.textBoxMdpData);
            this.groupBoxMyPassword.Controls.Add(this.labelMdpData);
            this.groupBoxMyPassword.Controls.Add(this.textBoxMdpPassword);
            this.groupBoxMyPassword.Controls.Add(this.labelMdpPassword);
            this.groupBoxMyPassword.Controls.Add(this.textBoxMdpLogin);
            this.groupBoxMyPassword.Controls.Add(this.labelMdpLogin);
            this.groupBoxMyPassword.Name = "groupBoxMyPassword";
            this.groupBoxMyPassword.TabStop = false;
            // 
            // groupBoxTranslateMsg
            // 
            this.groupBoxTranslateMsg.Controls.Add(this.labelMsgAddDoneTitle);
            this.groupBoxTranslateMsg.Controls.Add(this.labelMsgAddDone);
            this.groupBoxTranslateMsg.Controls.Add(this.labelMsgImportTitle);
            this.groupBoxTranslateMsg.Controls.Add(this.labelMsgImport);
            this.groupBoxTranslateMsg.Controls.Add(this.labelGridKeyword);
            this.groupBoxTranslateMsg.Controls.Add(this.labelGridData);
            this.groupBoxTranslateMsg.Controls.Add(this.labelGridPassword);
            this.groupBoxTranslateMsg.Controls.Add(this.labelGridLogin);
            this.groupBoxTranslateMsg.Controls.Add(this.labelMsgPasswordTitle);
            this.groupBoxTranslateMsg.Controls.Add(this.labelMsgPassword);
            resources.ApplyResources(this.groupBoxTranslateMsg, "groupBoxTranslateMsg");
            this.groupBoxTranslateMsg.Name = "groupBoxTranslateMsg";
            this.groupBoxTranslateMsg.TabStop = false;
            // 
            // labelMsgAddDoneTitle
            // 
            resources.ApplyResources(this.labelMsgAddDoneTitle, "labelMsgAddDoneTitle");
            this.labelMsgAddDoneTitle.Name = "labelMsgAddDoneTitle";
            // 
            // labelMsgAddDone
            // 
            resources.ApplyResources(this.labelMsgAddDone, "labelMsgAddDone");
            this.labelMsgAddDone.Name = "labelMsgAddDone";
            // 
            // labelMsgImportTitle
            // 
            resources.ApplyResources(this.labelMsgImportTitle, "labelMsgImportTitle");
            this.labelMsgImportTitle.Name = "labelMsgImportTitle";
            // 
            // labelMsgImport
            // 
            resources.ApplyResources(this.labelMsgImport, "labelMsgImport");
            this.labelMsgImport.Name = "labelMsgImport";
            // 
            // labelGridKeyword
            // 
            resources.ApplyResources(this.labelGridKeyword, "labelGridKeyword");
            this.labelGridKeyword.Name = "labelGridKeyword";
            // 
            // labelGridData
            // 
            resources.ApplyResources(this.labelGridData, "labelGridData");
            this.labelGridData.Name = "labelGridData";
            // 
            // labelGridPassword
            // 
            resources.ApplyResources(this.labelGridPassword, "labelGridPassword");
            this.labelGridPassword.Name = "labelGridPassword";
            // 
            // labelGridLogin
            // 
            resources.ApplyResources(this.labelGridLogin, "labelGridLogin");
            this.labelGridLogin.Name = "labelGridLogin";
            // 
            // labelMsgPasswordTitle
            // 
            resources.ApplyResources(this.labelMsgPasswordTitle, "labelMsgPasswordTitle");
            this.labelMsgPasswordTitle.Name = "labelMsgPasswordTitle";
            // 
            // labelMsgPassword
            // 
            resources.ApplyResources(this.labelMsgPassword, "labelMsgPassword");
            this.labelMsgPassword.Name = "labelMsgPassword";
            // 
            // textBoxMdpKeyword
            // 
            resources.ApplyResources(this.textBoxMdpKeyword, "textBoxMdpKeyword");
            this.textBoxMdpKeyword.Name = "textBoxMdpKeyword";
            // 
            // labelMdpKeyword
            // 
            resources.ApplyResources(this.labelMdpKeyword, "labelMdpKeyword");
            this.labelMdpKeyword.Name = "labelMdpKeyword";
            // 
            // textBoxMdpData
            // 
            resources.ApplyResources(this.textBoxMdpData, "textBoxMdpData");
            this.textBoxMdpData.Name = "textBoxMdpData";
            // 
            // labelMdpData
            // 
            resources.ApplyResources(this.labelMdpData, "labelMdpData");
            this.labelMdpData.Name = "labelMdpData";
            // 
            // textBoxMdpPassword
            // 
            resources.ApplyResources(this.textBoxMdpPassword, "textBoxMdpPassword");
            this.textBoxMdpPassword.Name = "textBoxMdpPassword";
            // 
            // labelMdpPassword
            // 
            resources.ApplyResources(this.labelMdpPassword, "labelMdpPassword");
            this.labelMdpPassword.Name = "labelMdpPassword";
            // 
            // textBoxMdpLogin
            // 
            resources.ApplyResources(this.textBoxMdpLogin, "textBoxMdpLogin");
            this.textBoxMdpLogin.Name = "textBoxMdpLogin";
            // 
            // labelMdpLogin
            // 
            resources.ApplyResources(this.labelMdpLogin, "labelMdpLogin");
            this.labelMdpLogin.Name = "labelMdpLogin";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tabPageSaveManagement
            // 
            this.tabPageSaveManagement.Controls.Add(this.pictureBox3);
            this.tabPageSaveManagement.Controls.Add(this.materialButtonSave);
            resources.ApplyResources(this.tabPageSaveManagement, "tabPageSaveManagement");
            this.tabPageSaveManagement.Name = "tabPageSaveManagement";
            this.tabPageSaveManagement.UseVisualStyleBackColor = true;
            // 
            // materialButtonSave
            // 
            resources.ApplyResources(this.materialButtonSave, "materialButtonSave");
            this.materialButtonSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSave.Depth = 0;
            this.materialButtonSave.HighEmphasis = true;
            this.materialButtonSave.Icon = global::WinformPasswordVault.Properties.Resources.save;
            this.materialButtonSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButtonSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButtonSave.Name = "materialButtonSave";
            this.materialButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSave.UseAccentColor = true;
            this.materialButtonSave.UseVisualStyleBackColor = true;
            this.materialButtonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabPageAbout
            // 
            resources.ApplyResources(this.tabPageAbout, "tabPageAbout");
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // imageListTabCtrl
            // 
            this.imageListTabCtrl.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListTabCtrl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabCtrl.ImageStream")));
            this.imageListTabCtrl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabCtrl.Images.SetKeyName(0, "round_bookmark_white_24dp.png");
            this.imageListTabCtrl.Images.SetKeyName(1, "round_build_white_24dp.png");
            this.imageListTabCtrl.Images.SetKeyName(2, "round_gps_fixed_white_24dp.png");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabControlMain);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControlMain;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonGridVault)).EndInit();
            this.poisonContextMenuStripGrid.ResumeLayout(false);
            this.tabPageFirefox.ResumeLayout(false);
            this.tabPageFirefox.PerformLayout();
            this.tabPageOption.ResumeLayout(false);
            this.groupBoxMyPassword.ResumeLayout(false);
            this.groupBoxMyPassword.PerformLayout();
            this.groupBoxTranslateMsg.ResumeLayout(false);
            this.groupBoxTranslateMsg.PerformLayout();
            this.tabPageSaveManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myVaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageOption;
        private System.Windows.Forms.TabPage tabPageFirefox;
        private System.Windows.Forms.Button buttonViewFirefox;
        private System.Windows.Forms.Label labelViewFirefox;
        private System.Windows.Forms.Button buttonImportFromFirefox;
        private System.Windows.Forms.Label labelImportFromFirefox;
        private System.Windows.Forms.CheckedListBox checkedListBoxMdpFireFox;
        private System.Windows.Forms.BindingSource myVaultBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxMyPassword;
        private System.Windows.Forms.TextBox textBoxMdpKeyword;
        private System.Windows.Forms.Label labelMdpKeyword;
        private System.Windows.Forms.TextBox textBoxMdpData;
        private System.Windows.Forms.Label labelMdpData;
        private System.Windows.Forms.TextBox textBoxMdpPassword;
        private System.Windows.Forms.Label labelMdpPassword;
        private System.Windows.Forms.TextBox textBoxMdpLogin;
        private System.Windows.Forms.Label labelMdpLogin;
        private System.Windows.Forms.GroupBox groupBoxTranslateMsg;
        private System.Windows.Forms.Label labelMsgPasswordTitle;
        private System.Windows.Forms.Label labelMsgPassword;
        private System.Windows.Forms.Label labelGridKeyword;
        private System.Windows.Forms.Label labelGridData;
        private System.Windows.Forms.Label labelGridPassword;
        private System.Windows.Forms.Label labelGridLogin;
        private System.Windows.Forms.Label labelMsgImportTitle;
        private System.Windows.Forms.Label labelMsgImport;
        private System.Windows.Forms.Label labelMsgAddDoneTitle;
        private System.Windows.Forms.Label labelMsgAddDone;
        private System.Windows.Forms.ImageList imageListTabCtrl;
        private PoisonDataGridView poisonGridVault;
        private MaterialTextBoxEdit materialTextBoxFilter;
        private MaterialButton materialButtonSave;
        private PoisonContextMenuStrip poisonContextMenuStripGrid;
        private System.Windows.Forms.ToolStripMenuItem supprimerLélémentToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPageSaveManagement;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
