using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASICS.Class
{
    public class clsConexao
    {

        SqlConnection sqlCon = new SqlConnection();

        //Construtor
        public clsConexao()
        {
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["basicsDB"].ConnectionString;
        }

        //Método Conectar
        public SqlConnection Connect()
        {
            if(sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            return sqlCon;

        }

        public void Disconnect()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

    }
}
