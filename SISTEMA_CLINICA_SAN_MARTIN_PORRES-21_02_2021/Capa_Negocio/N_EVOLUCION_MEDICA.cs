using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
namespace Capa_Negocio
{
   public class N_EVOLUCION_MEDICA
    {
        public static DataTable MOSTRAR() {
           return new D_EVOLUCION_MEDICA().Listar();
        }
        public static string REGISTRAR( int cod_int, int cod_usu, int codi_medic, string descrip, string esta) {
            D_EVOLUCION_MEDICA o = new D_EVOLUCION_MEDICA();
            
            o._Codigo_Internacion = cod_int;
            o._Codigo_Usuario = cod_usu;
            o._Codigo_Medico = codi_medic;
            o._Descripcion = descrip;
            o._Estado = esta;
            return o.REGISTRAR_MEDICO(o);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_EVOLUCION_MEDICA obj = new D_EVOLUCION_MEDICA();
            obj._Codigo = codigo;
            return obj.Consultar_EVOLUCION(obj);
        }
        public static string Editar(int codi, int codinterna, int codusuario, int codmedico, string descripci) {
            D_EVOLUCION_MEDICA o = new D_EVOLUCION_MEDICA();
            o._Codigo = codi;
            o._Codigo_Internacion = codinterna;
            o._Codigo_Usuario = codusuario;
            o._Codigo_Medico = codmedico;
            o._Descripcion = descripci;
            return o.EDITAR(o);
        }
        public static string Estado(int codi, string estado)
        {
            D_EVOLUCION_MEDICA o = new D_EVOLUCION_MEDICA();
            o._Codigo = codi;
         
            o._Estado = estado;
            return o.CAMBIAR_eSTADO(o);
        }
    }
}
