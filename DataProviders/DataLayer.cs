using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    //Classe couche accés aux données
    public class DataLayer : IDataLayer
    {
        string connectionString;
        string sqlquery;
        SqlConnection connexion;
        SqlCommand commande;
        SqlDataAdapter dataA;
        DataSet dataS;

        //Constructeur de la classe
        //initialise les objets et la connection string
        public DataLayer()
        {
            this.connectionString = "Data Source=RYADH-PORTABE-E;Initial Catalog=RedXproject;Integrated Security=True";
           
            this.connexion = new SqlConnection(this.connectionString);
            this.dataA = new SqlDataAdapter();
            this.commande = new SqlCommand();
            this.dataS = new DataSet();

            this.commande.CommandType = CommandType.Text;
            this.commande.Connection = this.connexion;
        }


        //méthode pour envoyer des requétes sans retour de données (INSERT, DELETE..)
        public void setDataRows(string rq_sql)
        {
            this.connexion.Open();
            this.sqlquery = rq_sql;
            this.commande.CommandText = this.sqlquery;
            this.commande.ExecuteNonQuery();
            this.connexion.Close();
        }

        //méthode pour envoyer des requétes avec retour de données (SELECT)
        public DataSet getDataRows(string rq_sql, string dataTableName)
        {
            this.dataS.Clear();

            this.sqlquery = rq_sql;
            this.commande.CommandText = this.sqlquery;
            this.dataA.SelectCommand = this.commande;
            this.dataA.Fill(this.dataS, dataTableName);

            return this.dataS;
        }

    }
}
