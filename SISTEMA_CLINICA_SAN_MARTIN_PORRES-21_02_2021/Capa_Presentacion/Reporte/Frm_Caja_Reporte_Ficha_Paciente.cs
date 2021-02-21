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
    public partial class Frm_Caja_Reporte_Ficha_Paciente : Form
    {
        public Frm_Caja_Reporte_Ficha_Paciente()
        {
            InitializeComponent();
        }

        private void Frm_Caja_Reporte_Ficha_Paciente_Load(object sender, EventArgs e)
        {

        }
        public void SET_REPORTE_LISTA_Ficha(string cbestado, string cbtipo, string caja)
        {
            FichaPaciente.CrystalReport_Ficha_Paciente crys2 = new FichaPaciente.CrystalReport_Ficha_Paciente();
            TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtestado"];
            TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtbuscar"];

            //TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];
            TextObject usuario = (TextObject)crys2.ReportDefinition.Sections["Section5"].ReportObjects["txtusuario"];
            usuario.Text = Program.Nombre_Usuario;
            esta.Text = cbestado;
            tip.Text = cbtipo;
            //nam.Text = caja;
            crys2.SetDataSource(Capa_Negocio.N_Ficha_Paciente.Buscar_Reporte_Buscar2(cbestado, cbtipo, caja));
            crystalReportViewerPaciente.ReportSource = crys2;
        }
    }
}
