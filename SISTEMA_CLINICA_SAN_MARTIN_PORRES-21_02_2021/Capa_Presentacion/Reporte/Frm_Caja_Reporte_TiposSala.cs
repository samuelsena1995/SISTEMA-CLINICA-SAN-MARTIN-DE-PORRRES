﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace Capa_Presentacion.Reporte
{
    public partial class Frm_Caja_Reporte_TiposSala : Form
    {
        public Frm_Caja_Reporte_TiposSala()
        {
            InitializeComponent();
        }

        private void Frm_Caja_Reporte_TiposSala_Load(object sender, EventArgs e)
        {

        }
        public void SET_REPORTE_LISTA_NUEVO(string cbestado, string cbtipo, string caja)
        {
            TiposSala.CrystalReport_TIPOSALA crys2 = new TiposSala.CrystalReport_TIPOSALA();
            TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtestado"];
            TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txttipo"];
            // TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];
            TextObject txtusuario = (TextObject)crys2.ReportDefinition.Sections["Section5"].ReportObjects["txtusuario"];
            esta.Text = cbestado;
            tip.Text = cbtipo;
            txtusuario.Text = Program.Nombre_Usuario;
            //nam.Text = caja;
            crys2.SetDataSource(Capa_Negocio.N_TiposSala.Buscar_Reporte_Buscar2(cbestado, cbtipo, caja));
            crystalReportViewerTiposSala.ReportSource = crys2;
        }
    }
}
