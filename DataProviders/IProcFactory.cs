using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    //Interface de la classe ProcFactory
    interface IProcFactory
    {
        ProcessLayer createProcess(string nom);


    }
}
