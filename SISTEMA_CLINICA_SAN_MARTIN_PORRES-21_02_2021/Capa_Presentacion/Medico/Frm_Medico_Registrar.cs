using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Medico
{
    public partial class Frm_Medico_Registrar : Form
    {
        public Frm_Medico_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo_medico == true)
            {
                lblestado.Visible = false;
                cbESTADO.Visible = false;
                label4.Visible = true;
                txtCODIGO.Enabled = false;
                lblTrabajadores.Text = "REGISTRAR";
            }
            else if (Program.ismodificar_medico == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "EDITAR";
            }
            else if (Program.Cambio_Estado_medico == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CAMBIAR ESTADO";
            }            
            else if (Program.Consultar_medico == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CONSULTAR";
            }
        }
        public string resp = "";
        private bool ValidarCajas()
        {
            bool bandera = true; ;
            if (txtNOMBRE.Text.Trim() == string.Empty)
            {
                errNOMBRE.SetError(txtNOMBRE, "Informacion requerida");
                bandera = false;
                txtNOMBRE.Focus();
            }
            else
            {
                errNOMBRE.Clear();
            }
            if (txtocupacion.Text.Trim() == string.Empty)
            {
                errOcupacion.SetError(txtocupacion, "Informacion requerida");
                bandera = false;
                txtNOMBRE.Focus();
            }
            else
            {
                errOcupacion.Clear();
            }
            if (txtcelular.Text.Trim() == string.Empty)
            {
                errCelular.SetError(txtcelular, "Informacion requerida");
                bandera = false;
            }
            else
            {
                errCelular.Clear();
            }
            return bandera;
        }
        #region Get_instancia
        private static Frm_Medico_Registrar instancia;

        public static Frm_Medico_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Medico_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Medico_Registrar();
            }
            return Instancia;
        }
        #endregion
        private void Frm_Medico_Registrar_Load(object sender, EventArgs e)
        {

        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCajas())
                {
                    if (Program.isnuevo_medico == true)
                    {
                        resp = Capa_Negocio.N_Medico.Insertar(txtNOMBRE.Text.Trim(), txtocupacion.Text.Trim(), txtcelular.Text.Trim(), txtobservacion.Text.Trim(), "H");
                    }
                    else if (Program.ismodificar_medico == true)
                    {
                        resp = Capa_Negocio.N_Medico.Editar(Convert.ToInt32(txtCODIGO.Text), txtNOMBRE.Text.Trim(), txtocupacion.Text.Trim(), txtcelular.Text.Trim(), txtobservacion.Text.Trim());
                    }
                    else if (Program.Cambio_Estado_medico == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {                            
                            resp = Capa_Negocio.N_Medico.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else
                        {                         
                            resp = Capa_Negocio.N_Medico.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }

                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_medico == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");                            
                            Program.ismodificar_medico = false;
                        }
                        if (Program.isnuevo_medico == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");                            
                            Program.isnuevo_medico = false;
                        }
                        if (Program.Cambio_Estado_medico == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_medico = false;

                            cbESTADO.Enabled = true;
                            txtNOMBRE.Enabled = true;
                            txtobservacion.Enabled = true;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_medico = false;
                    Program.ismodificar_medico = false;
                    Program.Cambio_Estado_medico = false;
                    Program.Eliminar_medico = false;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Medico_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {           
            Frm_Medico.frm_dgv.Actualizar_dgv();
            if (Program.ismodificar_medico == true)
            {
                Program.ismodificar_medico = false;
            }
            else if (Program.isnuevo_medico == true)
            {
                Program.isnuevo_medico = false;

            }
            else if (Program.Cambio_Estado_medico == true)
            {
                Program.Cambio_Estado_medico = false;
            }
            else if (Program.Eliminar_medico == true)
            {
                Program.Eliminar_medico = false;
            }
          
            Instancia = null;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar_medico == true)
            {
                Program.ismodificar_medico = false;
            }
            else if (Program.isnuevo_medico == true)
            {
                Program.isnuevo_medico = false;

            }
            else if (Program.Cambio_Estado_medico == true)
            {
                Program.Cambio_Estado_medico = false;
            }
            else if (Program.Eliminar_medico == true)
            {
                Program.Eliminar_medico = false;
            }
            this.Close();
            Instancia = null;
        }
    }
}
