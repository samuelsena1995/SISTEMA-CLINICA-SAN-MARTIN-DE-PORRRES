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
    public partial class Frm_Reporte_Medico_caja : Form
    {
        public Frm_Reporte_Medico_caja()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Medico_Load(object sender, EventArgs e)
        {

        }
        public void SET_REPORTE_LISTA_NUEVO(string cbestado, string cbtipo, string caja)
        {
            Medico.CrystalReport_Medico crys2 = new Medico.CrystalReport_Medico();
            TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtestado"];
            TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtbuscar"];
            //   TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];
            TextObject txtusuario = (TextObject)crys2.ReportDefinition.Sections["Section5"].ReportObjects["txtusuario"];
            esta.Text = cbestado;
            tip.Text = cbtipo;
            txtusuario.Text = Program.Nombre_Usuario;
           // nam.Text = caja;
            crys2.SetDataSource(Capa_Negocio.N_Medico.Buscar_Reporte_Buscar2(cbestado, cbtipo, caja));
            crystalReportViewer_Medico.ReportSource = crys2;
        }
    }
}
