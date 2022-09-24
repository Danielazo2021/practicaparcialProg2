using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class DetalleReceta
    {
        public Ingrediente ingrediente { get; set; }
        public int cantidad { get; set; }
        public DetalleReceta(Ingrediente ingrediente, int cantidad)
        {
            this.ingrediente = ingrediente;
            this.cantidad = cantidad;
        }
    }
}
