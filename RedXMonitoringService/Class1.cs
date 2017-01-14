using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace RedXMonitoringService
{
    public class DataLayer
    {
        string connectionString;
        string sqlquery;
        SqlConnection connexion;
        SqlCommand commande;
        SqlDataAdapter dataA;
        DataSet dataS;


        public DataLayer()
        {

        }

        private void startConnection(string cnx)
        {
            connexion.ConnectionString = cnx;
            connexion.Open();
        }

        private void startCommands(string rq_sql)
        {

        }


    }
}
