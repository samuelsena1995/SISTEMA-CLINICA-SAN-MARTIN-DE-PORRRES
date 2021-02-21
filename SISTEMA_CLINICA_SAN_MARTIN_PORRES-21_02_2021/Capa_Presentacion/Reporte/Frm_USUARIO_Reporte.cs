using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CrystalDecisions.CrystalReports.Engine;
namespace Capa_Presentacion.Reporte
{
    public partial class Frm_USUARIO_Reporte : Form
    {
        public Frm_USUARIO_Reporte()
        {
            InitializeComponent();
        }

        private void Frm_USUARIO_Reporte_Load(object sender, EventArgs e)
        {

        }
        public void SET_REPORTE_USUARIO_NUEVO(string cbestado, string cbtipo, string caja)
        {
            Usuario.CrystalReport_USUARIO crys2 = new Usuario.CrystalReport_USUARIO();
            TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtestado"];
            TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txttipo"];
            //TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];
            TextObject txtusuario = (TextObject)crys2.ReportDefinition.Sections["Section5"].ReportObjects["txtusuario"];

            esta.Text = cbestado;
            tip.Text = cbtipo;
            //nam.Text = caja;
            txtusuario.Text = Program.Nombre_Usuario;
            crys2.SetDataSource(Capa_Negocio.N_Permiso.Buscar_Reporte_Buscar2(cbestado, cbtipo, caja));
            crystalReportViewer_USUARIO.ReportSource = crys2;
        }
    }
}
