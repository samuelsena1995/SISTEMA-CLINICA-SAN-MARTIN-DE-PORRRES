using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Usuario
{
    public partial class Frm_Usuario_Registrar : Form
    {
        string resp = "";
    
        public Frm_Usuario_Registrar()
        {
            InitializeComponent();
            if (Program.isnuevo == true)
            {
                cbestado_Usuario.Visible = false;
                label4.Visible = false;
                lbl.Text = "REGISTRAR";
            }
            if (Program.ismodificar == true)
            {

                lbl.Text = "EDITAR";
            }
            if (Program.Cambio_Estado == true)
            {

                lbl.Text = "CAMBIO DE ESTADO";
            }
            if (Program.Consultar == true)
            {
                button1.Visible = false;
                lbl.Text = "CONSULTAR";
            }


        }
        public static Frm_Usuario_Registrar Instancias
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
        private static Frm_Usuario_Registrar instancias;
            
        public static Frm_Usuario_Registrar Get_instancias()
        {
            if (Instancias == null)
            {
                Instancias = new Frm_Usuario_Registrar();
            }
            return Instancias;
        }

        private bool validar_rol()
        {
            if (txtNombre_Rol.Text != "")
                return true;
            else return false;
        }
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre_Rol.Text == string.Empty)
                {
                    MessageBox.Show("Porfavor relleno datos");
                }
                else
                {
                    //string resp = "";

                    if (Program.isnuevo == true)
                    {

                        // resp = NRoles.registrar(txtNOMBRE_rol.Text, cbESTADO.Text, detalle_rol());
                        resp = Capa_Negocio.N_Permiso.registrar(txtNombre_Rol.Text, txtobservacion.Text, "H", txtUsuario.Text, txtContraseña.Text, detalle_rol());
                    }

                    if (Program.ismodificar == true)
                    {
                        resp = Capa_Negocio.N_Permiso.ELIMINAR(Convert.ToInt32(txtid_roles.Text));
                        resp = Capa_Negocio.N_Permiso.MODIFICAR(Convert.ToInt32(txtid_roles.Text), txtNombre_Rol.Text, txtobservacion.Text, txtUsuario.Text, txtContraseña.Text, detalle_rol());
                    }

                    if (Program.Cambio_Estado == true)
                    {
                        if (cbestado_Usuario.Text == "Deshabilitado")
                        {
                     //       resp = Capa_Negocio.N_Permiso.Cambio_Estado(Convert.ToInt32(txtid_roles.Text), "D");
                        }
                        else {
                       //     resp = Capa_Negocio.N_Permiso.Cambio_Estado(Convert.ToInt32(txtid_roles.Text), "H");
                        }
                     //  resp = NRoles.CambiarEstado_rol(Convert.ToInt32(txtCODIGO_rol.Text), cbESTADO.Text);
                    }

                    if (resp == "ok")
                    {
                        if (Program.isnuevo == true)
                        {
                            MessageBox.Show("se registro de forma correcta.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar_treeview_Cliente();
                         //   this.Limpiar_treeview_Cliente();
                         //  this.Limpiar_treeview_Rol();
                         //  this.Limpiar_treeview_Sucursal();
                         //  this.Limpiar_treeview_Trabajador();
                         // this.Limpiar_treeview_Usuario();

                            // txtNOMBRE_rol.Text = string.Empty;
                            // txtCODIGO_rol.Text = string.Empty;
                            //cbESTADO.Text = "Activo";
                            //dateFECHAREGISTRO.Value = getFechaActual();


                        }
                        if (Program.ismodificar)
                        {
                            MessageBox.Show("se Modifico de forma correcta.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar_treeview_Cliente();
                            //this.Limpiar_treeview_Cliente();
                            //this.Limpiar_treeview_Rol();
                            //this.Limpiar_treeview_Sucursal();
                            //this.Limpiar_treeview_Trabajador();
                            //this.Limpiar_treeview_Usuario();

                            //txtNOMBRE_rol.Text = string.Empty;
                            //txtCODIGO_rol.Text = string.Empty;
                            //cbESTADO.Text = "Activo";
                            //dateFECHAREGISTRO.Value = getFechaActual();


                        }

                        if (Program.Cambio_Estado == true)
                        {
                            MessageBox.Show("Se cambio el estado de forma correcta");

                            //cbESTADO.Enabled = true;
                            //dateFECHAREGISTRO.Enabled = true;
                            //txtNOMBRE_rol.Enabled = true;
                            //groupboxDETALLEROL.Enabled = true;
                        }

                    }
                    else
                    {
                        //MessageBox.Show("ERROR");
                    }

                    Program.isnuevo = false;
                    Program.ismodificar = false;
                    Program.Cambio_Estado = false;

                    this.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }        
        }

        private int[] detalle_rol()
        {
            int[] reg = new int[60];
            int conta = 0;

            /************************************************      Treeview1*/
            if (treePacienteTrabajador.Nodes[0].Nodes[0].Checked == true)
            {
                reg[conta] = 1;//regist
                conta++;
            }
            if (treePacienteTrabajador.Nodes[0].Nodes[1].Checked == true)
            {
                reg[conta] = 2;//editar
                conta++;
            }
            if (treePacienteTrabajador.Nodes[0].Nodes[2].Checked == true)
            {
                reg[conta] = 3;//cam
                conta++;
            }
            if (treePacienteTrabajador.Nodes[0].Nodes[3].Checked == true)
            {
                reg[conta] = 4;//elimi
                conta++;
            }
            if (treePacienteTrabajador.Nodes[0].Nodes[4].Checked == true)
            {
                reg[conta] = 5;//consuñ
                conta++;
            }
            if (treePacienteTrabajador.Nodes[0].Nodes[5].Checked == true)
            {
                reg[conta] = 6;//reporte
                conta++;
            }
            ////FUNCIOANRIO/////////////
            if (treePacienteTrabajador.Nodes[1].Nodes[0].Checked == true)
            {
                reg[conta] = 7;//regist
                conta++;
            }
            if (treePacienteTrabajador.Nodes[1].Nodes[1].Checked == true)
            {
                reg[conta] = 8;//editar
                conta++;
            }
            if (treePacienteTrabajador.Nodes[1].Nodes[2].Checked == true)
            {
                reg[conta] = 9;//cam
                conta++;
            }
            if (treePacienteTrabajador.Nodes[1].Nodes[3].Checked == true)
            {
                reg[conta] = 10;//elimi
                conta++;
            }
            if (treePacienteTrabajador.Nodes[1].Nodes[4].Checked == true)
            {
                reg[conta] = 11;//consuñ
                conta++;
            }
            if (treePacienteTrabajador.Nodes[1].Nodes[5].Checked == true)
            {
                reg[conta] = 12;//reporte
                conta++;
            }
            ////////MEDICO///////
            if (treeMedico_TipoSAla.Nodes[0].Nodes[0].Checked == true)
            {
                reg[conta] = 13;//regist
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[0].Nodes[1].Checked == true)
            {
                reg[conta] = 14;//editar
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[0].Nodes[2].Checked == true)
            {
                reg[conta] = 15;//cam
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[0].Nodes[3].Checked == true)
            {
                reg[conta] = 16;//elimi
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[0].Nodes[4].Checked == true)
            {
                reg[conta] = 17;//consuñ
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[0].Nodes[5].Checked == true)
            {
                reg[conta] = 18;//reporte
                conta++;
            }
            ///////////Tipos sala////
            if (treeMedico_TipoSAla.Nodes[1].Nodes[0].Checked == true)
            {
                reg[conta] = 19;//regist
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[1].Nodes[1].Checked == true)
            {
                reg[conta] = 20;//editar
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[1].Nodes[2].Checked == true)
            {
                reg[conta] = 21;//cam
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[1].Nodes[3].Checked == true)
            {
                reg[conta] = 22;//elimi
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[1].Nodes[4].Checked == true)
            {
                reg[conta] = 23;//consuñ
                conta++;
            }
            if (treeMedico_TipoSAla.Nodes[1].Nodes[5].Checked == true)
            {
                reg[conta] = 24;//reporte
                conta++;
            }
            ////SALA//
            if (tree_SALA_USUARIO.Nodes[0].Nodes[0].Checked == true)
            {
                reg[conta] = 25;//regist
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[0].Nodes[1].Checked == true)
            {
                reg[conta] = 26;//editar
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[0].Nodes[2].Checked == true)
            {
                reg[conta] = 27;//cam
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[0].Nodes[3].Checked == true)
            {
                reg[conta] = 28;//elimi
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[0].Nodes[4].Checked == true)
            {
                reg[conta] = 29;//consuñ
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[0].Nodes[5].Checked == true)
            {
                reg[conta] = 30;//reporte
                conta++;
            }
            ////////USUARIO////
            if (tree_SALA_USUARIO.Nodes[1].Nodes[0].Checked == true)
            {
                reg[conta] = 31;//regist
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[1].Nodes[1].Checked == true)
            {
                reg[conta] = 32;//editar
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[1].Nodes[2].Checked == true)
            {
                reg[conta] = 33;//cam
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[1].Nodes[3].Checked == true)
            {
                reg[conta] = 34;//elimi
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[1].Nodes[4].Checked == true)
            {
                reg[conta] = 45;//consuñ
                conta++;
            }
            if (tree_SALA_USUARIO.Nodes[1].Nodes[5].Checked == true)
            {
                reg[conta] = 36;//reporte
                conta++;
            }
            /*************************************************************************/

            return reg;
        }
        public void limpiar_treeview_Cliente()
        {
            treePacienteTrabajador.Nodes[0].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[0].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[1].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[2].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[3].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[4].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[5].Checked = false;
            //treePacienteTrabajador.Nodes[0].Nodes[6].Checked = false;
        }

        private void Frm_Usuario_Registrar_Load(object sender, EventArgs e)
        {
            treePacienteTrabajador.ExpandAll();
            tree_SALA_USUARIO.ExpandAll();
            treeMedico_TipoSAla.ExpandAll();
        }

        private void Frm_Usuario_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Frm_Pantalla_principal.frm_princiapal.Privilegios();
            //Frm_Usuario.frm_dgv.MostrarRoles();
            Frm_Usuario.frm_dgv.MOSTRAR_USUARIO();
            Instancias = null;
        }
        #region mostrarTreeview
        public void Mostrar_treeview_Paciente()
        {
            treePacienteTrabajador.Nodes[0].Nodes[0].Checked = true;
            treePacienteTrabajador.Nodes[0].Nodes[1].Checked = true;
            treePacienteTrabajador.Nodes[0].Nodes[2].Checked = true;
            treePacienteTrabajador.Nodes[0].Nodes[3].Checked = true;
            treePacienteTrabajador.Nodes[0].Nodes[4].Checked = true;
            treePacienteTrabajador.Nodes[0].Nodes[5].Checked = true;

        }
        public void Mostrar_treeview_Funcionario()
        {
            treePacienteTrabajador.Nodes[1].Nodes[0].Checked = true;
            treePacienteTrabajador.Nodes[1].Nodes[1].Checked = true;
            treePacienteTrabajador.Nodes[1].Nodes[2].Checked = true;
            treePacienteTrabajador.Nodes[1].Nodes[3].Checked = true;
            treePacienteTrabajador.Nodes[1].Nodes[4].Checked = true;
            treePacienteTrabajador.Nodes[1].Nodes[5].Checked = true;

        }
        public void Mostrar_treeview_Medico()
        {
            treeMedico_TipoSAla.Nodes[0].Nodes[0].Checked = true;
            treeMedico_TipoSAla.Nodes[0].Nodes[1].Checked = true;
            treeMedico_TipoSAla.Nodes[0].Nodes[2].Checked = true;
            treeMedico_TipoSAla.Nodes[0].Nodes[3].Checked = true;
            treeMedico_TipoSAla.Nodes[0].Nodes[4].Checked = true;
            treeMedico_TipoSAla.Nodes[0].Nodes[5].Checked = true;

        }
        public void Mostrar_treeview_TipoSala()
        {
            treeMedico_TipoSAla.Nodes[1].Nodes[0].Checked = true;
            treeMedico_TipoSAla.Nodes[1].Nodes[1].Checked = true;
            treeMedico_TipoSAla.Nodes[1].Nodes[2].Checked = true;
            treeMedico_TipoSAla.Nodes[1].Nodes[3].Checked = true;
            treeMedico_TipoSAla.Nodes[1].Nodes[4].Checked = true;
            treeMedico_TipoSAla.Nodes[1].Nodes[5].Checked = true;

        }

        #endregion
        #region  limpiar
        public void Limpiar_treeview_ficha_paciente()
        {
            treePacienteTrabajador.Nodes[0].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[0].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[1].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[2].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[3].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[4].Checked = false;
            treePacienteTrabajador.Nodes[0].Nodes[5].Checked = false;
        }
        public void Limpiar_treeview_funcionaro()
        {
            treePacienteTrabajador.Nodes[1].Checked = false;
            treePacienteTrabajador.Nodes[1].Nodes[0].Checked = false;
            treePacienteTrabajador.Nodes[1].Nodes[1].Checked = false;
            treePacienteTrabajador.Nodes[1].Nodes[2].Checked = false;
            treePacienteTrabajador.Nodes[1].Nodes[3].Checked = false;
            treePacienteTrabajador.Nodes[1].Nodes[4].Checked = false;
            treePacienteTrabajador.Nodes[1].Nodes[5].Checked = false;
        }
        public void Limpiar_treeview_medico()
        {
            treeMedico_TipoSAla.Nodes[0].Checked = false;
            treeMedico_TipoSAla.Nodes[0].Nodes[0].Checked = false;
            treeMedico_TipoSAla.Nodes[0].Nodes[1].Checked = false;
            treeMedico_TipoSAla.Nodes[0].Nodes[2].Checked = false;
            treeMedico_TipoSAla.Nodes[0].Nodes[3].Checked = false;
            treeMedico_TipoSAla.Nodes[0].Nodes[4].Checked = false;
            treeMedico_TipoSAla.Nodes[0].Nodes[5].Checked = false;
        }
        public void Limpiar_treeview_tiposala()
        {
            treeMedico_TipoSAla.Nodes[1].Checked = false;
            treeMedico_TipoSAla.Nodes[1].Nodes[0].Checked = false;
            treeMedico_TipoSAla.Nodes[1].Nodes[1].Checked = false;
            treeMedico_TipoSAla.Nodes[1].Nodes[2].Checked = false;
            treeMedico_TipoSAla.Nodes[1].Nodes[3].Checked = false;
            treeMedico_TipoSAla.Nodes[1].Nodes[4].Checked = false;
            treeMedico_TipoSAla.Nodes[1].Nodes[5].Checked = false;
        }
        #endregion

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (Program.ismodificar == true)
            {
                Program.ismodificar = false;
            }
            else if (Program.isnuevo == true)
            {
                Program.isnuevo = false;

            }
            else if (Program.Consultar == true)
            {
                Program.Consultar = false;
            }
            else if (Program.Cambio_Estado == true){
                Program.Cambio_Estado = false;
            }
            
            this.Close();
            Instancias = null;
        }
        private bool ValidarCajas_USUARIO()
        {
            bool bandera = true; ;
            if (txtNombre_Rol.Text.Trim() == string.Empty)
            {
                errNombreUsuario.SetError(txtNombre_Rol, "Informacion requerida");
                bandera = false;
                txtNombre_Rol.Focus();
            }
            else { txtNombre_Rol.Clear(); }
            if (txtUsuario.Text.Trim() == string.Empty)
            {
                errUsuario.SetError(txtNombre_Rol, "Informacion requerida");
                bandera = false;
                txtUsuario.Focus();
            }
            else { txtUsuario.Clear(); }
            if (txtContraseña.Text.Trim() == string.Empty)
            {
                errContraseña.SetError(txtNombre_Rol, "Informacion requerida");
                bandera = false;
                txtContraseña.Focus();
            }
            else { txtContraseña.Clear(); }
            return bandera;
        }
        private bool ValidarCajas()
        {
            bool bandera = true; ;
            if (txtNombre_Rol.Text.Trim() == string.Empty)
            {
                errNombreUsuario.SetError(txtNombre_Rol, "Informacion requerida");
                bandera = false;
                txtNombre_Rol.Focus();
            }
            else
            {
                errNombreUsuario.Clear();
            }
            if (txtUsuario.Text.Trim() == string.Empty)
            {
                errUsuario.SetError(txtUsuario, "Informacion requerida");
                bandera = false;
                txtUsuario.Focus();
            }
            else
            {
                errUsuario.Clear();
            }
            if (txtContraseña.Text.Trim() == string.Empty)
            {
                errContraseña.SetError(txtContraseña, "Informacion requerida");
                bandera = false;
            }
            else
            {
                errContraseña.Clear();
            }
            return bandera;
        }
        private bool validar_rolM()
        {
            if (txtNombre_Rol.Text != "")
                return true;
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCajas())
                {
                    if (Program.isnuevo == true)
                    {                     
                       // resp = Capa_Negocio.N_Permiso.registrar_usuario(txtNombre_Rol.Text, txtobservacion.Text, "H", txtUsuario.Text, txtContraseña.Text);
                    }
                    else if (Program.ismodificar == true)
                    {
                        //resp = Capa_Negocio.N_Permiso.ELIMINAR(Convert.ToInt32(txtid_roles.Text));
                    //    resp = Capa_Negocio.N_Permiso.MODIFICAR_USUARIO(Convert.ToInt32(txtid_roles.Text), txtNombre_Rol.Text, txtobservacion.Text, txtUsuario.Text, txtContraseña.Text);
                    }
                    else if (Program.Cambio_Estado == true)
                    {
                        if (cbestado_Usuario.Text == "Deshabilitado")
                        {
                       //     resp = Capa_Negocio.N_Permiso.Cambio_Estado(Convert.ToInt32(txtid_roles.Text), "D");
                        }
                        else
                        {
                         //   resp = Capa_Negocio.N_Permiso.Cambio_Estado(Convert.ToInt32(txtid_roles.Text), "H");
                        }
                    }

                    ///
                    if (resp.Equals("OK"))
                    {
                        if (Program.ismodificar == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");
                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            
                            Program.ismodificar = false;
                        }
                        if (Program.isnuevo == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");

                            //this.Alert("Success", Messager.FrmAlerta.alertTypeEnum.Success);
                            Program.isnuevo = false;
                        }
                        if (Program.Cambio_Estado == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado = false;

                            //cbESTADO.Enabled = true;
                            //txtNOMBRE.Enabled = true;
                            txtobservacion.Enabled = true;
                        }
                        if (Program.Consultar == true) {
                            Program.Consultar = false;
                            Instancias = null;
                        }
                    }
                    else
                    {
                        //   MessageBox.Show(resp);
                    }
                    Program.isnuevo = false;
                    Program.ismodificar = false;
                    Program.Consultar = false;
                    Program.Cambio_Estado = false;                   
                    this.Close();
                    Instancias = null;

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

        private void treePacienteTrabajador_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string a = "";
            a = e.Node.Text;
            if (a == "GESTION FICHA PACIENTE")
            {

                if (treePacienteTrabajador.Nodes[0].Checked == true)
                {
                    this.Mostrar_treeview_Paciente();
                }
                else if (treePacienteTrabajador.Nodes[0].Nodes[0].Checked == true || treePacienteTrabajador.Nodes[0].Nodes[1].Checked == true 
                    || treePacienteTrabajador.Nodes[0].Nodes[2].Checked == true || treePacienteTrabajador.Nodes[0].Nodes[3].Checked == true
                    || treePacienteTrabajador.Nodes[0].Nodes[4].Checked == true || treePacienteTrabajador.Nodes[0].Nodes[5].Checked == true)
                {
                    this.Limpiar_treeview_ficha_paciente();
                }
                //else
                //{
                //    this.Mostrar_treeview_Rol();
                //}
            }
            if (a == "GESTION FUNCIONARIO")
            {
                if (treePacienteTrabajador.Nodes[1].Checked == true)
                {
                    this.Mostrar_treeview_Funcionario();
                }
                else if (treePacienteTrabajador.Nodes[1].Nodes[0].Checked == true || treePacienteTrabajador.Nodes[1].Nodes[1].Checked == true
                    || treePacienteTrabajador.Nodes[1].Nodes[2].Checked == true || treePacienteTrabajador.Nodes[1].Nodes[3].Checked == true
                    || treePacienteTrabajador.Nodes[1].Nodes[4].Checked == true || treePacienteTrabajador.Nodes[1].Nodes[5].Checked == true)
                {
                    this.Limpiar_treeview_funcionaro();
                }
                //else
                //{
                //    this.Mostrar_treeview_Cliente();
                //}
            }
        }

        private void treeMedico_TipoSAla_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string a = "";
            a = e.Node.Text;
            if (a == "GESTION MEDICO")
            {

                if (treeMedico_TipoSAla.Nodes[0].Checked == true)
                {
                    this.Mostrar_treeview_Medico();
                }
                else if (treeMedico_TipoSAla.Nodes[0].Nodes[0].Checked == true || treeMedico_TipoSAla.Nodes[0].Nodes[1].Checked == true
                    || treeMedico_TipoSAla.Nodes[0].Nodes[2].Checked == true || treeMedico_TipoSAla.Nodes[0].Nodes[3].Checked == true
                    || treeMedico_TipoSAla.Nodes[0].Nodes[4].Checked == true || treeMedico_TipoSAla.Nodes[0].Nodes[5].Checked == true)
                {
                    this.Limpiar_treeview_medico();
                }
                //else
                //{
                //    this.Mostrar_treeview_Rol();
                //}
            }
            if (a == "GESTION TIPO SALA")
            {
                if (treeMedico_TipoSAla.Nodes[1].Checked == true)
                {
                    this.Mostrar_treeview_TipoSala();
                }
                else if (treeMedico_TipoSAla.Nodes[1].Nodes[0].Checked == true || treeMedico_TipoSAla.Nodes[1].Nodes[1].Checked == true
                    || treeMedico_TipoSAla.Nodes[1].Nodes[2].Checked == true || treeMedico_TipoSAla.Nodes[1].Nodes[3].Checked == true
                    || treeMedico_TipoSAla.Nodes[1].Nodes[4].Checked == true || treeMedico_TipoSAla.Nodes[1].Nodes[5].Checked == true)
                {
                    this.Limpiar_treeview_tiposala();
                }
                //else
                //{
                //    this.Mostrar_treeview_Cliente();
                //}
            }
        }
    }
}
