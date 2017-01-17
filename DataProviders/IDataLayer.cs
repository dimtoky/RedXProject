using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{

    //Interfaces de la classe Datalayer avec signature des méthodes
    interface IDataLayer
    {

        void setDataRows(string rq_sql);

        DataSet getDataRows(string rq_sql, string dataTableName);
    }
}
