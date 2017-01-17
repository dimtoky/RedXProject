using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    //Classe de mappage des texte à diffuser
    //cette classe contient les méthodes pour les requétes adressées à la table "TextTable"
    class RedXMap
    {
        int ID;
        string text;
        string sqlquery;


        public string SelectAll()
        {
            this.sqlquery = "SELECT * FROM textTable;";
            return this.sqlquery;
        }

        public string insert()
        {
            this.sqlquery = "INSERT INTO textTable (text) VALUES ('" + this.text + "');";
            return this.sqlquery;
        }

        public string update()
        {
            this.sqlquery = "UPDATE textTable SET text = '" + this.text + "' WHERE ID = (" + this.ID + ");";
            return this.sqlquery;
        }

        public string delete()
        {
            this.sqlquery = "DELETE FROM textTable WHERE (ID = " + this.ID + ");";
            return this.sqlquery;
        }


        //Setter des attributs
        public void setID(int id) { this.ID = id; }
        public void setText(string nom) { this.text = nom; }

    }
}
