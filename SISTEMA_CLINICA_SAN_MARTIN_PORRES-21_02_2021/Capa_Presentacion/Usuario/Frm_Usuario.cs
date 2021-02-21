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
namespace Capa_Presentacion.Usuario
{
    public partial class Frm_Usuario : Form
    {
        public static Frm_Usuario frm_dgv;
        public Frm_Usuario()
        {
            InitializeComponent();
            Program.isnuevo = false;
            Program.ismodificar = false;
            Program.Cambio_Estado = false;
            Program.Consultar = false;
            Program.Eliminar = false;
            Frm_Usuario.frm_dgv = this;
            MOSTRARMENU_PERMISO();
        }
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>   
        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Usuario);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo = true;
            Frm_Usuario_Nuevo obj = new Frm_Usuario_Nuevo();
            obj.ShowDialog();
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {            
            //  MostrarRoles();
            MOSTRAR_USUARIO();
            Configurar_Datagridview();
        
        }
       
        public void MOSTRARMENU_PERMISO()
        {
            foreach (DataGridViewRow item in Frm_Pantalla_principal.frm_princiapal.dtPermisoPrinciapl.Rows)
            {
                if (item.Cells[0].Value.ToString() == "Us_001")
                {
                    menustpNUEVO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Us_002")
                {
                    menustpEDITAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Us_003")
                {
                    menustpCAMBIARESTADO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Us_004")
                {
                    menustpELIMINAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Us_005")
                {
                    consultarToolStripMenuItem.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "Us_006")
                {
                    informesToolStripMenuItem.Visible = true;
                }
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

            dgvLista.Columns[0].Width = 100;
            dgvLista.Columns[1].Width = 300;
            dgvLista.Columns[2].Width = 592;
            dgvLista.Columns[3].Width = 240;
            //dgv.Columns[3].Visible = false;
            dgvLista.Columns[4].Width = 240;
            dgvLista.Columns[5].Width = 95;
           // dgvLista.Columns[0].Visible = false;
            // dgvLista.Columns[5].Width = 95;
           


        }
        //public void MostrarRoles()
        //{
        //    dgvLista.DataSource = Capa_Negocio.N_Permiso.MostrarRol();

        //}
        public void MOSTRAR_USUARIO() {
            dgvLista.DataSource = Capa_Negocio.N_USUARIOS.MostrarRol();
        }
        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.ismodificar = true;
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

                DataTable codigo = Capa_Negocio.N_USUARIOS.Consultar_ID(this.dgvLista.CurrentRow.Cells["#"].Value.ToString());
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Usuario.Frm_Usuario_Nuevo frm = Usuario.Frm_Usuario_Nuevo.Get_instancias();


                    string co = codigo.Rows[0][0].ToString();//codigo
                    string nom = codigo.Rows[0][1].ToString();//nombre
                    string desc = codigo.Rows[0][2].ToString();//obserca
                    string usua = codigo.Rows[0]["Usuario"].ToString();
                    string contrase = codigo.Rows[0]["Contraseña"].ToString();//contraseña
                    frm.txt_codigo_usuario.Text = co.Trim();
                    frm.txtNombre_Rol.Text = nom.Trim();
                    frm.txtobservacion.Text = desc.Trim();
                    frm.txt_usuario.Text = usua.Trim();
                    frm.txtContraseña.Text = contrase.Trim();


                    if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                    {
                        string habilitado = "Habilitado";
                        frm.cbestado_Usuario.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbestado_Usuario.Text = Deshabilitado;
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
                        frm.txt_codigo_usuario.Enabled = false;
                        frm.cbestado_Usuario.Enabled = false;
                        //frm..Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                        if (codigo.Rows[0]["Estado"].ToString() == "H")
                        {
                            string habilitado = "Habilitado";
                            frm.cbestado_Usuario.Text = habilitado.ToString();
                        }
                        else
                        {
                            string Deshabilitado = "Deshabilitado";
                            frm.cbestado_Usuario.Text = Deshabilitado;
                        }
                    }
                    else
                    {
                        if (Program.Cambio_Estado == true)
                        {
                            frm.btnACEPTAR.Enabled = true;
                            frm.btnCANCELAR.Enabled = true;
                          //  frm.groupBoxDATOS.Enabled = true;
                            frm.cbestado_Usuario.Enabled = false;
                            frm.txt_codigo_usuario.Enabled = false;
                            frm.txtNombre_Rol.Enabled = false;
                            frm.txtobservacion.Enabled = false;
                   //         frm.txtUsuario.Enabled = false;
                            frm.txtContraseña.Enabled = false;
                            //frm.cbESTADO.Focus();
                            string Deshabilitado = "Deshabilitado";
                            string habilitado = "Habilitado";
                            if (codigo.Rows[0]["Estado"].ToString() == "D")
                            {
                                frm.cbestado_Usuario.Text = habilitado;
                            }
                            else
                            {
                                frm.cbestado_Usuario.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Consultar == true)
                        {
                            frm.txtNombre_Rol.Enabled = false;
                            frm.txtobservacion.Enabled = false;
                            frm.cbestado_Usuario.Enabled = false;
                            frm.txtContraseña.Enabled = false;
                     //       frm.txtUsuario.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
                            if (codigo.Rows[0]["Estado"].ToString() == "H")
                            {
                                string habilitado = "Habilitado";
                                frm.cbestado_Usuario.Text = habilitado.ToString();
                            }
                            else
                            {
                                string Deshabilitado = "Deshabilitado";
                                frm.cbestado_Usuario.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Eliminar == true)
                        {
                            if (codigo.Rows[0]["Estado"].ToString() == "H")
                            {
                                string habilitado = "Habilitado";
                                frm.cbestado_Usuario.Text = habilitado.ToString();
                            }
                            else
                            {
                                string Deshabilitado = "Deshabilitado";
                                frm.cbestado_Usuario.Text = Deshabilitado;
                            }
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
        public void DatosAsignarPermiso()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_USUARIOS.Consultar_ID(this.dgvLista.CurrentRow.Cells["#"].Value.ToString());
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Usuario.FRM_PERMISO frm = Usuario.FRM_PERMISO.Get_instancias();


                    string co = codigo.Rows[0][0].ToString();//codigo
                    string nom = codigo.Rows[0][1].ToString();//nombre
                    string desc = codigo.Rows[0][2].ToString();//observac
                    //string usua = codigo.Rows[0][4].ToString();//
                  //  string contrase = codigo.Rows[0][3].ToString();//contras
                    frm.txtvodigo.Text = co.Trim();
                    frm.txtname.Text = nom.Trim();               
                    frm.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }

        //////
        /////
        private static Frm_Usuario instancia;
        public static Frm_Usuario Instancia;
        public static Frm_Usuario getInstancia() {
            if (Instancia == null)
                Instancia = new Frm_Usuario();
            return Instancia;
        }

        private void menustpELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los registros?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo="";
                    string Rpta = "";
                   // Rpta = Capa_Negocio.N_USUARIOS.ELIMINAR_ASIGNACION_PERMISO_IDUSUARIO(Convert.ToString(dgvLista.Rows[0].Cells["#"].Value));
                    
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        if (row.Selected)
                        {
                            if (this.dgvLista.CurrentRow.Cells["ESTADO"].Value.ToString() == "Deshabilitado")
                            {
                                Codigo = Convert.ToString(row.Cells["#"].Value);
                                //Rpta = Capa_Negocio.N_USUARIOS.Elimnar_USUARIOS(dgvLista.CurrentRow.Cells["#"].Value.ToString());
                                Rpta = Capa_Negocio.N_USUARIOS.Elimnar_USUARIOS(Codigo);
                                Rpta = Capa_Negocio.N_USUARIOS.ELIMINAR_ASIGNACION_PERMISO_IDUSUARIO(Codigo);
                                MessageBox.Show("Dato eliminado correctamente", ".:Sistema Clinico:.");
                            }
                            else
                            {
                                MessageBox.Show("DESHABILITE PRIMERO EL DATO ", ".:Sistema Clinico:.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                    }
                    if (Rpta.Equals("Ok"))
                    {

                    }
                    else
                    {
                        // MessageBox.Show(Rpta);
                    }
                    //        this.Actualizar_dgv();
                    // MostrarRoles();
                    MOSTRAR_USUARIO();
                    //Numero_Cliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Consultar = true;
                this.Datos2();
            }
            else
            {
                MessageBox.Show("Selecciones");
            }
        }

        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Cambio_Estado = true;
                this.Datos2();
            }
            else
            {
                MessageBox.Show("Selecciones");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            dgvLista.DataSource = Capa_Negocio.N_USUARIOS.Buscar_campo_usuarios(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            if (txtBusqueda.Text == string.Empty) {
                dgvLista.DataSource = Capa_Negocio.N_USUARIOS.MostrarRol();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            
            dgvLista.DataSource = Capa_Negocio.N_USUARIOS.Buscar_campo_usuarios(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            dgvLista.DataSource = Capa_Negocio.N_USUARIOS.MostrarRol();
            
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is FrmReporte_Usuario);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Frm_Reporte_Usuario obj = new Frm_Reporte_Usuario();
            obj.ShowDialog();
        }

        private void Frm_Usuario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Frm_Pantalla_principal.frm_princiapal.MOSTRAR_Id_Permiso_Pantalla_principal();
        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                //Program.Cambio_Estado = true;
                this.DatosAsignarPermiso();
            }
            else
            {
                MessageBox.Show("Selecciones");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(dgvLista.Rows[0].Cells["#"].Value));
           
        }

        private void Frm_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Pantalla_principal.frm_princiapal.MOSTRAR_Id_Permiso_Pantalla_principal();
        }

        private void faltaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
