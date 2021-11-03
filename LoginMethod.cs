using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace VaxTrax_2._0_
{
    class LoginMethod
    {
        public static bool IsValid()
        {
            bool returnStatus;

            int userExists;

            string connectionString = GetConnectionString();

            string sqlString = "select count(*) from Vaccinator where UserName = @GlobalUser_UserID and Password = @GlobalUser_Password";

            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();

                    parameters.Add("@GlobalUser_UserID", GlobalUser.UserID, DbType.String, ParameterDirection.Input);
                    parameters.Add("@GlobalUser_Password", GlobalUser.Password, DbType.String, ParameterDirection.Input);

                    userExists = (Convert.ToInt32(db.ExecuteScalar(sqlString, parameters)));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if(userExists == 1)
            {
                returnStatus = true;
            }
            else
            {
                returnStatus = false;
            }

            return returnStatus;
        }

        private static string GetConnectionString()
        {
            string connectionString = "server=vaxtrax.database.windows.net;database=VaxTraxDB;user id=Brinkmann;password=VaxTrax1!;";

            return connectionString;
        }
    }
}
