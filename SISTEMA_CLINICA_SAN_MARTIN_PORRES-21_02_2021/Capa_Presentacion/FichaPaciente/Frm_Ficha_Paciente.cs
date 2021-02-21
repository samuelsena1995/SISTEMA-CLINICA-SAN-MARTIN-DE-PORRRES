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
namespace Capa_Presentacion.FichaPaciente
{
    public partial class Frm_Ficha_Paciente : Form
    {
        public static Frm_Ficha_Paciente frm_dgv;
        public Frm_Ficha_Paciente()
        {
            InitializeComponent();
            Program.isnuevo_paciente = false;
            Program.ismodificar_paciente = false;
            Program.Cambio_Estado_paciente = false;
            Program.Consultar_paciente = false;
            Program.Eliminar_paciente = false;
            frm_dgv = this;
            Actualizar_dgv();
            MOSTRARMENU_PERMISO();
           
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

            dgv.Columns[0].Width = 35; //codigo
            dgv.Columns[1].Width = 260; //nombre
            dgv.Columns[2].Width = 200; //fecha
            dgv.Columns[3].Width = 80; //sexo
            dgv.Columns[4].Width = 260; //datos
            dgv.Columns[5].Width = 1065; //observac
            dgv.Columns[6].Width = 95; //estado


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

        public void Actualizar_dgv()
        {
            if (Program.Seleccionar_Paciente == false)
            {
                this.dgvLista.DataSource = Capa_Negocio.N_Ficha_Paciente.Listar_Todo();
            }
            else if (Program.Seleccionar_Paciente == true) {
                this.dgvLista.DataSource = Capa_Negocio.N_Ficha_Paciente.Listar_No_Asignados();
            }
        }

        private void Frm_Ficha_Paciente_Load(object sender, EventArgs e)
        {            
             MOSTRARMENU_PERMISO();            
            Actualizar_dgv();
            Configurar_Datagridview();           
        }
        #region DATOS
        public void Datos()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_Ficha_Paciente.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FichaPaciente.Frm_Ficha_Paciente_Registrar frm = FichaPaciente.Frm_Ficha_Paciente_Registrar.Get_instacnias();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string fecha = codigo.Rows[0][2].ToString();
                    string sex = codigo.Rows[0][3].ToString();
                    string datosRefe = codigo.Rows[0][4].ToString();
                    string observacion = codigo.Rows[0][5].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.dtFecha.Value = Convert.ToDateTime(fecha.ToString());
                    frm.cbsExo.Text = sex.ToString();
                    frm.txtDatosReferencia.Text = datosRefe.Trim();
                    frm.txtobservacion.Text = observacion.Trim();


                    if (codigo.Rows[0][6].ToString() == "D")
                    {
                        string habilitado = "Habilitado";
                        frm.cbESTADO.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbESTADO.Text = Deshabilitado;
                    }          
                    if (Program.isnuevo_paciente == true)
                    {

                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_paciente == true)
                    {
                        frm.cbESTADO.Enabled = false;
                        frm.lblestado.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                        if (codigo.Rows[0][6].ToString() == "H")
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
                        if (Program.Cambio_Estado_paciente == true)
                        {
                            frm.btnACEPTAR.Enabled = true;
                            frm.btnCANCELAR.Enabled = true;
                            frm.groupBoxDATOS.Enabled = true;
                            frm.cbESTADO.Enabled = false;
                            frm.txtCODIGO.Enabled = false;
                            frm.txtNOMBRE.Enabled = false;
                            frm.dtFecha.Enabled = false;
                            frm.cbsExo.Enabled = false;
                            frm.txtDatosReferencia.Enabled = false;
                            frm.txtobservacion.Enabled = false;
                            frm.cbESTADO.Focus();
                            string Deshabilitado = "Deshabilitado";
                            string habilitado = "Habilitado";
                            if (codigo.Rows[0][6].ToString() == "D")
                            {
                                frm.cbESTADO.Text = habilitado;
                            }
                            else
                            {
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Consultar_paciente == true)
                        {
                            frm.txtNOMBRE.Enabled = false;
                            frm.dtFecha.Enabled = false;
                            frm.cbsExo.Enabled = false;
                            frm.txtDatosReferencia.Enabled = false;
                            frm.txtobservacion.Enabled = false;
                            frm.cbESTADO.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
                            if (codigo.Rows[0][6].ToString() == "H")
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

                DataTable codigo = Capa_Negocio.N_Ficha_Paciente.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_Ficha_Paciente_Eliminar frm = Frm_Ficha_Paciente_Eliminar.Get_instacnias();                    
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string fecha = codigo.Rows[0][2].ToString();
                    string sex = codigo.Rows[0][3].ToString();
                    string datosRefe = codigo.Rows[0][4].ToString();
                    string observacion = codigo.Rows[0][5].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.dtFecha.Value = Convert.ToDateTime(fecha.ToString());
                    frm.cbsExo.Text = sex.ToString();
                    frm.txtDatosReferencia.Text = datosRefe.Trim();
                    frm.txtobservacion.Text = observacion.Trim();
                    if (codigo.Rows[0][6].ToString() == "H")
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
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Ficha_Paciente);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo_paciente = true;
            Frm_Ficha_Paciente_Registrar obj = new FichaPaciente.Frm_Ficha_Paciente_Registrar();
            obj.ShowDialog();
        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.ismodificar_paciente = true;
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
                Program.Cambio_Estado_paciente = true;
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
                Program.Eliminar_paciente = true;
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
                Program.Consultar_paciente = true;
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

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Ficha_Paciente_Reporte);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }            
            Frm_Ficha_Paciente_Reporte obj = new FichaPaciente.Frm_Ficha_Paciente_Reporte();
            obj.ShowDialog();
        }

        private void Frm_Ficha_Paciente_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Frm_Ficha_Paciente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgvLista.DataSource =  Capa_Negocio.N_Ficha_Paciente.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            
            //if (txtBusqueda.Text == string.Empty)
            //{
            //    dgvLista.DataSource = Capa_Negocio.N_Ficha_Paciente.Listar_Todo();
            //}
            if (cbFiltro.Text == "Nombre" && txtBusqueda.Text.Any(x => char.IsNumber(x)))
            {
                MessageBox.Show("solo se permite letras");//letra
            }
            else {
                dgvLista.DataSource = Capa_Negocio.N_Ficha_Paciente.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            }
            if (cbFiltro.Text == "Codigo" && txtBusqueda.Text.Any(y => !char.IsNumber(y)))
            {
                MessageBox.Show("solo se permite numero");//numero
            }
            else
            {
                dgvLista.DataSource = Capa_Negocio.N_Ficha_Paciente.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvLista.DataSource = Capa_Negocio.N_Ficha_Paciente.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);

            dgvLista.DataSource = Capa_Negocio.N_Ficha_Paciente.Listar_Todo();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        //public void PRIVILEGIOS() {

        //    Program.resultado_funcion_permisos = Capa_Negocio.N_USUARIOS.login_funcion_NUEVOSAMUEL(Program.ID_USUARIO);
        //    foreach (string idServ in Program.resultado_funcion_permisos)
        //    {
        //        if (idServ == "fp_001") {
        //            menustpNUEVO.Enabled = true;
        //        }
        //        if (idServ == "fp_002")
        //        {
        //            menustpEDITAR.Enabled = true;
        //        }
        //        if (idServ == "fp_003")
        //        {
        //            menustpCAMBIARESTADO.Enabled = true;
        //        }
        //    }

        //}
        //public void MOSTRAR_VERSION_2(bool b) {
        //    menustpNUEVO.Enabled = !b && Capa_Datos.D_USUARIOS.TIENE_REGLAS("fp_001");
        //    menustpEDITAR.Enabled = !b && Capa_Datos.D_USUARIOS.TIENE_REGLAS("fp_002");
        //    menustpCAMBIARESTADO.Enabled = !b && Capa_Datos.D_USUARIOS.TIENE_REGLAS("fp_003");
        //    menustpELIMINAR.Enabled = !b && Capa_Datos.D_USUARIOS.TIENE_REGLAS("fp_004");
        //    consultarToolStripMenuItem.Enabled = !b && Capa_Datos.D_USUARIOS.TIENE_REGLAS("fp_005");
        //    informesToolStripMenuItem.Enabled = !b && Capa_Datos.D_USUARIOS.TIENE_REGLAS("fp_006");
        //}
        public void MOSTRARMENU_PERMISO()
        {
            foreach (DataGridViewRow item in Frm_Pantalla_principal.frm_princiapal.dtPermisoPrinciapl.Rows)
            {
                if (item.Cells[0].Value.ToString() == "fp_001")
                {
                    menustpNUEVO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "fp_002")
                {
                    menustpEDITAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "fp_003")
                {
                    menustpCAMBIARESTADO.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "fp_004")
                {
                    menustpELIMINAR.Visible = true;
                }
                else if (item.Cells[0].Value.ToString() == "fp_005")
                {
                    consultarToolStripMenuItem.Visible = true;
                }
                else if(item.Cells[0].Value.ToString() == "fp_006") {
                    informesToolStripMenuItem.Visible = true;
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Nombre" && txtBusqueda.Text.Any(x => char.IsNumber(x)))
            {
                MessageBox.Show("solo se permite letras");//letra
            }
            else if(cbFiltro.Text=="Codigo" &&txtBusqueda.Text.Any(y=> !char.IsNumber(y)))
            {
                MessageBox.Show("solo se permite numero");//numero
            }
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            INTERNACION.Frm_Internacion_Registrar f = (INTERNACION.Frm_Internacion_Registrar)Owner;
            f.txtcodigopaciente.Text = dgvLista.CurrentRow.Cells[0].Value.ToString();
            f.txtnombrepaciente.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
            f.txtfecha_nacicmeintoPaciente.Text = dgvLista.CurrentRow.Cells[2].Value.ToString();
            Program.Seleccionar_Paciente = false;
            Program.isnuevo = true;
            this.Close();
        }
    }
}
