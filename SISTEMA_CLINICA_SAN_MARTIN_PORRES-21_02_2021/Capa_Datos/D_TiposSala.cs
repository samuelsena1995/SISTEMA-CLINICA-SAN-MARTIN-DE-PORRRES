using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
 public class D_TiposSala   
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private string estado;

        public string _Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string _Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int _Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public D_TiposSala() {

        }
        public D_TiposSala(int co,string no, string des, string est)
        {
            _Codigo = co;
            _Nombre = no;
            _Descripcion = des;
            _Estado = est;
        }
        SqlCommand sqlcmd;
        SqlConnection sqlconex;
        SqlTransaction sqltrans;
        DataTable tableResultado;
        public string result = "";

        public DataTable Consultar_Id_Tipos(D_TiposSala ID)
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "Tipos_Sala_ID";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@id";
                parid.SqlDbType = SqlDbType.Int;
                parid.Value = ID._Codigo;
                sqlcmd.Parameters.Add(parid);

                SqlDataAdapter sqldate = new SqlDataAdapter(sqlcmd);
                sqldate.Fill(Dtresultado);
            }
            catch (Exception)
            {
                Dtresultado = null;
            }
            return Dtresultado;
        }

        public DataTable Listar()
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "Tipos_Sala_Mostrar";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcmd);
                sqldata.Fill(tableResultado);
            }
            catch (Exception ex)
            {
                tableResultado = null;
            }
            return tableResultado;
        }

        public string REGISTRAR_TIPOS_SALA(D_TiposSala lista)
        {
            try
            {
                sqlconex = new SqlConnection();
                sqlcmd = new SqlCommand();
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqltrans = sqlconex.BeginTransaction();

                sqlcmd.Connection = sqlconex;
                sqlcmd.Transaction = sqltrans;
                sqlcmd.CommandText = "Tipos_Sala_Registrar";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Nombre", lista._Nombre);
                sqlcmd.Parameters.AddWithValue("@Descripcion", lista._Descripcion);
                sqlcmd.Parameters.AddWithValue("@Estado", lista._Estado);

                result = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se puede registrar";
                if (result.Equals("OK"))
                {
                    sqltrans.Commit();
                }
                else
                {
                    sqltrans.Rollback();
                }

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (sqlconex.State == ConnectionState.Open)
                {
                    sqlconex.Close();
                }
            }
            return result;
        }
        public string EDITAR_TIPOS_SALA(D_TiposSala editar)
        {

            try
            {
                sqlconex = new SqlConnection();
                sqlcmd = new SqlCommand();
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqltrans = sqlconex.BeginTransaction();

                sqlcmd.Connection = sqlconex;
                sqlcmd.Transaction = sqltrans;
                sqlcmd.CommandText = "[Tipos_Sala_Editar]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", _Codigo);
                sqlcmd.Parameters.AddWithValue("@Nombre", _Nombre);
                sqlcmd.Parameters.AddWithValue("@Descripcion", _Descripcion);
                result = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se puede editar";

                if (result.Equals("OK"))
                {
                    sqltrans.Commit();
                }
                else
                {
                    sqltrans.Rollback();
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (sqlconex.State == ConnectionState.Open)
                {
                    sqlconex.Close();
                }
            }
            return result;
        }
        public string ELIMINAR_TIPOS_SALA(D_TiposSala eliminar)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conexion_bd;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "[Tipos_Sala_Eliminar]";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@Codigo", eliminar._Codigo);

                rpta = SqlCmd.ExecuteNonQuery() >= 1 ? "OK" : "No se elimino registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public string CAMBIO_ESTADO_TIPOS_SALA(D_TiposSala estado)
        {
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;

                sqlcmd.CommandText = "Tipos_Sala_Cambio_Estado";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", estado._Codigo);
                sqlcmd.Parameters.AddWithValue("@Estado", estado._Estado);

                result = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se cambio el estado";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (sqlconex.State == ConnectionState.Open)
                {
                    sqlconex.Close();
                }
            }
            return result;
        }

        public DataTable BUSCAR_LISTA_TIPOS_SALA(string BUSCAR, string CBTIPOS, string CBESTADOS)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[Tipo_Sala_Buscar_Campo]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@buscar", BUSCAR);
                sqlcmd.Parameters.AddWithValue("@cbtipo", CBTIPOS);
                sqlcmd.Parameters.AddWithValue("@Estado", CBESTADOS);

                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcmd);
                sqldata.Fill(tableResultado);
            }
            catch (Exception ex)
            {
                tableResultado = null;
            }
            return tableResultado;
        }

        public DataTable BUSCAR_REPORTE_LISTA_TIPO_SALA_CAJA2(string estado_lista, string cbtipo, string caja)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[Tipo_Sala_Reporte]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Estado", estado_lista);
                sqlcmd.Parameters.AddWithValue("@cbtipo", cbtipo);
                sqlcmd.Parameters.AddWithValue("@buscar", caja);
                SqlDataAdapter sqldate = new SqlDataAdapter(sqlcmd);
                sqldate.Fill(tableResultado);
            }
            catch (Exception)
            {
                tableResultado = null;
            }
            return tableResultado;
        }

 

    }
}
