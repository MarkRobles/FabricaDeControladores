using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeControladores
{
    /*Esta infertace permitira definir los miembros que deben cumplir las clases para que permitan escribir un historial */
    interface ILogger
    {
        void Write(string Data);

    }
}
