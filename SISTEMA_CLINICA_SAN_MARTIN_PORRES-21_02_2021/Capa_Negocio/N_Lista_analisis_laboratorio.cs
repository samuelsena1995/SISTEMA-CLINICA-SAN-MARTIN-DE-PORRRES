using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
namespace Capa_Negocio
{
    public class N_Lista_analisis_laboratorio
    {
        public static DataTable Listar_Todo() {
            return new D_Lista_analisis_laboratorio().Listar();
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_Lista_analisis_laboratorio obj = new D_Lista_analisis_laboratorio();
            obj.CODIGO = codigo;
            return obj.Consultar_Id_lista_analisis(obj);
        }
        public static string Insertar(string nombre, string descripcio, string estad)
        {
            D_Lista_analisis_laboratorio lista = new D_Lista_analisis_laboratorio();
            lista.NOMBRE_CORTO = nombre;
            lista.DESCRIPCION = descripcio;
            lista.ESTADO = estad;
            return lista.REGISTRAR_LISTA_LABORATORIO(lista);
        }
        public static string Editar(int codigo, string nombre, string descipcion) {

            D_Lista_analisis_laboratorio edita = new D_Lista_analisis_laboratorio();
            edita.CODIGO = codigo;
            edita.NOMBRE_CORTO = nombre;
            edita.DESCRIPCION = descipcion;

            return edita.EDITAR_LISTA_LABORATORIO(edita);

        }
        public static string Eliminar(int codigo) {
            D_Lista_analisis_laboratorio elim = new D_Lista_analisis_laboratorio();
            elim.CODIGO = codigo;
            return elim.ELIMINAR_LISTA_LABORATORIO(elim);
        }
        public static string Cambio_Estado(int codigo, string estado) {
            D_Lista_analisis_laboratorio obj = new D_Lista_analisis_laboratorio();
            obj.CODIGO = codigo;
            obj.ESTADO = estado;
            return obj.CAMBIO_ESTADO_LISTA_LABORATORIO(obj);
        }

        public static DataTable Buscar_campo(string bus, string cbti, string cbest) {
            return new D_Lista_analisis_laboratorio().BUSCAR_LISTA_LABORATORIO(bus,cbti,cbest);
        }

        public static DataTable Buscar_Reporte_(string estado) {
            return new D_Lista_analisis_laboratorio().BUSCAR_REPORTE_LISTA_LABORATORIO(estado);
        }
        public static DataTable Buscar_Reporte_Buscar(string estado,string cajas)
        {
            return new D_Lista_analisis_laboratorio().BUSCAR_REPORTE_LISTA_LABORATORIO_CAJA(estado,cajas);
        }
        public static DataTable Buscar_Reporte_Buscar2(string estado,string cbtipo, string cajas)
        {
            return new D_Lista_analisis_laboratorio().BUSCAR_REPORTE_LISTA_LABORATORIO_CAJA2(estado,cbtipo, cajas);
        }
    }
}
