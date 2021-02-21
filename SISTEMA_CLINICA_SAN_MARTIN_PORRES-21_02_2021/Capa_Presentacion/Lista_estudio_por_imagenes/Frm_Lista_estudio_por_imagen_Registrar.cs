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
namespace Capa_Presentacion.Lista_estudio_por_imagenes
{
    public partial class Frm_Lista_estudio_por_imagen_Registrar : Form
    {
        public Frm_Lista_estudio_por_imagen_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo == true)
            {
                lblestado.Visible = false;
                cbESTADO.Visible = false;
                label4.Visible = true;
                txtCODIGO.Enabled = false;
                lblTrabajadores.Text = "REGISTRAR";
            }
            else if (Program.ismodificar == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "EDITAR";
            }
            else if (Program.Cambio_Estado == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CAMBIAR ESTADO";
            }           
            else if (Program.Consultar == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CONSULTAR";
            }
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string resp = "";
        private void Frm_Lista_estudio_por_imagen_Registrar_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }       

        #region Get_instancia
        private static Frm_Lista_estudio_por_imagen_Registrar instancia;

        public static Frm_Lista_estudio_por_imagen_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Lista_estudio_por_imagen_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Lista_estudio_por_imagen_Registrar();
            }
            return Instancia;
        }
        #endregion
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
                    if (Program.isnuevo == true)
                    {                 
                        resp = Capa_Negocio.N_Lista_estudio_por_imagen.Insertar(txtNOMBRE.Text, txtDescripcion.Text, "H");
                    }
                    else if (Program.ismodificar == true)
                    {
                        resp = Capa_Negocio.N_Lista_estudio_por_imagen.Editar(Convert.ToInt32(txtCODIGO.Text),
                            txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());                        
                    }
                    else if (Program.Cambio_Estado == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {
                            resp = Capa_Negocio.N_Lista_estudio_por_imagen.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else
                        {
                            resp = Capa_Negocio.N_Lista_estudio_por_imagen.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }
                                                 
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");                             
                            Program.ismodificar = false;
                        }
                        if (Program.isnuevo == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");                                                       
                            Program.isnuevo = false;
                        }
                        if (Program.Cambio_Estado == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado = false;
                            cbESTADO.Enabled = true;
                            txtNOMBRE.Enabled = true;
                            txtDescripcion.Enabled = true;
                        }
                    }
                    else
                    {
                     //   MessageBox.Show(resp);
                    }
                    Program.isnuevo = false;
                    Program.ismodificar = false;
                    Program.Cambio_Estado = false;
                    Program.Eliminar = false;
                    this.Close();
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar == true)
            {
                Program.ismodificar = false;
            }
            else if (Program.isnuevo == true)
            {
                Program.isnuevo = false;
            }
            else if (Program.Cambio_Estado == true)
            {
                Program.Cambio_Estado = false;
            }
            else if (Program.Eliminar == true)
            {
                Program.Eliminar = false;
            }
            this.Close();
            Instancia = null;
        }

        private void Frm_Lista_estudio_por_imagen_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Lista_estudio_imagen.frm_dgv.Actualizar_dgv();
        }
        /////////////////

    }   
}
