using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezun_Portali.Ent.ValueObjects
{
    public class LoginViewModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public LoginViewModel(string username,string password,string email)
        {
            this.username = username;
            this.email = email;
            this.email = email;
        }
    }
}
