﻿namespace Microsoft.PS.Common.Vault.Explorer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            System.Windows.Forms.ToolStripLabel toolStripLabel1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            this.uxListViewSecrets = new System.Windows.Forms.ListView();
            this.uxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemAddSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemAddCertificate = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.uxPropertyGridSecret = new System.Windows.Forms.PropertyGrid();
            this.uxToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxComboBoxVaultAlias = new System.Windows.Forms.ToolStripComboBox();
            this.uxButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.uxButtonAdd = new System.Windows.Forms.ToolStripSplitButton();
            this.uxAddSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddCertificate = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.uxButtonToggle = new System.Windows.Forms.ToolStripButton();
            this.uxButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.uxImageSearch = new System.Windows.Forms.ToolStripLabel();
            this.uxTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.uxButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.uxButtonSave = new System.Windows.Forms.ToolStripButton();
            this.uxButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.uxButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.uxStatusStrip = new System.Windows.Forms.StatusStrip();
            this.uxStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxStatusLabelSecertsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxTimerSearchTextTypingCompleted = new System.Windows.Forms.Timer(this.components);
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxToolTip = new System.Windows.Forms.ToolTip(this.components);
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            this.uxContextMenuStrip.SuspendLayout();
            this.uxToolStrip.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.uxStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.uxListViewSecrets);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.uxPropertyGridSecret);
            splitContainer1.Size = new System.Drawing.Size(1029, 451);
            splitContainer1.SplitterDistance = 231;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 8;
            // 
            // uxListViewSecrets
            // 
            this.uxListViewSecrets.AllowColumnReorder = true;
            this.uxListViewSecrets.AllowDrop = true;
            this.uxListViewSecrets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            this.uxListViewSecrets.ContextMenuStrip = this.uxContextMenuStrip;
            this.uxListViewSecrets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxListViewSecrets.FullRowSelect = true;
            this.uxListViewSecrets.HideSelection = false;
            this.uxListViewSecrets.Location = new System.Drawing.Point(0, 0);
            this.uxListViewSecrets.Margin = new System.Windows.Forms.Padding(2);
            this.uxListViewSecrets.MultiSelect = false;
            this.uxListViewSecrets.Name = "uxListViewSecrets";
            this.uxListViewSecrets.Size = new System.Drawing.Size(1029, 231);
            this.uxListViewSecrets.SmallImageList = this.uxSmallImageList;
            this.uxListViewSecrets.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.uxListViewSecrets.TabIndex = 0;
            this.uxListViewSecrets.UseCompatibleStateImageBehavior = false;
            this.uxListViewSecrets.View = System.Windows.Forms.View.Details;
            this.uxListViewSecrets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.uxListViewSecrets_ColumnClick);
            this.uxListViewSecrets.SelectedIndexChanged += new System.EventHandler(this.uxListViewSecrets_SelectedIndexChanged);
            this.uxListViewSecrets.DragDrop += new System.Windows.Forms.DragEventHandler(this.uxListViewSecrets_DragDrop);
            this.uxListViewSecrets.DragEnter += new System.Windows.Forms.DragEventHandler(this.uxListViewSecrets_DragEnter);
            this.uxListViewSecrets.DoubleClick += new System.EventHandler(this.uxButtonEdit_Click);
            this.uxListViewSecrets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxListViewSecrets_KeyUp);
            this.uxListViewSecrets.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxListViewSecrets_MouseDown);
            this.uxListViewSecrets.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uxListViewSecrets_MouseMove);
            this.uxListViewSecrets.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uxListViewSecrets_MouseUp);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Updated";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Changed by";
            columnHeader3.Width = 200;
            // 
            // uxContextMenuStrip
            // 
            this.uxContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuItemAdd,
            this.uxMenuItemEdit,
            this.uxMenuItemToggle,
            this.uxMenuItemDelete,
            toolStripSeparator5,
            this.uxMenuItemCopy,
            this.uxMenuItemSave,
            toolStripSeparator4,
            this.uxMenuItemRefresh});
            this.uxContextMenuStrip.Name = "uxContextMenuStrip";
            this.uxContextMenuStrip.Size = new System.Drawing.Size(126, 198);
            // 
            // uxMenuItemAdd
            // 
            this.uxMenuItemAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuItemAddSecret,
            this.uxMenuItemAddCertificate,
            this.uxMenuItemAddFile});
            this.uxMenuItemAdd.Enabled = false;
            this.uxMenuItemAdd.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_add;
            this.uxMenuItemAdd.Name = "uxMenuItemAdd";
            this.uxMenuItemAdd.Size = new System.Drawing.Size(125, 26);
            this.uxMenuItemAdd.Text = "&Add";
            this.uxMenuItemAdd.Click += new System.EventHandler(this.uxButtonAdd_Click);
            // 
            // uxMenuItemAddSecret
            // 
            this.uxMenuItemAddSecret.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.key;
            this.uxMenuItemAddSecret.Name = "uxMenuItemAddSecret";
            this.uxMenuItemAddSecret.Size = new System.Drawing.Size(176, 22);
            this.uxMenuItemAddSecret.Text = "&Secret...";
            this.uxMenuItemAddSecret.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxMenuItemAddCertificate
            // 
            this.uxMenuItemAddCertificate.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.certificate;
            this.uxMenuItemAddCertificate.Name = "uxMenuItemAddCertificate";
            this.uxMenuItemAddCertificate.Size = new System.Drawing.Size(176, 22);
            this.uxMenuItemAddCertificate.Text = "Certificate...";
            this.uxMenuItemAddCertificate.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxMenuItemAddFile
            // 
            this.uxMenuItemAddFile.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.folder_key;
            this.uxMenuItemAddFile.Name = "uxMenuItemAddFile";
            this.uxMenuItemAddFile.Size = new System.Drawing.Size(176, 22);
            this.uxMenuItemAddFile.Text = "Configuration &file...";
            this.uxMenuItemAddFile.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxMenuItemEdit
            // 
            this.uxMenuItemEdit.Enabled = false;
            this.uxMenuItemEdit.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_edit;
            this.uxMenuItemEdit.Name = "uxMenuItemEdit";
            this.uxMenuItemEdit.Size = new System.Drawing.Size(125, 26);
            this.uxMenuItemEdit.Text = "&Edit...";
            this.uxMenuItemEdit.Click += new System.EventHandler(this.uxButtonEdit_Click);
            // 
            // uxMenuItemToggle
            // 
            this.uxMenuItemToggle.Enabled = false;
            this.uxMenuItemToggle.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_break;
            this.uxMenuItemToggle.Name = "uxMenuItemToggle";
            this.uxMenuItemToggle.Size = new System.Drawing.Size(125, 26);
            this.uxMenuItemToggle.Text = "Disabl&e...";
            this.uxMenuItemToggle.Click += new System.EventHandler(this.uxButtonToggle_Click);
            // 
            // uxMenuItemDelete
            // 
            this.uxMenuItemDelete.Enabled = false;
            this.uxMenuItemDelete.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_delete;
            this.uxMenuItemDelete.Name = "uxMenuItemDelete";
            this.uxMenuItemDelete.Size = new System.Drawing.Size(125, 26);
            this.uxMenuItemDelete.Text = "&Delete...";
            this.uxMenuItemDelete.Click += new System.EventHandler(this.uxButtonDelete_Click);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(122, 6);
            // 
            // uxMenuItemCopy
            // 
            this.uxMenuItemCopy.Enabled = false;
            this.uxMenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("uxMenuItemCopy.Image")));
            this.uxMenuItemCopy.Name = "uxMenuItemCopy";
            this.uxMenuItemCopy.Size = new System.Drawing.Size(125, 26);
            this.uxMenuItemCopy.Text = "&Copy";
            this.uxMenuItemCopy.Click += new System.EventHandler(this.uxButtonCopy_Click);
            // 
            // uxMenuItemSave
            // 
            this.uxMenuItemSave.Enabled = false;
            this.uxMenuItemSave.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.disk;
            this.uxMenuItemSave.Name = "uxMenuItemSave";
            this.uxMenuItemSave.Size = new System.Drawing.Size(125, 26);
            this.uxMenuItemSave.Text = "&Save...";
            this.uxMenuItemSave.Click += new System.EventHandler(this.uxButtonSave_Click);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(122, 6);
            // 
            // uxMenuItemRefresh
            // 
            this.uxMenuItemRefresh.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_go;
            this.uxMenuItemRefresh.Name = "uxMenuItemRefresh";
            this.uxMenuItemRefresh.Size = new System.Drawing.Size(125, 26);
            this.uxMenuItemRefresh.Text = "&Refresh";
            this.uxMenuItemRefresh.Click += new System.EventHandler(this.uxButtonRefresh_Click);
            // 
            // uxSmallImageList
            // 
            this.uxSmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("uxSmallImageList.ImageStream")));
            this.uxSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.uxSmallImageList.Images.SetKeyName(0, "empty.png");
            this.uxSmallImageList.Images.SetKeyName(1, "key.png");
            this.uxSmallImageList.Images.SetKeyName(2, "key_delete.png");
            this.uxSmallImageList.Images.SetKeyName(3, "medal_bronze_1.png");
            this.uxSmallImageList.Images.SetKeyName(4, "medal_bronze_delete.png");
            // 
            // uxPropertyGridSecret
            // 
            this.uxPropertyGridSecret.DisabledItemForeColor = System.Drawing.SystemColors.WindowText;
            this.uxPropertyGridSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPropertyGridSecret.HelpVisible = false;
            this.uxPropertyGridSecret.Location = new System.Drawing.Point(0, 0);
            this.uxPropertyGridSecret.Margin = new System.Windows.Forms.Padding(2);
            this.uxPropertyGridSecret.Name = "uxPropertyGridSecret";
            this.uxPropertyGridSecret.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.uxPropertyGridSecret.Size = new System.Drawing.Size(1029, 215);
            this.uxPropertyGridSecret.TabIndex = 0;
            this.uxPropertyGridSecret.ToolbarVisible = false;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(34, 24);
            toolStripLabel1.Text = "Vault";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // uxToolStrip
            // 
            this.uxToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.uxToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripLabel1,
            this.uxComboBoxVaultAlias,
            this.uxButtonRefresh,
            toolStripSeparator1,
            this.uxButtonAdd,
            this.uxButtonEdit,
            this.uxButtonToggle,
            this.uxButtonDelete,
            toolStripSeparator2,
            this.uxImageSearch,
            this.uxTextBoxSearch,
            this.uxButtonCopy,
            this.uxButtonSave,
            toolStripSeparator3,
            this.uxButtonHelp,
            this.uxButtonExit});
            this.uxToolStrip.Location = new System.Drawing.Point(3, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(996, 27);
            this.uxToolStrip.TabIndex = 0;
            // 
            // uxComboBoxVaultAlias
            // 
            this.uxComboBoxVaultAlias.DropDownHeight = 200;
            this.uxComboBoxVaultAlias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComboBoxVaultAlias.IntegralHeight = false;
            this.uxComboBoxVaultAlias.Name = "uxComboBoxVaultAlias";
            this.uxComboBoxVaultAlias.Size = new System.Drawing.Size(250, 27);
            // 
            // uxButtonRefresh
            // 
            this.uxButtonRefresh.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_go;
            this.uxButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonRefresh.Name = "uxButtonRefresh";
            this.uxButtonRefresh.Size = new System.Drawing.Size(70, 24);
            this.uxButtonRefresh.Text = "&Refresh";
            this.uxButtonRefresh.Click += new System.EventHandler(this.uxButtonRefresh_Click);
            // 
            // uxButtonAdd
            // 
            this.uxButtonAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxAddSecret,
            this.uxAddCertificate,
            this.uxAddFile});
            this.uxButtonAdd.Enabled = false;
            this.uxButtonAdd.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_add;
            this.uxButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonAdd.Name = "uxButtonAdd";
            this.uxButtonAdd.Size = new System.Drawing.Size(65, 24);
            this.uxButtonAdd.Text = "&Add";
            this.uxButtonAdd.Click += new System.EventHandler(this.uxButtonAdd_Click);
            // 
            // uxAddSecret
            // 
            this.uxAddSecret.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.key;
            this.uxAddSecret.Name = "uxAddSecret";
            this.uxAddSecret.Size = new System.Drawing.Size(176, 22);
            this.uxAddSecret.Text = "&Secret...";
            this.uxAddSecret.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxAddCertificate
            // 
            this.uxAddCertificate.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.certificate;
            this.uxAddCertificate.Name = "uxAddCertificate";
            this.uxAddCertificate.Size = new System.Drawing.Size(176, 22);
            this.uxAddCertificate.Text = "Ce&rtificate...";
            this.uxAddCertificate.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxAddFile
            // 
            this.uxAddFile.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.folder_key;
            this.uxAddFile.Name = "uxAddFile";
            this.uxAddFile.Size = new System.Drawing.Size(176, 22);
            this.uxAddFile.Text = "Configuration &file...";
            this.uxAddFile.Click += new System.EventHandler(this.uxButtonAddItem_Click);
            // 
            // uxButtonEdit
            // 
            this.uxButtonEdit.Enabled = false;
            this.uxButtonEdit.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_edit;
            this.uxButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonEdit.Name = "uxButtonEdit";
            this.uxButtonEdit.Size = new System.Drawing.Size(51, 24);
            this.uxButtonEdit.Text = "&Edit";
            this.uxButtonEdit.Click += new System.EventHandler(this.uxButtonEdit_Click);
            // 
            // uxButtonToggle
            // 
            this.uxButtonToggle.Enabled = false;
            this.uxButtonToggle.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_break;
            this.uxButtonToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonToggle.Name = "uxButtonToggle";
            this.uxButtonToggle.Size = new System.Drawing.Size(69, 24);
            this.uxButtonToggle.Text = "Disabl&e";
            this.uxButtonToggle.Click += new System.EventHandler(this.uxButtonToggle_Click);
            // 
            // uxButtonDelete
            // 
            this.uxButtonDelete.Enabled = false;
            this.uxButtonDelete.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.lock_delete;
            this.uxButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonDelete.Name = "uxButtonDelete";
            this.uxButtonDelete.Size = new System.Drawing.Size(64, 24);
            this.uxButtonDelete.Text = "&Delete";
            this.uxButtonDelete.Click += new System.EventHandler(this.uxButtonDelete_Click);
            // 
            // uxImageSearch
            // 
            this.uxImageSearch.Enabled = false;
            this.uxImageSearch.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.magnifier;
            this.uxImageSearch.Name = "uxImageSearch";
            this.uxImageSearch.Size = new System.Drawing.Size(20, 24);
            this.uxImageSearch.ToolTipText = "Search";
            // 
            // uxTextBoxSearch
            // 
            this.uxTextBoxSearch.Enabled = false;
            this.uxTextBoxSearch.Name = "uxTextBoxSearch";
            this.uxTextBoxSearch.Size = new System.Drawing.Size(120, 27);
            this.uxTextBoxSearch.ToolTipText = "Search";
            this.uxTextBoxSearch.TextChanged += new System.EventHandler(this.uxTextBoxSearch_TextChanged);
            // 
            // uxButtonCopy
            // 
            this.uxButtonCopy.Enabled = false;
            this.uxButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("uxButtonCopy.Image")));
            this.uxButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonCopy.Name = "uxButtonCopy";
            this.uxButtonCopy.Size = new System.Drawing.Size(59, 24);
            this.uxButtonCopy.Text = "&Copy";
            this.uxButtonCopy.Click += new System.EventHandler(this.uxButtonCopy_Click);
            // 
            // uxButtonSave
            // 
            this.uxButtonSave.Enabled = false;
            this.uxButtonSave.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.disk;
            this.uxButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonSave.Name = "uxButtonSave";
            this.uxButtonSave.Size = new System.Drawing.Size(55, 24);
            this.uxButtonSave.Text = "&Save";
            this.uxButtonSave.Click += new System.EventHandler(this.uxButtonSave_Click);
            // 
            // uxButtonHelp
            // 
            this.uxButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("uxButtonHelp.Image")));
            this.uxButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonHelp.Name = "uxButtonHelp";
            this.uxButtonHelp.Size = new System.Drawing.Size(56, 24);
            this.uxButtonHelp.Text = "&Help";
            this.uxButtonHelp.Click += new System.EventHandler(this.uxButtonHelp_Click);
            // 
            // uxButtonExit
            // 
            this.uxButtonExit.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.door_out;
            this.uxButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxButtonExit.Name = "uxButtonExit";
            this.uxButtonExit.Size = new System.Drawing.Size(49, 24);
            this.uxButtonExit.Text = "E&xit";
            this.uxButtonExit.Click += new System.EventHandler(this.uxButtonExit_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.uxStatusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1029, 451);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1029, 500);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.uxToolStrip);
            // 
            // uxStatusStrip
            // 
            this.uxStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.uxStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxStatusLabel,
            this.uxStatusLabelSecertsCount});
            this.uxStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.uxStatusStrip.Name = "uxStatusStrip";
            this.uxStatusStrip.Size = new System.Drawing.Size(1029, 22);
            this.uxStatusStrip.TabIndex = 0;
            // 
            // uxStatusLabel
            // 
            this.uxStatusLabel.Name = "uxStatusLabel";
            this.uxStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.uxStatusLabel.Text = "Ready";
            this.uxStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxStatusLabelSecertsCount
            // 
            this.uxStatusLabelSecertsCount.Name = "uxStatusLabelSecertsCount";
            this.uxStatusLabelSecertsCount.Size = new System.Drawing.Size(975, 17);
            this.uxStatusLabelSecertsCount.Spring = true;
            this.uxStatusLabelSecertsCount.Text = "0 secret(s)";
            this.uxStatusLabelSecertsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.Filter = "Personal Information Exchange|*.pfx;*.p12|X509 Certificate|*.cer;*.crt|Configurat" +
    "ion files|*.json;*.xml;*.config|All files|*.*";
            this.uxOpenFileDialog.Title = "Open file";
            // 
            // uxTimerSearchTextTypingCompleted
            // 
            this.uxTimerSearchTextTypingCompleted.Interval = 250;
            this.uxTimerSearchTextTypingCompleted.Tick += new System.EventHandler(this.uxTimerSearchTextTypingCompleted_Tick);
            // 
            // uxSaveFileDialog
            // 
            this.uxSaveFileDialog.Filter = "All files|*.*";
            this.uxSaveFileDialog.Title = "Save As";
            // 
            // uxToolTip
            // 
            this.uxToolTip.IsBalloon = true;
            this.uxToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 500);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(602, 491);
            this.Name = "MainForm";
            this.Text = "Azure Key Vault Explorer";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            this.uxContextMenuStrip.ResumeLayout(false);
            this.uxToolStrip.ResumeLayout(false);
            this.uxToolStrip.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.uxStatusStrip.ResumeLayout(false);
            this.uxStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip uxStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel uxStatusLabel;
        private System.Windows.Forms.ListView uxListViewSecrets;
        private System.Windows.Forms.PropertyGrid uxPropertyGridSecret;
        private System.Windows.Forms.ToolStripComboBox uxComboBoxVaultAlias;
        private System.Windows.Forms.ToolStripButton uxButtonRefresh;
        private System.Windows.Forms.ToolStripButton uxButtonCopy;
        private System.Windows.Forms.ToolStripButton uxButtonHelp;
        private System.Windows.Forms.ToolStripButton uxButtonEdit;
        private System.Windows.Forms.ToolStripButton uxButtonDelete;
        private System.Windows.Forms.ToolStripSplitButton uxButtonAdd;
        private System.Windows.Forms.ToolStripMenuItem uxAddSecret;
        private System.Windows.Forms.ToolStripMenuItem uxAddCertificate;
        private System.Windows.Forms.ToolStripButton uxButtonExit;
        private System.Windows.Forms.ContextMenuStrip uxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemCopy;
        private System.Windows.Forms.ToolStripButton uxButtonToggle;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemToggle;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAddSecret;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAddCertificate;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemAddFile;
        private System.Windows.Forms.ToolStripMenuItem uxAddFile;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.ImageList uxSmallImageList;
        private System.Windows.Forms.ToolStripTextBox uxTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel uxImageSearch;
        private System.Windows.Forms.Timer uxTimerSearchTextTypingCompleted;
        private System.Windows.Forms.ToolStrip uxToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel uxStatusLabelSecertsCount;
        private System.Windows.Forms.ToolStripButton uxButtonSave;
        private System.Windows.Forms.ToolStripMenuItem uxMenuItemSave;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.ToolTip uxToolTip;
    }
}

