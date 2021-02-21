using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.NODULO_REPORTE_CONTROL
{
    public partial class Frm_ReporteControlSalaEnMes : Form
    {
        public Frm_ReporteControlSalaEnMes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NODULO_REPORTE_CONTROL.Frm_ReporteControlMostrarGlobal obj = new NODULO_REPORTE_CONTROL.Frm_ReporteControlMostrarGlobal();
            obj.SET_REPORTE_LISTA_SALA_INTERNACION(dateTimePicker1.Value);            
            obj.ShowDialog();
        }
    }
}
