using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNIDIO.Classes
{
    public class User
    {
        private int id;
        private string userName;
        private string name;
        private string lastName;
        private string pass;
        private string email;
        private string phone;
        private int acess;

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Acess { get; set; }

    }
}
