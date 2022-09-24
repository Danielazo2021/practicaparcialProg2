using RecetasSLN.datos;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación //Observaciones 
/* no existe la tabla tipo de recetas, ni el sp para consultar,
 lo que no permite cargar la ventana principal.
tampoco deja guardar sin el tipo de receta.
no pide que funcione la consulta del form princiipal, 
solo activamos el boton nueva receta??
no indica en el datagridview que poner en accion, 
puse la unidad porque queda mejor...
no tiene creado el sp para buscar la ultima receta y sumarle uno


no pide que usemos interfaces.... no pide que usemos instancia de singelton
no pide que carguemos el dgv del form principal para usar los filtros ni nada

*/



{
    public partial class Frm_Nueva_Receta : Form
    {
       // Helper dao = new Helper();
       
        Receta oReceta = new Receta();
        Ingrediente MiIngrediente = new Ingrediente();

        public Frm_Nueva_Receta()
        {
            InitializeComponent();
        }

        private void Frm_Nueva_Receta_Load(object sender, EventArgs e)
        {
            cargarcomboIngredientes();
          //  cargarcomboTipoRecetas();  // no existe tabla prox receta
            rbtKilos.Checked = true;
            //cargarProximaReceta(); //no existe sp 
            limpiarCampos();

        }

        private void cargarProximaReceta()
        {
            LblProximaReceta.Text = "Esta es la receta nº " + Convert.ToString((HelperBD.ObtenerInstancia().ProximaReceta("pa_UltimaReceta")) + 1);
            //creo un SP para buscar la ultima receta
        }

        private void cargarcomboTipoRecetas() // ver que no hay tabla tipo de receta // creo una tabla y un sp 
        {
            DataTable tabla = HelperBD.ObtenerInstancia().consultarBD("pa_comboTipoRecetas"); // no existe 
            cboTipo.DataSource = tabla;
            cboTipo.ValueMember = tabla.Columns[0].ColumnName;
            cboTipo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void cargarcomboIngredientes()
        {
            DataTable tabla = HelperBD.ObtenerInstancia().consultarBD("SP_CONSULTAR_INGREDIENTES");
            cboIngrediente.DataSource = tabla;
            cboIngrediente.ValueMember = tabla.Columns[0].ColumnName;
            cboIngrediente.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void limpiarCampos()
        {
            txtCheff.Text = "";
            txtNombre.Text = "";
            cboTipo.SelectedIndex = -1;
            cboIngrediente.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (cboIngrediente.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar algun ingrediente");
                return;
            }
            if (existeProductoEnGrilla(cboIngrediente.Text))
            {
                MessageBox.Show("Ingrediente ya agregado");
                return;
            }

            DataRowView oIngrediente = (DataRowView)cboIngrediente.SelectedItem;

            int Idingrediente = (int)(oIngrediente.Row.ItemArray[0]);
            string nombreIngrediente = oIngrediente.Row[1].ToString();
            int cantidad = (int)nudCantidad.Value;
            string unidad;


            if (rbtGramos.Checked)
            {
                 unidad = "gr";
            }
            if(rbtCm3.Checked)
            {
                unidad = "Cm3";
            }
            else
            {
                unidad = "Kg";
            }
            MiIngrediente.nombre = nombreIngrediente;
            MiIngrediente.unidad = unidad;
            MiIngrediente.ingredienteId = Idingrediente;

            DetalleReceta item = new DetalleReceta(MiIngrediente, cantidad);

            oReceta.AgregarDetalle(item);

            dgvDetalles.Rows.Add(new object[] { "", MiIngrediente.nombre, cantidad, unidad }); ;
            ActualizarContadorDetalles();


        }

        private void ActualizarContadorDetalles()
        {
            lblTotalIngredientes.Text = " Cantidad de ingredientes de la receta: " + Convert.ToString(dgvDetalles.Rows.Count);

        }

        private bool existeProductoEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["col_ingrediente"].Value.Equals(text))
                    return true;
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count <= 3)
            {
                MessageBox.Show("Ha olvidado ingredientes ?");
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("debe ingresar el nombre de la receta");
            }
            if (txtCheff.Text == "")
            {
                MessageBox.Show("debe ingresar el nombre del Cheff");
            }




            oReceta.nombre = txtNombre.Text;
            oReceta.cheff = txtCheff.Text;
            oReceta.recetaNro = (HelperBD.ObtenerInstancia().ProximaReceta("pa_UltimaReceta") + 1); // por mas quesea identity lo necesito para el detalle
            oReceta.tipoReceta = (int)(cboTipo.SelectedIndex + 1);

            if (HelperBD.ObtenerInstancia().grabarReceta(oReceta, "SP_INSERTAR_RECETA", "SP_INSERTAR_DETALLES"))
            {
                MessageBox.Show("Receta grabada con exito ", "aviso!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("error al grabar la receta", "Atención!", MessageBoxButtons.OK);
            }
            limpiarCampos();
            cargarProximaReceta();
            limpiarGrilla();
            ActualizarContadorDetalles();

        }

        private void limpiarGrilla()
        {
            dgvDetalles.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
