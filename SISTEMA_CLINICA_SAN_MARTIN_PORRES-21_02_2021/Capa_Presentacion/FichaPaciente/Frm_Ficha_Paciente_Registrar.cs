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
    public partial class Frm_Ficha_Paciente_Registrar : Form
    {
        public Frm_Ficha_Paciente_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo_paciente == true) {
                lblTrabajadores.Text ="REGISTRAR";
                cbESTADO.Visible = false;
                lblestado.Visible = false;
            }
            if (Program.ismodificar_paciente == true) {
                lblTrabajadores.Text = "EDITAR";
            }
            if (Program.Consultar_paciente == true) {
                lblTrabajadores.Text = "CONSULTAR";
            }
            if (Program.Cambio_Estado_paciente == true) {
                lblTrabajadores.Text = "CAMBIAR ESTADO";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string resp = "";
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

        #region Get_instancia
        private static Frm_Ficha_Paciente_Registrar instancia;

        public static Frm_Ficha_Paciente_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Ficha_Paciente_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Ficha_Paciente_Registrar();
            }
            return Instancia;
        }
        #endregion
        private void Frm_Ficha_Paciente_Registrar_Load(object sender, EventArgs e)
        {
          
        }
        private bool ValidarCajas()
        {
            bool bandera = true;
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
                    if (Program.isnuevo_paciente == true)
                    {
                        // resp = N_Lista_analisis_laboratorio.Insertar(txtNOMBRE.Text.Trim(),
                        //   txtDescripcion.Text.Trim(), "H");
                        if (cbsExo.Text == "Masculino")
                        {
                            resp = Capa_Negocio.N_Ficha_Paciente.Insertar(txtNOMBRE.Text.Trim(), dtFecha.Value, "M", txtDatosReferencia.Text, txtobservacion.Text, "H");
                        }
                        else {
                            resp = Capa_Negocio.N_Ficha_Paciente.Insertar(txtNOMBRE.Text.Trim(), dtFecha.Value, "F", txtDatosReferencia.Text, txtobservacion.Text, "H");
                        }
                    }
                    else if (Program.ismodificar_paciente == true)
                    {
                        //resp = N_Lista_analisis_laboratorio.Editar(Convert.ToInt32(txtCODIGO.Text),
                        //  txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());
                        if (cbsExo.Text == "MASCULINO")
                        {
                            resp = Capa_Negocio.N_Ficha_Paciente.Editar(Convert.ToInt32(txtCODIGO.Text), txtNOMBRE.Text.Trim(), dtFecha.Value, "M", txtDatosReferencia.Text, txtobservacion.Text);
                        }else
                        {
                            resp = Capa_Negocio.N_Ficha_Paciente.Editar(Convert.ToInt32(txtCODIGO.Text), txtNOMBRE.Text.Trim(), dtFecha.Value, "F", txtDatosReferencia.Text, txtobservacion.Text);
                        }
                    }
                    else if (Program.Cambio_Estado_paciente == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {
                            //resp = N_Lista_analisis_laboratorio.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                            resp = Capa_Negocio.N_Ficha_Paciente.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else
                        {
                            //resp = N_Lista_analisis_laboratorio.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                            resp = Capa_Negocio.N_Ficha_Paciente.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }

                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_paciente == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar_paciente = false;
                        }
                        if (Program.isnuevo_paciente == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.isnuevo_paciente = false;
                        }
                        if (Program.Cambio_Estado_paciente == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_paciente = false;

                            cbESTADO.Enabled = true;
                            txtNOMBRE.Enabled = true;
                            txtobservacion.Enabled = true;
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

        private void Frm_Ficha_Paciente_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Refresh();
            Frm_Ficha_Paciente.frm_dgv.Actualizar_dgv();
            if (Program.ismodificar_paciente == true)
            {
                Program.ismodificar_paciente = false;
            }
            else if (Program.isnuevo_paciente == true)
            {
                Program.isnuevo_paciente = false;

            }
            else if (Program.Cambio_Estado_paciente == true)
            {
                Program.Cambio_Estado_paciente = false;
            }
            else if (Program.Consultar_paciente == true)
            {
                Program.Consultar_paciente = false;
            }           
            Instancia = null;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar_paciente == true)
            {
                Program.ismodificar_paciente = false;
            }
            else if (Program.isnuevo_paciente == true)
            {
                Program.isnuevo_paciente = false;

            }
            else if (Program.Cambio_Estado_paciente == true)
            {
                Program.Cambio_Estado_paciente = false;
            }
            else if (Program.Consultar_paciente == true)
            {
                Program.Consultar_paciente = false;
            }

            this.Close();
            Instancia = null;
        }

        private void Frm_Ficha_Paciente_Registrar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
