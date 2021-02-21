using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Lista_estudio_por_imagenes
{
    public partial class Frm_Lista_estudio_por_imagen_eliminar : Form
    {
        public Frm_Lista_estudio_por_imagen_eliminar()
        {
            InitializeComponent();
        }
        #region Get_instancia
        private static Frm_Lista_estudio_por_imagen_eliminar instancia_eliminar;

        public static Frm_Lista_estudio_por_imagen_eliminar Instancia_eliminar
        {
            get { return instancia_eliminar; }
            set { instancia_eliminar = value; }
        }

        public static Frm_Lista_estudio_por_imagen_eliminar Get_instacniasElimi()
        {
            if (Instancia_eliminar == null)
            {
                Instancia_eliminar = new Frm_Lista_estudio_por_imagen_eliminar();
            }
            return Instancia_eliminar;
        }
        #endregion
        private void Frm_Lista_estudio_por_imagen_eliminar_Load(object sender, EventArgs e)
        {
            lblTrabajadores.Text = "ELIMINAR";
            if (Program.Eliminar == true)
            {
                Program.Eliminar = false;
                //"hola a todos como estan todos estamos deguastando una riquisima sopa de la casera en el torno este es un dia ermoso para deguastar un segundo de pollo en la par"
            }
        }

        private void txtNOMBRE_Leave(object sender, EventArgs e)
        {
            if (txtNOMBRE.Text == "")
            {
                txtNOMBRE.Text = "Introduce el nombre";
                txtNOMBRE.ForeColor = Color.Gray;
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.Eliminar == true)
            {
                Program.Eliminar = false;
            }
            Instancia_eliminar = null;
            Close();
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Lista_estudio_por_imagen_eliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Lista_estudio_imagen.frm_dgv.Actualizar_dgv();
        }
    }
}
