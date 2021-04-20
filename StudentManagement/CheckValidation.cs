using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    class CheckValidation
    {
        //check email validation
        public static bool checkEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
