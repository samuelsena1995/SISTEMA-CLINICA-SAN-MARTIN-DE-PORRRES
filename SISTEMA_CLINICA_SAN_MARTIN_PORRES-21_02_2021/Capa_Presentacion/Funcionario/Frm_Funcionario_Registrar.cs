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
    public partial class Frm_Funcionario_Registrar : Form
    {
        public Frm_Funcionario_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo_funcionario == true)
            {
                lblestado.Visible = false;
                cbESTADO.Visible = false;
                label4.Visible = true;
                txtCODIGO.Enabled = false;
                lblTrabajadores.Text = "REGISTRAR";
            }
            else if (Program.ismodificar_funcionario == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "EDITAR";
            }
            else if (Program.Cambio_Estado_funcionario == true)
            {
                txtcelular.Enabled = false;
                txtocupacion.Enabled = false;
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CAMBIAR ESTADO";
            }
            else if (Program.Eliminar_funcionario == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "ELIMINAR 3";
            }
            else if (Program.Consultar_funcionario == true)
            {
                cbESTADO.Visible = true;
                lblestado.Visible = true;
                lblTrabajadores.Text = "CONSULTAR";
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
            else { errNOMBRE.Clear();
            }
            if (txtocupacion.Text.Trim() == string.Empty)
            {
                errOcupacion.SetError(txtocupacion, "Informacion requerida");
                bandera = false;
                txtNOMBRE.Focus();
            }
            else
            { errOcupacion.Clear();
            }
            if (txtcelular.Text.Trim() == string.Empty)
            {
                errNcelular.SetError(txtcelular, "Informacion requerida");
                bandera = false;
            }
            else {
                errNcelular.Clear();
            }
                return bandera;
        }
        #region Get_instancia
        private static Frm_Funcionario_Registrar instancia;

        public static Frm_Funcionario_Registrar Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public static Frm_Funcionario_Registrar Get_instacnias()
        {
            if (Instancia == null)
            {
                Instancia = new Frm_Funcionario_Registrar();
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
                    if (Program.isnuevo_funcionario == true)
                    {                 
                        resp = Capa_Negocio.N_Funcionario.Insertar(txtNOMBRE.Text.Trim(), txtocupacion.Text.Trim(), txtcelular.Text.Trim(), txtobservacion.Text.Trim(), "H");
                    }
                    else if (Program.ismodificar_funcionario == true)
                    {
                        //resp = N_Lista_analisis_laboratorio.Editar(Convert.ToInt32(txtCODIGO.Text),
                        //  txtNOMBRE.Text.Trim(), txtDescripcion.Text.Trim());
                        resp = Capa_Negocio.N_Funcionario.Editar(Convert.ToInt32(txtCODIGO.Text), txtNOMBRE.Text.Trim(), txtocupacion.Text.Trim(), txtcelular.Text.Trim(), txtobservacion.Text.Trim());
                    }
                    else if (Program.Cambio_Estado_funcionario == true)
                    {
                        if (cbESTADO.Text == "Habilitado")
                        {
                            //resp = N_Lista_analisis_laboratorio.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                            resp = Capa_Negocio.N_Funcionario.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "H");
                        }
                        else
                        {
                            //resp = N_Lista_analisis_laboratorio.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                            resp = Capa_Negocio.N_Funcionario.Cambio_Estado(Convert.ToInt32(txtCODIGO.Text), "D");
                        }
                    }

                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar_funcionario == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.ismodificar_funcionario = false;
                        }
                        if (Program.isnuevo_funcionario == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.isnuevo_funcionario = false;
                        }
                        if (Program.Cambio_Estado_funcionario == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado_funcionario = false;

                            cbESTADO.Enabled = true;
                            txtNOMBRE.Enabled = true;
                            txtobservacion.Enabled = true;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo_funcionario = false;
                    Program.ismodificar_funcionario = false;
                    Program.Cambio_Estado_funcionario = false;
                    Program.Eliminar_funcionario = false;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Funcionario_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Refresh();
            Frm_Funcionario.frm_dgv.Actualizar_dgv();
            if (Program.ismodificar_funcionario == true)
            {
                Program.ismodificar_funcionario = false;
            }
            else if (Program.isnuevo_funcionario == true)
            {
                Program.isnuevo_funcionario = false;

            }
            else if (Program.Cambio_Estado_funcionario == true)
            {
                Program.Cambio_Estado_funcionario = false;
            }
            else if (Program.Eliminar_funcionario == true)
            {
                Program.Eliminar_funcionario = false;
            }           
            Instancia = null;
        }

        private void Frm_Funcionario_Registrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar_funcionario == true)
            {
                Program.ismodificar_funcionario = false;
            }
            else if (Program.isnuevo_funcionario == true)
            {
                Program.isnuevo_funcionario = false;

            }
            else if (Program.Cambio_Estado_funcionario == true)
            {
                Program.Cambio_Estado_funcionario = false;
            }
            else if (Program.Eliminar_funcionario == true)
            {
                Program.Eliminar_funcionario = false;
            }
            this.Close();
            Instancia = null;
        }
    }
}
