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
namespace Capa_Presentacion.TiposSala
{
    public partial class Frm_TiposSala_Registrar : Form
    {
        public string resp = "";
        public Frm_TiposSala_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo_TipoSala == true)
            {
                // lblestado.Visible = false;
                // cbESTADO.Visible = false;
                //label4.Visible = true;
                //txtCODIGO.Enabled = false;  
                cbESTADO.Visible = false;
                lblestado.Visible = false;              
                lblTrabajadores.Text = "REGISTRAR";
            }
            else if (Program.ismodificar_TipoSala == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "EDITAR";
            }
            else if (Program.Cambio_Estado_TipoSala == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CAMBIAR ESTADO";
            }          
            else if (Program.Consultar_TipoSala == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CONSULTAR";
            }           
        }

        private void Frm_TiposSala_Registrar_Load(object sender, EventArgs e)
        {
            Frm_TiposSala.frm_dgv.Actualizar_dgv();
        }
        private bool ValidarCajas()
        {
            bool bandera = true; ;
            if (txtNOMBRE.Text.Trim() == string.Empty)
            {
                errNOMBRE.SetError(txtNOMBRE, "Informacion requerida");
                bandera = false;
                txtNOMBRE.Focus();
            }
            else { errNOMBRE.Clear(); }
            return bandera;
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCajas())
                {
                    //  MessageBox.Show("Error: Ingres los campos obligatorios");
                    //}
                    //else
                    //{
                    if (Program.isnuevo_TipoSala == true)
                    {

                        resp = Capa_Negocio.N_TiposSala.Insertar(txtNOMBRE.Text, txtDescripcion.Text, "H");
                    }
                    else if (Program.ismodificar_TipoSala == true)
                    {
                     //   resp = N_Lista_analisis_laboratorio.Editar(Convert.ToInt32(txtCODIGO.Text),
                       //     txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());
                       resp=Capa_Negocio.N_TiposSala.Editar(Convert.ToInt32(txtCODIGO.Text),
                            txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    else if (Program.Cambio_Estado_TipoSala == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {                            
                            resp = Capa_Negocio.N_TiposSala.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else
                        {                         
                            resp = Capa_Negocio.N_TiposSala.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }
                    ///                                       
                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_TipoSala == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar_TipoSala = false;
                        }
                        if (Program.isnuevo_TipoSala == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.isnuevo_TipoSala = false;
                        }
                        if (Program.Cambio_Estado_TipoSala == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_TipoSala = false;

                            cbESTADO.Enabled = true;
                            txtNOMBRE.Enabled = true;
                            txtDescripcion.Enabled = true;
                        }                   
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_TipoSala = false;
                    Program.ismodificar_TipoSala = false;
                    Program.Cambio_Estado_TipoSala = false;                    
                    this.Close();

                }
                //  else {
                //    MessageBox.Show(resp);
                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar_TipoSala == true)
            {
                Program.ismodificar_TipoSala = false;
            }
            else if (Program.isnuevo_TipoSala == true)
            {
                Program.isnuevo_TipoSala = false;

            }
            else if (Program.Cambio_Estado_TipoSala == true)
            {
                Program.Cambio_Estado_TipoSala = false;
            }          
            this.Close();
            Instancia = null;
        }
        #region Get_instancia
        private static Frm_TiposSala_Registrar instancia;

        public static Frm_TiposSala_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_TiposSala_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_TiposSala_Registrar();
            }
            return Instancia;
        }
        #endregion

        private void Frm_TiposSala_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Refresh();
            Frm_TiposSala.frm_dgv.Actualizar_dgv();
            if (Program.ismodificar_TipoSala == true)
            {
                Program.ismodificar_TipoSala = false;
            }
            else if (Program.isnuevo_TipoSala == true)
            {
                Program.isnuevo_TipoSala = false;

            }
            else if (Program.Cambio_Estado_TipoSala == true)
            {
                Program.Cambio_Estado_TipoSala = false;
            }           
            Instancia = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar_TipoSala == true)
            {
                Program.ismodificar_TipoSala = false;
            }
            else if (Program.isnuevo_TipoSala == true)
            {
                Program.isnuevo_TipoSala = false;

            }
            else if (Program.Cambio_Estado_TipoSala == true)
            {
                Program.Cambio_Estado_TipoSala = false;
            }
            this.Close();
            Instancia = null;
        }
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>   
        private void Frm_TiposSala_Registrar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
