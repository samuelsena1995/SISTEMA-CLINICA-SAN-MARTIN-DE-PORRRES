using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Capa_Datos
{
   public class D_USUARIOS
    {
        private string cod_capia_usuario_copia;

        public string _Cod_CopiaUsuario
        {
            get { return cod_capia_usuario_copia; }
            set { cod_capia_usuario_copia = value; }
        }

        //private string codigousuariosas_copia;

        //public string Cod_copia
        //{
        //    get { return codigousuariosas_copia; }
        //    set { codigousuariosas_copia = value; }
        //}

          
        private string Idpermiso;

        public string _IDPermiso
        {
            get { return Idpermiso; }
            set { Idpermiso = value; }
        }

        SqlCommand sqlcmd;
        SqlConnection sqlconex;
        SqlTransaction sqltrans;
        DataTable tableResultado;
        public string result = "";
        #region variables
        private string _codigo_Usu;

        private string ip;

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }


        public string CodigoUsuario
        {
            get { return _codigo_Usu; }
            set { _codigo_Usu = value; }
        }

        private string resp = "";       
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
    
     
       

        #endregion

        public DataTable MostrarTODO()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.Conexion_bd;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "[USUARIOS_Mostrar]";
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
        public string REGISTRAR_USUARIO_Nuevo(D_USUARIOS lista)
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

                sqlcmd.Parameters.AddWithValue("@Codigo", lista.CodigoUsuario);
                sqlcmd.Parameters.AddWithValue("@Nombre", lista.Nombre);
                sqlcmd.Parameters.AddWithValue("@Observacion", lista.Observacion);
                sqlcmd.Parameters.AddWithValue("@Estado", lista.Estado);
                sqlcmd.Parameters.AddWithValue("@Contraseña", lista.Contraseña);
                sqlcmd.Parameters.AddWithValue("@Usuario", lista.Usuario);
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
        public string EDITAR_USUARIO(D_USUARIOS lista)
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

                sqlcmd.Parameters.AddWithValue("@Codigo", lista.CodigoUsuario);
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
        public DataTable Consultar_Id_USUARIO(D_USUARIOS ID)//mostrar en la tabla permisos de los usuario
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
                parid.SqlDbType = SqlDbType.Char;
                parid.Value = ID.CodigoUsuario;
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
        public DataTable MOSTRARPERMISOS()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.Conexion_bd;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SP_MOSTRAR_PERMISOS";
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
        public DataTable INICIO_SESION(D_USUARIOS usuario)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            try
            {
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SP_INICIO_SESION";
                Sqlcmd.CommandType = CommandType.StoredProcedure;            
                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@Codigo";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = usuario.Usuario;
                Sqlcmd.Parameters.Add(ParUsuario);

                SqlParameter ParContra = new SqlParameter();
                ParContra.ParameterName = "@Contraseña";
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
      
        public string REGISTRAR_ASIGNACIONPERMISOS(D_USUARIOS lista)
        {
            try
            {
                SqlTransaction sqltrans;
                sqlconex = new SqlConnection();
                sqlcmd = new SqlCommand();
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqltrans = sqlconex.BeginTransaction();

                sqlcmd.Connection = sqlconex;
                sqlcmd.Transaction = sqltrans;
                sqlcmd.CommandText = "REGISTRAR_ASIGANCION";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@IdUsuario", lista.CodigoUsuario);
                sqlcmd.Parameters.AddWithValue("@IdPermiso", lista._IDPermiso);
                sqlcmd.Parameters.AddWithValue("@Estado", lista.Estado);
                
                
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
        public DataTable MOSTRAR_PERMISOS_HABILITADOS(D_USUARIOS ID)//pantalla principal mostrar los permisos de ese usuairo
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                //sqlcmd.CommandText = "MOSTRAR_PERMISOS_ID";
                sqlcmd.CommandText = "[MOSTRAR_PERMISOS_HABILITADOS]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@Codigo_Usuario";
                parid.SqlDbType = SqlDbType.Char;
                parid.Value = ID.CodigoUsuario;
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

        public string ELIMINAR_ASIGNACION_PERMISO_IDUSUARIO(D_USUARIOS lista)//eliminar el permiso que tiene al usuario
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
                sqlcmd.CommandText = "ELIMINAR_ASIGNACION_PERMISO";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Id_Usuario", lista.CodigoUsuario);
             
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

        public string CAMBIO_ESTADO_USUARIOS(D_USUARIOS estado)
        {
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlconex.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;

                sqlcmd.CommandText = "[USUARIOS_Cambio_Estado]";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Codigo", estado.CodigoUsuario);
                sqlcmd.Parameters.AddWithValue("@Estado", estado.Estado);

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
        public string Eliminar_USUARIO(D_USUARIOS rol)//eliminar solo el usuario 
        {
            string resp = "";
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "[USUARIOS_Eliminar]";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@Codigo", rol.CodigoUsuario);

                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se puede eliminar el rol";
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
   
      
        ////    verifica si tiene alguna aignacion de permisos

        /*public DataTable Id_PERMISO_BOTONES(D_USUARIOS ID)
        {
            DataTable Dtresultado = new DataTable();
            sqlconex = new SqlConnection();
            try
            {
                sqlconex.ConnectionString = Conexion.Conexion_bd;
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconex;
                //sqlcmd.CommandText = "MOSTRAR_PERMISOS_ID";
                sqlcmd.CommandText = "SP_BOTONES";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@CODIGO_USUARIO_ASIGNACION";
                parid.SqlDbType = SqlDbType.Char;
                parid.Value = ID._CodigoUsuario;
                sqlcmd.Parameters.Add(parid);

                SqlParameter parid_permiso = new SqlParameter();
                parid_permiso.ParameterName = "@CODIGO_PERMISO";
                parid_permiso.SqlDbType = SqlDbType.Char;
                parid_permiso.Value = ID._IDPermiso;
                sqlcmd.Parameters.Add(parid_permiso);

                SqlDataAdapter sqldate = new SqlDataAdapter(sqlcmd);
                sqldate.Fill(Dtresultado);
            }
            catch (Exception)
            {
                Dtresultado = null;
            }
            return Dtresultado;
        }*/


        public DataTable MOSTRAR_Id_Permiso_Pantalla_principal(D_USUARIOS ID)///mostrar en la datagridview los permisos que tiene ese usuario
       {
           DataTable Dtresultado = new DataTable();
           sqlconex = new SqlConnection();
           try
           {
               sqlconex.ConnectionString = Conexion.Conexion_bd;
               sqlcmd = new SqlCommand();
               sqlcmd.Connection = sqlconex;
               //sqlcmd.CommandText = "MOSTRAR_PERMISOS_ID";
               sqlcmd.CommandText = "MOSTRAR_Id_Permiso_Pantalla_principal";
               sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Id_Usuario", ID.CodigoUsuario);

               SqlDataAdapter sqldate = new SqlDataAdapter(sqlcmd);
               sqldate.Fill(Dtresultado);
           }
           catch (Exception)
           {
               Dtresultado = null;
           }
           return Dtresultado;
       }
        ////pasar valores de una permisos a un nuevo usuairo
        public string COPIAR_ASIGNACIONPERMISO_NUEVO_USUARIO(D_USUARIOS o)
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
                sqlcmd.CommandText = "SP_COPIAR_PERMISOS";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Cod_Usuario_COPIA", o._Cod_CopiaUsuario );
                sqlcmd.Parameters.AddWithValue("@Cod_Nuevo_Usuario", o.CodigoUsuario);
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


        ///para pasar la contraseña en un label y desencriptar
        public void pasword(D_USUARIOS trabajador, Label cargo)
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


                Sqlcmd.Parameters.AddWithValue("@usuario", trabajador.CodigoUsuario);
                Sqlcmd.Parameters.AddWithValue("@password", trabajador.Contraseña);

                SqlDataAdapter Sqldat = new SqlDataAdapter(Sqlcmd);
                Sqldat.Fill(tablaResultados);

                //  string cargo;
                //foreach (DataRow dr in tablaResultados.Rows)
                //{

                //    TreeNode nod = new TreeNode(dr["password"].ToString());
                //    cargo.Text = nod.Text;
                //}


            }
            catch (Exception ex)
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

        }


        //////mostrar menu en treeview
        public DataTable leerOpciones()
        {
            SqlConnection cnn = new SqlConnection(Conexion.Conexion_bd);
            SqlCommand cmd = new SqlCommand("SP_MENU_TREEVIEW", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Codigo", SqlDbType.Char).Value = CodigoUsuario;
            cmd.Parameters.Add("@Contraseña", SqlDbType.Char).Value = Contraseña;

            cnn.Open();
            DataTable dtt = new DataTable();
            dtt.Load(cmd.ExecuteReader(), LoadOption.OverwriteChanges);
            cnn.Close();

            return dtt;
        }


        /////audtoria

        public string Editar_AUDITORIA(D_USUARIOS trabajador)
        {

            try
            {
                SqlCn = new SqlConnection();
                Sqlcmd = new SqlCommand();

                SqlCn.ConnectionString = Conexion.Conexion_bd;
                SqlCn.Open();

                Sqltra = SqlCn.BeginTransaction();

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.CommandText = "sp_Auditoria_Editar";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@Codigo_Usuario", trabajador.CodigoUsuario);
                Sqlcmd.Parameters.AddWithValue("@IP", trabajador.IP);
                Sqlcmd.Parameters.AddWithValue("@Nombre_Usuario", trabajador.Nombre);

                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo Editar";


                if (resp.Equals("ok"))
                {
                    Sqltra.Commit();
                }
                else
                {
                    Sqltra.Rollback();
                }
            }

            catch (Exception ex)
            {
                resp = ex.Message;

            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();
            }
            return resp;
        }
    }
}

