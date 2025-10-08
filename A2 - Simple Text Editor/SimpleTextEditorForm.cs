using A2___Simple_Text_Editor.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace A2___Simple_Text_Editor
{
    /// <summary>
    /// Represents the Simple Text Editor Form that handles all the basic text editing features.
    /// </summary>
    public partial class SimpleTextEditorForm : Form
    {
        // Private fields
        // Accessible only within the body of the class
        private readonly CurrentSession _currentSession;

        /// <summary>
        /// Overload constructor to initialize form components and 
        /// to get CurrentSession instance object that contains current user's information.
        /// </summary>
        public SimpleTextEditorForm(CurrentSession currentSession)
        {
            InitializeComponent();

            // Set private field
            _currentSession = currentSession;

            // Set initial form fields and properties
            InitialTextEditorSetup();
        }

        /// <summary>
        /// Disables all text editor's menu strip and tool strips buttons.
        /// </summary>
        private void RestrictViewTypeUserFromEditing()
        {
            // Make rich text box readonly
            rtbTextEditor.ReadOnly = true;

            // Disable all text style buttons and font size combo box             
            tsBtnBoldText.Enabled = false;
            tsBtnItalicText.Enabled = false;
            tsBtnUnderlineText.Enabled = false;
            tsLblFontSize.Enabled = false;
            tsCmbBoxFontSize.Enabled = false;

            // Disable all text edit operation buttons
            tsEditMenuItem.Enabled = false;
            tsVertTextEditor.Enabled = false;

            // Disable all file operation buttons expect open and logout buttons
            tsNewMenuItem.Enabled = false;
            tsBtnNew.Enabled = false;
            tsSaveMenuItem.Enabled = false;
            tsBtnSave.Enabled = false;
            tsSaveAsMenuItem.Enabled = false;
            tsBtnSaveAs.Enabled = false;
        }

        /// <summary>
        /// Performs initial setup of properties and fields on a load of Text Editor Form.
        /// </summary>
        private void InitialTextEditorSetup()
        {
            // Set logged in user name to display it on text editor form
            tsLblUsernameValue.Text = _currentSession.LoggedInUser;

            // Display user type label on text editor form
            if (_currentSession.LoggedInUserType == "Edit")
            {
                tsLblUserTypeView.Visible = false;
                tsLblUserTypeEdit.Visible = true;
            }
            else if (_currentSession.LoggedInUserType == "View")
            {
                tsLblUserTypeView.Visible = true;
                tsLblUserTypeEdit.Visible = false;
            }

            // Restrict a View type user from performing any text editing functionality
            if (_currentSession.LoggedInUserType == "View")
            {
                RestrictViewTypeUserFromEditing();
            }
        }

        #region Tool strip's text style buttons and font size event handlers

        /// <summary>
        /// Updates rich text box's selected text's font.
        /// </summary>
        /// <param name="fontStyle"></param>
        /// /// <param name="fontSize"></param>
        private void UpdateTextStyle(FontStyle fontStyle, float fontSize)
        {
            rtbTextEditor.SelectionFont = new Font(rtbTextEditor.SelectionFont.FontFamily, fontSize, fontStyle);
        }

        /// <summary>
        /// Handles all horizontal tool strip's text style buttons click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsTextStyleBtns_Click(object sender, EventArgs e)
        {
            // Get button control name
            string controlName = ((ToolStripItem)sender).Name;

            // Get selected text's font style
            FontStyle fontStyle = rtbTextEditor.SelectionFont.Style;

            // Set font style based on control name
            if (controlName == tsBtnBoldText.Name)
            {
                fontStyle = fontStyle != FontStyle.Bold ? FontStyle.Bold : FontStyle.Regular;
            }
            else if (controlName == tsBtnItalicText.Name)
            {
                fontStyle = fontStyle != FontStyle.Italic ? FontStyle.Italic : FontStyle.Regular;
            }
            else if (controlName == tsBtnUnderlineText.Name)
            {
                fontStyle = fontStyle != FontStyle.Underline ? FontStyle.Underline : FontStyle.Regular;
            }

            // Update rich text box's font
            UpdateTextStyle(fontStyle, rtbTextEditor.SelectionFont.Size);
        }

        /// <summary>
        /// Handles horizontal tool strip's font size combo box's selected index changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsCmbBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tsCmbBoxFontSize.Text) && !string.IsNullOrWhiteSpace(tsCmbBoxFontSize.Text))
            {
                // Update rich text box's font
                UpdateTextStyle(rtbTextEditor.SelectionFont.Style, float.Parse(tsCmbBoxFontSize.Text));
            }
        }

        /// <summary>
        /// Handles horizontal tool strip's font size combo box's drop down closed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsCmbBoxFontSize_DropDownClosed(object sender, EventArgs e)
        {
            // Set focus to rich text box editor
            ActiveControl = rtbTextEditor;
        }
        #endregion

        #region Edit menu strip items and horizontal tool strip's text edit buttons' event handlers

        /// <summary>
        /// Handles all the basic text edit operations' buttons click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsEditMenuItemsOrTsEditBtns_Click(object sender, EventArgs e)
        {
            // Get button control name
            string controlName = ((ToolStripItem)sender).Name;

            // Perform edit operation based on control name
            if (controlName == tsCutMenuItem.Name || controlName == tsBtnCutText.Name)
            {
                rtbTextEditor.Cut();
            }
            else if (controlName == tsCopyMenuItem.Name || controlName == tsBtnCopyText.Name)
            {
                rtbTextEditor.Copy();
            }
            else if (controlName == tsPasteMenuItem.Name || controlName == tsBtnPasteText.Name)
            {
                rtbTextEditor.Paste();
            }
        }
        #endregion

        #region File menu strip items and horizontal tool strip's file operation button's event handlers

        /// <summary>
        /// Handles New menu strip item and tool strip's New button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsNewMenuItemOrTsBtnNew_Click(object sender, EventArgs e)
        {
            // Clear rich text box
            rtbTextEditor.Clear();

            // Clear tool strip's font size combo box's value
            tsCmbBoxFontSize.SelectedIndex = -1;
        }

        /// <summary>
        /// Handles Open menu strip item and tool strip's Open button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsOpenMenuItemOrTsBtnOpen_Click(object sender, EventArgs e)
        {
            // Try-catch block to handle Open Text File exceptions
            try
            {
                // Reset file name field to blank
                ofdOpenTextFile.FileName = string.Empty;
                if (ofdOpenTextFile.ShowDialog() == DialogResult.OK)
                {
                    // Clear tool strip's font size combo box's value
                    tsCmbBoxFontSize.SelectedIndex = -1;
                    if (ofdOpenTextFile.FileName.EndsWith(".txt")) // Check to open the .txt file
                        rtbTextEditor.Text = File.ReadAllText(ofdOpenTextFile.FileName);
                    else if (ofdOpenTextFile.FileName.EndsWith(".rtf")) // Check to open the .rtf file
                        rtbTextEditor.LoadFile(ofdOpenTextFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles Save/SaveAs menu strip items and tool strip's Save/SaveAs buttons click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsSaveSaveAsMenuItemOrTsBtnSaveSaveAs_Click(object sender, EventArgs e)
        {
            // Try-catch block to handle Save RTF File exceptions
            try
            {
                // Reset file name field to blank
                sfdSaveRTFFile.FileName = string.Empty;
                if (sfdSaveRTFFile.ShowDialog() == DialogResult.OK)
                {
                    // Save rich text box text into the .rtf file
                    rtbTextEditor.SaveFile(sfdSaveRTFFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles Logout menu item's click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsLogoutMenuItem_Click(object sender, EventArgs e)
        {
            // Ask the user for logout confirmation
            DialogResult comfirmLogout = MessageBox.Show("Are you sure you want to logout?\nAll unsaved changes will be lost.", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if user clicked Yes
            if (comfirmLogout == DialogResult.Yes)
            {
                // Hide Text Editor Form
                Hide();

                // Close any already opened About Forms
                if (Application.OpenForms.OfType<AboutForm>().Any())
                {
                    foreach (AboutForm form in Application.OpenForms.OfType<AboutForm>().ToList()) { form.Close(); }
                }

                // Close any already opened Login Forms
                if (Application.OpenForms.OfType<LoginForm>().Any())
                {
                    foreach (LoginForm form in Application.OpenForms.OfType<LoginForm>().ToList())
                    {
                        if (!form.IsMainFormInstance)
                        {
                            form.Close();
                        }
                    }
                }

                // Show Login Form
                LoginForm loginForm = new LoginForm(false);
                loginForm.Show();
            }
        }
        #endregion

        #region Help menu items and horizontal tool strip's About button's event handlers

        /// <summary>
        /// Handles About menu item and tool strip's About button's click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsAboutMenuItemOrTsBtnAbout_Click(object sender, EventArgs e)
        {
            // Close any already opened About Forms
            if (Application.OpenForms.OfType<AboutForm>().Any())
            {
                foreach (AboutForm form in Application.OpenForms.OfType<AboutForm>().ToList()) { form.Close(); }
            }

            // Show About Form
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
        #endregion

        #region Custom shortcut keys event

        /// <summary>
        /// Override ProcessCmdKey method to handle all the custom shortcut keys event
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Allow only for edit user types
            if (_currentSession.LoggedInUserType == "Edit")
            {
                // Text style buttons shortcut keys
                if (keyData == (Keys.Control | Keys.B)) { UpdateTextStyle(FontStyle.Bold, rtbTextEditor.SelectionFont.Size); return true; }
                if (keyData == (Keys.Control | Keys.I)) { UpdateTextStyle(FontStyle.Italic, rtbTextEditor.SelectionFont.Size); return true; }
                if (keyData == (Keys.Control | Keys.U)) { UpdateTextStyle(FontStyle.Underline, rtbTextEditor.SelectionFont.Size); return true; }

                // File operations shortcut keys
                if (keyData == (Keys.Control | Keys.N)) { TsNewMenuItemOrTsBtnNew_Click(null, null); return true; }
                if (keyData == (Keys.Control | Keys.S) || keyData == (Keys.Control | Keys.Alt | Keys.S)) { TsSaveSaveAsMenuItemOrTsBtnSaveSaveAs_Click(null, null); return true; }
            }

            // File open operation shortcut keys
            if (keyData == (Keys.Control | Keys.O)) { TsOpenMenuItemOrTsBtnOpen_Click(null, null); return true; }

            // About menu strip item shortcut key
            if (keyData == Keys.F1) { TsAboutMenuItemOrTsBtnAbout_Click(null, null); return true; }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
