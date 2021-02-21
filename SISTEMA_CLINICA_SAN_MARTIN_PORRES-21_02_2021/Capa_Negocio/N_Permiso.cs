using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Negocio
{
  public  class N_Permiso
    {
        public static DataTable Consultar_codigo(int codigo)
        {
            D_Usuario obj = new D_Usuario();
            obj.Codigo = codigo;
            return obj.Consultar_Id_USUARIO(obj);
        }
        public static string registrar(string Nombre_rol,string obser, string estado,string usuario,string contrase, int[] idFunci)
        {
            D_Usuario obj = new D_Usuario();
            obj.Nombre = Nombre_rol;
            obj.Observacion = obser;
            obj.Estado = estado;
            obj.Usuario = usuario;
            obj.Contraseña = contrase;

            return obj.Registrar_Roles(idFunci);
        }
        public static string registrar_usuario(string Nombre_rol, string obser, string estado, string contrase)
        {
            D_Usuario obj = new D_Usuario();
           
            obj.Nombre = Nombre_rol;
            obj.Observacion = obser;
            obj.Estado = estado;            
            obj.Contraseña = contrase;

            return obj.REGISTRAR_USUARIO(obj);
        }
        public static string registrar_usuario_nuevo(string codi,string Nombre_rol, string obser, string estado, string contrase)
        {
            D_Usuario obj = new D_Usuario();
            obj._CodigoUsuario = codi;
            obj.Nombre = Nombre_rol;
            obj.Observacion = obser;
            obj.Estado = estado;
            obj.Contraseña = contrase;

            return obj.REGISTRAR_USUARIO_Nuevo(obj);
        }
        public static string MODIFICAR_USUARIO(int codigo, string nombre, string obser, string usua, string contra)
        {
            D_Usuario obj = new D_Usuario();
            obj.Nombre = nombre;
            obj.Observacion = obser;
            obj.Usuario = usua;
            obj.Contraseña = contra;
            obj.Codigo = codigo;

            return obj.EDITAR_USUARIO(obj);
        }
        public static DataTable MostrarRol()
        {
            return new D_Usuario().MostrarTODO();
        }
        public static DataTable MostrarTodo_funciones(int a)
        {
            return new D_Usuario().MostrarTODO_Tipo_roles(a);
        }
        public static string MODIFICAR(int codigo, string nombre, string obser, string usua, string contra, int[] idPermiso)
        {
            D_Usuario obj = new D_Usuario();
            obj.Nombre = nombre;
            obj.Observacion = obser;
            obj.Usuario = usua;
            obj.Contraseña = contra;
            obj.Codigo = codigo;

            return obj.MODIFICAR_USUARIO_ASIGNACION_PERMISO(idPermiso);
        }
        public static string ELIMINAR(int id)
        {
            D_Usuario obj = new D_Usuario();
            obj.IDUSUARIO = id;

            return obj.ELIMINAR_USUARIO_PERMISO();
        }
        public static string ELIMINAR_IDPERMISO(int codigoPermiso) {
            D_Detalle_Permisos o = new D_Detalle_Permisos();
            o.ID_Permiso = codigoPermiso;
            return o.Eliminar_ASIGNACION(o);
        }
        public static string Elimnar_USUARIO(int cod_rol)
        {
            D_Usuario obj = new D_Usuario();
            obj.Codigo = cod_rol;
            return obj.Eliminar_Rol(obj);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_Usuario obj = new D_Usuario();
            obj.Codigo = codigo;
            obj.Estado = estado;
            return obj.CAMBIO_ESTADO_USUARIO(obj);
        }
        public static DataTable Login(string usuario, string password)
        {
            D_Usuario obj = new D_Usuario();

            obj.Usuario = usuario;
            obj.Contraseña = password;

            return obj.Login(obj);
        }
        public static int[] login_funcion(int IDRol)
        {
            D_Usuario obj = new D_Usuario();

            obj.Codigo = IDRol;

            return obj.Privilegios_Botones(obj);
        }
        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_Usuario().BUSCAR_LISTA_USUARIO(bus, cbti, cbest);
        }
        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_Usuario().BUSCAR_REPORTE_LISTA_USUARIO_CAJA2(estado, cbtipo, cajas);
        }

        public static DataTable Buscar_PRUEBA(string bus)
        {
            return new D_Usuario().BUSCAR_PRUEBA(bus);
        }
    }
}
