using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
namespace Capa_Presentacion.ESTUDIO_LABORATORIO
{
    public partial class Frm_EstudioLaboratorio_Mostrar : Form
    {
       public static Frm_EstudioLaboratorio_Mostrar frm;
        public Frm_EstudioLaboratorio_Mostrar()
        {
            InitializeComponent();
            frm = this;
        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Mostrar);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo_EstudioLaboratorio = true;
            ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar obj = new ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar();
            obj.ShowDialog();
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
            dgv.Columns[0].Width = 65;
            dgv.Columns[1].Width = 120;
            dgv.Columns[2].Width = 400;
            dgv.Columns[3].Width = 1065;
            dgv.Columns[4].Width = 95;        
        }

        public void Actualizar_dgv()
        {
            this.dgvLista.DataSource = N_ESTUDIO_LABORATORIO.Listar_Todo();
        }
        private void Frm_EstudioLaboratorio_Mostrar_Load(object sender, EventArgs e)
        {
            Actualizar_dgv();
            Configurar_Datagridview();
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void Datos()
        {

            try
            {

                DataTable codigo = N_ESTUDIO_LABORATORIO.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells[0].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar frm = ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar.Get_instacnias();


                    string co = codigo.Rows[0][0].ToString();//codi
                    string nom = codigo.Rows[0][1].ToString();//nombre
                    string desc = codigo.Rows[0][2].ToString();//obse
                    string evolucionmedica = codigo.Rows[0][5].ToString();
                                                               //string nombreTipo = codigo.Rows[0]["TIPO SALA"].ToString();//
                                                               //string codiTipo = codigo.Rows[0][4].ToString();

                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtDescripcion.Text = desc.Trim();
                    frm.txtcodigo_evolucion_medica.Text = evolucionmedica.Trim();
                    // frm.txtcodigoTiposala.Text = codiTipo;
                    //   frm.txtnombretiposala.Text = nombreTipo;
                    if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                    {
                        string habilitado = "Habilitado";
                        frm.cbESTADO.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbESTADO.Text = Deshabilitado;
                    }
                    if (Program.isnuevo_EstudioLaboratorio == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_EstudioLaboratorio == true)
                    {
                        frm.cbESTADO.Enabled = false;
                        frm.lblestado.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                        if (codigo.Rows[0]["ESTADO"].ToString() == "H")
                        {
                            string habilitado = "Habilitado";
                            frm.cbESTADO.Text = habilitado.ToString();
                        }
                        else
                        {
                            string Deshabilitado = "Deshabilitado";
                            frm.cbESTADO.Text = Deshabilitado;
                        }
                    }
                    else
                    {
                        if (Program.Cambio_Estado_EstudioLaboratorio == true)
                        {
                            frm.btnACEPTAR.Enabled = true;
                            frm.btnCANCELAR.Enabled = true;
                            frm.groupBoxDATOS.Enabled = true;
                            frm.cbESTADO.Enabled = false;
                            frm.txtCODIGO.Enabled = false;
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtDescripcion.Enabled = false;
                            frm.cbESTADO.Focus();
                            string Deshabilitado = "Deshabilitado";
                            string habilitado = "Habilitado";
                            if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                            {
                                frm.cbESTADO.Text = habilitado;
                            }
                            else
                            {
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Consultar_EstudioLaboratorio == true)
                        {
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtDescripcion.Enabled = false;
                            frm.cbESTADO.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
                            if (codigo.Rows[0]["ESTADO"].ToString() == "H")
                            {
                                string habilitado = "Habilitado";
                                frm.cbESTADO.Text = habilitado.ToString();
                            }
                            else
                            {
                                string Deshabilitado = "Deshabilitado";
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Eliminar_EstudioLaboratorio == true)
                        {
                            if (codigo.Rows[0][3].ToString() == "H")
                            {
                                string habilitado = "Habilitado";
                                frm.cbESTADO.Text = habilitado.ToString();
                            }
                            else
                            {
                                string Deshabilitado = "Deshabilitado";
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else
                        {
                            frm.groupBoxDATOS.Enabled = false;
                            frm.btnACEPTAR.Enabled = false;
                            frm.btnCANCELAR.Enabled = false;
                        }
                    }

                    frm.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }
    }
}
