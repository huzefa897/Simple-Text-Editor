using A2___Simple_Text_Editor.Model;
using A2___Simple_Text_Editor.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace A2___Simple_Text_Editor
{
    /// <summary>
    /// Represents the New User Form of the Simple Text Editor that handles the new user registration feature.
    /// </summary>
    public partial class NewUserForm : Form
    {
        // Private fields
        // Accessible only within the body of the class
        private readonly CurrentSession _currentSession;

        /// <summary>
        /// Overload constructor to initialize form components and 
        /// to get CurrentSession instance object that contains current user's information.
        /// </summary>
        public NewUserForm(CurrentSession currentSession, LoginForm loginForm)
        {
            InitializeComponent();

            // Set private field
            _currentSession = currentSession;

            // Set Date of Birth's (DateTimePicker) custom format blank
            // to display blank Date of Birth on load of the New User Form
            dtpDateOfBirth.CustomFormat = " ";
        }

        #region Date of Birth field's event handlers

        /// <summary>
        /// Handles Date Of Birth field's value changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            // Set Date of Birth's (DateTimePicker) custom format correctly
            // if the checkbox is checked and DOB is not set to its minimum value
            dtpDateOfBirth.CustomFormat = (dtpDateOfBirth.Checked && dtpDateOfBirth.Value != dtpDateOfBirth.MinDate) ? "dd-MM-yyyy" : " ";
        }

        /// <summary>
        /// Handles Date Of Birth field's key pressed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpDateOfBirth_KeyDown(object sender, KeyEventArgs e)
        {
            // If user pressed backspace or delete key
            // then set Date of Birth's (DateTimePicker) custom format blank and uncheck the checkbox
            // to display blank Date of Birth
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dtpDateOfBirth.CustomFormat = " ";
                dtpDateOfBirth.Checked = false;
            }
        }
        #endregion

        #region Submit button's event handlers

        /// <summary>
        /// Handles Submit button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Create UserDetails object with accessors
            UserDetails newUserDetails = new UserDetails
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                ReEnterPwd = txtReEnterPwd.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Checked ? dtpDateOfBirth.Value : dtpDateOfBirth.MinDate,
                UserType = cbUserType.Text
            };

            // New user details validation
            (bool isValidNewDetails, string newDetailsErrName, string newDetailsErrMsg, string fieldName) = _currentSession.ValidateNewUserDetails(newUserDetails, dtpDateOfBirth.MinDate);

            if (isValidNewDetails)
            {
                // Add new user's information to login.txt
                (bool isUpdateSuccess, string fileErrorName, string fileUpdateErrorMsg) = _currentSession.AddNewUserInfoToLoginFile(newUserDetails);

                if (isUpdateSuccess)
                {
                    // Display successful registration message
                    DialogResult confirmMsg = MessageBox.Show("New user registered successfully. Please login.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Check if user clicked OK
                    if (confirmMsg == DialogResult.OK)
                    {
                        // Hide New User Form
                        Hide();

                        // Close any already opened Login Forms
                        if (Application.OpenForms.OfType<LoginForm>().Any())
                        {
                            foreach (LoginForm form in Application.OpenForms.OfType<LoginForm>().ToList())
                            {
                                // Check if Login Form instance is of Main Form
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
                else if (!isUpdateSuccess)
                    _currentSession.DisplayErrorMessage(fileErrorName, fileUpdateErrorMsg);
            }
            else if (!isValidNewDetails)
            {
                DialogResult confirmResult = _currentSession.DisplayErrorMessage(newDetailsErrName, newDetailsErrMsg);
                if (confirmResult == DialogResult.OK)
                {
                    // Set focus on the field with error
                    SetFieldFocusOnError(fieldName);
                }
            }
        }

        /// <summary>
        /// Sets field focus on error.
        /// </summary>
        /// <param name="fieldName"></param>
        private void SetFieldFocusOnError(string fieldName)
        {
            switch (fieldName)
            {
                case "Username":
                    txtUsername.Clear();
                    ActiveControl = txtUsername;
                    break;
                case "Password":
                    txtPassword.Clear();
                    ActiveControl = txtPassword;
                    break;
                case "User Type":
                    ActiveControl = cbUserType;
                    break;
                case "First Name":
                    txtFirstName.Clear();
                    ActiveControl = txtFirstName;
                    break;
                case "Last Name":
                    txtLastName.Clear();
                    ActiveControl = txtLastName;
                    break;
                case "Date of Birth":
                    ActiveControl = dtpDateOfBirth;
                    break;
                case "Re-Enter Password":
                    txtReEnterPwd.Clear();
                    ActiveControl = txtReEnterPwd;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Cancel button's event handlers

        /// <summary>
        /// Handles Cancel button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Hide New User Form
            Hide();

            // Close any already opened Login Forms
            if (Application.OpenForms.OfType<LoginForm>().Any())
            {
                foreach (LoginForm form in Application.OpenForms.OfType<LoginForm>().ToList())
                {
                    // Check if Login Form instance is of Main Form
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
        #endregion
    }
}
