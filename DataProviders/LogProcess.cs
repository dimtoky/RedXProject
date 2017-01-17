using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    //Classe de la couche métier pour la le service windows
    //Cette classe permet au service de modifier les log sur la BDD
    class LogProcess : ProcessLayer
    {

        private System.Data.DataSet dataS;
        private DataLayer oCad;
        private LogMap mapLogger;
        private string sqlquery;


        public LogProcess()
        {
            this.dataS = new System.Data.DataSet();
            this.mapLogger = new LogMap();
            this.oCad = new DataLayer();
            this.sqlquery = "NC";
            
        }

        

        //méthode pour inserer les logs
        override public void setText(string nom,int valide,int code,string msg)
        {
            this.dataS.Clear();

            this.mapLogger.setNom(nom);
            this.mapLogger.setValide(valide);
            this.mapLogger.setCodeE(code);
            this.mapLogger.setMError(msg);


            this.sqlquery = this.mapLogger.insert();
            this.oCad.setDataRows(this.sqlquery);
        }

        //méthode pour modifier la valeur des logs
        override public void updateText(int id,string nom, int valide, int code, string msg)
        {
            this.dataS.Clear();

            this.mapLogger.setID(id);          
            this.mapLogger.setValide(valide);         

            this.sqlquery = this.mapLogger.update(); ;
            this.oCad.setDataRows(this.sqlquery);
        }



        
    }
}
