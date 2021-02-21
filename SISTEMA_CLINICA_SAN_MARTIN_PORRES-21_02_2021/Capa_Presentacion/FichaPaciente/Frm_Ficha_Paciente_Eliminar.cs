using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.FichaPaciente
{
    public partial class Frm_Ficha_Paciente_Eliminar : Form
    {
        public Frm_Ficha_Paciente_Eliminar()
        {
            InitializeComponent();
            if (Program.Eliminar_paciente == true)
            {
                lblTrabajadores.Text = "ELIMINAR PACIENTE";
            }
        }
        public string resp = "";

        #region Get_instancia
        private static Frm_Ficha_Paciente_Eliminar instancia;

        public static Frm_Ficha_Paciente_Eliminar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Ficha_Paciente_Eliminar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Ficha_Paciente_Eliminar();
            }
            return Instancia;
        }
        #endregion
        private void Frm_Ficha_Paciente_Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {

            if (Program.Eliminar_paciente == true)
            {
                Program.Eliminar_paciente = false;
            }
            this.Close();
            Instancia = null;
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbESTADO.Text == "Deshabilitado")
                {
                    resp = Capa_Negocio.N_Ficha_Paciente.Eliminar(Convert.ToInt32(txtCODIGO.Text));
                   // MessageBox.Show("Se elimino de forma correcta");
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL REGISTRO");
                }

                ///
                if (resp.Equals("OK"))
                {
                    if (Program.Eliminar_paciente == true)
                    {
                        Program.Eliminar_paciente = false;
                        MessageBox.Show("Se elimino");
                    }

                }
                else
                {
                    //  MessageBox.Show(resp);
                    //   MessageBox.Show("no se pudo Eliminar ");
                }
                Program.Eliminar_paciente = false;
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
      }
    }

