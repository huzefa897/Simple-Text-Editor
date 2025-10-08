namespace A2___Simple_Text_Editor
{
    partial class SimpleTextEditorForm
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
            this.msTextEditor = new System.Windows.Forms.MenuStrip();
            this.tsFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparatorMenu1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparatorMenu2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLogoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHorizTextEditor = new System.Windows.Forms.ToolStrip();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsSeparatorHoriz1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBoldText = new System.Windows.Forms.ToolStripButton();
            this.tsBtnItalicText = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUnderlineText = new System.Windows.Forms.ToolStripButton();
            this.tsLblFontSize = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbBoxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsSeparatorHoriz2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAbout = new System.Windows.Forms.ToolStripButton();
            this.tsSeparatorHoriz3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblUsername = new System.Windows.Forms.ToolStripLabel();
            this.tsLblUsernameValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblUserType = new System.Windows.Forms.ToolStripLabel();
            this.tsLblUserTypeView = new System.Windows.Forms.ToolStripLabel();
            this.tsLblUserTypeEdit = new System.Windows.Forms.ToolStripLabel();
            this.tsVertTextEditor = new System.Windows.Forms.ToolStrip();
            this.tsBtnCutText = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCopyText = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPasteText = new System.Windows.Forms.ToolStripButton();
            this.rtbTextEditor = new System.Windows.Forms.RichTextBox();
            this.ofdOpenTextFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveRTFFile = new System.Windows.Forms.SaveFileDialog();
            this.msTextEditor.SuspendLayout();
            this.tsHorizTextEditor.SuspendLayout();
            this.tsVertTextEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTextEditor
            // 
            this.msTextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msTextEditor.AutoSize = false;
            this.msTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.msTextEditor.Dock = System.Windows.Forms.DockStyle.None;
            this.msTextEditor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTextEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileMenuItem,
            this.tsEditMenuItem,
            this.tsHelpMenuItem});
            this.msTextEditor.Location = new System.Drawing.Point(9, 0);
            this.msTextEditor.Name = "msTextEditor";
            this.msTextEditor.Padding = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.msTextEditor.Size = new System.Drawing.Size(964, 28);
            this.msTextEditor.TabIndex = 1;
            this.msTextEditor.Text = "Text Editor Menu";
            // 
            // tsFileMenuItem
            // 
            this.tsFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewMenuItem,
            this.tsOpenMenuItem,
            this.tsSeparatorMenu1,
            this.tsSaveMenuItem,
            this.tsSaveAsMenuItem,
            this.tsSeparatorMenu2,
            this.tsLogoutMenuItem});
            this.tsFileMenuItem.Name = "tsFileMenuItem";
            this.tsFileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.tsFileMenuItem.Text = "File";
            // 
            // tsNewMenuItem
            // 
            this.tsNewMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsNewMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.New;
            this.tsNewMenuItem.Name = "tsNewMenuItem";
            this.tsNewMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.tsNewMenuItem.Size = new System.Drawing.Size(231, 26);
            this.tsNewMenuItem.Text = "New";
            this.tsNewMenuItem.Click += new System.EventHandler(this.TsNewMenuItemOrTsBtnNew_Click);
            // 
            // tsOpenMenuItem
            // 
            this.tsOpenMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsOpenMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.Open;
            this.tsOpenMenuItem.Name = "tsOpenMenuItem";
            this.tsOpenMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.tsOpenMenuItem.Size = new System.Drawing.Size(231, 26);
            this.tsOpenMenuItem.Text = "Open";
            this.tsOpenMenuItem.Click += new System.EventHandler(this.TsOpenMenuItemOrTsBtnOpen_Click);
            // 
            // tsSeparatorMenu1
            // 
            this.tsSeparatorMenu1.BackColor = System.Drawing.SystemColors.Control;
            this.tsSeparatorMenu1.Name = "tsSeparatorMenu1";
            this.tsSeparatorMenu1.Size = new System.Drawing.Size(228, 6);
            // 
            // tsSaveMenuItem
            // 
            this.tsSaveMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsSaveMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.Save;
            this.tsSaveMenuItem.Name = "tsSaveMenuItem";
            this.tsSaveMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.tsSaveMenuItem.Size = new System.Drawing.Size(231, 26);
            this.tsSaveMenuItem.Text = "Save";
            this.tsSaveMenuItem.Click += new System.EventHandler(this.TsSaveSaveAsMenuItemOrTsBtnSaveSaveAs_Click);
            // 
            // tsSaveAsMenuItem
            // 
            this.tsSaveAsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsSaveAsMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.SaveAs;
            this.tsSaveAsMenuItem.Name = "tsSaveAsMenuItem";
            this.tsSaveAsMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+S";
            this.tsSaveAsMenuItem.Size = new System.Drawing.Size(231, 26);
            this.tsSaveAsMenuItem.Text = "Save As...";
            this.tsSaveAsMenuItem.Click += new System.EventHandler(this.TsSaveSaveAsMenuItemOrTsBtnSaveSaveAs_Click);
            // 
            // tsSeparatorMenu2
            // 
            this.tsSeparatorMenu2.Name = "tsSeparatorMenu2";
            this.tsSeparatorMenu2.Size = new System.Drawing.Size(228, 6);
            // 
            // tsLogoutMenuItem
            // 
            this.tsLogoutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsLogoutMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.Logout;
            this.tsLogoutMenuItem.Name = "tsLogoutMenuItem";
            this.tsLogoutMenuItem.ShortcutKeyDisplayString = "";
            this.tsLogoutMenuItem.Size = new System.Drawing.Size(231, 26);
            this.tsLogoutMenuItem.Text = "Logout";
            this.tsLogoutMenuItem.Click += new System.EventHandler(this.TsLogoutMenuItem_Click);
            // 
            // tsEditMenuItem
            // 
            this.tsEditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCutMenuItem,
            this.tsCopyMenuItem,
            this.tsPasteMenuItem});
            this.tsEditMenuItem.Name = "tsEditMenuItem";
            this.tsEditMenuItem.Size = new System.Drawing.Size(49, 24);
            this.tsEditMenuItem.Text = "Edit";
            // 
            // tsCutMenuItem
            // 
            this.tsCutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsCutMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.Cut;
            this.tsCutMenuItem.Name = "tsCutMenuItem";
            this.tsCutMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.tsCutMenuItem.Size = new System.Drawing.Size(177, 26);
            this.tsCutMenuItem.Text = "Cut";
            this.tsCutMenuItem.Click += new System.EventHandler(this.TsEditMenuItemsOrTsEditBtns_Click);
            // 
            // tsCopyMenuItem
            // 
            this.tsCopyMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsCopyMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.Copy;
            this.tsCopyMenuItem.Name = "tsCopyMenuItem";
            this.tsCopyMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.tsCopyMenuItem.Size = new System.Drawing.Size(177, 26);
            this.tsCopyMenuItem.Text = "Copy";
            this.tsCopyMenuItem.Click += new System.EventHandler(this.TsEditMenuItemsOrTsEditBtns_Click);
            // 
            // tsPasteMenuItem
            // 
            this.tsPasteMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsPasteMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.Paste;
            this.tsPasteMenuItem.Name = "tsPasteMenuItem";
            this.tsPasteMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.tsPasteMenuItem.Size = new System.Drawing.Size(177, 26);
            this.tsPasteMenuItem.Text = "Paste";
            this.tsPasteMenuItem.Click += new System.EventHandler(this.TsEditMenuItemsOrTsEditBtns_Click);
            // 
            // tsHelpMenuItem
            // 
            this.tsHelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAboutMenuItem});
            this.tsHelpMenuItem.Name = "tsHelpMenuItem";
            this.tsHelpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.tsHelpMenuItem.Text = "Help";
            // 
            // tsAboutMenuItem
            // 
            this.tsAboutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsAboutMenuItem.Image = global::A2___Simple_Text_Editor.Properties.Resources.About;
            this.tsAboutMenuItem.Name = "tsAboutMenuItem";
            this.tsAboutMenuItem.ShortcutKeyDisplayString = "F1";
            this.tsAboutMenuItem.Size = new System.Drawing.Size(157, 26);
            this.tsAboutMenuItem.Text = "About";
            this.tsAboutMenuItem.Click += new System.EventHandler(this.TsAboutMenuItemOrTsBtnAbout_Click);
            // 
            // tsHorizTextEditor
            // 
            this.tsHorizTextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsHorizTextEditor.AutoSize = false;
            this.tsHorizTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsHorizTextEditor.CanOverflow = false;
            this.tsHorizTextEditor.Dock = System.Windows.Forms.DockStyle.None;
            this.tsHorizTextEditor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHorizTextEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsHorizTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNew,
            this.tsBtnOpen,
            this.tsBtnSave,
            this.tsBtnSaveAs,
            this.tsSeparatorHoriz1,
            this.tsBtnBoldText,
            this.tsBtnItalicText,
            this.tsBtnUnderlineText,
            this.tsLblFontSize,
            this.tsCmbBoxFontSize,
            this.tsSeparatorHoriz2,
            this.tsBtnAbout,
            this.tsSeparatorHoriz3,
            this.tsLblUsername,
            this.tsLblUsernameValue,
            this.toolStripSeparator1,
            this.tsLblUserType,
            this.tsLblUserTypeView,
            this.tsLblUserTypeEdit});
            this.tsHorizTextEditor.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsHorizTextEditor.Location = new System.Drawing.Point(9, 28);
            this.tsHorizTextEditor.Name = "tsHorizTextEditor";
            this.tsHorizTextEditor.Padding = new System.Windows.Forms.Padding(0);
            this.tsHorizTextEditor.Size = new System.Drawing.Size(964, 34);
            this.tsHorizTextEditor.Stretch = true;
            this.tsHorizTextEditor.TabIndex = 2;
            this.tsHorizTextEditor.Text = "Text Editor Horiz Tool";
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.AutoSize = false;
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = global::A2___Simple_Text_Editor.Properties.Resources.New;
            this.tsBtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNew.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Size = new System.Drawing.Size(24, 24);
            this.tsBtnNew.Text = "New File";
            this.tsBtnNew.ToolTipText = "New File (Ctrl+N)";
            this.tsBtnNew.Click += new System.EventHandler(this.TsNewMenuItemOrTsBtnNew_Click);
            // 
            // tsBtnOpen
            // 
            this.tsBtnOpen.AutoSize = false;
            this.tsBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnOpen.Image = global::A2___Simple_Text_Editor.Properties.Resources.Open;
            this.tsBtnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnOpen.Name = "tsBtnOpen";
            this.tsBtnOpen.Size = new System.Drawing.Size(24, 24);
            this.tsBtnOpen.Text = "Open File";
            this.tsBtnOpen.ToolTipText = "Open File (Ctrl+O)";
            this.tsBtnOpen.Click += new System.EventHandler(this.TsOpenMenuItemOrTsBtnOpen_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.AutoSize = false;
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = global::A2___Simple_Text_Editor.Properties.Resources.Save;
            this.tsBtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(24, 24);
            this.tsBtnSave.Text = "Save File";
            this.tsBtnSave.ToolTipText = "Save File (Ctrl+S)";
            this.tsBtnSave.Click += new System.EventHandler(this.TsSaveSaveAsMenuItemOrTsBtnSaveSaveAs_Click);
            // 
            // tsBtnSaveAs
            // 
            this.tsBtnSaveAs.AutoSize = false;
            this.tsBtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSaveAs.Image = global::A2___Simple_Text_Editor.Properties.Resources.SaveAs;
            this.tsBtnSaveAs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveAs.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnSaveAs.Name = "tsBtnSaveAs";
            this.tsBtnSaveAs.Size = new System.Drawing.Size(24, 24);
            this.tsBtnSaveAs.Text = "Save As...";
            this.tsBtnSaveAs.ToolTipText = "Save As... (Ctrl+Alt+S)";
            this.tsBtnSaveAs.Click += new System.EventHandler(this.TsSaveSaveAsMenuItemOrTsBtnSaveSaveAs_Click);
            // 
            // tsSeparatorHoriz1
            // 
            this.tsSeparatorHoriz1.Name = "tsSeparatorHoriz1";
            this.tsSeparatorHoriz1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsBtnBoldText
            // 
            this.tsBtnBoldText.AutoSize = false;
            this.tsBtnBoldText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBoldText.Image = global::A2___Simple_Text_Editor.Properties.Resources.Bold;
            this.tsBtnBoldText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnBoldText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBoldText.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnBoldText.Name = "tsBtnBoldText";
            this.tsBtnBoldText.Size = new System.Drawing.Size(24, 24);
            this.tsBtnBoldText.Text = "Bold";
            this.tsBtnBoldText.ToolTipText = "Bold (Ctrl+B)\r\n\r\nMake your text bold.";
            this.tsBtnBoldText.Click += new System.EventHandler(this.TsTextStyleBtns_Click);
            // 
            // tsBtnItalicText
            // 
            this.tsBtnItalicText.AutoSize = false;
            this.tsBtnItalicText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnItalicText.Image = global::A2___Simple_Text_Editor.Properties.Resources.Italic;
            this.tsBtnItalicText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnItalicText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnItalicText.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnItalicText.Name = "tsBtnItalicText";
            this.tsBtnItalicText.Size = new System.Drawing.Size(24, 24);
            this.tsBtnItalicText.Text = "Italic";
            this.tsBtnItalicText.ToolTipText = "Italic (Ctrl+I)\r\n\r\nItalicize your text.";
            this.tsBtnItalicText.Click += new System.EventHandler(this.TsTextStyleBtns_Click);
            // 
            // tsBtnUnderlineText
            // 
            this.tsBtnUnderlineText.AutoSize = false;
            this.tsBtnUnderlineText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUnderlineText.Image = global::A2___Simple_Text_Editor.Properties.Resources.Underline;
            this.tsBtnUnderlineText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnUnderlineText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUnderlineText.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnUnderlineText.Name = "tsBtnUnderlineText";
            this.tsBtnUnderlineText.Size = new System.Drawing.Size(24, 24);
            this.tsBtnUnderlineText.Text = "Underline";
            this.tsBtnUnderlineText.ToolTipText = "Underline (Ctrl+U)\r\n\r\nUnderline your text.";
            this.tsBtnUnderlineText.Click += new System.EventHandler(this.TsTextStyleBtns_Click);
            // 
            // tsLblFontSize
            // 
            this.tsLblFontSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLblFontSize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tsLblFontSize.Name = "tsLblFontSize";
            this.tsLblFontSize.Size = new System.Drawing.Size(72, 34);
            this.tsLblFontSize.Text = "Font Size:";
            // 
            // tsCmbBoxFontSize
            // 
            this.tsCmbBoxFontSize.AutoSize = false;
            this.tsCmbBoxFontSize.AutoToolTip = true;
            this.tsCmbBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsCmbBoxFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tsCmbBoxFontSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCmbBoxFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.tsCmbBoxFontSize.Margin = new System.Windows.Forms.Padding(0);
            this.tsCmbBoxFontSize.Name = "tsCmbBoxFontSize";
            this.tsCmbBoxFontSize.Size = new System.Drawing.Size(50, 28);
            this.tsCmbBoxFontSize.DropDownClosed += new System.EventHandler(this.TsCmbBoxFontSize_DropDownClosed);
            this.tsCmbBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.TsCmbBoxFontSize_SelectedIndexChanged);
            // 
            // tsSeparatorHoriz2
            // 
            this.tsSeparatorHoriz2.Name = "tsSeparatorHoriz2";
            this.tsSeparatorHoriz2.Size = new System.Drawing.Size(6, 34);
            // 
            // tsBtnAbout
            // 
            this.tsBtnAbout.AutoSize = false;
            this.tsBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAbout.Image = global::A2___Simple_Text_Editor.Properties.Resources.About;
            this.tsBtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnAbout.Name = "tsBtnAbout";
            this.tsBtnAbout.Size = new System.Drawing.Size(24, 24);
            this.tsBtnAbout.Text = "About";
            this.tsBtnAbout.ToolTipText = "About (F1)";
            this.tsBtnAbout.Click += new System.EventHandler(this.TsAboutMenuItemOrTsBtnAbout_Click);
            // 
            // tsSeparatorHoriz3
            // 
            this.tsSeparatorHoriz3.Name = "tsSeparatorHoriz3";
            this.tsSeparatorHoriz3.Size = new System.Drawing.Size(6, 34);
            // 
            // tsLblUsername
            // 
            this.tsLblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsLblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLblUsername.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tsLblUsername.Name = "tsLblUsername";
            this.tsLblUsername.Size = new System.Drawing.Size(78, 34);
            this.tsLblUsername.Text = "Username:";
            this.tsLblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsLblUsernameValue
            // 
            this.tsLblUsernameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLblUsernameValue.Image = global::A2___Simple_Text_Editor.Properties.Resources.User;
            this.tsLblUsernameValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsLblUsernameValue.Name = "tsLblUsernameValue";
            this.tsLblUsernameValue.Size = new System.Drawing.Size(135, 34);
            this.tsLblUsernameValue.Text = "Username Value";
            this.tsLblUsernameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsLblUserType
            // 
            this.tsLblUserType.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tsLblUserType.Name = "tsLblUserType";
            this.tsLblUserType.Size = new System.Drawing.Size(56, 34);
            this.tsLblUserType.Text = "Access:";
            this.tsLblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsLblUserTypeView
            // 
            this.tsLblUserTypeView.Image = global::A2___Simple_Text_Editor.Properties.Resources.View;
            this.tsLblUserTypeView.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsLblUserTypeView.Name = "tsLblUserTypeView";
            this.tsLblUserTypeView.Size = new System.Drawing.Size(61, 34);
            this.tsLblUserTypeView.Text = "View";
            this.tsLblUserTypeView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsLblUserTypeEdit
            // 
            this.tsLblUserTypeEdit.Image = global::A2___Simple_Text_Editor.Properties.Resources.Edit;
            this.tsLblUserTypeEdit.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsLblUserTypeEdit.Name = "tsLblUserTypeEdit";
            this.tsLblUserTypeEdit.Size = new System.Drawing.Size(55, 34);
            this.tsLblUserTypeEdit.Text = "Edit";
            // 
            // tsVertTextEditor
            // 
            this.tsVertTextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tsVertTextEditor.AutoSize = false;
            this.tsVertTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.tsVertTextEditor.CanOverflow = false;
            this.tsVertTextEditor.Dock = System.Windows.Forms.DockStyle.None;
            this.tsVertTextEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsVertTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnCutText,
            this.tsBtnCopyText,
            this.tsBtnPasteText});
            this.tsVertTextEditor.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsVertTextEditor.Location = new System.Drawing.Point(9, 62);
            this.tsVertTextEditor.Name = "tsVertTextEditor";
            this.tsVertTextEditor.Size = new System.Drawing.Size(34, 582);
            this.tsVertTextEditor.Stretch = true;
            this.tsVertTextEditor.TabIndex = 3;
            this.tsVertTextEditor.Text = "Text Editor Vert Tool";
            // 
            // tsBtnCutText
            // 
            this.tsBtnCutText.AutoSize = false;
            this.tsBtnCutText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCutText.Image = global::A2___Simple_Text_Editor.Properties.Resources.Cut;
            this.tsBtnCutText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnCutText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCutText.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnCutText.Name = "tsBtnCutText";
            this.tsBtnCutText.Size = new System.Drawing.Size(24, 24);
            this.tsBtnCutText.Text = "Cut";
            this.tsBtnCutText.ToolTipText = "Cut (Ctrl+X)\r\n\r\nCut your text.";
            this.tsBtnCutText.Click += new System.EventHandler(this.TsEditMenuItemsOrTsEditBtns_Click);
            // 
            // tsBtnCopyText
            // 
            this.tsBtnCopyText.AutoSize = false;
            this.tsBtnCopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCopyText.Image = global::A2___Simple_Text_Editor.Properties.Resources.Copy;
            this.tsBtnCopyText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnCopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCopyText.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnCopyText.Name = "tsBtnCopyText";
            this.tsBtnCopyText.Size = new System.Drawing.Size(24, 24);
            this.tsBtnCopyText.Text = "Copy";
            this.tsBtnCopyText.ToolTipText = "Copy (Ctrl+C)\r\n\r\nCopy your text.";
            this.tsBtnCopyText.Click += new System.EventHandler(this.TsEditMenuItemsOrTsEditBtns_Click);
            // 
            // tsBtnPasteText
            // 
            this.tsBtnPasteText.AutoSize = false;
            this.tsBtnPasteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPasteText.Image = global::A2___Simple_Text_Editor.Properties.Resources.Paste;
            this.tsBtnPasteText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBtnPasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPasteText.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnPasteText.Name = "tsBtnPasteText";
            this.tsBtnPasteText.Size = new System.Drawing.Size(24, 24);
            this.tsBtnPasteText.Text = "Paste";
            this.tsBtnPasteText.ToolTipText = "Paste (Ctrl+V)\r\n\r\nPaste your text.";
            this.tsBtnPasteText.Click += new System.EventHandler(this.TsEditMenuItemsOrTsEditBtns_Click);
            // 
            // rtbTextEditor
            // 
            this.rtbTextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTextEditor.BackColor = System.Drawing.SystemColors.Window;
            this.rtbTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTextEditor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbTextEditor.Location = new System.Drawing.Point(45, 62);
            this.rtbTextEditor.Margin = new System.Windows.Forms.Padding(2);
            this.rtbTextEditor.Name = "rtbTextEditor";
            this.rtbTextEditor.Size = new System.Drawing.Size(926, 582);
            this.rtbTextEditor.TabIndex = 4;
            this.rtbTextEditor.Text = "";
            // 
            // ofdOpenTextFile
            // 
            this.ofdOpenTextFile.DefaultExt = "txt";
            this.ofdOpenTextFile.Filter = "Text files|*.txt|Rich text files|*.rtf";
            this.ofdOpenTextFile.InitialDirectory = "\\..\\..\\TextEditorDB\\TextEditorFiles";
            this.ofdOpenTextFile.RestoreDirectory = true;
            this.ofdOpenTextFile.Title = "Open Text File";
            // 
            // sfdSaveRTFFile
            // 
            this.sfdSaveRTFFile.DefaultExt = "rtf";
            this.sfdSaveRTFFile.Filter = "Rich text files|*.rtf";
            this.sfdSaveRTFFile.InitialDirectory = "\\..\\..\\TextEditorDB\\TextEditorFiles";
            this.sfdSaveRTFFile.RestoreDirectory = true;
            this.sfdSaveRTFFile.Title = "Save RTF File";
            // 
            // SimpleTextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.rtbTextEditor);
            this.Controls.Add(this.tsVertTextEditor);
            this.Controls.Add(this.tsHorizTextEditor);
            this.Controls.Add(this.msTextEditor);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = global::A2___Simple_Text_Editor.Properties.Resources.AppLogo;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "SimpleTextEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Text Editor";
            this.msTextEditor.ResumeLayout(false);
            this.msTextEditor.PerformLayout();
            this.tsHorizTextEditor.ResumeLayout(false);
            this.tsHorizTextEditor.PerformLayout();
            this.tsVertTextEditor.ResumeLayout(false);
            this.tsVertTextEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTextEditor;
        private System.Windows.Forms.ToolStripMenuItem tsFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsOpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorMenu1;
        private System.Windows.Forms.ToolStripMenuItem tsSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsSaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorMenu2;
        private System.Windows.Forms.ToolStripMenuItem tsLogoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsPasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsHelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAboutMenuItem;
        private System.Windows.Forms.ToolStrip tsHorizTextEditor;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnOpen;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnSaveAs;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorHoriz1;
        private System.Windows.Forms.ToolStripButton tsBtnBoldText;
        private System.Windows.Forms.ToolStripButton tsBtnItalicText;
        private System.Windows.Forms.ToolStripButton tsBtnUnderlineText;
        private System.Windows.Forms.ToolStripLabel tsLblFontSize;
        private System.Windows.Forms.ToolStripComboBox tsCmbBoxFontSize;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorHoriz2;
        private System.Windows.Forms.ToolStripButton tsBtnAbout;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorHoriz3;
        private System.Windows.Forms.ToolStripLabel tsLblUsername;
        private System.Windows.Forms.ToolStripLabel tsLblUsernameValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsLblUserType;
        private System.Windows.Forms.ToolStripLabel tsLblUserTypeView;
        private System.Windows.Forms.ToolStripLabel tsLblUserTypeEdit;
        private System.Windows.Forms.ToolStrip tsVertTextEditor;
        private System.Windows.Forms.ToolStripButton tsBtnCutText;
        private System.Windows.Forms.ToolStripButton tsBtnCopyText;
        private System.Windows.Forms.ToolStripButton tsBtnPasteText;
        private System.Windows.Forms.RichTextBox rtbTextEditor;
        private System.Windows.Forms.OpenFileDialog ofdOpenTextFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveRTFFile;
    }
}