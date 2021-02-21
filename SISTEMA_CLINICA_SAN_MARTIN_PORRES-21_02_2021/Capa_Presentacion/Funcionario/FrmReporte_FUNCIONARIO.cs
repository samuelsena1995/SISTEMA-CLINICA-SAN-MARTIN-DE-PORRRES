using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Funcionario
{
    public partial class FrmReporte_FUNCIONARIO : Form
    {
        public FrmReporte_FUNCIONARIO()
        {
            InitializeComponent();
        }

        private void btnBuscar_1_Click(object sender, EventArgs e)
        {
            Reporte.FrmReporte_GENERAL_FUNCIONARIO obj = new Reporte.FrmReporte_GENERAL_FUNCIONARIO();

            obj.SET_REPORTE_FUNCIOANRIO_NUEVO(cboEstado.Text, cbTipo.Text, textBox1.Text);
            obj.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
