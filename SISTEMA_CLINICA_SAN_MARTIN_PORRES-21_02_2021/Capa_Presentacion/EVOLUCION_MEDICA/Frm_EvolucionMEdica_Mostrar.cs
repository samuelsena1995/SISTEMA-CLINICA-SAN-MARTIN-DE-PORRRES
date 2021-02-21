using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.EVOLUCION_MEDICA
{
    public partial class Frm_EvolucionMEdica_Mostrar : Form
    {
        public static Frm_EvolucionMEdica_Mostrar frm;
        public Frm_EvolucionMEdica_Mostrar()
        {
            InitializeComponent();
            frm = this;
        }

        private void Frm_EvolucionMEdica_Mostrar_Load(object sender, EventArgs e)
        {
            Actualizar_dgv();
            Configurar_Datagridview();
        }
        ////
        public void Actualizar_dgv()
        {
           
                this.dgvLista.DataSource = Capa_Negocio.N_EVOLUCION_MEDICA.MOSTRAR();
            
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

            dgv.Columns[0].Width = 120; //codigo
            dgv.Columns[1].Width = 140; //codigo inte
            dgv.Columns[2].Width = 140; //cod usu
            dgv.Columns[2].Visible=false; //cod usu
            dgv.Columns[3].Width = 140; //usu
            dgv.Columns[4].Width = 140; //cod med
            dgv.Columns[4].Visible = false; ; //cod med
            dgv.Columns[5].Width = 160; //med
            dgv.Columns[6].Width = 260; //desc
            dgv.Columns[7].Width = 95; //estado           


        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_EvolucionMEdica_Mostrar);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo_evolucion = true;
            Frm_EvolucionMedica_Registrar obj = new Frm_EvolucionMedica_Registrar();
            obj.ShowDialog();
        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.ismodificar_evolucion = true;
                this.Datos2();
            }
            else
            {
                MessageBox.Show("Selecciones");
            }
        }
        public void Datos2()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_EVOLUCION_MEDICA.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells[0].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   EVOLUCION_MEDICA.Frm_EvolucionMedica_Registrar frm = EVOLUCION_MEDICA.Frm_EvolucionMedica_Registrar.Get_instacnias();


                    string co = codigo.Rows[0][0].ToString();//codigo
                    string internacion = codigo.Rows[0][1].ToString();//internacion
                    string usuario = codigo.Rows[0][2].ToString();//usuario
                    string usuario_nombre = codigo.Rows[0][3].ToString();//usuario
                    string medico = codigo.Rows[0][4].ToString();//medico
                    string medico_nombre = codigo.Rows[0][5].ToString();//medico
                    string descripcion = codigo.Rows[0][6].ToString();//descripcion
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtcodigointernacion.Text = internacion.Trim();
                    frm.txtcodigousuario.Text = usuario_nombre.Trim();
                    frm.lblcodigousario.Text = usuario.Trim();
                    frm.lblcodigomedico.Text = medico.Trim();
                    frm.txtccodigomedico.Text = medico_nombre.Trim();
                    frm.txtobservacion.Text = descripcion.Trim();


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
                    if (Program.isnuevo_evolucion == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_evolucion == true)
                    {
                        frm.txtCODIGO.Enabled = false;
                        frm.cbESTADO.Enabled = false;
                        //frm..Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                        if (codigo.Rows[0]["Estado"].ToString() == "Habilitado")
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
                        if (Program.Cambio_Estado_evolucion == true)
                        {
                            frm.btnACEPTAR.Enabled = true;
                            frm.btnCANCELAR.Enabled = true;
                            ////  frm.groupBoxDATOS.Enabled = true;
                            frm.txtCODIGO.Enabled = false;
                            frm.txtobservacion.Enabled = false;
                           frm.cbESTADO.Focus();
                            string Deshabilitado = "Deshabilitado";
                            string habilitado = "Habilitado";
                            if (codigo.Rows[0]["Estado"].ToString() == "Deshabilitado")
                            {
                                frm.cbESTADO.Text = habilitado;
                            }
                            else
                            {
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Consultar_evolucion == true)
                        {
                            frm.btnCANCELAR.Visible = true;

                            //frm.txtNombre_Rol.Enabled = false;
                            //frm.txtobservacion.Enabled = false;
                            frm.cbESTADO.Enabled = false;
                            //frm.txtContraseña.Enabled = false;
                            ////       frm.txtUsuario.Enabled = false;
                            frm.button1.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
                            if (codigo.Rows[0]["Estado"].ToString() == "Habilitado")
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
                        else if (Program.Eliminar_evolucion == true)
                        {
                            //if (codigo.Rows[0]["Estado"].ToString() == "H")
                            //{
                            //    string habilitado = "Habilitado";
                            //    frm.cbestado_Usuario.Text = habilitado.ToString();
                            //}
                            //else
                            //{
                            //    string Deshabilitado = "Deshabilitado";
                            //    frm.cbestado_Usuario.Text = Deshabilitado;
                            //}
                        }
                        else
                        {

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Cambio_Estado_evolucion = true;
                this.Datos2();
            }
            else
            {
                MessageBox.Show("Selecciones");
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Consultar_evolucion = true;
                this.Datos2();
            }
            else
            {
                MessageBox.Show("Selecciones");
            }
        }

        private void menustpELIMINAR_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar f = (ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar)Owner;
            f.txtcodigo_evolucion_medica.Text= dgvLista.CurrentRow.Cells[0].Value.ToString();                        
            Program.isnuevo_evolucion = true;
            Program.sekleccionar_evolucionmedica = false;
            this.Close();
        }
    }
}
