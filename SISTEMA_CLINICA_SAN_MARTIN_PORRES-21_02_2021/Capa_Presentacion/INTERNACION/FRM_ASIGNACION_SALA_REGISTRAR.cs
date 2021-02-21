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
    public partial class FRM_ASIGNACION_SALA_REGISTRAR : Form
    {
        public FRM_ASIGNACION_SALA_REGISTRAR()
        {
            InitializeComponent();
            if (Program.Consultar_ASIGNACION_SALA==true) {
                lblTrabajadores.Text = "CONSULTAR ASIGNACION SALA";
            }
            if (Program.isnuevo_ASIGNACION_SALA == true) {
                lblTrabajadores.Text = "REGISTRAR ASIGNACION DE SALA";
            }
        }
        private bool ValidarCajas()
        {
            bool bandera = true; ;
            if (txtNombreSala.Text.Trim() == string.Empty)
            {
                errCodigoSala.SetError(txtNombreSala, "Informacion requerida");
                bandera = false;
                btnBuscarSala.Focus();
            }
            else { errNOMBREPaciente.Clear(); }
            return bandera;
        }
        string resp = "";

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCajas())
                {

                    if (Program.isnuevo_ASIGNACION_SALA == true)
                    {
                        resp = Capa_Negocio.N_ASIGNACION_SALA.REGISTRAR(dtFechaAsignacionSala.Value, Convert.ToInt32(lblCodigoSala.Text), Convert.ToInt32(txtcodigoInternacion.Text),"H");
                    }
                    else if (Program.ismodificar_ASIGNACION_SALA == true)
                    {
                        //   resp = N_Lista_analisis_laboratorio.Editar(Convert.ToInt32(txtCODIGO.Text),
                        //     txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());
                        //resp = Capa_Negocio.N_TiposSala.Editar(Convert.ToInt32(txtCODIGO.Text),
                        //     txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    else if (Program.Cambio_Estado_ASIGNACION_SALA == true)
                    {
                        //if (cbESTADO.Text == "Habilitado")
                        //{
                        //    resp = Capa_Negocio.N_TiposSala.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        //}
                        //else
                        //{
                        //    resp = Capa_Negocio.N_TiposSala.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        //}
                    }
                    ///                                       
                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_ASIGNACION_SALA == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar_ASIGNACION_SALA = false;
                        }
                        if (Program.isnuevo_ASIGNACION_SALA == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Instancia = null;
                            Program.isnuevo_ASIGNACION_SALA = false;
                        }
                        if (Program.Cambio_Estado_ASIGNACION_SALA == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_ASIGNACION_SALA = false;

                            //cbESTADO.Enabled = true;
                            //txtNOMBRE.Enabled = true;
                            //txtDescripcion.Enabled = true;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_ASIGNACION_SALA = false;
                    Program.ismodificar_ASIGNACION_SALA = false;
                    Program.Cambio_Estado_ASIGNACION_SALA = false;
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
        #region Get_instancia
        private static FRM_ASIGNACION_SALA_REGISTRAR instancia;

        public static FRM_ASIGNACION_SALA_REGISTRAR Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static FRM_ASIGNACION_SALA_REGISTRAR Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new FRM_ASIGNACION_SALA_REGISTRAR();
            }
            return Instancia;
        }
        #endregion

        private void btnBuscarSala_Click(object sender, EventArgs e)
        {
            SALA.FrmSala d = new SALA.FrmSala();
            Program.Seleccionar_Sala = true;
            AddOwnedForm(d);

            d.Show();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            
            if (Program.isnuevo_ASIGNACION_SALA == true) {
                Program.isnuevo_ASIGNACION_SALA = false;
            }
            if (Program.Consultar_ASIGNACION_SALA == true) {
                Program.Consultar_ASIGNACION_SALA = false;
            }
            Instancia = null;
            Close();
        }

        private void FRM_ASIGNACION_SALA_REGISTRAR_Load(object sender, EventArgs e)
        {

        }
    }
}
