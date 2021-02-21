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
    public partial class FrmReporte_GENERAL_FUNCIONARIO : Form
    {
        public FrmReporte_GENERAL_FUNCIONARIO()
        {
            InitializeComponent();
        }

        private void FrmReporte_GENERAL_FUNCIONARIO_Load(object sender, EventArgs e)
        {

        }
        public void SET_REPORTE_FUNCIOANRIO_NUEVO(string cbestado, string cbtipo, string caja)
        {
            Funcionario.CrystalReport_FUNCIONARIO crys2 = new Funcionario.CrystalReport_FUNCIONARIO();
            TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["cbestado"];
            TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["buscar"];
            //TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];
            TextObject txtusuario = (TextObject)crys2.ReportDefinition.Sections["Section5"].ReportObjects["txtusuario"];

            esta.Text = cbestado;
            tip.Text = cbtipo;
            //nam.Text = caja;
            txtusuario.Text = Program.Nombre_Usuario;
            crys2.SetDataSource(Capa_Negocio.N_Funcionario.Buscar_Reporte_Buscar2(cbestado, cbtipo, caja));
            crystalReportViewerFUNCIONARIO.ReportSource = crys2;
        }
    }
}
