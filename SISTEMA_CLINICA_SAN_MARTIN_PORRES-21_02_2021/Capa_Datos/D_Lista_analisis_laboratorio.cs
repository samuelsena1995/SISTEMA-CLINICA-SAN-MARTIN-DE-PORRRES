﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
   public class D_Lista_analisis_laboratorio
    {
        private int Codigo;
        private string Nombre_corto;
        private string Descripcion;
        private string Estado;

        public string ESTADO
        {
            get { return Estado; }
            set { Estado = value; }
        }


        public string DESCRIPCION
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }


        public string NOMBRE_CORTO
        {
            get { return Nombre_corto; }
            set { Nombre_corto = value; }
        }


        public int CODIGO
        {
            get { return Codigo; }
            set { Codigo = value; }
        }


        SqlCommand sqlcmd;
        SqlConnection sqlconex;
        SqlTransaction sqltrans;
        DataTable tableResultado;
        public string result="";

        public DataTable Listar()
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "LISTA_DE_ANALISIS_LABORATORIO_Mostrar";
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
        public DataTable Consultar_Id_lista_analisis(D_Lista_analisis_laboratorio ID)
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "LISTA_DE_ANALISIS_LABORATORIO_ID";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@id";
                parid.SqlDbType = SqlDbType.Int;
                parid.Value = ID.CODIGO;
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
        public string REGISTRAR_LISTA_LABORATORIO(D_Lista_analisis_laboratorio lista) {
            try
            {
                sqlconex = new SqlConnection();
                sqlcmd = new SqlCommand();
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqltrans = sqlconex.BeginTransaction();

                sqlcmd.Connection = sqlconex;
                sqlcmd.Transaction = sqltrans;
                sqlcmd.CommandText = "LISTA_DE_ANALISIS_LABORATORIO_Registrar";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Nombrecorto", lista.NOMBRE_CORTO);
                sqlcmd.Parameters.AddWithValue("@Descripcion", lista.DESCRIPCION);
                sqlcmd.Parameters.AddWithValue("@Estado", lista.ESTADO);

                result = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se puede registrar";
                if (result.Equals("OK")) {
                    sqltrans.Commit();
                }else
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
                if (sqlconex.State == ConnectionState.Open) {
                    sqlconex.Close();
                }
            }
            return result;
        }
        public string EDITAR_LISTA_LABORATORIO(D_Lista_analisis_laboratorio editar) {

            try
            {
                sqlconex = new SqlConnection();
                sqlcmd = new SqlCommand();
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqltrans = sqlconex.BeginTransaction();

                sqlcmd.Connection = sqlconex;
                sqlcmd.Transaction = sqltrans;
                sqlcmd.CommandText = "LISTA_DE_ANALISIS_LABORATORIO_Editar";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", CODIGO);
                sqlcmd.Parameters.AddWithValue("@Nombrecorto", NOMBRE_CORTO);
                sqlcmd.Parameters.AddWithValue("@Descripcion", DESCRIPCION);
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
            finally {
                if (sqlconex.State == ConnectionState.Open) {
                    sqlconex.Close();
                }
            }
            return result;
        }
        public string ELIMINAR_LISTA_LABORATORIO(D_Lista_analisis_laboratorio eliminar) {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conexion_bd;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "LISTA_DE_ANALISIS_LABORATORIO_Eliminar";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@Codigo", eliminar.CODIGO);

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
        public string CAMBIO_ESTADO_LISTA_LABORATORIO(D_Lista_analisis_laboratorio estado) {
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;

                sqlcmd.CommandText = "LISTA_DE_ANALISIS_LABORATORIO_Cambio_Estado";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", estado.CODIGO);
                sqlcmd.Parameters.AddWithValue("@Estado", estado.ESTADO);

                result = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se cambio el estado";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally {
                if (sqlconex.State == ConnectionState.Open)
                {
                    sqlconex.Close();
                }
            }
            return result;
        }
    
        public DataTable BUSCAR_LISTA_LABORATORIO(string BUSCAR, string CBTIPOS, string CBESTADOS) {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[LISTA_DE_ANALISIS_LABORATORIO_Buscar_Campo]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@buscar",BUSCAR);
                sqlcmd.Parameters.AddWithValue("@cbtipos", CBTIPOS);
                sqlcmd.Parameters.AddWithValue("@cbestado", CBESTADOS);

                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcmd);
                sqldata.Fill(tableResultado);
            }
            catch (Exception ex)
            {
                tableResultado = null;
            }
            return tableResultado;
        }

        public DataTable BUSCAR_REPORTE_LISTA_LABORATORIO(string estado_lista) {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "LISTA_DE_ANALISIS_LABORATORIO_Reporte";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Estado", estado_lista);
                SqlDataAdapter sqldate = new SqlDataAdapter(sqlcmd);
                sqldate.Fill(tableResultado);
            }
            catch (Exception)
            {
                tableResultado = null;
            }
            return tableResultado;
        }

        public DataTable BUSCAR_REPORTE_LISTA_LABORATORIO_CAJA(string estado_lista, string caja)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[LISTA_DE_ANALISIS_LABORATORIO_Reporte_Buscar]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Estado", estado_lista);
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

        public DataTable BUSCAR_REPORTE_LISTA_LABORATORIO_CAJA2(string estado_lista,string cbtipo, string caja)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[LISTA_DE_ANALISIS_LABORATORIO_Reporte_Buscar2]";
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
