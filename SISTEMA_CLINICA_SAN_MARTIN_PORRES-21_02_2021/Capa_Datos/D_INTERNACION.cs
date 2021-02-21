using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
  public class D_INTERNACION
    {
        private int codigo;       
        private string estado;
        private int codigoPaciente;
        private int codigoFunciona;
        private int codigoMedico;
        private string descripcion;

        public string _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int _CodigoMedico
        {
            get { return codigoMedico; }
            set { codigoMedico = value; }
        }

        public int _CodigoFuncionario
        {
            get { return codigoFunciona; }
            set { codigoFunciona = value; }
        }

        public int _CodigoPaciente
        {
            get { return codigoPaciente; }
            set { codigoPaciente = value; }
        }

        private DateTime fecha;

        public DateTime _Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
       
        public string _Estado
        {
            get { return estado; }
            set { estado = value; }
        }
       
        public int _Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public D_INTERNACION()
        {

        }
        public D_INTERNACION(int cod,DateTime fec, int codiPAcie, int codiMedic, int codiFuncio, string obs, string est)
        {
            _Codigo = cod;
            _Fecha = fec;
           _CodigoPaciente = codiPAcie;
            _CodigoMedico = codiMedic;
            _CodigoFuncionario = codiFuncio;
            _Descripcion = obs;
            _Estado = est;
        }
        SqlCommand sqlcmd;
        SqlConnection sqlconex;
        SqlTransaction sqltrans;
        DataTable tableResultado;
        public string result = "";

        public DataTable Consultar_Id_Internacion(D_INTERNACION ID)
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[INTERNACION_ID]";
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

        public DataTable Listar()
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "INTERNACION_MOSTRAR";
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

        public string REGISTRAR_INTERNACION(D_INTERNACION lista)
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
                sqlcmd.CommandText = "INTERNACION_REGISTRAR";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Fecha", lista._Fecha);
                sqlcmd.Parameters.AddWithValue("@CodigoMedico", lista._CodigoMedico);
                sqlcmd.Parameters.AddWithValue("@CodigoFuncionario", lista._CodigoFuncionario);
                sqlcmd.Parameters.AddWithValue("@CodigoPaciente", lista._CodigoPaciente);
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
        public string EDITAR_INTERNACION(D_INTERNACION editar)
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
                sqlcmd.CommandText = "[INTERNACION_EDITAR]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", editar._Codigo);
                sqlcmd.Parameters.AddWithValue("@Fecha", editar._Fecha);
                sqlcmd.Parameters.AddWithValue("@CodigoMedico", editar._CodigoMedico);
                sqlcmd.Parameters.AddWithValue("@CodigoFuncionario", editar._CodigoFuncionario);
                sqlcmd.Parameters.AddWithValue("@CodigoPaciente", editar._CodigoPaciente);
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
        public string ELIMINAR_FUNCIONARIO(D_Funcionario eliminar)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conexion_bd;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "FUNCIONARIO_Eliminar";
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
        public string CAMBIO_ESTADO_INTERNACION(D_INTERNACION estado)
        {
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;

                sqlcmd.CommandText = "[INTERNACION_Cambio_Estado]";
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

        public DataTable BUSCAR_LISTA_FUNCIONARIO(string BUSCAR, string CBTIPOS, string CBESTADOS)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[FUNCIONARIO_Buscar_Campo]";
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

        public DataTable BUSCAR_REPORTE_LISTA_FUNCIONARIO(string estado_lista, string cbtipo, string caja)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[FUNCIONARIO_Reporte]";
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


        public bool Exists_AsignacionSala(D_INTERNACION usuarios)
        {
          
            int conta = 0;
            try
            {
               // sqlconex.ConnectionString = Conexion.Conexion_bd;
               
                sqlcmd = new SqlCommand();
               // sqlcmd.Connection = sqlconex;
                using (sqlconex = new SqlConnection(Conexion.Conexion_bd))
                {
                    sqlconex.Open();
                    sqlcmd.CommandText = "INTERNACION_ASIGNACION_SALA_EXISTENTE";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@Codigo", usuarios._Codigo);
                    conta = Convert.ToInt32(sqlcmd.ExecuteScalar());

                }


            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            //finally {
            //    if (sqlconex.State == ConnectionState.Open) {
            //        sqlconex.Close();
            //    }
            //}
            return conta == 0;
        }
    }
}
