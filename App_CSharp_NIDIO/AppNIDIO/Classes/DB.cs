using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;

namespace AppNIDIO.Classes
{
    class DB
    {
        /* Declarations */
        private Config configs = new Config();
        private OracleConnection conn;
        private string conn_string;

        public DB()
        {
            this.conn_string =
                "Data Source=" +
                this.configs.DB_User + "/" +
                this.configs.DB_Pass + "@" +
                this.configs.DB_Host + ":" +
                this.configs.DB_Port + "//" +
                this.configs.DB_Instance;
        }
   
        public void connectDB()
        {
            this.conn = new OracleConnection();
            this.conn.ConnectionString = this.conn_string;
            this.conn.Open();
        }

        public void closeDB()
        {
            this.conn.Close();
            this.conn.Dispose();
        }

        public OracleDataReader execQry(string query, List<OracleParameter> args)
        {
            OracleCommand comm = this.conn.CreateCommand();
            comm.CommandText = query;
            
            foreach (OracleParameter param in args)
            {
                comm.Parameters.Add(param);
            }
            return comm.ExecuteReader();
        }

    }
}
