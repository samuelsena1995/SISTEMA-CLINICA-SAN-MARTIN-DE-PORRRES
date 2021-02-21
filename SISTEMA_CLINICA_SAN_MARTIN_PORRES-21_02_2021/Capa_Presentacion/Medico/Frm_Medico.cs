using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Capa_Presentacion.Medico
{
    public partial class Frm_Medico : Form
    {
        public static Frm_Medico frm_dgv;
        public Frm_Medico()
        {
            InitializeComponent();
            Program.isnuevo_medico = false;
            Program.ismodificar_medico = false;
            Program.Cambio_Estado_medico = false;
            Program.Consultar_medico = false;
            Program.Eliminar_medico = false;
            Frm_Medico.frm_dgv = this;
            MOSTRARMENU_PERMISO();
        }
        /*         
        mover el formulario sin borde
        */
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>
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
            dgv.Columns[0].Width = 35;
            dgv.Columns[1].Width = 300;
            dgv.Columns[2].Width = 200;
            dgv.Columns[3].Width = 150;
            dgv.Columns[4].Width = 1065;
            dgv.Columns[5].Width = 95;


        }
     
        public void Listar(DataGridView a)
        {
            a.DataSource = Capa_Negocio.N_Medico.Listar_Todo();
        }
        public void Actualizar_dgv()
        {
            this.dgvLista.DataSource =Capa_Negocio.N_Medico.Listar_Todo();
        }
        private void Frm_Medico_Load(object sender, EventArgs e)
        {
            MOSTRARMENU_PERMISO();
            Actualizar_dgv();
            Configurar_Datagridview();
       
        }
        public void MOSTRARMENU_PERMISO()
        {
            foreach (DataGridViewRow item in Frm_Pantalla_principal.frm_princiapal.dtPermisoPrinciapl.Rows)
            {
                if (item.Cells[0].Value.ToString() == "M_001")
                {
                    menustpNUEVO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "M_002")
                {
                    menustpEDITAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "M_003")
                {
                    menustpCAMBIARESTADO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "M_004")
                {
                    menustpELIMINAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "M_005")
                {
                    consultarToolStripMenuItem.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "M_006")
                {
                    informesToolStripMenuItem.Visible = true;
                }
            }


        }
        #region Datos

        public void Datos()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_Medico.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_Medico_Registrar frm = Frm_Medico_Registrar.Get_instacnias();

                    //frm.txtCODIGO.Text = codigo.Rows[0][0].ToString();
                    //frm.txtNOMBRE.Text= codigo.Rows[0][1].ToString();
                    //frm.txtDescripcion.Text = codigo.Rows[0][2].ToString();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string ocupa = codigo.Rows[0][2].ToString();
                    string numeroce = codigo.Rows[0][3].ToString();
                    string Observaco = codigo.Rows[0][4].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtocupacion.Text = ocupa.Trim();
                    frm.txtcelular.Text = numeroce.Trim();
                    frm.txtobservacion.Text = Observaco.Trim();


                    if (codigo.Rows[0][5].ToString() == "D")
                    {
                        string habilitado = "Habilitado";
                        frm.cbESTADO.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbESTADO.Text = Deshabilitado;
                    }
                    if (Program.isnuevo_medico == true)
                    {
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_medico == true)
                    {
                        frm.cbESTADO.Enabled = false;
                        frm.lblestado.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                        if (codigo.Rows[0][5].ToString() == "H")
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
                        if (Program.Cambio_Estado_medico == true)
                        {
                            frm.btnACEPTAR.Enabled = true;
                            frm.btnCANCELAR.Enabled = true;
                            frm.groupBoxDATOS.Enabled = true;
                            frm.cbESTADO.Enabled = false;
                            frm.txtCODIGO.Enabled = false;
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtcelular.Enabled = false;
                            frm.txtocupacion.Enabled = false;
                            frm.txtobservacion.Enabled = false;
                            frm.cbESTADO.Focus();
                            string Deshabilitado = "Deshabilitado";
                            string habilitado = "Habilitado";
                            if (codigo.Rows[0][5].ToString() == "D")
                            {
                                frm.cbESTADO.Text = habilitado;
                            }
                            else
                            {
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Consultar_medico == true)
                        {
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtocupacion.Enabled = false;
                            frm.txtcelular.Enabled = false;
                            frm.txtobservacion.Enabled = false;
                            frm.cbESTADO.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
                            if (codigo.Rows[0][5].ToString() == "H")
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



        public void Datos_Eliminar()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_Medico.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_Medico_Eliminar frm = Frm_Medico_Eliminar.Get_instacnias();

                    //frm.txtCODIGO.Text = codigo.Rows[0][0].ToString();
                    //frm.txtNOMBRE.Text= codigo.Rows[0][1].ToString();
                    //frm.txtDescripcion.Text = codigo.Rows[0][2].ToString();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string ocupa = codigo.Rows[0][2].ToString();
                    string numeroce = codigo.Rows[0][3].ToString();
                    string Observaco = codigo.Rows[0][4].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtocupacion.Text = ocupa.Trim();
                    frm.txtcelular.Text = numeroce.Trim();
                    frm.txtobservacion.Text = Observaco.Trim();
                    if (codigo.Rows[0][5].ToString() == "H")
                    {
                        string habilitado = "Habilitado";
                        frm.cbESTADO.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbESTADO.Text = Deshabilitado;
                    }
                    frm.ShowDialog();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }

        #endregion

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Medico);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo_medico = true;
            Frm_Medico_Registrar obj = new Frm_Medico_Registrar();
            obj.ShowDialog();
        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.ismodificar_medico = true;
                this.Datos();            
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Cambio_Estado_medico = true;
                this.Datos();

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Consultar_medico = true;
                this.Datos();

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void menustpELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Eliminar_medico = true;
                this.Datos_Eliminar();

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.DataSource = Capa_Negocio.N_Medico.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            if (txtBusqueda.Text == string.Empty)
            {
                dgvLista.DataSource = Capa_Negocio.N_Medico.Listar_Todo();
            }
        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Reporte_Medico);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Frm_Reporte_Medico obj = new Frm_Reporte_Medico();
            obj.ShowDialog();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvLista.DataSource = Capa_Negocio.N_Medico.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);

            dgvLista.DataSource = Capa_Negocio.N_Medico.Listar_Todo();
        }

        private void Frm_Medico_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            INTERNACION.Frm_Internacion_Registrar f = (INTERNACION.Frm_Internacion_Registrar)Owner;
            f.txtcodigomedico.Text = dgvLista.CurrentRow.Cells[0].Value.ToString();
            f.txtnombremedico.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
          //  f.txttelefonoPaciente.Text = dgvLista.CurrentRow.Cells[2].Value.ToString();

            Program.isnuevo = true;
            this.Close();
        }
    }
}
