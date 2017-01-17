using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataProviders
{

    //Classe de la couche métier pour l'application de gestion et de diffusion
    //Cette classe permet aux applications de modifier ou récuperer les textes à diffuser sur la BDD
    public class RedXProcess : ProcessLayer
    {
        private System.Data.DataSet dataS;
        private DataLayer oCad;
        private LogMap mapLogger;
        private RedXMap mapRedX;
        private string sqlquery;


        public RedXProcess()
        {
            this.dataS = new System.Data.DataSet();
            this.mapLogger = new LogMap();
            this.mapRedX = new RedXMap();
            this.oCad = new DataLayer();
            this.sqlquery = "NC";

        }


        //méthode pour récuperer les logs
        override public DataSet chargerLog(string dataTableName)
        {
            this.dataS.Clear();

            this.sqlquery = this.mapLogger.SelectAll();
            this.dataS = this.oCad.getDataRows(this.sqlquery, dataTableName);

            return this.dataS;
        }


        //méthode pour recuperer la table "TextTable"
        override public DataSet getText(string dataTableName)
        {
            this.dataS.Clear();

            this.sqlquery = this.mapRedX.SelectAll();
            this.dataS = this.oCad.getDataRows(this.sqlquery, dataTableName);

            return this.dataS;
        }


        //méthode pour inserer de nouveaux textes
        override public void setText(string text)
        {
            this.dataS.Clear();


            this.mapRedX.setText(text);

            this.sqlquery = this.mapRedX.insert();
            this.oCad.setDataRows(this.sqlquery);
        }


        //méthode pour modifier un texte
        override public void updateText(int id, string text,string dataTableName)
        {
            this.dataS.Clear();

            this.mapRedX.setID(id);
            this.mapRedX.setText(text);

            this.sqlquery = this.mapRedX.update(); ;
            this.oCad.setDataRows(this.sqlquery);

            this.getText(dataTableName);
        }

        //méthode pour supprimer un texte
        override public void deleteText(int id)
        {
            this.dataS.Clear();

            this.mapRedX.setID(id);
            this.sqlquery = this.mapRedX.delete();
            this.oCad.setDataRows(this.sqlquery);
        }
    }
}
