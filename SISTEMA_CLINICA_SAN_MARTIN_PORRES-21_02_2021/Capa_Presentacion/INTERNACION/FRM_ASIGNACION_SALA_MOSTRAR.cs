using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.INTERNACION
{
    public partial class FRM_ASIGNACION_SALA_MOSTRAR : Form
    {
        public FRM_ASIGNACION_SALA_MOSTRAR()
        {
            InitializeComponent();
        }

        private void FRM_ASIGNACION_SALA_MOSTRAR_Load(object sender, EventArgs e)
        {
          
            MOSTRAR_ASIGNACION_SALA();
            Configurar_Datagridview();
        }
        public void MOSTRAR_ASIGNACION_SALA() {
            dgvLista.DataSource = Capa_Negocio.N_ASIGNACION_SALA.MOSTRAR_ASIGNACION_SALA();
        }
        public void Configurar_Datagridview()
        {
            var dgv = dgvLista;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Orange;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Oxygen", 12);
            dgv.ColumnHeadersHeight = 40;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = true;

            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = true;

            //ajustar el tamaño de la tabla
            //dgv.AutoResizeColumns();
            //dgv.Columns[0].Width = 20;
            dgv.Columns[0].Width = 85;//#
            dgv.Columns[1].Width = 150;//CODIGO_SALA       
            dgv.Columns[2].Width = 110;//SALA
            dgv.Columns[3].Width = 170;//CODIGO INTERNACION
            dgv.Columns[4].Width = 130;//FECHA
            dgv.Columns[5].Width = 90;//ESTADO           
        }

        private void menustpELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show(String.Format("Esta seguro de <Anular> el registro :\n {0} ?",
                    this.dgvLista.CurrentRow.Cells[2].Value.ToString()),
                    ".: SISTEMA CLINICO :.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        if (row.Selected)
                        {
                            if (this.dgvLista.CurrentRow.Cells["ESTADO"].Value.ToString() == "Deshabilitado" || this.dgvLista.CurrentRow.Cells["ESTADO"].Value.ToString() == "Habilitado")
                            {
                                Rpta = Capa_Negocio.N_ASIGNACION_SALA.ANULAR_SALA(Convert.ToInt32(dgvLista.CurrentRow.Cells["CODIGO"].Value.ToString()),"A");
                              
                            }
                            else
                            {
                                MessageBox.Show("DESHABILITE PRIMERO EL DATO ", ".:Sistema Clinico:.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                    }
                    if (Rpta.Equals("Ok"))
                    {
                        MessageBox.Show("Se Anulo a Asignacion de la Sala", ".:Sistema Clinico:.");
                    }
                    else
                    {
                        // MessageBox.Show(Rpta);
                    }
                    this.MOSTRAR_ASIGNACION_SALA();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void asignarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignacionDeSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {

        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {

        }

        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
