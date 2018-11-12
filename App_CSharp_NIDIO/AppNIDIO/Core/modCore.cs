using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Oracle.ManagedDataAccess.Client;
using AppNIDIO.Classes;

namespace AppNIDIO.Core
{
    public class ModCore
    {
        private DB db = new DB();
        private User user = new User();


        public bool login(string userName, string pass)
        {
            this.user.UserName = userName;
            this.user.Pass = pass;

            this.db.connectDB();

            string sql =
                "SELECT lgUser FROM users WHERE lgUser = :username AND pwdUser = :pass";

            List<OracleParameter> parameters = new List<OracleParameter>();

            parameters.Add(new OracleParameter("username", this.user.UserName));
            parameters.Add(new OracleParameter("pass", this.user.Pass));

            OracleDataReader result = this.db.execQry(sql, parameters);

            this.db.closeDB();

            return result.HasRows;
        }

        public void logout()
        {
            this.user = null;
            this.user = new User();
        }

        public List<Select> getServicos()
        {
            List<Select> list = new List<Select>();
            this.db.connectDB();

            string sql =
                "SELECT idSrv, nmSrv FROM tbSrv";

            OracleDataReader result = this.db.execQry(sql);
 
            while (result.Read())
            {
                list.Add(new Select(result.GetInt32(0), result.GetString(1)));
            }
            
            this.db.closeDB();

            return list;
        }

        public int requisitar(Req req)
        {
            this.db.connectDB();

            string sql =
                "Exec insert_req(:usr,:srv,:desc)";

            List<OracleParameter> parameters = new List<OracleParameter>();

            parameters.Add(new OracleParameter("usr", this.user.Id));
            parameters.Add(new OracleParameter("srv", req.Service.Id));
            parameters.Add(new OracleParameter("desc", req.Descricao));

            OracleDataReader result = this.db.execQry(sql, parameters);

            this.db.closeDB();

            return result.GetInt32(0);
        }
    }
}
