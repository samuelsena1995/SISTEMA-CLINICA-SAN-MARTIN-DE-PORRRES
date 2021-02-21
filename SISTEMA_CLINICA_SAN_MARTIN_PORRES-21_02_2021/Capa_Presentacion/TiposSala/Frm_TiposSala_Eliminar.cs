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
using System.Data;
using System.Data.SqlClient;
namespace Capa_Presentacion.TiposSala
{
    public partial class Frm_TiposSala_Eliminar : Form
    {
        string resp = "";
        public Frm_TiposSala_Eliminar()
        {
            InitializeComponent();
            lblTrabajadores.Text = "ELIMINAR";
            if (Program.Eliminar == true)
            {
                Program.Eliminar = false;
                //"hola a todos como estan todos estamos deguastando una riquisima sopa de la casera en el torno este es un dia ermoso para deguastar un segundo de pollo en la par"
            }
        }
        #region Get_instancia
        private static Frm_TiposSala_Eliminar instancia;

        public static Frm_TiposSala_Eliminar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_TiposSala_Eliminar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_TiposSala_Eliminar();
            }
            return Instancia;
        }
        #endregion
        private void Frm_TiposSala_Eliminar_Load(object sender, EventArgs e)
        {

        }
        private bool Exists_Usuario_copiar(string usuarios)
        {
            string consulta = @"select count(*) from SALA where CodigoTipoSala=@codigoTiposala";
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(Capa_Datos.Conexion.Conexion_bd))
            {
                con.Open();
                cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@codigoTiposala", usuarios);
                int conta = Convert.ToInt32(cmd.ExecuteScalar());
                if (conta == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                //return conta == 0;
            }
        }
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>   
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.Eliminar_TipoSala == true)
            {
                Program.Eliminar_TipoSala = false;
            }
            Instancia = null;
            Close();
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {                
                if (cbESTADO.Text == "Deshabilitado")
                {
                    if (Exists_Usuario_copiar(txtCODIGO.Text)) {
                        MessageBox.Show("no se puede eliminar x qu el dato esta en uso");
                    }else
                    {

                        resp = Capa_Negocio.N_TiposSala.Eliminar(Convert.ToInt32(txtCODIGO.Text));
                        MessageBox.Show("Se elimino de forma correcta");
                    }
                    //resp = Capa_Negocio.N_TiposSala.Eliminar(Convert.ToInt32(txtCODIGO.Text));
                    //MessageBox.Show("Se elimino de forma correcta");
                }
                else
                {
                    MessageBox.Show("no se puede");
                }

                ///
                if (resp.Equals("OK"))
                {
                    if (Program.Eliminar_TipoSala == true)
                    {
                        Program.Eliminar_TipoSala = false;
                        MessageBox.Show("Se elimino");
                    }

                }
                else
                {
                }
                Program.Eliminar_TipoSala = false;
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

        private void Frm_TiposSala_Eliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_TiposSala.frm_dgv.Actualizar_dgv();
        }

        private void Frm_TiposSala_Eliminar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
