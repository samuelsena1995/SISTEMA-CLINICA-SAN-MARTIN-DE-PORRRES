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
namespace Capa_Presentacion.ESTUDIO_LABORATORIO
{
    public partial class Frm_EstudioLaboratorio_Registrar : Form
    {
        public Frm_EstudioLaboratorio_Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EVOLUCION_MEDICA.Frm_EvolucionMEdica_Mostrar d = new EVOLUCION_MEDICA.Frm_EvolucionMEdica_Mostrar();
            Program.sekleccionar_evolucionmedica = true;
            AddOwnedForm(d);

            d.Show();
        }
        private bool ValidarCajas()
        {
            bool bandera = true; ;
            if (txtcodigo_evolucion_medica.Text.Trim() == string.Empty)
            {
                errNOMBRE.SetError(txtcodigo_evolucion_medica, "Informacion requerida");
                bandera = false;
                txtNOMBRE.Focus();
            }
            else { errNOMBRE.Clear(); }
            return bandera;
        }
        string resp = "";
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCajas())
                {

                    if (Program.isnuevo_EstudioLaboratorio == true)
                    {
                        resp = N_ESTUDIO_LABORATORIO.Insertar(txtNOMBRE.Text,txtDescripcion.Text,"H",Convert.ToInt32(txtcodigo_evolucion_medica.Text));
                    }
                    else if (Program.ismodificar_EstudioLaboratorio == true)
                    {
                        
                    }
                    else if (Program.Cambio_Estado_internacion == true)
                    {
                        //if (cbestado.Text == "Habilitado")
                        //{
                        //    resp = Capa_Negocio.N_INTERNACION.CAMBIAR_ESTADO(Convert.ToInt32(TXTCODIGOINTERNACION.Text), "H");
                        //}
                        //else
                        //{
                        //    resp = Capa_Negocio.N_INTERNACION.CAMBIAR_ESTADO(Convert.ToInt32(TXTCODIGOINTERNACION.Text), "D");
                        //}
                    }
                    ///                                       
                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_EstudioLaboratorio == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar_internacion = false;
                            Instancia = null;
                        }
                        if (Program.isnuevo_EstudioLaboratorio == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.isnuevo_internacion = false;
                            Instancia = null;
                        }
                        if (Program.Cambio_Estado_EstudioLaboratorio == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_internacion = false;
                            Instancia = null;

                            //cbESTADO.Enabled = true;
                            //txtNOMBRE.Enabled = true;
                            //txtDescripcion.Enabled = true;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_EstudioLaboratorio = false;
                    Program.ismodificar_EstudioLaboratorio = false;
                    Program.Cambio_Estado_EstudioLaboratorio = false;
                    Frm_EstudioLaboratorio_Mostrar.frm.Actualizar_dgv();
                   // Frm_Internacion_View.frm.Mostrar();
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

        private void Frm_EstudioLaboratorio_Registrar_Load(object sender, EventArgs e)
        {

        }
        #region Get_instancia
        private static ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar instancia;

        public static ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Registrar();
            }
            return Instancia;
        }
        #endregion
    }
}
