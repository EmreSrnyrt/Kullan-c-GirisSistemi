using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class kullanici : insan
    {
        private string username;
        private int userid;
        private string password;
        private string posta;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Posta
        {
            get { return posta; }
            set { posta = value; }
        }
    }
}
