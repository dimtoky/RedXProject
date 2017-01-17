using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    //Classe de mappage des fichiers log
    //cette classe contient les méthodes pour les requétes adressées à la table "LogTable"
    public class LogMap
    {
        private string sqlquery;
        private int ID;
        private string nom;
        private int valide;
        private int codeE;
        private string mError;

        public string  SelectAll()
        {
           this.sqlquery = "SELECT * FROM LogTable;";
           return this.sqlquery;
        }

        public string insert()
        {
            this.sqlquery = "INSERT INTO LogTable (nom,valide,codeE,mError) VALUES ('"+this.nom+"',("+this.valide+"),("+this.codeE+"),'"+this.mError+"');";
            return this.sqlquery;
        }

        public string update()
        {
            this.sqlquery = "UPDATE LogTable SET valide = ("+this.valide+") WHERE (id = "+this.ID+");";
            return this.sqlquery;
        }
        
     //Setter des attributs
     public void setID(int id) { this.ID = id; }
     public void setNom(string nom) { this.nom = nom; }
     public void setValide(int value) { this.valide = value; }
     public void setCodeE(int code) { this.codeE = code; }
     public void setMError(string msg) { this.mError = msg; }
    }
}
