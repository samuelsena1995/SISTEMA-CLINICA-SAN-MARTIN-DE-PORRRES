using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
   public class D_ASIGNACION_SALA
    {
        private int codigo;
        private string estado;
        private int codigoSala;        
        private int codigoInternacion;
        private DateTime fecha;
        public int _CodigoSala
        {
            get { return codigoSala; }
            set { codigoSala = value; }
        }

        public int _CodigoInternacion
        {
            get { return codigoInternacion; }
            set { codigoInternacion = value; }
        }     

        

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

        public D_ASIGNACION_SALA()
        {

        }
        public D_ASIGNACION_SALA(int cod, DateTime fec, int codiSala, int codiInternacio,string estado)
        {
            _Codigo = cod;
            _Fecha = fec;
            _CodigoSala = codiSala;
            _CodigoInternacion = codigoInternacion;
            _Estado = estado;
        }
        SqlCommand sqlcmd;
        SqlConnection sqlconex;
        SqlTransaction sqltrans;
        DataTable tableResultado;
        public string result = "";

        public DataTable Consultar_Asignacion_Sala(D_ASIGNACION_SALA ID)
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "ASIGNACION_SALA_ID";
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

        /// <summary>
        /// /ASIGNACION DE SALA
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public string REGISTRAR_ASIGNACION_SALA(D_ASIGNACION_SALA lista)
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
                sqlcmd.CommandText = "ASIGNACION_SALA_REGISTRAR";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Fecha", lista._Fecha);
                sqlcmd.Parameters.AddWithValue("@Codigo_Sala", lista._CodigoSala);
                sqlcmd.Parameters.AddWithValue("@CodigoInternacion", lista._CodigoInternacion);
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

        public DataTable Listar_ASIGNACION_SALA()
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "ASIGNACION_SALA_MOSTRAR";
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

        public string ANULAR_ASIGNACION_SALA(D_ASIGNACION_SALA estado)
        {
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;

                sqlcmd.CommandText = "[ASIGNACION_SALA_ANULAR]";
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

        ///para el modulo reporte de control////
        public DataTable BUSCAR_REPORTE_LISTA_ASIGNACION_SALA( DateTime FECHA)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "SP_REPORTE_CONTROL_TIPOHABILTACION_AÑO";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@FECHA", _Fecha);
                SqlDataAdapter sqldate = new SqlDataAdapter(sqlcmd);
                sqldate.Fill(tableResultado);
            }
            catch (Exception)
            {
                tableResultado = null;
            }
            return tableResultado;
        }
        ///////

        public DataTable CONSULTAR(D_ASIGNACION_SALA consultar) {

            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "ASIGNACION_SALA_CONSULTAR";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@CodigoInternacion";
                parid.SqlDbType = SqlDbType.Int;
                parid.Value = consultar._CodigoInternacion;
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
    }
}
