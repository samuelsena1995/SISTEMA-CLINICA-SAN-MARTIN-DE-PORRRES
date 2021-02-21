using System;
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
    public partial class Frm_Caja_Reporte_SALA : Form
    {
        public Frm_Caja_Reporte_SALA()
        {
            InitializeComponent();
        }

        private void Frm_Caja_Reporte_SALA_Load(object sender, EventArgs e)
        {

        }
        public void SET_REPORTE_LISTA_SALA(string cbestado, string cbtipo, string caja)
        {
            SALA.CrystalReport_SALA crys2 = new SALA.CrystalReport_SALA();
            TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtestado"];
            TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txttipo"];
          //TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];
            TextObject usuario = (TextObject)crys2.ReportDefinition.Sections["Section5"].ReportObjects["txtusuario"];
            esta.Text = cbestado;
            tip.Text = cbtipo;
            //nam.Text = caja;
            usuario.Text = Program.Nombre_Usuario;
            crys2.SetDataSource(Capa_Negocio.N_Sala.Buscar_Reporte_Buscar2(cbestado, cbtipo, caja));
            crystalReportViewer_SALA.ReportSource = crys2;
        }
    }
}
