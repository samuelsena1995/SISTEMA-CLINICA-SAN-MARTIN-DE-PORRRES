using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_Negocio
{
   public class N_Medico
    {
        public static DataTable Listar_Todo()
        {
            //return new D_Lista_analisis_laboratorio().Listar();
            return new D_Medico().Listar();
        }
        public static string Insertar(string nombre,string ocupa,string numerocle, string observac, string estad)
        {
            D_Medico lista = new D_Medico();
            lista._Nombre = nombre;
            lista._Ocupacion = ocupa;
            lista._NumeroCelular = numerocle;
            lista._Observacion = observac;
            lista._Estado = estad;
            return lista.REGISTRAR_MEDICO(lista);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_Medico obj = new D_Medico();
            obj._Codigo = codigo;
            return obj.Consultar_Medico_ID(obj);
        }
        public static string Editar(int codigo, string nombre,string ocuapa,string numecel, string obse)
        {

            D_Medico edita = new D_Medico();
            edita._Codigo = codigo;
            edita._Nombre = nombre;
            edita._Ocupacion = ocuapa;
            edita._NumeroCelular = numecel;
            edita._Observacion = obse;

            return edita.EDITAR_MEDICO(edita);

        }
        public static string Eliminar(int codigo)
        {
            D_Medico elim = new D_Medico();
            elim._Codigo = codigo;
            return elim.ELIMINAR_MEDICO(elim);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_Medico obj = new D_Medico();
            obj._Codigo = codigo;
            obj._Estado = estado;
            return obj.CAMBIO_ESTADO_MEDICO(obj);
        }

        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_Medico().BUSCAR_LISTA_MEDICO(bus, cbti, cbest);
        }

        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_Medico().BUSCAR_REPORTE_LISTA_MEDICO(estado, cbtipo, cajas);
        }
    }
}
