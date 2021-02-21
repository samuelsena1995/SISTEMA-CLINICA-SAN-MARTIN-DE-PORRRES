using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
namespace Capa_Presentacion.Lista_analisis
{
    public partial class Frm_Listar_analisis_laboratorio_Registrar : Form
    {
        
        
        public string resp = "";

        #region Get_instancia
        private static Frm_Listar_analisis_laboratorio_Registrar instancia;

        public static Frm_Listar_analisis_laboratorio_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Listar_analisis_laboratorio_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Listar_analisis_laboratorio_Registrar();
            }
            return Instancia;
        }
        #endregion

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Frm_Listar_analisis_laboratorio_Registrar()
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
             else if (Program.Eliminar == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;                
                lblTrabajadores.Text = "ELIMINAR 3";                
            }
            else if (Program.Consultar == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;                
                lblTrabajadores.Text = "CONSULTAR";                
            }           
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
                    if (Program.isnuevo == true)
                    {
                        resp = N_Lista_analisis_laboratorio.Insertar(txtNOMBRE.Text.Trim(),
                            txtDescripcion.Text.Trim(), "H");
                    }
                    else if (Program.ismodificar == true)
                    {
                        resp = N_Lista_analisis_laboratorio.Editar(Convert.ToInt32(txtCODIGO.Text),
                            txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());                        
                    }
                    else if (Program.Cambio_Estado == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {
                            resp = N_Lista_analisis_laboratorio.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else
                        {
                            resp = N_Lista_analisis_laboratorio.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }
                                  
                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:."); 
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar = false;
                        }
                        if (Program.isnuevo == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");
                            
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
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
              //  else {
                //    MessageBox.Show(resp);
               // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void Frm_Listar_analisis_laboratorio_Registrar_Load(object sender, EventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }

        private void Frm_Listar_analisis_laboratorio_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TiposSala.Frm_TiposSala.frm_dgv.Actualizar_dgv();
            //Frm_Lista_estudio_imagen.frm_dgv.Actualizar_dgv();
            Frm_Lista_analisis_laboratorio.frm_dgv.Actualizar_dgv();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
            else if (Program.Eliminar == true) {
                Program.Eliminar = false;
            }
            this.Close();
            Instancia = null;
        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar)) //||
                //char.IsPunctuation(e.KeyChar) ||
              //  char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSeparator(e.KeyChar)) {
                e.Handled = false;
            }
            
          /*  if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
         /*   else if (char.IsControl(e.KeyChar)|| char.IsSeparator(e.KeyChar))
            {
               e.Handled = false;
            }*/
           /* else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSymbol(e.KeyChar)) {
               e.Handled= false;
            }*/
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

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
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
            this.Close();
            Instancia = null;
        }

        private void cbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
        }
    }
}
