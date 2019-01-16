using System;
using System.Collections.Generic;
using System.Text;

namespace CaseNotes1.Model
{
    public class User
    {
        public string userEmail { get; set; }
        public string password { get; set; }
        public static bool Login(string email, string password)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email);
            bool isPasswordEmpty = string.IsNullOrEmpty(password);

            if (isEmailEmpty == true || isPasswordEmpty == true)
            {
                return false;
            }
            else
            {
                App.user.userEmail = email;
                return true;
            }
        }
    }
}
