﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos;
namespace Capa_Negocio
{
  public class N_TiposSala
    {
        public static DataTable Listar_Todo()
        {
            //return new D_Lista_analisis_laboratorio().Listar();
            return new D_TiposSala().Listar();
        }
        public static string Insertar(string nombre, string descripcio, string estad)
        {
            D_TiposSala lista = new D_TiposSala();
            lista._Nombre = nombre;
            lista._Descripcion = descripcio;
            lista._Estado = estad;
            return lista.REGISTRAR_TIPOS_SALA(lista);
        }
        public static DataTable Consultar_codigo(int codigo)
        {
            D_TiposSala obj = new D_TiposSala();
            obj._Codigo = codigo;
            return obj.Consultar_Id_Tipos(obj);
        }
        public static string Editar(int codigo, string nombre, string descipcion)
        {

            D_TiposSala edita = new D_TiposSala();
            edita._Codigo = codigo;
            edita._Nombre = nombre;
            edita._Descripcion = descipcion;

            return edita.EDITAR_TIPOS_SALA(edita);

        }
        public static string Eliminar(int codigo)
        {
            D_TiposSala elim = new D_TiposSala();
            elim._Codigo = codigo;
            return elim.ELIMINAR_TIPOS_SALA(elim);
        }
        public static string Cambio_Estado(int codigo, string estado)
        {
            D_TiposSala obj = new D_TiposSala();
            obj._Codigo = codigo;
            obj._Estado = estado;
            return obj.CAMBIO_ESTADO_TIPOS_SALA(obj);
        }

        public static DataTable Buscar_campo(string bus, string cbti, string cbest)
        {
            return new D_TiposSala().BUSCAR_LISTA_TIPOS_SALA(bus, cbti, cbest);
        }       

        public static DataTable Buscar_Reporte_Buscar2(string estado, string cbtipo, string cajas)
        {
            return new D_TiposSala().BUSCAR_REPORTE_LISTA_TIPO_SALA_CAJA2(estado, cbtipo, cajas);
        }
    }
}
