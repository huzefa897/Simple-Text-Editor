using System;

namespace A2___Simple_Text_Editor.Model
{
    /// <summary>
    /// Handles user information and access/update it.
    /// </summary>
    public class UserDetails
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReEnterPwd { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserType { get; set; }

        /// <summary>
        /// Overriden ToString method to create a string of user information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Username},{Password},{UserType},{FirstName},{LastName},{DateOfBirth:dd-MM-yyyy}";
        }
    }
}
