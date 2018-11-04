using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNIDIO.Classes
{
    class Config
    {
        /* DataBase Connector */
        private string db_host = "localhost";
        private string db_port = "3306";
        private string db_user = "test";
        private string db_pass = "test";
        private string db_instance = "test";
        public string DB_Host { get => db_host; }
        public string DB_Port { get => db_port; }
        public string DB_User { get => db_user; }
        public string DB_Pass { get => db_pass; }
        public string DB_Instance { get => db_instance; }
    }
}
