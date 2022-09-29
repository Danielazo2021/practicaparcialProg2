using RecetasSLN.datos;
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
        string[] tipoRecetas = { "1 - pollo", "2 - carne", "3 - pastas", "4 - pescado", "5 - otros" };
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

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            cargargrilla();
            cargarTipoReceta();

        }

        private void cargarTipoReceta()
        {
            /*
            DataTable tabla = ImplementacionDao.ObtenerInstancia().consultarBD("pa_comboTipoRecetas");
            cboTipoReceta.DataSource = tabla;
            cboTipoReceta.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoReceta.DisplayMember = tabla.Columns[1].ColumnName;*/
            
            
            cboTipoReceta.DataSource = tipoRecetas; // uso la lista que pase en vez de una tabla de la base

        }

        private void cargargrilla()
        {

            DataTable tabla = ImplementacionDao.ObtenerInstancia().consultarBD("pa_MostrarGrillaConsultas");
            dgvConsultas.Rows.Clear();           


            dgvConsultas.DataSource = tabla;
            

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Función Momentanemente no disponible, pero puede ingresar una receta nueva sin ningún inconveniente");
            return;

        }
    }
}
