using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class D_EVOLUCION_MEDICA
    {
        private int Codigo;
        private int Codigo_Internacion;
        private int Codigo_Usuario;
        private int Codigo_Medico;
        private string Descripcion;
        private string Estado;
        SqlCommand sqlcmd;
        SqlConnection sqlconex;
        SqlTransaction sqltrans;
        DataTable tableResultado;
        public string result = "";

        public string _Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public string _Descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public int _Codigo_Medico
        {
            get { return Codigo_Medico; }
            set { Codigo_Medico = value; }
        }

        public int _Codigo_Usuario
        {
            get { return Codigo_Usuario; }
            set { Codigo_Usuario = value; }
        }

        public int _Codigo_Internacion
        {
            get { return Codigo_Internacion; }
            set { Codigo_Internacion = value; }
        }

        public int _Codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        ///
        public D_EVOLUCION_MEDICA() { }

        public D_EVOLUCION_MEDICA(int cod, int cod_inte, int cod_usua, int cod_medi, string desc, string esta) {
            this._Codigo = cod;
            this._Codigo_Internacion = cod_inte;
            this._Codigo_Usuario = cod_usua;
            this._Codigo_Medico = cod_medi;
            this._Descripcion = desc;
            this._Estado = esta;           
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
                sqlcmd.CommandText = "EVOLUCION_MEDICA_MOSTRAR";
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

        public string REGISTRAR_MEDICO(D_EVOLUCION_MEDICA lista)
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
                sqlcmd.CommandText = "[EVOLUCION_MEDICA_REGISTRAR]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo_internacion", lista._Codigo_Internacion);
                sqlcmd.Parameters.AddWithValue("@Codigo_usuario", lista._Codigo_Usuario);
                sqlcmd.Parameters.AddWithValue("@Codigo_medico", lista._Codigo_Medico);
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

        public DataTable Consultar_EVOLUCION(D_EVOLUCION_MEDICA ID)
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "EVOLUCION_MEDICA_ID";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@Codigo";
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

        public string EDITAR(D_EVOLUCION_MEDICA editar)
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
                sqlcmd.CommandText = "EVOLUCION_MEDICA_EDITAR";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", editar._Codigo);
                sqlcmd.Parameters.AddWithValue("@Codigo_internacion", editar._Codigo_Internacion);
                sqlcmd.Parameters.AddWithValue("@Codigo_Usuario", editar._Codigo_Usuario);
                sqlcmd.Parameters.AddWithValue("@Codigo_Medico", editar._Codigo_Medico);
                sqlcmd.Parameters.AddWithValue("@Descripcion", editar._Descripcion);
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
        public string CAMBIAR_eSTADO(D_EVOLUCION_MEDICA editar)
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
                sqlcmd.CommandText = "EVOLUCION_MEDICA_CAMBIAR_ESTADO";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", editar._Codigo);
                sqlcmd.Parameters.AddWithValue("@Estado", editar._Estado);
           
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
    }
}
