using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos;
namespace Capa_Negocio
{
  public class N_Lista_estudio_por_imagen
    {
        public static DataTable Listar_Todo()
        {
            //return new D_Lista_analisis_laboratorio().Listar();
            return new Capa_Datos.D_Lista_estudio_por_imagen().Listar();
        }
        public static string Insertar(string nombre, string descripcio, string estad)
        {
            D_Lista_estudio_por_imagen lista = new D_Lista_estudio_por_imagen();
            lista._Nombre = nombre;
            lista._Descripcion = descripcio;
            lista._Estado = estad;
            return lista.REGISTRAR_LISTA_ESTUDIO_POR_IMAGEN(lista);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_Lista_estudio_por_imagen obj = new D_Lista_estudio_por_imagen();
            obj._Codigo = codigo;
            return obj.Consultar_Id_lista_analisis(obj);
        }
        public static string Editar(int codigo, string nombre, string descipcion)
        {

            D_Lista_estudio_por_imagen edita = new D_Lista_estudio_por_imagen();
            edita._Codigo = codigo;
            edita._Nombre = nombre;
            edita._Descripcion = descipcion;

            return edita.EDITAR_LISTA_LABORATORIO(edita);

        }
        public static string Eliminar(int codigo)
        {
            D_Lista_estudio_por_imagen elim = new D_Lista_estudio_por_imagen();
            elim._Codigo = codigo;
            return elim.ELIMINAR_LISTA_LABORATORIO(elim);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_Lista_estudio_por_imagen obj = new D_Lista_estudio_por_imagen();
            obj._Codigo = codigo;
            obj._Estado = estado;
            return obj.CAMBIO_ESTADO_LISTA_LABORATORIO(obj);
        }

        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_Lista_estudio_por_imagen().BUSCAR_LISTA_LABORATORIO(bus, cbti, cbest);
        }       

        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_Lista_estudio_por_imagen().BUSCAR_REPORTE_LISTA_LABORATORIO_CAJA2(estado, cbtipo, cajas);
        }
    }
}
