using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    //Classe abstraite pour les classes de la couche métier
    //les classes de la couche métier redéfinissent les méthodes de cette classe
   public abstract class ProcessLayer
    {
        private System.Data.DataSet dataS;       
       

        public ProcessLayer()
        {
           
        }

        virtual public DataSet chargerLog(string dataTableName)
        {
            return this.dataS;
        }


        virtual public DataSet getText(string dataTableName)
        {
            return this.dataS;
        }


        virtual public void setText(string nom, int valide, int code, string msg)
        {

        }

        virtual public void setText(string text)
        {

        }

        virtual public void updateText(int id, string nom, int valide, int code, string msg)
        { }

        virtual public void updateText(int id, string text, string dataTableName)
        { }





        virtual public void deleteText(int id)
        { }
    }
}
