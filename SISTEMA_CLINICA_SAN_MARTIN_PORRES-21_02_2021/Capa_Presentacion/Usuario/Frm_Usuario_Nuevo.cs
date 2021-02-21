using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Presentacion.Usuario
{
    public partial class Frm_Usuario_Nuevo : Form
    {
        string resp = "";
        public Frm_Usuario_Nuevo()
        {
            InitializeComponent();
            if (Program.isnuevo == true)
            {
                cbestado_Usuario.Visible = false;
                lblestado.Visible = false;
                lbl.Text = "REGISTRAR";
                mostrarID_tabla();
            }
            if (Program.ismodificar == true)
            {
                lblestado.Visible = false;
                cbestado_Usuario.Visible = false;
                lbl.Text = "EDITAR";
            }
            if (Program.Cambio_Estado == true)
            {
                checkBox1.Enabled = false;
                lbl.Text = "CAMBIO DE ESTADO";
            }
            if (Program.Consultar == true)
            {
                checkBox1.Enabled = false;
                txt_codigo_usuario.Enabled = false;
                btnACEPTAR.Visible = false;
                lbl.Text = "CONSULTAR";
            }
        }
        public void mostrarID_tabla()
        {
            string s = "select max(Codigo)as Codigo from Usuarios";
            SqlConnection sqlc;
            using (sqlc = new SqlConnection(Capa_Datos.Conexion.Conexion_bd))
            {
                sqlc.Open();
                SqlCommand cmd = new SqlCommand(s, sqlc);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int i = Convert.ToInt16(dr["Codigo"].ToString());
                txt_codigo_usuario.Text = (i + 1).ToString();
            }
        }

        #region INSTANCIA

        public static Frm_Usuario_Nuevo Instancias
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
        private static Frm_Usuario_Nuevo instancias;

        public static Frm_Usuario_Nuevo Get_instancias()
        {
            if (Instancias == null)
            {
                Instancias = new Frm_Usuario_Nuevo();
            }
            return Instancias;
        }


        #endregion
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
        //DataTable Mao = Capa_Negocio.N_USUARIOS.MostrarRol();
        private bool Exists(string usuarios)
        {
            string consulta = @"select count(*) from USUARIOS where Usuario=@usuarios;";
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(Capa_Datos.Conexion.Conexion_bd))
            {
                con.Open();
                cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@usuarios", usuarios);                
                int conta = Convert.ToInt32(cmd.ExecuteScalar());
                return conta == 0;
            }
        }
        private bool Exists_Usuario_copiar(string usuarios)
        {
            string consulta = @"select count(*) from usuarios where Usuario=@CodigoUsuario";
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(Capa_Datos.Conexion.Conexion_bd))
            {
                con.Open();
                cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@CodigoUsuario", usuarios);
                int conta = Convert.ToInt32(cmd.ExecuteScalar());
                if (conta == 0)
                {
                    return false;
                }
                else {
                    return true;
                }
                //return conta == 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                if (ValidarCajas())
                {
                    if (Program.isnuevo == true)
                    {
                        if (Exists(txt_usuario.Text) == true)
                        {
                            if (TXTCOPIA_USUARIO.Text!=string.Empty)
                            {
                                if (Exists_Usuario_copiar(TXTCOPIA_USUARIO.Text))
                                {
                                    resp = Capa_Negocio.N_USUARIOS.registrar_usuario_nuevo(txt_codigo_usuario.Text, txtNombre_Rol.Text, txtobservacion.Text, "H", txtContraseña.Text,txt_usuario.Text);
                                    resp = Capa_Negocio.N_USUARIOS.COPIAR_ASIGNACIONPERMISO_NUEVO_USUARIO(txt_codigo_usuario.Text, TXTCOPIA_USUARIO.Text);
                                 }
                                else
                                {
                                MessageBox.Show("EL CODIGO DEL USUARIO NO EXISTE", ".:SISTEMA:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 }
                        }
                            else
                            {
                                //va saltar si no esta en true el che                                
                                resp = Capa_Negocio.N_USUARIOS.registrar_usuario_nuevo(txt_codigo_usuario.Text, txtNombre_Rol.Text, txtobservacion.Text, "H", txtContraseña.Text,txt_usuario.Text);
                            }                            
                        }else
                        {
                            MessageBox.Show("usuario ya existe");
                        }
                    }
                    else if (Program.ismodificar == true)
                    {
                        if (TXTCOPIA_USUARIO.Text != string.Empty)
                        {
                            if (Exists_Usuario_copiar(TXTCOPIA_USUARIO.Text)){
                                
                                resp = Capa_Negocio.N_USUARIOS.MODIFICAR_USUARIO(txt_codigo_usuario.Text, txtNombre_Rol.Text, txtobservacion.Text, txtContraseña.Text,txt_usuario.Text);
                                resp = Capa_Negocio.N_USUARIOS.COPIAR_ASIGNACIONPERMISO_NUEVO_USUARIO(txt_codigo_usuario.Text, TXTCOPIA_USUARIO.Text);
                            } else {
                               MessageBox.Show("EL CODIGO DEL USUARIO NO EXISTE", ".:SISTEMA:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }                            
                        }
                        else {
                            resp = Capa_Negocio.N_USUARIOS.MODIFICAR_USUARIO(txt_codigo_usuario.Text, txtNombre_Rol.Text, txtobservacion.Text,txtContraseña.Text,txt_usuario.Text);
                        }
                        
                    }
                    else if (Program.Cambio_Estado == true)
                    {
                        if (cbestado_Usuario.Text == "Deshabilitado")
                        {
                            resp = Capa_Negocio.N_USUARIOS.Cambio_Estado_USUARIOS(txt_codigo_usuario.Text, "D");
                        }
                        else
                        {
                            resp = Capa_Negocio.N_USUARIOS.Cambio_Estado_USUARIOS(txt_codigo_usuario.Text, "H");
                        }
                    }                    
                    if (resp.Equals("OK"))
                    {
                        resp = Capa_Negocio.N_USUARIOS.EditaR_Audi(Convert.ToString(Program.Id_Usuario), Program.IP_PC(), Program.Nombre_Usuario);
                        if (Program.ismodificar == true)
                        {
                            MessageBox.Show("Se Editado Correcatmente", ".:Sistema Clinico:.");                                                    
                            Program.ismodificar = false;
                        }
                        if (Program.isnuevo == true)
                        {
                            MessageBox.Show("Se inserto de forma correcta", ".:Sistema Clinico:.");                           
                            Program.isnuevo = false;
                        }
                        if (Program.Cambio_Estado == true)
                        {
                            MessageBox.Show("Se cambio el estado correctamente", ".:Sistema Clinico:.");
                            Program.Cambio_Estado = false;                           
                            txtobservacion.Enabled = true;
                        }
                        if (Program.Consultar == true)
                        {
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
            else if (Program.Cambio_Estado == true)
            {
                Program.Cambio_Estado = false;
            }

            this.Close();
            Instancias = null;
        }

        private void Frm_Usuario_Nuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Refresh();
            Frm_Usuario.frm_dgv.MOSTRAR_USUARIO();

            Instancias = null;
        }                    
        private void Frm_Usuario_Nuevo_Load(object sender, EventArgs e)
        {
            //txtContraseña.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                TXTCOPIA_USUARIO.Enabled = true;
            }else
            {
                TXTCOPIA_USUARIO.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
