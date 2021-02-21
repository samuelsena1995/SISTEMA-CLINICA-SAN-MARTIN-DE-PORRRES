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
    public partial class Reporte_General_Caja2 : Form
    {
        public Reporte_General_Caja2()
        {
            InitializeComponent();
        }
        private static Reporte_General_Caja2 Instancia;
        ReportDocument crysta;

        public static Reporte_General_Caja2 Get_Instancia()
        {
            if (Instancia == null)
            {
                Instancia = new Reporte_General_Caja2();
            }
            return Instancia;
        }

        private void Reporte_General_Caja2_Load(object sender, EventArgs e)
        {

        }
        public void Set_Reporte_Lista_caja3(string estado, string cbtipo, string caja)
        {
          
            crysta = new ReportDocument();
            string filename = "\\Lista_analisis\\ReporteLista_Analisis_Caja2.rpt";
            string ruta = Application.StartupPath;
            string cadenaruta = ruta.Substring(0, ruta.IndexOf("\\bin")) + filename;
            crysta.Load(cadenaruta);            
            crysta.SetDataSource(Capa_Negocio.N_Lista_analisis_laboratorio.Buscar_Reporte_Buscar2(estado, cbtipo, caja));
            crystalReportViewer1.ReportSource = crysta;
        }
        public void SET_REPORTE_LISTA_NUEVO(string cbestado, string cbtipo, string caja) {
            Lista_analisis.ReporteLista_Analisis_Caja2 crys2 = new Lista_analisis.ReporteLista_Analisis_Caja2();            
           // Usuario.CrystalReport_USUARIO crys2 = new Usuario.CrystalReport_USUARIO();
            TextObject esta = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtestado"];
            TextObject tip = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txttipo"];
            TextObject nam = (TextObject)crys2.ReportDefinition.Sections["Section4"].ReportObjects["txtnombre"];           
            esta.Text = cbestado;
            tip.Text = cbtipo;
            nam.Text = caja;            
            crys2.SetDataSource(Capa_Negocio.N_Lista_analisis_laboratorio.Buscar_Reporte_Buscar2(cbestado, cbtipo, caja));            
            crystalReportViewer1.ReportSource = crys2;
        }
        
    }
}
