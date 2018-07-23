using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    class Customer
    {
        private int id;
        private string name;
        private int contact;
        private string userName;
        private int password;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Contact { get => contact; set => contact = value; }
        public string UserName { get => userName; set => userName = value; }
        public int Password { get => password; set => password = value;}
    }
}
