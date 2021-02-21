using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.SALA
{
    public partial class Frm_Reporte_SALA : Form
    {
        public Frm_Reporte_SALA()
        {
            InitializeComponent();
        }

        private void btnBuscar_1_Click(object sender, EventArgs e)
        {
            Reporte.Frm_Caja_Reporte_SALA obj = new Reporte.Frm_Caja_Reporte_SALA();

            obj.SET_REPORTE_LISTA_SALA(cboEstado.Text, cbTipo.Text, textBox1.Text);
            obj.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
