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
    public partial class Frm_Medico_Eliminar : Form
    {
        public Frm_Medico_Eliminar()
        {
            InitializeComponent();
            if (Program.Eliminar_medico == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "ELIMINAR";
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
        private static Frm_Medico_Eliminar instancia;

        public static Frm_Medico_Eliminar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Medico_Eliminar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Medico_Eliminar();
            }
            return Instancia;
        }
        #endregion
        private void Frm_Medico_Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {
                /* if (txtNOMBRE.Text == string.Empty || txtDescripcion.Text == string.Empty) {
                     MessageBox.Show("Error: Ingres los campos obligatorios");
                 }*/
                //  MessageBox.Show("Error: Ingres los campos obligatorios");
                //}
                //else
                //{
                if (cbESTADO.Text == "Deshabilitado")
                {
                    resp = Capa_Negocio.N_Medico.Eliminar(Convert.ToInt32(txtCODIGO.Text));
                    MessageBox.Show("Se elimino de forma correcta");
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }

                ///
                if (resp.Equals("OK"))
                {
                    if (Program.Eliminar_medico == true)
                    {
                        Program.Eliminar_medico = false;
                        MessageBox.Show("Se elimino");
                    }
                }
                else
                {     
                }
                Program.Eliminar_medico = false;
                this.Close();
                //  else {
                //    MessageBox.Show(resp);
                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Medico_Eliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Medico.frm_dgv.Actualizar_dgv();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            
            if (Program.Eliminar_medico == true)
            {
                Program.Eliminar_medico = false;
            }
            this.Close();
            Instancia = null;
        }
    }
    }

