using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Funcionario
{
    public partial class Frm_Funcionario_Eliminar : Form
    {
        public Frm_Funcionario_Eliminar()
        {
            InitializeComponent();
        }

        private void Frm_Funcionario_Eliminar_Load(object sender, EventArgs e)
        {
            lblTrabajadores.Text = "ELIMINAR";
            if (Program.Eliminar == true)
            {
                Program.Eliminar = false;
                //"hola a todos como estan todos estamos deguastando una riquisima sopa de la casera en el torno este es un dia ermoso para deguastar un segundo de pollo en la par"
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
                errNcelular.SetError(txtcelular, "Informacion requerida");
                bandera = false;
            }
            else
            {
                errNcelular.Clear();
            }
            return bandera;
        }
        #region Get_instancia
        private static Frm_Funcionario_Eliminar instancia;

        public static Frm_Funcionario_Eliminar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Funcionario_Eliminar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Funcionario_Eliminar();
            }
            return Instancia;
        }
        #endregion

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
                    resp = Capa_Negocio.N_Funcionario.Eliminar(Convert.ToInt32(txtCODIGO.Text));
                    MessageBox.Show("Se elimino de forma correcta");
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }

                ///
                if (resp.Equals("OK"))
                {
                    if (Program.Eliminar == true)
                    {
                        Program.Eliminar = false;
                        MessageBox.Show("Se elimino");
                    }

                }
                else
                {
                    //  MessageBox.Show(resp);
                    //   MessageBox.Show("no se pudo Eliminar ");
                }
                Program.Eliminar = false;
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

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.Eliminar == true)
            {
                Program.Eliminar = false;
            }
            Instancia = null;
            Close();
        }

        private void Frm_Funcionario_Eliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Frm_Funcionario.frm_dgv.Actualizar_dgv();
        }
    }
}
