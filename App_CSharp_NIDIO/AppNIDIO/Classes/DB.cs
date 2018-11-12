using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Oracle.ManagedDataAccess.Client;

namespace AppNIDIO.Classes
{
    public class DB
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

        public OracleDataReader execQry(string query)
        {
            OracleCommand comm = this.conn.CreateCommand();
            comm.CommandText = query;

            return comm.ExecuteReader();
        }

        public OracleDataReader execQry(string query, List<OracleParameter> inParams)
        {
            OracleCommand comm = this.conn.CreateCommand();
            comm.CommandText = query;

            foreach (OracleParameter dbParam in inParams)
            {
                comm.Parameters.Add(dbParam);
            }

            return comm.ExecuteReader();
        }

    }
}
