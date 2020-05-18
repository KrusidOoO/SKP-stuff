using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Login_interface_and_so_on
{
    class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Login(string User, string Pass)
        {
            this.Username = User;
            this.Password = Pass;
        }

        private bool stringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool integerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void clearTexts(string user, string pass)
        {
            user = string.Empty;
            pass = string.Empty;
        }
        internal bool IsLoggedIn(string user, string pass)
        {
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please enter your username");
                return false;
            }
            else if (stringValidator(user) == true)
            {
                MessageBox.Show("Enter only text here");
                clearTexts(user, pass);
                return false;
            }
            else
            {
                if (Username != user)
                {
                    MessageBox.Show("Username is incorrect");
                    clearTexts(user, pass);
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Please enter your password");
                        return false;
                    }
                    else if (integerValidator(pass) == true)
                    {
                        MessageBox.Show("Enter only numbers here");
                        return false;

                    }
                    else if (Password != pass)
                    {
                        MessageBox.Show("Password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }


    }
}
