using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class HelperBD
    {
        //SqlConnection cnn = new SqlConnection(@"Data Source =laptop-sjp45n95; Initial Catalog = recetas_db; Integrated Security = True");
        //SqlCommand cmd = new SqlCommand();

        private static HelperBD instancia;
        private SqlConnection cnn;

        private HelperBD()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }

        public static HelperBD ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperBD();
            return instancia;
        }

       

        public DataTable consultarBD(string pa)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(pa, cnn);
            DataTable tabla = new DataTable();
            try
            {
               
                cmd.CommandType = CommandType.StoredProcedure;
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        internal bool grabarReceta(Receta oReceta, string paMaestro, string paDetalle)
        {

            SqlTransaction t = null;
            bool confirmar = false;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdMaestro = new SqlCommand(paMaestro, cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                //cmdMaestro.Parameters.AddWithValue("@id_receta", oReceta.recetaNro); es identity
                cmdMaestro.Parameters.AddWithValue("@nombre", oReceta.nombre);
                cmdMaestro.Parameters.AddWithValue("@tipo_receta", oReceta.tipoReceta);
                cmdMaestro.Parameters.AddWithValue("@cheff", oReceta.cheff);
                cmdMaestro.ExecuteNonQuery();

                foreach (DetalleReceta det in oReceta.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand(paDetalle, cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_receta", oReceta.recetaNro);
                    cmdDetalle.Parameters.AddWithValue("@id_ingrediente", det.ingrediente.ingredienteId);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", det.cantidad);
                    cmdDetalle.ExecuteNonQuery();

                }
                confirmar = true;
                t.Commit();
            }
            catch
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return confirmar;

        }

        internal int ProximaReceta(string pa)
        {

            SqlCommand cmd = new SqlCommand(pa);
            DataTable tabla = new DataTable();
            int verificacion;
            try
            {


                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@next";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                cnn.Close();
                try
                {
                    verificacion = (int)pOut.Value;

                }
                catch
                {
                    return 0;
                }

                return (int)pOut.Value;
                

            }
            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

        }
    }
}
