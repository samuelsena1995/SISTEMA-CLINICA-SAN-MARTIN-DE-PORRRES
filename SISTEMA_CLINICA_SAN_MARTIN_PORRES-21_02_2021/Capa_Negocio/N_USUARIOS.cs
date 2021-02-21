using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Capa_Negocio
{
   public class N_USUARIOS
    {
        public static string Encriptar2(string texto)
        {
            try
            {

                string key = "qualityinfosolutions"; //llave para encriptar datos

                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }

        public static string Encriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);

            return resultado;
        }
       public static string Desencriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] desencriptar = Convert.FromBase64String(cadena);
            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);

            return resultado;
        }
        public static string Desencriptar2(string textoEncriptado)
        {
            try
            {
                string key = "qualityinfosolutions";
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return textoEncriptado;
        }


        public static string registrar_usuario_nuevo(string codi, string Nombre_rol, string obser, string estado, string contrase,string usuario)
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.CodigoUsuario = codi;
            obj.Nombre = Nombre_rol;
            obj.Observacion = obser;
            obj.Estado = estado;
            obj.Contraseña = contrase;
            obj.Usuario = usuario;
            return obj.REGISTRAR_USUARIO_Nuevo(obj);
        }
        public static string MODIFICAR_USUARIO(string codigo, string nombre, string obser, string contra,string usuario)
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.Nombre = nombre;
            obj.Observacion = obser;            
            obj.Contraseña = contra;
            obj.CodigoUsuario = codigo;
            obj.Usuario = usuario;
            return obj.EDITAR_USUARIO(obj);
        }
        public static DataTable Consultar_ID(string codigo) {///para mostrar los permisos en la tabla permisos
            D_USUARIOS o = new D_USUARIOS();
            o.CodigoUsuario = codigo;
            return o.Consultar_Id_USUARIO(o);
            
        }
        public static DataTable MOSTRAR_PERMISOS_HABILITADOS(string codigo)//mostrar en la pantalla principal los permisos de ese usuario
        {
            D_USUARIOS o = new D_USUARIOS();
            o.CodigoUsuario = codigo;
            return o.MOSTRAR_PERMISOS_HABILITADOS(o);
        }
        public static DataTable MostrarRol()
        {
            return new D_USUARIOS().MostrarTODO();
        }
        public static DataTable MOSTRARPERMISOS()
        {
            return new D_USUARIOS().MOSTRARPERMISOS();
        }
        public static DataTable INICIO_SESION_NUEVO(string usuario, string password)
        {
            D_USUARIOS obj = new D_USUARIOS();

            obj.Usuario = usuario;
            obj.Contraseña = password;

            return obj.INICIO_SESION(obj);
        }

       
        public static string registrar_PERMISO(string idusuario, string idpermiso,string etado)
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.CodigoUsuario = idusuario;
            obj._IDPermiso = idpermiso;
            obj.Estado = etado;
            return obj.REGISTRAR_ASIGNACIONPERMISOS(obj);
        }
        public static string ELIMINAR_ASIGNACION_PERMISO_IDUSUARIO(string idusuario)//eliminar la asignacion de permisos por el usuario
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.CodigoUsuario = idusuario;       
            return obj.ELIMINAR_ASIGNACION_PERMISO_IDUSUARIO(obj);
        }
        public static string Cambio_Estado_USUARIOS(string codigo, string estado)
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.CodigoUsuario = codigo;
            obj.Estado = estado;
            return obj.CAMBIO_ESTADO_USUARIOS(obj);
        }
        public static DataTable Buscar_campo_usuarios(string bus, string cbti, string cbest)
        {
            return new D_USUARIOS().BUSCAR_LISTA_USUARIO(bus, cbti, cbest);
        }
        public static string Elimnar_USUARIOS(string cod_rol)
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.CodigoUsuario = cod_rol;
            return obj.Eliminar_USUARIO(obj);
        }       
        /*public static DataTable ID_PERMISOS_ASIGNACION_BOTONES(string COD_USUARIO_ASIGNACIONPERMISO, string COD_PERMISO_) {
            D_USUARIOS o = new D_USUARIOS();
            o._CodigoUsuario = COD_USUARIO_ASIGNACIONPERMISO;
            o._IDPermiso = COD_PERMISO_;
            return o.Id_PERMISO_BOTONES(o);
        }*/

  
        public static DataTable MOSTRAR_Id_Permiso_Pantalla_principal(string codi) {
            D_USUARIOS o = new D_USUARIOS();
            o.CodigoUsuario = codi;            
            return o.MOSTRAR_Id_Permiso_Pantalla_principal(o);
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="idusuario"></param>
        /// <param name="idpermiso"></param>
        /// <param name="etado"></param>
        //COPIAR ASIGNACION DE PERMISOS A OTRO USUARIO NUEVO
        /// <returns></returns>
        public static string COPIAR_ASIGNACIONPERMISO_NUEVO_USUARIO(string idusuario_nuevo, string idcopia_usuario)
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.CodigoUsuario = idusuario_nuevo;
            obj._Cod_CopiaUsuario = idcopia_usuario;
            return obj.COPIAR_ASIGNACIONPERMISO_NUEVO_USUARIO(obj);
        }
        ///para pasar el contraseña desencriptada a un label
        public void pas_word(string usuario, string password, Label dato)
        {
            D_USUARIOS obj = new D_USUARIOS();
            obj.Usuario = usuario;
            obj.Contraseña = password;//CifrarCadena(password);
            obj.pasword(obj, dato);
        }
        ///mosttrar menu en treeview
        /*public  void cargarOpcionesUsuario(string idUsuario,string   codigo, TreeView tvw)
        {
            string grupo = "", modulo = "";

            TreeNode nodoG = new TreeNode();
            TreeNode nodoM = new TreeNode();
            

            D_USUARIOS user = new D_USUARIOS();
            DataTable dtt = user.leerOpciones();

            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                DataRow filaM = dtt.Rows[i];
                

                if (modulo != filaM[0].ToString())
                {
                    grupo = filaM[0].ToString();
                    nodoG = new TreeNode(grupo, filaM[1].ToString());

                    modulo = filaM[0].ToString();
                    nodoM = new TreeNode(modulo, filaM[0].ToString());

                    nodoG.ChildNodes.Add(new TreeNode();
                    nodoM.ChildNodes.Add(nodoG);
                    tvw.Nodes.Add(nodoM);
                }
                else
                {
                    if (grupo != filaM[3].ToString())
                    {
                        grupo = filaM[3].ToString();
                        nodoG = new TreeNode(grupo, filaM[2].ToString());
                        nodoM.ChildNodes.Add(nodoG);
                    }
                   nodoG.ChildNodes.Add(new TreeNode(filaM[5].ToString(), filaM[4].ToString(), "", filaM[6].ToString(), "_self"));
                }
            }
            dtt.Dispose();
            dtt = null;
        }*/

        public static string EditaR_Audi(string codigo, string ip1, string nombre)
        {
            D_USUARIOS trabajador = new D_USUARIOS();

            trabajador.Nombre = nombre;
            trabajador.IP = ip1;
            trabajador.CodigoUsuario = codigo;


            return trabajador.Editar_AUDITORIA(trabajador);
        }
    }
    ///
}
