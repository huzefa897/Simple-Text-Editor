using A2___Simple_Text_Editor.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace A2___Simple_Text_Editor
{
    /// <summary>
    /// Represents the Login Form of the Simple Text Editor that handles the login feature.
    /// </summary>
    public partial class LoginForm : Form
    {
        // Private fields
        // Accessible only within the body of the class
        private CurrentSession _currentSession;

        // Property to access whether the instance of the login form is the main form
        public bool IsMainFormInstance { get; }

        /// <summary>
        /// Overload constructor to initialize form components 
        /// and get bool parameter to check whether the instance of the login form is the main form.
        /// </summary>
        public LoginForm(bool isMainFormInstance)
        {
            InitializeComponent();

            // Set property IsMainFormInstance
            IsMainFormInstance = isMainFormInstance;
        }

        #region Login form's event handlers

        /// <summary>
        /// Handles Login Form's load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Create a CurrentSession object to load the list of registered users and other utilities
            _currentSession = new CurrentSession(this);
        }
        #endregion

        #region New User button's event handlers

        /// <summary>
        /// Handles New User button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            // Hide Login Form
            Hide();

            // Close any already opened New User Forms
            if (Application.OpenForms.OfType<NewUserForm>().Any())
            {
                foreach (NewUserForm form in Application.OpenForms.OfType<NewUserForm>().ToList()) { form.Close(); }
            }

            // Show New User Form
            NewUserForm newUserForm = new NewUserForm(_currentSession, this);
            newUserForm.Show();
        }
        #endregion

        #region Login button's event handlers

        /// <summary>
        /// Handles Login button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // User credentials validation
            (bool isValidLogin, string credsErrName, string credsErrMsg) = _currentSession.ValidateUserCredentials(txtUsername.Text, txtPassword.Text);

            if (isValidLogin)
            {
                // Hide Login Form
                Hide();

                // Close any already opened Simple Text Editor Forms
                if (Application.OpenForms.OfType<SimpleTextEditorForm>().Any())
                {
                    foreach (SimpleTextEditorForm form in Application.OpenForms.OfType<SimpleTextEditorForm>().ToList()) { form.Close(); }
                }

                // Show Simple Text Editor Form
                SimpleTextEditorForm simpleTextEditorForm = new SimpleTextEditorForm(_currentSession);
                simpleTextEditorForm.Show();
            }
            else if (!isValidLogin)
            {
                // Display error message for invalid credentials
                DialogResult confirmError = _currentSession.DisplayErrorMessage(credsErrName, credsErrMsg);

                // Check if user clicked OK
                if (confirmError == DialogResult.OK)
                {
                    // Clear login fields
                    txtUsername.Clear();
                    txtPassword.Clear();

                    // Set focus to Username field
                    ActiveControl = txtUsername;
                }
            }
        }
        #endregion

        #region Exit button's event handlers

        /// <summary>
        /// Handles Exit button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Ask the user for exit confirmation
            DialogResult comfirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if user clicked Yes
            if (comfirmExit == DialogResult.Yes)
            {
                // Exit from application
                Application.Exit();
            }
            else if (comfirmExit == DialogResult.No)
            {
                // Set focus to login button
                ActiveControl = btnLogin;
            }
        }
        #endregion
    }
}
