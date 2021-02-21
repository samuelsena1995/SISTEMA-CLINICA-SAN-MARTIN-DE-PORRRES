using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_Negocio
{
   public class N_ASIGNACION_SALA
    {
        public static string REGISTRAR(DateTime fecha, int codiSala, int codiInternacion, string estado) {
            D_ASIGNACION_SALA D = new D_ASIGNACION_SALA();
            D._Fecha = fecha;
            D._CodigoSala = codiSala;
            D._CodigoInternacion = codiInternacion;
            D._Estado = estado;
            return D.REGISTRAR_ASIGNACION_SALA(D);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_ASIGNACION_SALA obj = new D_ASIGNACION_SALA();
            obj._Codigo = codigo;
            return obj.Consultar_Asignacion_Sala(obj);
        }
        public static DataTable MOSTRAR_ASIGNACION_SALA() {
            return new Capa_Datos.D_ASIGNACION_SALA().Listar_ASIGNACION_SALA();
        }
        public static string ANULAR_SALA(int codig, string anul)
        {
            D_ASIGNACION_SALA h = new D_ASIGNACION_SALA();
            h._Codigo = codig;
            h._Estado = anul;
            return h.ANULAR_ASIGNACION_SALA(h);
        }
        ////modulo reporte de control
        public static DataTable Buscar_Reporte_ASIGNACION_SALA(DateTime cajas)
        {
            return new D_ASIGNACION_SALA().BUSCAR_REPORTE_LISTA_ASIGNACION_SALA(cajas);
        }
        public static DataTable CONSULTAR(int codiInternacion) {
            D_ASIGNACION_SALA a = new D_ASIGNACION_SALA();
          //  a._Codigo = codigoAsigna;
            a._CodigoInternacion = codiInternacion;
            return a.CONSULTAR(a);
        }
    }
}
