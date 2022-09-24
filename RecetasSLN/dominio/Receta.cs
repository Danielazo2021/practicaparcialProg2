using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        public int recetaNro { get; set; }
        public string nombre { get; set; }
        public int tipoReceta { get; set; }
        public string cheff { get; set; }

        public List<DetalleReceta> Detalles { get; }

        public Receta()
        {
            //generar la relación 1 a muchos
            Detalles = new List<DetalleReceta>();
        }

        public void AgregarDetalle(DetalleReceta detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }

        public double Total()
        {
            double total = 0;
            foreach (DetalleReceta item in Detalles)
            {
                total += item.cantidad;
            }
            return total;
        }
    }
}
