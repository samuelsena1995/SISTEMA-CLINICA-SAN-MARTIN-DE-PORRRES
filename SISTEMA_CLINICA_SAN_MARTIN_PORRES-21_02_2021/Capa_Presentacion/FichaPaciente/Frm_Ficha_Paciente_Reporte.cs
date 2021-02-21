using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.FichaPaciente
{
    public partial class Frm_Ficha_Paciente_Reporte : Form
    {
        public Frm_Ficha_Paciente_Reporte()
        {
            InitializeComponent();
        }

        private void btnBuscar_1_Click(object sender, EventArgs e)
        {
            Reporte.Frm_Caja_Reporte_Ficha_Paciente obj = new Reporte.Frm_Caja_Reporte_Ficha_Paciente();

            obj.SET_REPORTE_LISTA_Ficha(cboEstado.Text, cbTipo.Text, textBox1.Text);
            obj.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Ficha_Paciente_Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}
