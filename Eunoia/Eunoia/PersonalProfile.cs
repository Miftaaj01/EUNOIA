using System;
using System.Collections.Generic;
using System.Text;

namespace Eunoia
{
    class PersonalProfile
    {
        private string getName;
        private string email;

        public string RealName
        {
            set { getName = value; }   
        }

        public string Email
        {
            set { email = value; }
        }

        public void updateProfile(string realName, string email)
        {

        }
    }
}
