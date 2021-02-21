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
using System.Data.SqlClient;
namespace Capa_Presentacion.SALA
{
    public partial class FrmSala : Form
    {
        public static FrmSala frm_dgv;
        public FrmSala()
        {
            InitializeComponent();
            Program.isnuevo_Sala = false;
            Program.ismodificar_Sala = false;
            Program.Cambio_Estado_Sala = false;
            MOSTRARMENU_PERMISO();
            frm_dgv = this;
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
        private void FrmSala_Load(object sender, EventArgs e)
        {
            MOSTRARMENU_PERMISO();
            Actualizar_dgv();
            Configurar_Datagridview();
            OCULTAR_CODIGO_TIPO();
           
        }
        public void MOSTRARMENU_PERMISO()
        {
            foreach (DataGridViewRow item in Frm_Pantalla_principal.frm_princiapal.dtPermisoPrinciapl.Rows)
            {
                if (item.Cells[0].Value.ToString() == "Sa_001")
                {
                    menustpNUEVO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Sa_002")
                {
                    menustpEDITAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Sa_003")
                {
                    menustpCAMBIARESTADO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Sa_004")
                {
                    menustpELIMINAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Sa_005")
                {
                    consultarToolStripMenuItem.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Sa_006")
                {
                    informesToolStripMenuItem.Visible = true;
                }
            }


        }
        public void Actualizar_dgv()
        {
            if (Program.Seleccionar_Sala == false)
            {
                this.dgvLista.DataSource = Capa_Negocio.N_Sala.Listar_Todo();
            }
            else if (Program.Seleccionar_Sala == true) {
                this.dgvLista.DataSource = Capa_Negocio.N_Sala.Listar_No_Asignados();
            }
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
            dgv.Columns[0].Width = 35;//#
            dgv.Columns[1].Width = 150;//NOMBRE        
            dgv.Columns[2].Width = 1010;//OBSER
            dgv.Columns[3].Width = 190;//TIPO SALA
            dgv.Columns[4].Width = 80;//CODIG SALA
            dgv.Columns[5].Width = 90;//ESTADO           
        }
        public void OCULTAR_CODIGO_TIPO() {
            dgvLista.Columns[4].Visible = false;
        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is FrmSala);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo_Sala = true;
            FrmSala_Registrar obj = new FrmSala_Registrar();
            obj.ShowDialog();
        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.ismodificar_Sala = true;
                this.Datos();
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }
        #region Datos
        public void Datos()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_Sala.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmSala_Registrar frm = FrmSala_Registrar.Get_instacnias();


                    string co = codigo.Rows[0][0].ToString();//codi
                    string nom = codigo.Rows[0][1].ToString();//nombre
                    string desc = codigo.Rows[0][2].ToString();//obse
                    //string nombreTipo = codigo.Rows[0]["TIPO SALA"].ToString();//
                    //string codiTipo = codigo.Rows[0][4].ToString();
                
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtobservacion.Text = desc.Trim();
                    // frm.txtcodigoTiposala.Text = codiTipo;
                    //   frm.txtnombretiposala.Text = nombreTipo;
                    frm.txtcodigoTiposala.Text = Convert.ToString(dgvLista.CurrentRow.Cells["CODIGO"].Value);                
                    frm.txtnombretiposala.Text = Convert.ToString(dgvLista.CurrentRow.Cells["TIPO SALA"].Value);
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
                    if (Program.isnuevo_Sala == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_Sala == true)
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
                        if (Program.Cambio_Estado_Sala == true)
                        {
                            frm.btnACEPTAR.Enabled = true;
                            frm.btnCANCELAR.Enabled = true;
                            frm.groupBoxDATOS.Enabled = true;
                            frm.cbESTADO.Enabled = false;
                            frm.txtCODIGO.Enabled = false;
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtobservacion.Enabled = false;
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
                        else if (Program.Consultar_Sala == true)
                        {
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtobservacion.Enabled = false;
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
                        else if (Program.Eliminar_Sala == true)
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
        public void Datos_Eliminar()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_Sala.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmSala_Eliminar frm = FrmSala_Eliminar.Get_instacnias();

                    //frm.txtCODIGO.Text = codigo.Rows[0][0].ToString();
                    //frm.txtNOMBRE.Text= codigo.Rows[0][1].ToString();
                    //frm.txtDescripcion.Text = codigo.Rows[0][2].ToString();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string desc = codigo.Rows[0][2].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtobservacion.Text = desc.Trim();
                    frm.txtcodigoTiposala.Text = Convert.ToString(dgvLista.CurrentRow.Cells["CODIGO"].Value);
                    frm.txtnombretiposala.Text = Convert.ToString(dgvLista.CurrentRow.Cells["TIPO SALA"].Value);
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
                    frm.ShowDialog();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }


        #endregion

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvLista.Rows.Count >= 0)
            {
                Program.Consultar_Sala = true;
                this.Datos();
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }
        private bool Exists_Sala_AsignacionSala(string usuarios)
        {
            string consulta = @"select count(*) from SALA s inner join ASIGNACION_SALA tp on s.Codigo=tp.Codigo_Sala 
where tp.Codigo_Sala=@Codigo and tp.Estado='H';";
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(Capa_Datos.Conexion.Conexion_bd))
            {
                con.Open();
                cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@Codigo", usuarios);
                int conta = Convert.ToInt32(cmd.ExecuteScalar());
                return conta == 0;
            }
        }
        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                if (!Exists_Sala_AsignacionSala(dgvLista.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("No se Puede cambiar el Estado por que se esta usando en Asignacion Sala");
                }
                else
                {
                    Program.Cambio_Estado_Sala = true;
                    this.Datos();
                }
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
                Program.Eliminar_Sala = true;
                this.Datos_Eliminar();
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            if (Program.Seleccionar_Sala == true) {
                Program.Seleccionar_Sala = false;
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.DataSource = Capa_Negocio.N_Sala.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            if (txtBusqueda.Text == string.Empty)
            {
                dgvLista.DataSource = Capa_Negocio.N_Sala.Listar_Todo();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvLista.DataSource = Capa_Negocio.N_Sala.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);

            dgvLista.DataSource = Capa_Negocio.N_Sala.Listar_Todo();
        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is FrmSala);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Frm_Reporte_SALA obj = new Frm_Reporte_SALA();
            obj.ShowDialog();
        }

        private void FrmSala_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            INTERNACION.FRM_ASIGNACION_SALA_REGISTRAR f = (INTERNACION.FRM_ASIGNACION_SALA_REGISTRAR)Owner;
            f.lblCodigoSala.Text = dgvLista.CurrentRow.Cells[0].Value.ToString();
            f.txtNombreSala.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
            f.btnACEPTAR.Focus();
            Program.isnuevo_Sala = true;
            Program.Seleccionar_Sala = false;
            this.Close();
        }
    }
}
