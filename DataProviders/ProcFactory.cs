using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{

    //Abstract factory pour les classe de type ProcessLayer
    
    public class ProcFactory : IProcFactory
    {

        ProcessLayer temp;
        public ProcFactory()
        {
            
        }

        //Cette méthode permet de renvoyer un objet RedXProcess ou LogProcess de type ProcessLayer 
      public ProcessLayer createProcess(string nom)
        {
            if (nom == "RedX")
            {
                return temp = new RedXProcess();
            }
            else if (nom == "Log")
            {
                return temp = new LogProcess();
            }

            return null;
        }

        
    }
}
