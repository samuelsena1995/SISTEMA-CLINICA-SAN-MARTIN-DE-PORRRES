using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_Negocio
{
   public class N_Ficha_Paciente
    {
        public static DataTable Listar_Todo()
        {           
            return new D_Ficha_Paciente().Listar();
        }
        public static DataTable Listar_No_Asignados()
        {
            return new D_Ficha_Paciente().Listar_No_Asignados();
        }

        public static string Insertar(string nombre,DateTime fec,string sex,string datosRefer, string observac, string estad)
        {
            D_Ficha_Paciente lista = new D_Ficha_Paciente();
            lista._Nombre = nombre;
            lista._Fecha = fec;
            lista._Sexo =sex;
            lista._DatosReferencia = datosRefer;
            lista._Observacion = observac;
            lista._Estado = estad;
            return lista.REGISTRAR_PACIENTE(lista);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_Ficha_Paciente obj = new D_Ficha_Paciente();
            obj._Codigo = codigo;
            return obj.Consultar_PACIENTE_ID(obj);
        }
        public static string Editar(int codigo, string nombre, DateTime fec, string sex, string datosRefer, string observac)
        {

            D_Ficha_Paciente edita = new D_Ficha_Paciente();
            edita._Codigo = codigo;
            edita._Nombre = nombre;
            edita._Fecha = fec;
            edita._Sexo = sex;
            edita._DatosReferencia = datosRefer;
            edita._Observacion = observac;
            return edita.EDITAR_PACIENTE(edita);

        }
        public static string Eliminar(int codigo)
        {
            D_Ficha_Paciente elim = new D_Ficha_Paciente();
            elim._Codigo = codigo;
            return elim.ELIMINAR_PACIENTE(elim);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_Ficha_Paciente obj = new D_Ficha_Paciente();
            obj._Codigo = codigo;
            obj._Estado = estado;
            return obj.CAMBIO_ESTADO_PACIENTE(obj);
        }

        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_Ficha_Paciente().BUSCAR_LISTA_PACIENTE(bus, cbti, cbest);
        }

        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_Ficha_Paciente().BUSCAR_REPORTE_LISTA_FICHA_PACIENTE(estado, cbtipo, cajas);
        }
    }
}
