using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;
using AppNIDIO.Classes;

namespace AppNIDIO.Components.Login
{
    class modLogin
    {
        private Db db = new Db();
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
    }
}
