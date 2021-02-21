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
using Capa_Presentacion;
namespace Capa_Presentacion.Lista_analisis
{
    public partial class Frm_Listar_analisis_laboratorio_eliminar : Form
    {
        public string resp = "";
        #region Get_instancia
        private static Frm_Listar_analisis_laboratorio_eliminar instancia_eliminar;

        public static Frm_Listar_analisis_laboratorio_eliminar Instancia_Eliminar
        {
            get { return instancia_eliminar; }
            set { instancia_eliminar = value; }
        }

        public static Frm_Listar_analisis_laboratorio_eliminar Get_instacnias()
        {
            if (Instancia_Eliminar == null)
            {
                Instancia_Eliminar = new Frm_Listar_analisis_laboratorio_eliminar();
            }
            return Instancia_Eliminar;
        }
        #endregion
        public Frm_Listar_analisis_laboratorio_eliminar()
        {
            InitializeComponent();
        }
        /*****/
        public void Alert(string msg, Messager.FrmAlerta.alertTypeEnum type)
        {
            Messager.FrmAlerta f = new Messager.FrmAlerta();
            f.setAlert(msg, type);
        }
        /*****/
        private void Frm_Listar_analisis_laboratorio_eliminar_Load(object sender, EventArgs e)
        {
            lblTrabajadores.Text = "ELIMINAR";
            if (Program.Eliminar == true) {
                Program.Eliminar = false;
                //"hola a todos como estan todos estamos deguastando una riquisima sopa de la casera en el torno este es un dia ermoso para deguastar un segundo de pollo en la par"
            }
        }

        private void btnCANCELAR_elimi_Click(object sender, EventArgs e)
        {
            if (Program.Eliminar == true) {
                Program.Eliminar = false;
            }
            Instancia_Eliminar = null;
            Close();
        }

        private void btnACEPTAR__elimi_Click(object sender, EventArgs e)
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
                    if (cbESTADO__elimi.Text == "Deshabilitado")
                    {
                        resp = N_Lista_analisis_laboratorio.Eliminar(Convert.ToInt32(txtCODIGO_elimi.Text));
                    MessageBox.Show("Se elimino de forma correcta");                   
                    }
                    else {
                       MessageBox.Show("no se puede");
                    }
                  
                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.Eliminar == true) {
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

        private void Frm_Listar_analisis_laboratorio_eliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Lista_analisis.frm.frm_dgv.Actualizar_dgv();
           //Lista_estudio_por_imagenes.Frm_Lista_estudio_imagen.frm_dgv.Actualizar_dgv();
           
        }
    }
}
