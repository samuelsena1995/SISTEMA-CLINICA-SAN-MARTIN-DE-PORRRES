using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_Negocio
{
   public class N_Funcionario
    {
        public static DataTable Listar_Todo()
        {
            //return new D_Lista_analisis_laboratorio().Listar();
            return new D_Funcionario().Listar();
        }
        public static string Insertar(string nombre,string ocupa,string numerocle, string observac, string estad)
        {
            D_Funcionario lista = new D_Funcionario();
            lista._Nombre = nombre;
            lista._Ocupacion = ocupa;
            lista._NumeroCelular = numerocle;
            lista._Observacion = observac;
            lista._Estado = estad;
            return lista.REGISTRAR_FUNCIONARIO(lista);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_Funcionario obj = new D_Funcionario();
            obj._Codigo = codigo;
            return obj.Consultar_Id_Tipos(obj);
        }
        public static string Editar(int codigo, string nombre,string ocuapa,string numecel, string obse)
        {

            D_Funcionario edita = new D_Funcionario();
            edita._Codigo = codigo;
            edita._Nombre = nombre;
            edita._Ocupacion = ocuapa;
            edita._NumeroCelular = numecel;
            edita._Observacion = obse;

            return edita.EDITAR_FUNCIONARIO(edita);

        }
        public static string Eliminar(int codigo)
        {
            D_Funcionario elim = new D_Funcionario();
            elim._Codigo = codigo;
            return elim.ELIMINAR_FUNCIONARIO(elim);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_Funcionario obj = new D_Funcionario();
            obj._Codigo = codigo;
            obj._Estado = estado;
            return obj.CAMBIO_ESTADO_FUNCIONARIO(obj);
        }

        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_Funcionario().BUSCAR_LISTA_FUNCIONARIO(bus, cbti, cbest);
        }

        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_Funcionario().BUSCAR_REPORTE_LISTA_FUNCIONARIO(estado, cbtipo, cajas);
        }
    }
}
