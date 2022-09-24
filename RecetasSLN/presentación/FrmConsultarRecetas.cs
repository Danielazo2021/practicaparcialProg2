using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        Frm_Nueva_Receta Nueva_receta;
        public FrmConsultarRecetas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            Nueva_receta = (new Frm_Nueva_Receta());
            Nueva_receta.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("estas seguro que deseas cerra la aplicacion?", "alerta", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                return;
            }
        }
    }
}
