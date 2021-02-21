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
namespace Capa_Presentacion.EVOLUCION_MEDICA
{
    public partial class Frm_EvolucionMedica_Registrar : Form
    {
        public Frm_EvolucionMedica_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo_evolucion == true) {
                lblTrabajadores.Text = "REGISTRAR EVOLUCIÓN MEDICA";
            }
            if (Program.ismodificar_evolucion == true) {
                lblTrabajadores.Text = "EDITAR EVOLUCIÓN MEDICA";
            }
            if (Program.Cambio_Estado_evolucion == true) {
                lblTrabajadores.Text = "CAMBIAR ESTADO EVOLUCIÓN MEDICA";
            }
            if (Program.Consultar_evolucion == true) {
                lblTrabajadores.Text = "CONSULTAR EVOLUCIÓN MEDICA";
            }
        }
        string resp = "";
        private bool ValidarCajas()
        {
            bool bandera = true;
            if (txtcodigointernacion.Text.Trim() == string.Empty)
            {
                errNOMBRE.SetError(txtcodigointernacion, "Informacion requerida");
                bandera = false;
                txtcodigointernacion.Focus();
            }
            else { errNOMBRE.Clear(); }
            return bandera;
        }
        #region Get_instancia
        private static Frm_EvolucionMedica_Registrar instancia;

        public static Frm_EvolucionMedica_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_EvolucionMedica_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_EvolucionMedica_Registrar();
            }
            return Instancia;
        }
        #endregion
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
                    if (Program.isnuevo_evolucion == true)
                    {
                        // resp = N_Lista_analisis_laboratorio.Insertar(txtNOMBRE.Text.Trim(),
                        //   txtDescripcion.Text.Trim(), "H");

                        resp = N_EVOLUCION_MEDICA.REGISTRAR(Convert.ToInt32(txtcodigointernacion.Text), Convert.ToInt32(lblcodigousario.Text), Convert.ToInt32(lblcodigomedico.Text), txtobservacion.Text, "H");
                      
                    }
                    else if (Program.ismodificar_evolucion == true)
                    {
                        //resp = N_Lista_analisis_laboratorio.Editar(Convert.ToInt32(txtCODIGO.Text),
                        //  txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());
                        resp = N_EVOLUCION_MEDICA.Editar(Convert.ToInt32(txtCODIGO.Text), Convert.ToInt32(txtcodigointernacion.Text), Convert.ToInt32(lblcodigousario.Text), Convert.ToInt32(lblcodigomedico.Text), txtobservacion.Text.Trim());
                        
                    }
                    else if (Program.Cambio_Estado_evolucion == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {
                            resp = N_EVOLUCION_MEDICA.Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else {
                            resp = N_EVOLUCION_MEDICA.Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }

                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_evolucion == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar_evolucion = false;
                        }
                        if (Program.isnuevo_evolucion == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.isnuevo_evolucion = false;
                        }
                        if (Program.Cambio_Estado_evolucion == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_evolucion = false;

                            cbESTADO.Enabled = true;
                            txtcodigointernacion.Enabled = true;
                            txtobservacion.Enabled = true;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_evolucion = false;
                    Program.ismodificar_evolucion = false;
                    Program.Cambio_Estado_evolucion = false;
                    Program.Eliminar_evolucion = false;
                    this.Close();
                    Frm_EvolucionMEdica_Mostrar.frm.Actualizar_dgv();

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

        private void button1_Click(object sender, EventArgs e)
        {
            INTERNACION.Frm_Internacion_View d = new INTERNACION.Frm_Internacion_View();
            AddOwnedForm(d);        
            d.Show();
        }

        private void groupBoxDATOS_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_EvolucionMedica_Registrar_Load(object sender, EventArgs e)
        {
            if (Program.isnuevo_evolucion == true) {
                lblcodigousario.Text = Convert.ToString(Program.Id_Usuario);
                txtcodigousuario.Text = Convert.ToString(Program.Nombre_Usuario);
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.Consultar_evolucion == true) {
                Program.Consultar_evolucion = false;
            }
            if (Program.isnuevo_evolucion == true) {
                Program.isnuevo_evolucion = false;
            }
            if (Program.ismodificar_evolucion == true) {
                Program.ismodificar_evolucion = false;
            }
            if (Program.Cambio_Estado_evolucion == true) {
                Program.Cambio_Estado_evolucion = false;
            }
            Instancia = null;
            Close();
        }
    }
}
