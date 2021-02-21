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
using System.Runtime.InteropServices;
namespace Capa_Presentacion.Lista_estudio_por_imagenes
{
    public partial class Frm_Lista_estudio_imagen : Form
    {
        public static Frm_Lista_estudio_imagen frm_dgv;

        public Frm_Lista_estudio_imagen()
        {
            InitializeComponent();
            Program.isnuevo = false;
            Program.ismodificar = false;
            Program.Cambio_Estado = false;
            Program.Consultar = false;
            Program.Eliminar = false;
            Frm_Lista_estudio_imagen.frm_dgv = this;
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
        private void Frm_Lista_estudio_imagen_Load(object sender, EventArgs e)
        {
            Actualizar_dgv();
            Configurar_Datagridview();
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
            dgv.Columns[0].Width = 35;
            dgv.Columns[1].Width = 400;
            dgv.Columns[2].Width = 1065;
            dgv.Columns[3].Width = 95;


        }
        public void Actualizar_dgv()
        {
            this.dgvLista.DataSource = N_Lista_estudio_por_imagen.Listar_Todo();
        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Lista_estudio_por_imagen_Registrar);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo = true;
            Frm_Lista_estudio_por_imagen_Registrar obj = new Frm_Lista_estudio_por_imagen_Registrar();
            obj.ShowDialog();
        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.ismodificar = true;
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

                DataTable codigo = N_Lista_estudio_por_imagen.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_Lista_estudio_por_imagen_Registrar frm = Frm_Lista_estudio_por_imagen_Registrar.Get_instacnias();
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
                    if (Program.isnuevo == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar == true)
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
                        if (Program.Cambio_Estado == true)
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
                        else if (Program.Consultar == true)
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

                DataTable codigo = N_Lista_estudio_por_imagen.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   Frm_Lista_estudio_por_imagen_eliminar frm = Frm_Lista_estudio_por_imagen_eliminar.Get_instacniasElimi();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string desc = codigo.Rows[0][2].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtDescripcion.Text = desc.Trim();
                    frm.cbESTADO.Enabled = false;
                    frm.txtCODIGO.Enabled = false;
                    frm.txtNOMBRE.Enabled = false;
                    frm.txtDescripcion.Enabled = false;
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

        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Cambio_Estado = true;
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
                Program.Eliminar = true;
                this.Datos_Eliminar();
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
                Program.Consultar = true;
                this.Datos();
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }
        int lx, ly;
        int sw, sh;

        private void Frm_Lista_estudio_imagen_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Frm_Lista_estudio_imagen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
