using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    internal interface InterfaceDao
    {
        DataTable consultarBD(string pa);
        bool grabarReceta(Receta oReceta, string paMaestro, string paDetalle);
        int ProximaReceta(string pa);

    }
}
