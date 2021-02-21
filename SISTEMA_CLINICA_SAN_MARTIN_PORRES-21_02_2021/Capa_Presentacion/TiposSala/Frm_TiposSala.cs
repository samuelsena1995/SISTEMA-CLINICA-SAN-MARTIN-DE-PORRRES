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
using System.Data;
using System.Data.SqlClient;
namespace Capa_Presentacion.TiposSala
{
    public partial class Frm_TiposSala : Form
    {
        public static Frm_TiposSala frm_dgv;
        public Frm_TiposSala()
        {
            InitializeComponent();
            Program.isnuevo = false;
            Program.ismodificar = false;
            Program.Cambio_Estado = false;
            Program.Consultar = false;
            Program.Eliminar = false;
            Program.SeleccionarTiposSala = false;
            Frm_TiposSala.frm_dgv = this;
            Actualizar_dgv();
            MOSTRARMENU_PERMISO();
        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_TiposSala);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo_TipoSala = true;
            Frm_TiposSala_Registrar obj = new Frm_TiposSala_Registrar();

            obj.ShowDialog();
        }
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>   
        private void Frm_TiposSala_Load(object sender, EventArgs e)
        {
            MOSTRARMENU_PERMISO();
            Actualizar_dgv();
            Configurar_Datagridview();
        }
        public void MOSTRARMENU_PERMISO()
        {
            foreach (DataGridViewRow item in Frm_Pantalla_principal.frm_princiapal.dtPermisoPrinciapl.Rows)
            {
                if (item.Cells[0].Value.ToString() == "Ts_001")
                {
                    menustpNUEVO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Ts_002")
                {
                    menustpEDITAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Ts_003")
                {
                    menustpCAMBIARESTADO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Ts_004")
                {
                    menustpELIMINAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Ts_005")
                {
                    consultarToolStripMenuItem.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Ts_006")
                {
                    informesToolStripMenuItem.Visible = true;
                }
            }


        }
        public void Actualizar_dgv()
        {
            this.dgvTiposSala.DataSource = Capa_Negocio.N_TiposSala.Listar_Todo();
        }
        public void Configurar_Datagridview()
        {
            var dgv = dgvTiposSala;
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
            dgv.Columns[0].Width = 35;//CODIGO
            dgv.Columns[1].Width = 170;//NOMBRE
            dgv.Columns[2].Width = 1065;//DESCRIPCION
            dgv.Columns[3].Width = 95;//ESTADO


        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvTiposSala.Rows.Count >= 0)
            {
                Program.ismodificar_TipoSala = true;
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

                DataTable codigo = Capa_Negocio.N_TiposSala.Consultar_codigo(Convert.ToInt32(this.dgvTiposSala.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_TiposSala_Registrar frm = Frm_TiposSala_Registrar.Get_instacnias();

 
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string desc = codigo.Rows[0][2].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtDescripcion.Text = desc.Trim();


                    if (codigo.Rows[0][3].ToString() == "D")
                    {
                        string habilitado = "Habilitado";
                        frm.cbESTADO.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbESTADO.Text = Deshabilitado;
                    }                   
                    if (Program.isnuevo_TipoSala == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_TipoSala == true)
                    {
                        frm.cbESTADO.Enabled = false;
                        frm.lblestado.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
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
                        if (Program.Cambio_Estado_TipoSala == true)
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
                            if (codigo.Rows[0][3].ToString() == "D")
                            {
                                frm.cbESTADO.Text = habilitado;
                            }
                            else
                            {
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Consultar_TipoSala == true)
                        {
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtDescripcion.Enabled = false;
                            frm.cbESTADO.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
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
                        else if (Program.Eliminar_TipoSala == true) {
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

                DataTable codigo = Capa_Negocio.N_TiposSala.Consultar_codigo(Convert.ToInt32(this.dgvTiposSala.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_TiposSala_Eliminar frm = Frm_TiposSala_Eliminar.Get_instacnias();

                    //frm.txtCODIGO.Text = codigo.Rows[0][0].ToString();
                    //frm.txtNOMBRE.Text= codigo.Rows[0][1].ToString();
                    //frm.txtDescripcion.Text = codigo.Rows[0][2].ToString();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string desc = codigo.Rows[0][2].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtDescripcion.Text = desc.Trim();
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
                    frm.ShowDialog();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }


        #endregion

        private bool Exists_TipoSala_(string usuarios)
        {
            string consulta = @"select count(*) from Tipos_Sala tp inner join SALA s on s.CodigoTipoSala=tp.Codigo 
where tp.Codigo=@Codigo and s.Estado='H';";
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
            if (dgvTiposSala.Rows.Count >= 0)
            {
                if (!Exists_TipoSala_(dgvTiposSala.CurrentRow.Cells[0].Value.ToString())){
                    MessageBox.Show("No se puede cambiar el <Estado> que el dato esta siendo usado en <Sala> ");
                }else
                {
                    Program.Cambio_Estado_TipoSala = true;
                    this.Datos();
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTiposSala.Rows.Count >= 0)
            {
                Program.Consultar_TipoSala = true;
                this.Datos();
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

        private void menustpELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvTiposSala.Rows.Count >= 0)
            {
                Program.Eliminar_TipoSala = true;
                Datos_Eliminar();
               
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void dgvTiposSala_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvTiposSala_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dgvTiposSala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_TiposSala);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Frm_Reporte_Caja_TipoSala obj = new Frm_Reporte_Caja_TipoSala();
            obj.ShowDialog();
        }

        private void dgvTiposSala_DoubleClick_1(object sender, EventArgs e)
        {
            SALA.FrmSala_Registrar f = (SALA.FrmSala_Registrar)Owner;
            f.txtcodigoTiposala.Text = dgvTiposSala.CurrentRow.Cells[0].Value.ToString();
            f.txtnombretiposala.Text = dgvTiposSala.CurrentRow.Cells[1].Value.ToString();
            f.txtNOMBRE.Focus();
            Program.isnuevo = true;
            this.Close();

        }

        private void dgvTiposSala_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTiposSala.DataSource = Capa_Negocio.N_TiposSala.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            if (txtBusqueda.Text == string.Empty)
            {
                dgvTiposSala.DataSource = Capa_Negocio.N_TiposSala.Listar_Todo();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvTiposSala.DataSource = Capa_Negocio.N_TiposSala.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);

            dgvTiposSala.DataSource = Capa_Negocio.N_TiposSala.Listar_Todo();
        }

        private void Frm_TiposSala_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
