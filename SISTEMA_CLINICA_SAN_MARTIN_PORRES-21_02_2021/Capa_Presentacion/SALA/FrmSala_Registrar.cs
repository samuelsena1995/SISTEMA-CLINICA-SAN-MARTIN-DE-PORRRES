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
namespace Capa_Presentacion.SALA
{
    public partial class FrmSala_Registrar : Form
    {
        string resp = "";
        public FrmSala_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo_Sala == true)
            {
                cbESTADO.Visible = false;
                lblestado.Visible = false;
                button1.Focus();
                lblTrabajadores.Text = "REGISTRAR";
            }
            if (Program.ismodificar_Sala == true)
            {

                lblTrabajadores.Text = "EDITAR";
            }
            if (Program.Cambio_Estado_Sala == true)
            {

                lblTrabajadores.Text = "CAMBIAR ESTADO";
            }
            if (Program.Consultar_Sala == true)
            {

                lblTrabajadores.Text = "CONSULTAR";
            }

        }
        #region Get_instancia
        private static FrmSala_Registrar instancia;

        public static FrmSala_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static FrmSala_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new FrmSala_Registrar();
            }
            return Instancia;
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {

            TiposSala.Frm_TiposSala d = new TiposSala.Frm_TiposSala();
            AddOwnedForm(d);

            d.Show();
            //Form listado = this.MdiChildren.FirstOrDefault(y => y is TiposSala.Frm_TiposSala);
            //if (listado != null)
            //{
            //    listado.BringToFront();
            //    return;
            //}
            //Program.isnuevo = true;
            //TiposSala.Frm_TiposSala obj = new TiposSala.Frm_TiposSala();

            //obj.ShowDialog();
        }
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>   
        private void FrmSala_Registrar_Load(object sender, EventArgs e)
        {
         
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
        private bool ValidarCajas_TIPO()
        {
            bool bandera = true; ;
            if (txtcodigoTiposala.Text.Trim() == string.Empty)
            {
                errCodigoTipoSala.SetError(txtcodigoTiposala, "Informacion requerida");
                bandera = false;
                button1.Focus();
            }
            else { errNOMBRE.Clear(); }
            return bandera;
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCajas() && ValidarCajas_TIPO())
                {
                    if (Program.isnuevo_Sala == true)
                    {
                        //resp = Capa_Negocio.N_Medico.Insertar(txtNOMBRE.Text.Trim(), txtocupacion.Text.Trim(), txtcelular.Text.Trim(), txtobservacion.Text.Trim(), "H");
                        resp = N_Sala.Insertar(txtNOMBRE.Text, txtobservacion.Text, "H", Convert.ToInt32(txtcodigoTiposala.Text));
                    }
                    else if (Program.ismodificar_Sala == true)
                    {
                        resp = N_Sala.Editar(Convert.ToInt32(txtCODIGO.Text), txtNOMBRE.Text, txtobservacion.Text, Convert.ToInt32(txtcodigoTiposala.Text));
                    }
                    else if (Program.Cambio_Estado_Sala == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {
                            resp = N_Sala.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else
                        {
                            resp = N_Sala.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }

                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_Sala == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            Program.ismodificar_Sala = false;
                        }
                        if (Program.isnuevo_Sala == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");
                            Program.isnuevo_Sala = false;
                        }
                        if (Program.Cambio_Estado_Sala == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_Sala = false;

                            cbESTADO.Enabled = true;
                            txtNOMBRE.Enabled = true;
                            txtobservacion.Enabled = true;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_Sala = false;
                    Program.ismodificar_Sala = false;
                    Program.Cambio_Estado_Sala = false;
                    Program.Eliminar_Sala = false;
                    this.Close();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmSala_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Refresh();
            FrmSala.frm_dgv.Actualizar_dgv();
            if (Program.ismodificar_Sala == true)
            {
                Program.ismodificar_Sala = false;
            }
            else if (Program.isnuevo_Sala == true)
            {
                Program.isnuevo_Sala = false;

            }
            else if (Program.Cambio_Estado_Sala == true)
            {
                Program.Cambio_Estado_Sala = false;
            }
            else if (Program.Eliminar_Sala == true)
            {
                Program.Eliminar_Sala = false;
            }
            else if (Program.Consultar_Sala == true)
            {
                Program.Consultar_Sala = false;
            }            
            Instancia = null;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar_Sala == true)
            {
                Program.ismodificar_Sala = false;
            }
            else if (Program.isnuevo_Sala == true)
            {
                Program.isnuevo_Sala = false;

            }
            else if (Program.Cambio_Estado_Sala == true)
            {
                Program.Cambio_Estado_Sala = false;
            }
            else if (Program.Eliminar_Sala == true)
            {
                Program.Eliminar_Sala = false;
            }
            else if (Program.Consultar_Sala == true)
            {
                Program.Consultar_Sala = false;
            }
            this.Close();
            Instancia = null;
        }
    }
}
