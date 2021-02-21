using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.INTERNACION
{
    public partial class Frm_Internacion_Registrar : Form
    {
        public Frm_Internacion_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo_internacion)
            {
                lblTrabajadores.Text = "REGISTRAR INTERNACIÓN";
            }
             if (Program.Consultar_internacion) {
                lblTrabajadores.Text = "CONSULTAR INTERNACIÓN";
            }
            if (Program.Cambio_Estado_internacion) {
                lblTrabajadores.Text = "CAMBIAR ESTADO INTERNACIÓN";
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {

            if (Program.isnuevo_internacion == true)
            {
                Program.isnuevo_internacion = false;
            }
            else if (Program.ismodificar_internacion == true)
            {
                Program.ismodificar_internacion = false;
            }
            else if (Program.Cambio_Estado_internacion == true)
            {
                Program.Cambio_Estado_internacion = false;
            }
            else if (Program.Consultar_internacion == true) {
                Program.Consultar_internacion = false;
            }
            Instancias = null;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FichaPaciente.Frm_Ficha_Paciente d = new FichaPaciente.Frm_Ficha_Paciente();
            Program.Seleccionar_Paciente = true;
            AddOwnedForm(d);

            d.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            Medico.Frm_Medico d = new Medico.Frm_Medico();
            AddOwnedForm(d);
            d.Show();
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario.Frm_Funcionario d = new Funcionario.Frm_Funcionario();
            AddOwnedForm(d);
            d.Show();
        }
        private bool ValidarCajas()
        {
            bool bandera = true; ;
            if (txtcodigopaciente.Text.Trim() == string.Empty)
            {
                errNOMBRE.SetError(txtcodigopaciente, "Informacion requerida");
                bandera = false;
                txtnombrepaciente.Focus();
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

                    if (Program.isnuevo_internacion == true)
                    {
                        resp = Capa_Negocio.N_INTERNACION.REGISTRAR(dateTimePicker1.Value,Convert.ToInt32(txtcodigomedico.Text),Convert.ToInt32(txtcodigoFuncionario.Text),Convert.ToInt32(txtcodigopaciente.Text),txtdescripcion.Text,"H");
                    }
                    else if (Program.ismodificar_internacion == true)
                    {
                        resp = Capa_Negocio.N_INTERNACION.EDITAR(Convert.ToInt32(TXTCODIGOINTERNACION.Text),dateTimePicker1.Value, Convert.ToInt32(txtcodigomedico.Text), Convert.ToInt32(txtcodigoFuncionario.Text), Convert.ToInt32(txtcodigopaciente.Text), txtdescripcion.Text);
                    }
                    else if (Program.Cambio_Estado_internacion == true)
                    {
                        if (cbestado.Text == "Habilitado")
                        {
                            resp = Capa_Negocio.N_INTERNACION.CAMBIAR_ESTADO(Convert.ToInt32(TXTCODIGOINTERNACION.Text), "H");
                        }
                        else
                        {
                            resp = Capa_Negocio.N_INTERNACION.CAMBIAR_ESTADO(Convert.ToInt32(TXTCODIGOINTERNACION.Text), "D");
                        }
                    }
                    ///                                       
                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_internacion == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar_internacion = false;
                            Instancias = null;
                        }
                        if (Program.isnuevo_internacion == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.isnuevo_internacion = false;
                            Instancias = null;
                        }
                        if (Program.Cambio_Estado_internacion == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_internacion = false;
                            Instancias = null;

                            //cbESTADO.Enabled = true;
                            //txtNOMBRE.Enabled = true;
                            //txtDescripcion.Enabled = true;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_internacion = false;
                    Program.ismodificar_internacion = false;
                    Program.Cambio_Estado_internacion = false;
                   
                    Frm_Internacion_View.frm.Mostrar();
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

        private void Frm_Internacion_Registrar_Load(object sender, EventArgs e)
        {

        }
        #region INSTANCIA

        public static Frm_Internacion_Registrar Instancias
        {
            get
            {
                return instancias;
            }

            set
            {
                instancias = value;
            }
        }

        // string nodos = "";
        private static Frm_Internacion_Registrar instancias;

        public static Frm_Internacion_Registrar Get_instancias()
        {
            if (Instancias == null)
            {
                Instancias = new Frm_Internacion_Registrar();
            }
            return Instancias;
        }


        #endregion
    }
}
