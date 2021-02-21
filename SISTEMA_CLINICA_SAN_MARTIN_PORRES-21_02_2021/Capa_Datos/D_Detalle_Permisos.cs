using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
   public class D_Detalle_Permisos
    {
        private int id_Usuario;
        private int idPermiso;

        public int ID_Permiso
        {
            get { return idPermiso; }
            set { idPermiso = value; }
        }
        public int ID_Usuario
        {
            get { return id_Usuario; }
            set { id_Usuario = value; }
        }


        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
        SqlTransaction Sqltra;
        DataTable tablaResultados;

        public string Registrar_Funcion()
        {
            string resp = "";
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                string consulta = "insert into AsigancionPermiso(IdUsuario,IdPermiso)values(" + ID_Usuario + "," + ID_Permiso + ")";

                Sqlcmd = new SqlCommand(consulta, SqlCn);
                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "no se ejecuto la consulta";

            }
            catch (Exception ex)
            {
                resp = ex.Message + "Metodo que produjo el error: " + ex.TargetSite;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();
            }
            return resp;
        }

        public string Eliminar_ASIGNACION(D_Detalle_Permisos rol)
        {
            string resp = "";
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "ELIMINAR_ASIGNACION";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@Codigo", rol.ID_Permiso);

                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se puede eliminar el rol";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }
            return resp;
        }
    }
}
