using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_INICIO_SESION : Form
    {
        Capa_Negocio.N_USUARIOS obj = new Capa_Negocio.N_USUARIOS();

        public Frm_INICIO_SESION()
        {
            InitializeComponent();
        }
     
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            obj.pas_word(txtUsuario.Text, txtPassword.Text, lbldesencriptacion);
            Program.PASSWORD_DESENCRIPTAR = Capa_Negocio.N_USUARIOS.Desencriptar(lbldesencriptacion.Text);
            DataTable Datos = Capa_Negocio.N_Permiso.Login(txtUsuario.Text, txtPassword.Text);

            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("COMPLETE LOS CAMPOS ", "SISTEMA RGJ GETSEMANI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (Datos.Rows.Count == 0)
            {
                MessageBox.Show(Program.PASSWORD_DESENCRIPTAR);
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTOS", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPassword.Text = "";
                txtUsuario.Text = "";
                
            }
            else
            {
                if (Datos.Rows[0][5].ToString() == "H")
                {
                    ///para sacar la contraseña y pasar al label
                  
                    //
                    
                        Frm_Pantalla_principal frm = new Frm_Pantalla_principal();

                        Program.Id_Usuario = Convert.ToInt32(Datos.Rows[0][0].ToString());
                        Program.Nombre_Usuario = Datos.Rows[0][1].ToString();
                        Program.Id_Rol = Convert.ToInt32(Datos.Rows[0][4].ToString());
                    //Program.Nombre_Cargo = Datos.Rows[0][4].ToString();
                    //Program.Nombre_Trabajador = Datos.Rows[0][5].ToString();

                  

                        frm.Show();
                        this.Hide();
                                      
                }
                else
                {
                    MessageBox.Show(" EL USUARIO  " + Datos.Rows[0][1].ToString() + " SE DIO DE BAJA EN EL SISTEMA ?", ".: SISTEMA :.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("Mensaje informativo con boton Aceptar", "Ejemplo Mensaje Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }
        private void lblSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
             Program.Datos = Capa_Negocio.N_USUARIOS.INICIO_SESION_NUEVO(txtUsuario.Text, txtPassword.Text);
                    
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("COMPLETE LOS CAMPOS ", "SISTEMA RGJ GETSEMANI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Datos.Rows.Count == 0)
            {
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTOS O NO TIENE PERMISOS ASIGNADO A ESTE USUARIO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                if (Program.Datos.Rows[0][4].ToString() == "H")
                {
                    Frm_Pantalla_principal frm =  Frm_Pantalla_principal.Get_instancias();
                    Program.Id_Usuario = Convert.ToInt32(Program.Datos.Rows[0][0].ToString());
                    Program.ID_USUARIO_2 = Program.Datos.Rows[0][5].ToString();
                    Program.CONTRASEÑA_USUARIO = Program.Datos.Rows[0][1].ToString();
                    Program.Nombre_Usuario = Program.Datos.Rows[0][2].ToString();                    
                    frm.txtsami.Text = Program.ID_USUARIO_2;
                    frm.lblsam.Text = Program.Datos.Rows[0][0].ToString();      
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" EL USUARIO  " + Program.Datos.Rows[0][2].ToString() + " SE DIO DE BAJA EN EL SISTEMA ?", ".: SISTEMA :.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se uardo de form", "Sistema",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
       }

        private void Frm_INICIO_SESION_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
