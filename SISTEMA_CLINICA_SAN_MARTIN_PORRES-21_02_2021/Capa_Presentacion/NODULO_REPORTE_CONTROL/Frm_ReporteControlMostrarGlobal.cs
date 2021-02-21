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
namespace Capa_Presentacion.NODULO_REPORTE_CONTROL
{
    public partial class Frm_ReporteControlMostrarGlobal : Form
    {
        public Frm_ReporteControlMostrarGlobal()
        {
            InitializeComponent();
        }

        private void Frm_ReporteControlMostrarGlobal_Load(object sender, EventArgs e)
        {

        }
        public void SET_REPORTE_LISTA_SALA_INTERNACION(DateTime caja)
        {
            NODULO_REPORTE_CONTROL.ReporteControlSalaEnMes crys2 = new NODULO_REPORTE_CONTROL.ReporteControlSalaEnMes();
          //  TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtestado"];
           // TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtbuscar"];

            //TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];
           // TextObject usuario = (TextObject)crys2.ReportDefinition.Sections["Section5"].ReportObjects["txtusuario"];
           // usuario.Text = Program.Nombre_Usuario;
           // esta.Text = cbestado;
           // tip.Text = cbtipo;
            //nam.Text = caja;
            crys2.SetDataSource(Capa_Negocio.N_ASIGNACION_SALA.Buscar_Reporte_ASIGNACION_SALA(caja));
            crystalReportViewerGlobal.ReportSource = crys2;
        }
    }
}
