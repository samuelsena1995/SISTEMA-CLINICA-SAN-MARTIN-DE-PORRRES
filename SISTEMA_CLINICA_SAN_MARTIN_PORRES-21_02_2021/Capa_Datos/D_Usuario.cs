using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
  public class D_Usuario
    {
        SqlCommand sqlcmd;
        SqlConnection sqlconex;
        SqlTransaction sqltrans;
        DataTable tableResultado;
        public string result = "";
        #region variables
        private string Codiigo_Usu;

        public string _CodigoUsuario
        {
            get { return Codiigo_Usu; }
            set { Codiigo_Usu = value; }
        }

        private string resp = "";
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _estado;
        private string _nombre_completo;
        private string _observacion;
        private string _usuario;
        private string _contraseña;

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        private int _idUsuario;
        private int _idfPermiso;
        //  public int[] resultado;


        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
        SqlTransaction Sqltra;
        DataTable tablaResultados;
        #endregion
        #region propiedades



        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public string Nombre
        {
            get { return _nombre_completo; }
            set { _nombre_completo = value; }
        }
        public int IDUSUARIO
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public int IDPERMISO
        {
            get { return _idfPermiso; }
            set { _idfPermiso = value; }
        }

        #endregion


        public DataTable Login(D_Usuario usuario)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();

            try
            {
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_Login";
                Sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = usuario.Usuario;
                Sqlcmd.Parameters.Add(ParUsuario);

                SqlParameter ParContra = new SqlParameter();
                ParContra.ParameterName = "@contra";
                ParContra.SqlDbType = SqlDbType.VarChar;
                ParContra.Size = 50;
                ParContra.Value = usuario.Contraseña;
                Sqlcmd.Parameters.Add(ParContra);

                SqlDataAdapter Sqldat = new SqlDataAdapter(Sqlcmd);
                Sqldat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }

            finally
            {
                if (SqlCn.State == ConnectionState.Open)
                {
                    SqlCn.Close();
                }
            }

            return tablaResultados;

        }

        public int[] Privilegios_Botones(D_Usuario o)
        {

            string resp = "";

            int[] prueba3 = new int[60];
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                //string consulta = "select fun_rol.Cod_Funciones from ROL r inner join FUNCIONES_ROL_USUARIOS fun_rol on r.Cod_Rol=fun_rol.Cod_Rol where r.Cod_Rol=" + o.IdRol;
                string consulta = "select a.IdPermiso from USUARIO u inner join AsigancionPermiso a on a.IdUsuario=u.Codigo where u.Codigo=" + o.Codigo;

                Sqlcmd = new SqlCommand(consulta, SqlCn);

                SqlDataReader reader = Sqlcmd.ExecuteReader();
            
                List<int> resultado = new List<int>();
                while (reader.Read())
                {
                    resultado.Add(Convert.ToInt32(reader["IdPermiso"]));
                    prueba3 = (resultado.ToArray());

                }                           
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
            return prueba3;

        }

        public string Registrar_Roles(int[] idTipo_funcion)
        {
            string resp = "";
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                string consulta = "insert into USUARIO(Nombre_Completo,Observacion,Estado,Usuario,Contraseña)values('" + Nombre + "','" + Observacion + "','"+Estado+"','"+Usuario+"','"+Contraseña+ "');  select MAX(Codigo) from USUARIO;";

                Sqlcmd = new SqlCommand(consulta, SqlCn);                
                IDUSUARIO = Convert.ToInt32(Sqlcmd.ExecuteScalar().ToString());


                if (IDUSUARIO > 0)// si el id es mayor a 0 entonces se registro correctamente.
                {
                    D_Detalle_Permisos obj = new D_Detalle_Permisos();

                    foreach (int idServ in idTipo_funcion)
                    {

                        if (idServ > 0)
                        {

                            obj.ID_Usuario = IDUSUARIO;
                            obj.ID_Permiso = idServ;

                            resp = obj.Registrar_Funcion();

                            if (resp != "ok")
                                break;
                        }
                        else
                        {
                            break;
                        }

                    }

                }
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

        public DataTable MostrarTODO()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.Conexion_bd;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "USUARIOS_Mostrar";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;

        }
        public DataTable MostrarTODO_Tipo_roles(int a)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();
            try
            {
                SqlCn.ConnectionString = Conexion.Conexion_bd;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "Usuario_AsignacionPermiso";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@texto", a);


                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);
            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;


        }

        public string MODIFICAR_USUARIO_ASIGNACION_PERMISO(int[] IdPermiso_uSUARIO) {
            string resp = "";
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();
                string consulta_editar = " update USUARIO set Nombre_Completo='" + Nombre + "', Observacion='" + Observacion + "',Usuario='" + Usuario + "',Contraseña='" + Contraseña + "' where Codigo= " + Codigo;

                Sqlcmd = new SqlCommand(consulta_editar, SqlCn);
                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se puede ejecutar la consulta";

                if (Codigo > 0)
                {
                    D_Detalle_Permisos obj = new D_Detalle_Permisos();
                    foreach (int Idservi in IdPermiso_uSUARIO)
                    {
                        if (Idservi > 0)
                        {
                            obj.ID_Usuario = Codigo;
                            obj.ID_Permiso = Idservi;

                            resp = obj.Registrar_Funcion();
                            if (resp != "ok")                           
                                break;                                                       
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message + "Metodo que produjo el error: " + ex.TargetSite;
            }
            finally {
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();
            }
            return resp;
        }
        public string ELIMINAR_USUARIO_PERMISO()
        {
            string resp = "";
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                string consulta = "delete from AsigancionPermiso where IdUsuario=" + IDUSUARIO;

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

        public string Eliminar_Rol(D_Usuario rol)
        {
            string resp = "";
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "USUARIO_Eliminar";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@Codigo", rol.Codigo);

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
      

        public string CAMBIO_ESTADO_USUARIO(D_Usuario estado)
        {
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;

                sqlcmd.CommandText = "USUARIO_Cambio_Estado";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", estado.Codigo);
                sqlcmd.Parameters.AddWithValue("@Estado", estado.Estado);

                result = sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se cambio el estado";
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


        public DataTable BUSCAR_LISTA_USUARIO(string BUSCAR, string CBTIPOS, string CBESTADOS)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[USUARIOS_Buscar_Campo]";
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

        public DataTable BUSCAR_REPORTE_LISTA_USUARIO_CAJA2(string estado_lista, string cbtipo, string caja)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "[USUARIOS2_Reporte]";
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


        public DataTable BUSCAR_PRUEBA(string BUSCAR)
        {
            tableResultado = new DataTable();
            sqlconex = new SqlConnection();
            sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "SP_PREUBA";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@CODIGO", BUSCAR);                                
                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcmd);
                sqldata.Fill(tableResultado);
            }
            catch (Exception ex)
            {
                tableResultado = null;
            }
            return tableResultado;
        }


        public string REGISTRAR_USUARIO(D_Usuario lista)
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
                sqlcmd.CommandText = "[USUARIOS_Registrar]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", lista.Codigo);
                sqlcmd.Parameters.AddWithValue("@Nombre", lista.Nombre);
                sqlcmd.Parameters.AddWithValue("@Observacion", lista.Observacion);
                sqlcmd.Parameters.AddWithValue("@Estado", lista.Estado);               
                sqlcmd.Parameters.AddWithValue("@Contraseña", lista.Contraseña);
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

        public string REGISTRAR_USUARIO_Nuevo(D_Usuario lista)
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
                sqlcmd.CommandText = "[USUARIOS_Registrar]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", lista._CodigoUsuario);
                sqlcmd.Parameters.AddWithValue("@Nombre", lista.Nombre);
                sqlcmd.Parameters.AddWithValue("@Observacion", lista.Observacion);
                sqlcmd.Parameters.AddWithValue("@Estado", lista.Estado);
                sqlcmd.Parameters.AddWithValue("@Contraseña", lista.Contraseña);
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

        public string EDITAR_USUARIO(D_Usuario lista)
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
                sqlcmd.CommandText = "[USUARIOS_Editar]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", lista.Codigo);
                sqlcmd.Parameters.AddWithValue("@Nombre", lista.Nombre);
                sqlcmd.Parameters.AddWithValue("@Observacion", lista.Observacion);
                
                sqlcmd.Parameters.AddWithValue("@Usuario", lista.Usuario);
                sqlcmd.Parameters.AddWithValue("@Contraseña", lista.Contraseña);
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

        public DataTable Consultar_Id_USUARIO(D_Usuario ID)
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "USUARIO_ID";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@id";
                parid.SqlDbType = SqlDbType.Int;
                parid.Value = ID.Codigo;
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
