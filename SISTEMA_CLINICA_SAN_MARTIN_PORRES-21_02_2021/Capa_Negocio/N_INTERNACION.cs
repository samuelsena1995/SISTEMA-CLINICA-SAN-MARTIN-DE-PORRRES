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
   public class N_INTERNACION
    {
        public static DataTable Listar_Todo()
        {
            return new D_INTERNACION().Listar();
        }
        public static string REGISTRAR(DateTime fecha, int codiMedi, int codigofun, int codiPacie, string descripcion, string estado) {
            D_INTERNACION i = new D_INTERNACION();
            i._Fecha = fecha;
            i._CodigoMedico = codiMedi;
            i._CodigoFuncionario = codigofun;
            i._CodigoPaciente = codiPacie;
            i._Descripcion = descripcion;
            i._Estado = estado;
            return i.REGISTRAR_INTERNACION(i);
        }
        public static string EDITAR(int codigo,DateTime fecha, int codiMedi, int codigofun, int codiPacie, string descripcion)
        {
            D_INTERNACION i = new D_INTERNACION();
            i._Codigo = codigo;
            i._Fecha = fecha;
            i._CodigoMedico = codiMedi;
            i._CodigoFuncionario = codigofun;
            i._CodigoPaciente = codiPacie;
            i._Descripcion = descripcion;            
            return i.EDITAR_INTERNACION(i);
        }
        public static string CAMBIAR_ESTADO(int codi, string estado) {
            D_INTERNACION o = new D_INTERNACION();
            o._Codigo = codi;
            o._Estado = estado;
            return o.CAMBIO_ESTADO_INTERNACION(o);
        }
        public static DataTable Consultar_Id_Internacion(int codi) {
            D_INTERNACION o = new D_INTERNACION();
            o._Codigo = codi;
            return o.Consultar_Id_Internacion(o);
        }
        public static bool ExisteAsignacionSala(int sala) {
            //return Capa_Negocio.N_INTERNACION.ExisteAsignacionSala(sala);  
            D_INTERNACION o = new D_INTERNACION();
            o._Codigo = sala;
            return o.Exists_AsignacionSala(o);
        }
    }
}
