using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
namespace Capa_Negocio
{
    public class N_ESTUDIO_LABORATORIO
    {
        public static DataTable Listar_Todo()
        {
            return new D_ESTUDIO_LABORATORIO().Listar();
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_ESTUDIO_LABORATORIO obj = new D_ESTUDIO_LABORATORIO();
            obj.CODIGO = codigo;
            return obj.Consultar_Id_Estudio_Laboratorio(obj);
        }
        public static string Insertar(string nombre, string descripcio, string estad, int codigoevolucion)
        {
            D_ESTUDIO_LABORATORIO lista = new D_ESTUDIO_LABORATORIO();
            //lista.CODIGO = codigo;
            lista.NOMBRE_CORTO = nombre;
            lista.DESCRIPCION = descripcio;
            lista.ESTADO = estad;
            
            lista.CODIGO_EVOLUCION_MEDICA = codigoevolucion;
            return lista.REGISTRAR_ESTUDIO_LABORATORIO(lista);
        }
        public static string Editar(int codigo, string nombre, string descipcion)
        {

            D_ESTUDIO_LABORATORIO edita = new D_ESTUDIO_LABORATORIO();
            edita.CODIGO = codigo;
            edita.NOMBRE_CORTO = nombre;
            edita.DESCRIPCION = descipcion;

            return edita.EDITAR_LISTA_LABORATORIO(edita);

        }
        public static string Eliminar(int codigo)
        {
            D_ESTUDIO_LABORATORIO elim = new D_ESTUDIO_LABORATORIO();
            elim.CODIGO = codigo;
            return elim.ELIMINAR_LISTA_LABORATORIO(elim);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_ESTUDIO_LABORATORIO obj = new D_ESTUDIO_LABORATORIO();
            obj.CODIGO = codigo;
            obj.ESTADO = estado;
            return obj.CAMBIO_ESTADO_LISTA_LABORATORIO(obj);
        }
        public static string Anular(int codigo, string estado)
        {
            D_ESTUDIO_LABORATORIO obj = new D_ESTUDIO_LABORATORIO();
            obj.CODIGO = codigo;
            obj.ESTADO = estado;
            return obj.ANULAR_ESTUDIO_LABORATORIO(obj);
        }
        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_ESTUDIO_LABORATORIO().BUSCAR_LISTA_LABORATORIO(bus, cbti, cbest);
        }

        public static DataTable Buscar_Reporte_(string estado)
        {
            return new D_ESTUDIO_LABORATORIO().BUSCAR_REPORTE_LISTA_LABORATORIO(estado);
        }
        public static DataTable Buscar_Reporte_Buscar(string estado, string cajas)
        {
            return new D_ESTUDIO_LABORATORIO().BUSCAR_REPORTE_LISTA_LABORATORIO_CAJA(estado, cajas);
        }
        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_ESTUDIO_LABORATORIO().BUSCAR_REPORTE_LISTA_LABORATORIO_CAJA2(estado, cbtipo, cajas);
        }
    }
}
