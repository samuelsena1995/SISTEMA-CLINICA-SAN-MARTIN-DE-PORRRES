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
  public class N_Sala
    {
        public static DataTable Listar_Todo()
        {
            //return new D_Lista_analisis_laboratorio().Listar();
            return new D_Sala().Listar();
        }
        public static DataTable Listar_No_Asignados()
        {
            //return new D_Lista_analisis_laboratorio().Listar();
            return new D_Sala().Listar_No_Asignados();
        }
        public static string Insertar(string nombre, string descripcio, string estad,int codiTipo)
        {
            D_Sala lista = new D_Sala();
            lista._Nombre = nombre;
            lista._Descripcion = descripcio;
            lista._Estado = estad;
            lista._CODIGOTIPOSALA = codiTipo;
            return lista.REGISTRAR_SALA(lista);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_Sala obj = new D_Sala();
            obj._Codigo = codigo;
            return obj.Consultar_Id_Tipos(obj);
        }
        public static string Editar(int codigo, string nombre, string descipcion,int codiTipo)
        {

            D_Sala edita = new D_Sala();
            edita._Codigo = codigo;
            edita._Nombre = nombre;
            edita._Descripcion = descipcion;
            edita._CODIGOTIPOSALA = codiTipo;
                    
            return edita.EDITAR_SALA(edita);

        }
        public static string Eliminar(int codigo)
        {
            D_Sala elim = new D_Sala();
            elim._Codigo = codigo;
            return elim.ELIMINAR_SALA(elim);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_Sala obj = new D_Sala();
            obj._Codigo = codigo;
            obj._Estado = estado;
            return obj.CAMBIO_ESTADO_TIPOS_SALA(obj);
        }

        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_Sala().BUSCAR_LISTA_SALA(bus, cbti, cbest);
        }       

        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_Sala().BUSCAR_REPORTE_LISTA_SALA_CAJA2(estado, cbtipo, cajas);
        }
    }
}
