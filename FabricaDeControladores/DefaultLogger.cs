using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FabricaDeControladores
{
    public class DefaultLogger : ILogger
    {
        /*Se pueden implementar otros metodos por ejemplo para que el log se guarde en disco , en base de datos, se mande a jun webservice etcetera*/
        public void Write(string Data)
        {
            Debug.WriteLine(Data,"DefaultLogger");
        }
    }
}