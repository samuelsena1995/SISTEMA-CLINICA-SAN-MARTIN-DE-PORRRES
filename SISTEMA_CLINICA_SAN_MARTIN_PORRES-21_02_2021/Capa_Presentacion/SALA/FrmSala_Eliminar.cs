using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.SALA
{
    public partial class FrmSala_Eliminar : Form
    {
        public string resp = "";
        public FrmSala_Eliminar()
        {
            InitializeComponent();
            if (Program.Eliminar_Sala) {
                lblTrabajadores.Text = "ELIMINAR";
            }
        }

        private void FrmSala_Eliminar_Load(object sender, EventArgs e)
        {

        }
        #region Get_instancia
        private static FrmSala_Eliminar instancia;

        public static FrmSala_Eliminar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static FrmSala_Eliminar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new FrmSala_Eliminar();
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
                    resp = Capa_Negocio.N_Sala.Eliminar(Convert.ToInt32(txtCODIGO.Text));
                   // MessageBox.Show("Se elimino de forma correcta");
                }
                else
                {
                    MessageBox.Show("no se puede");
                }

                ///
                if (resp.Equals("OK"))
                {
                    if (Program.Eliminar_Sala == true)
                    {
                        Program.Eliminar_Sala = false;
                        MessageBox.Show("Se elimino de forma correcta");
                    }

                }
                else
                {
                }
                Program.Eliminar_Sala = false;
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

        private void FrmSala_Eliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmSala.frm_dgv.Actualizar_dgv();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.Eliminar_Sala == true) {
                Program.Eliminar_Sala = false;
            }

            Instancia = null;
            this.Close();
        }
    }
}
