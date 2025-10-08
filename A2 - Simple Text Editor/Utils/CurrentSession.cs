using A2___Simple_Text_Editor.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace A2___Simple_Text_Editor.Utils
{
    /// <summary>
    /// Current session to handle login information of the Simple Text Editor.
    /// </summary>
    public class CurrentSession
    {
        // Private fields
        // Accessible only within the body of the class 
        private readonly List<UserDetails> _userList;
        private string _loggedInUser;
        private string _loggedInUserType;
        private readonly string _loginFilePath = @"..\..\TextEditorDB\login.txt";

        // Property to access and update the value of private fields
        public string LoggedInUser { get => _loggedInUser; set => _loggedInUser = value; }
        public string LoggedInUserType { get => _loggedInUserType; set => _loggedInUserType = value; }

        /// <summary>
        /// Default constructor to load the list of registered users.
        /// </summary>
        public CurrentSession(LoginForm loginForm)
        {
            // Load registered users from login.txt file
            bool loadSuccess;
            string loginFileErrName, loginFileErrMsg;
            (loadSuccess, loginFileErrName, loginFileErrMsg, _userList) = LoadRegisteredUsers();

            // Check if the login file failed to load
            if (!loadSuccess)
            {
                // Display error message for login file error
                DialogResult confirmError = DisplayErrorMessage(loginFileErrName, loginFileErrMsg);

                // Check if user clicked OK
                if (confirmError == DialogResult.OK)
                {
                    // Close Login Form and exit from application
                    loginForm.Close();
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Loads all the registered users information.
        /// </summary>
        /// <returns>A tuple of file read status, file read error name, file read error message and list of registered users.</returns>
        private (bool, string, string, List<UserDetails>) LoadRegisteredUsers()
        {
            List<UserDetails> lstUserDetails = new List<UserDetails>();
            try
            {
                // Get all the registered users information from the login.txt file and store it in a UserDetails object list
                lstUserDetails = File.ReadAllLines(_loginFilePath)
                       .Where(x => !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x))
                       .Select(x => x.Split(','))
                       .Select(x => new UserDetails()
                       {
                           Username = x[0],
                           Password = x[1],
                           UserType = x[2],
                           FirstName = x[3],
                           LastName = x[4],
                           DateOfBirth = DateTime.ParseExact(x[5], "dd-MM-yyyy", CultureInfo.InvariantCulture)
                       })
                       .ToList();

                // Check if login.txt is not empty
                if (lstUserDetails != null && lstUserDetails.Count > 0)
                    return (true, string.Empty, string.Empty, lstUserDetails);
                else
                {
                    return (false, "File Is Empty",
                        "Login file empty. Please add registered users information in the file and try again.", null);
                }
            }
            // Exception handling
            catch (FileNotFoundException)
            {
                return (false, "Login File Error",
                    @"File read failed. Login file not found. Please check if the file name is correct and then retry. Expected file path: <ProjectFolder>\TextEditorDB\login.txt.",
                    null);
            }
            catch (DirectoryNotFoundException)
            {
                return (false, "Login File Error",
                    @"File read failed. Directory not found. Please check if the file path is correct and then retry. Expected file path: <ProjectFolder>\TextEditorDB\login.txt.",
                    null);
            }
            catch (Exception ex)
            {
                return (false, "Login File Error",
                    $"File read failed. {ex.Message}. Please resolve the error and try again.", null);
            }
        }

        /// <summary>
        /// Displays error message in a dialog box.
        /// </summary>
        /// <param name="errName"></param>
        /// <param name="errMessage"></param>
        /// <returns>Value of the dialog box.</returns>
        public DialogResult DisplayErrorMessage(string errName, string errMessage)
        {
            return MessageBox.Show(errMessage, errName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Validates user credentials.
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="password"></param>
        /// <returns>A tupple of validation status, invalid error name and invalid error message.</returns>
        public (bool, string, string) ValidateUserCredentials(string Username, string password)
        {
            // Check if the user has not entered an empty Username or Password
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrWhiteSpace(Username)
                && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                // Get the matching registered user with user-entered credentials
                UserDetails currUserDetails = _userList.Where(x => x.Username == Username.Trim() && x.Password == password).FirstOrDefault();

                // Check if user-entered credentials are valid
                if (currUserDetails != null)
                {
                    // Set private fields to track the currently logged in user and their user type
                    _loggedInUser = currUserDetails.Username;
                    _loggedInUserType = currUserDetails.UserType;

                    return (true, string.Empty, string.Empty);
                }
                else
                    return (false, "Login Failed", "Your Username or password is incorrect. Please try again.");
            }
            else
                return (false, "Empty Credentials", "User name or password cannot be empty. Please try again.");
        }

        /// <summary>
        /// Validates new user's information.
        /// </summary>
        /// <param name="newUserDetails">New user's information</param>
        /// <param name="dtpMinDate">Datetime picker's minimum date.</param>
        /// <returns>A tupple of validation status, invalid error name, invalid error message and field name.</returns>
        public (bool, string, string, string) ValidateNewUserDetails(UserDetails newUserDetails, DateTime dtpMinDate)
        {
            // Get the list of the fields left blank by the user
            List<string> blankFields = GetNewUserBlankFields(newUserDetails, dtpMinDate);

            // Check if there are fields left blank by the user
            if (blankFields != null && blankFields.Count > 0)
            {
                return (false, "Empty Fields",
                    $"The following fields cannot be empty:\n{string.Join(", ", blankFields)}\n\nPlease try again.",
                    blankFields.FirstOrDefault());
            }
            // Check if the user entered username already exists in login.txt
            else if (_userList.Any(x => x.Username == newUserDetails.Username))
            {
                return (false, "Duplicate Username",
                    "Username already exists. Please enter unique Username and try again.",
                    "Username");
            }
            // Check if the user entered username is valid
            else if (int.TryParse(newUserDetails.Username, out int usrNameInt) || long.TryParse(newUserDetails.Username, out long usrNameLong)
                || float.TryParse(newUserDetails.Username, out float usrNameFloat) || double.TryParse(newUserDetails.Username, out double usrNameDouble)
                || decimal.TryParse(newUserDetails.Username, out decimal usrNameDec) || newUserDetails.Username.Any(char.IsWhiteSpace))
            {
                return (false, "Invalid Username",
                    "Username cannot contain any spaces or only numbers. Please enter valid Username and try again.",
                    "Username");
            }
            // Check if there is mismatch in Password and Re-Enter Password
            else if (newUserDetails.Password != newUserDetails.ReEnterPwd)
            {
                return (false, "Password Mismatch",
                    "The Re-Enter Password did not match with the Password. Please try again.",
                    "Re-Enter Password");
            }
            // Check if the user entered first name is valid
            else if (int.TryParse(newUserDetails.FirstName, out int firstNameInt) || long.TryParse(newUserDetails.FirstName, out long firstNameLong)
                || float.TryParse(newUserDetails.FirstName, out float firstNameFloat) || double.TryParse(newUserDetails.FirstName, out double firstNameDouble)
                || decimal.TryParse(newUserDetails.FirstName, out decimal firstNameDec))
            {
                return (false, "Invalid First Name",
                    "First Name cannot contain only numbers. Please enter valid First Name and try again.",
                    "First Name");
            }
            // Check if the user entered last name is valid
            else if (int.TryParse(newUserDetails.LastName, out int lastNameInt) || long.TryParse(newUserDetails.LastName, out long lastNameLong)
                || float.TryParse(newUserDetails.LastName, out float lastNameFloat) || double.TryParse(newUserDetails.LastName, out double lastNameDouble)
                || decimal.TryParse(newUserDetails.LastName, out decimal lastNameDec))
            {
                return (false, "Invalid Last Name",
                    "Last Name cannot contain only numbers. Please enter valid Last Name and try again.",
                    "Last Name");
            }
            // Check if the Date of Birth is from the future
            else if (newUserDetails.DateOfBirth.Date > DateTime.Now.Date)
            {
                return (false, "Date of Birth Error",
                    "The Date of Birth can not be in the future. Please try again.",
                    "Date of Birth");
            }
            // Check if the Date of Birth is less than 10 years
            else if (DateTime.Now.Year - newUserDetails.DateOfBirth.Date.Year < 10)
            {
                return (false, "Date of Birth Error",
                    "User must be at least 10 years of age. Please try again.",
                    "Date of Birth");
            }
            else
                return (true, string.Empty, string.Empty, string.Empty);
        }

        /// <summary>
        /// Get all the New User Form fields left blank by the user
        /// </summary>
        /// <param name="newUserDetails">New user's information</param>
        /// <param name="dtpMinDate">Datetime picker's minimum date.</param>
        /// <returns>List of New User blank fields</returns>
        private List<string> GetNewUserBlankFields(UserDetails newUserDetails, DateTime dtpMinDate)
        {
            // Dictionary to store New User Form fields label
            Dictionary<string, string> newUserFormFields = new Dictionary<string, string>()
            {
                { "Username", "Username" },
                { "Password", "Password" },
                { "UserType", "User Type" },
                { "FirstName", "First Name" },
                { "LastName", "Last Name" },
                { "DateOfBirth", "Date of Birth" },
                { "ReEnterPwd", "Re-Enter Password" }
            };

            List<string> blankFieldList = new List<string>();

            // Get all the properties from newUserDetails object
            PropertyInfo[] newUserProperties = typeof(UserDetails).GetProperties();

            // Loop through each property and check if it's empty and add it to blankFieldList
            foreach (PropertyInfo property in newUserProperties)
            {
                if (property.Name != "DateOfBirth")
                {
                    if (string.IsNullOrEmpty(property.GetValue(newUserDetails).ToString()) || string.IsNullOrWhiteSpace(property.GetValue(newUserDetails).ToString()))
                        blankFieldList.Add(newUserFormFields[property.Name]);
                }
                else
                {
                    if (Convert.ToDateTime(property.GetValue(newUserDetails)).Date == dtpMinDate.Date)
                        blankFieldList.Add(newUserFormFields[property.Name]);
                }
            }

            return blankFieldList;
        }

        /// <summary>
        /// Add new user's information to login file
        /// </summary>
        /// <param name="newUserDetails">New user's information</param>
        /// <returns>A tuple of file update status, file update error name and file update error message.</returns>
        public (bool, string, string) AddNewUserInfoToLoginFile(UserDetails newUserDetails)
        {
            try
            {
                // Add new user's information to registered user list and convert it to an array.
                _userList.Add(newUserDetails);
                string[] loginFileLines = _userList.Select(x => x.ToString()).ToArray();

                // Overwrite entire login file
                File.WriteAllLines(_loginFilePath, loginFileLines);

                return (true, string.Empty, string.Empty);
            }
            // Exception handling
            catch (FileNotFoundException)
            {
                return (false, "Login File Error",
                    @"File update failed. Login file not found. Please check if the file name is correct and then retry. Expected file path: <ProjectFolder>\TextEditorDB\login.txt.");
            }
            catch (DirectoryNotFoundException)
            {
                return (false, "Login File Error",
                    @"File update failed. Directory not found. Please check if the file path is correct and then retry. Expected file path: <ProjectFolder>\TextEditorDB\login.txt.");
            }
            catch (Exception ex)
            {
                return (false, "Login File Error",
                    $"File update failed. {ex.Message}. Please resolve the error and try again.");
            }
        }
    }
}
