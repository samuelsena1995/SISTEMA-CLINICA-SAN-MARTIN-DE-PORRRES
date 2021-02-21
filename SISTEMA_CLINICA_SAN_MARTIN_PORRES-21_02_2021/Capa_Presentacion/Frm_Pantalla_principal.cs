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
using System.Data.SqlClient;
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Frm_Pantalla_principal : Form
    {
        public static Frm_Pantalla_principal frm_princiapal;
       public static string sam;
        public Frm_Pantalla_principal()
        {
            frm_princiapal = this;
            InitializeComponent();
            ID_USUARIOS.Text = Program.ID_USUARIO;
            frm_princiapal = this;
            treeView1.ExpandAll();
            PRIVILEGIOS_MIO();
            MOSTRAR_Id_Permiso_Pantalla_principal();
            Refresh();   
        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>    
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            // this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show("Estoy seleccionando " + treeView1.SelectedNode);           
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string datos = "";
            datos = e.Node.Text;
            if (datos == "LISTA DE ANALISIS DE LABORATORIO")
            {
                //new Frm_Lista_analisis_laboratorio().Show();
                //se localiza el formulario buscandolo entre los forms abiertos 
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Lista_analisis_laboratorio);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }

                //sino existe la instancia se crea una nueva
                frm = new Frm_Lista_analisis_laboratorio();
                frm.Show();
            }
            else if (datos == "LISTA DE ESTUDIOS POR IMAGENES")
            {
                // new Lista_estudio_por_imagenes.Frm_Lista_estudio_imagen().Show();

            }
            else if (datos == "TIPOS DE SALA")
            {
                //  new TiposSala.Frm_TiposSala().Show();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TiposSala.Frm_TiposSala);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }

                //sino existe la instancia se crea una nueva
                frm = new TiposSala.Frm_TiposSala();
                frm.Show();
            }
            else if (datos == "FUNCIONARIOS") {
                new Funcionario.Frm_Funcionario().Show();
            }
            else if (datos == "MÉDICO")
            {
                //  new Medico.Frm_Medico().Show();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Medico.Frm_Medico);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }

                //sino existe la instancia se crea una nueva
                frm = new Medico.Frm_Medico();
                frm.Show();
            }
            else if (datos == "FICHA PACIENTE")
            {
                //new FichaPaciente.Frm_Ficha_Paciente().Show();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FichaPaciente.Frm_Ficha_Paciente);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }

                //sino existe la instancia se crea una nueva
                frm = new FichaPaciente.Frm_Ficha_Paciente();
                frm.Show();
            }
            else if (datos == "USUARIOS")
            {
                //new FichaPaciente.Frm_Ficha_Paciente().Show();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Usuario.Frm_Usuario);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }

                //sino existe la instancia se crea una nueva
                frm = new Usuario.Frm_Usuario();
                frm.Show();
            }
            else if (datos == "SALAS")
            {
                //new FichaPaciente.Frm_Ficha_Paciente().Show();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is SALA.FrmSala);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }

                //sino existe la instancia se crea una nueva
                frm = new SALA.FrmSala();
                frm.Show();
            }
            else if (datos == "HOLA ELVIA")
            {
                //new FichaPaciente.Frm_Ficha_Paciente().Show();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is SALA.FrmSala);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }

                //sino existe la instancia se crea una nueva
                frm = new SALA.FrmSala();
                frm.Show();
            }


        }

        private void Frm_Pantalla_principal_Load(object sender, EventArgs e)
        {
            MOSTRAR_Id_Permiso_Pantalla_principal();
            PRIVILEGIOS_MIO();
            toolStripLabel1USUARIO.Text = "Usuario : " + Program.Nombre_Usuario;
            CenterToScreen();
            //cargarTreview(Program.ID_USUARIO_2, Program.CONTRASEÑA_USUARIO,treeView1);

        }
        
        private void internacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       


        /*public void Privilegios()
        {
            Program.resultado_funcion = Capa_Negocio.N_Permiso.login_funcion(Convert.ToInt32(Program.Id_Usuario));
            foreach (int idServ in Program.resultado_funcion)
            {

                if (idServ > 0 && idServ <= 6)
                {
                    Program.Tiene_Ficha_paciente++;
                    if (Program.Tiene_Ficha_paciente == 6 || (Program.Tiene_Ficha_paciente > 0 && Program.Tiene_Ficha_paciente < 7))
                    {

                        internacionToolStripMenuItem.Enabled = true;
                        if (internacionToolStripMenuItem.Enabled == true) {
                            pACIENTEToolStripMenuItem.Enabled = true;
                        }
                        Program.Tiene_Ficha_paciente = 0;
                    }
                }
                else if (idServ > 6 && idServ <= 12)
                {

                    Program.Tiene_Funcionnes++;
                    if (Program.Tiene_Funcionnes == 6 || (Program.Tiene_Funcionnes > 0 && Program.Tiene_Funcionnes < 7))
                    {
                        parametrosYConfiguracionToolStripMenuItem.Enabled = true;
                        if (parametrosYConfiguracionToolStripMenuItem.Enabled == true)
                        {
                            fUNCIONARIOSToolStripMenuItem.Enabled = true;
                        }
                        Program.Tiene_Funcionnes = 0;
                    }
                }
                else if (idServ > 13 && idServ <= 18)
                {

                    Program.Tiene_Medico++;
                    if (Program.Tiene_Medico == 6 || (Program.Tiene_Medico > 0 && Program.Tiene_Medico < 7))
                    {
                        parametrosYConfiguracionToolStripMenuItem.Enabled = true;
                        if (parametrosYConfiguracionToolStripMenuItem.Enabled == true)
                        {
                            medicoToolStripMenuItem.Enabled = true;
                        }
                        Program.Tiene_Medico = 0;
                    }
                }
                else if (idServ > 19 && idServ <= 24)
                {

                    Program.Tiene_Tiposala++;
                    if (Program.Tiene_Tiposala == 6 || (Program.Tiene_Tiposala > 0 && Program.Tiene_Tiposala < 7))
                    {
                        parametrosYConfiguracionToolStripMenuItem.Enabled = true;
                        if (parametrosYConfiguracionToolStripMenuItem.Enabled == true)
                        {
                            tIPOSDESALAToolStripMenuItem.Enabled = true;
                        }
                        Program.Tiene_Tiposala = 0;
                    }
                }
                else if (idServ > 25 && idServ <= 30)
                {

                    Program.Tiene_Sala++;
                    if (Program.Tiene_Sala == 6 || (Program.Tiene_Sala > 0 && Program.Tiene_Sala < 7))
                    {

                        parametrosYConfiguracionToolStripMenuItem.Enabled = true;
                        if (parametrosYConfiguracionToolStripMenuItem.Enabled == true)
                        {
                            sala.Enabled = true;

                        }

                        Program.Tiene_Sala = 0;
                    }
                }
                else if (idServ > 31 && idServ <= 36)
                {

                    Program.Tiene_Usuario++;
                    if (Program.Tiene_Usuario == 6 || (Program.Tiene_Usuario > 0 && Program.Tiene_Usuario < 7))
                    {
                        administracionToolStripMenuItem.Enabled = true;
                        if (administracionToolStripMenuItem.Enabled == true)
                        {
                            uSUARIOSToolStripMenuItem.Enabled = true;
                        }
                        Program.Tiene_Usuario = 0;
                    }
                }
                if (Program.Menu_Principal == 0)
                {

                }
                else if (Program.Menu_Principal == 1)
                {
                    // menuStrip1.Enabled = true;
                }
            }
        }*/

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea salir del sistema?", "SISTEMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                 this.Close();
                //Application.Exit();
               new Frm_INICIO_SESION().Show();
            }
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rEPORTESPARACONTROLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //treeView1.Nodes[0].Nodes[0].Remove();
            //treeView1.Nodes[0].Nodes.RemoveAt(0);
            treeView1.Nodes[0].Nodes.Add("USUARIOS");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Nodes.Add("HOLA ELVIA");
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_EnabledChanged(object sender, EventArgs e)
        {

        }
        private void pACIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FichaPaciente.Frm_Ficha_Paciente);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new FichaPaciente.Frm_Ficha_Paciente();
            frm.Show();
        }

        private void internacionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void sALASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is SALA.FrmSala);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new SALA.FrmSala();
            frm.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Usuario.Frm_Usuario);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new Usuario.Frm_Usuario();
            frm.Show();
        }

        private void cARGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Medico.Frm_Medico);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new Medico.Frm_Medico();
            frm.Show();
        }
        private void tIPOSDESALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TiposSala.Frm_TiposSala);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new TiposSala.Frm_TiposSala();
            frm.Show();
        }

        private void fUNCIONARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Funcionario.Frm_Funcionario);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new Funcionario.Frm_Funcionario();
            frm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void eVOLUCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is INTERNACION.Frm_Internacion_View);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new INTERNACION.Frm_Internacion_View();
            frm.Show();
        }

        private void parametrosYConfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Maximizar();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }      
        public void Maximizar() {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }                

       
        #region INSTANCIA

        public static Frm_Pantalla_principal Instancias
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

        private void Frm_Pantalla_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Frm_Pantalla_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instancias = null;
        }

        private void ID_USUARIOS_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                                 
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MOSTRAR_Id_Permiso_Pantalla_principal();
        }
        public void MOSTRAR_Id_Permiso_Pantalla_principal() {
            DataTable d = Capa_Negocio.N_USUARIOS.MOSTRAR_Id_Permiso_Pantalla_principal(lblsam.Text);
            dtPermisoPrinciapl.DataSource = d;

        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtPermisoPrinciapl.Rows)
            {
                MessageBox.Show(item.Cells[0].Value.ToString());
            }
        }

       
        public  void PRIVILEGIOS_MIO() {

            foreach (DataGridViewRow item in dtPermisoPrinciapl.Rows)
            {
               
                //MessageBox.Show(item.Cells[0].Value.ToString());
                if (item.Cells[0].Value.ToString() == "fp_001" || item.Cells[0].Value.ToString() == "fp_002" || item.Cells[0].Value.ToString() == "fp_003"
                    || item.Cells[0].Value.ToString() == "fp_004" || item.Cells[0].Value.ToString() == "fp_005" || item.Cells[0].Value.ToString() == "fp_006")
                {
                    //internacionToolStripMenuItem.Visible = true;//internacion
                    pACIENTEToolStripMenuItem.Visible = true;//ficha paciente
               } 

                 if (item.Cells[0].Value.ToString() == "f_001" || item.Cells[0].Value.ToString() == "f_002" || item.Cells[0].Value.ToString() == "f_003"
                    || item.Cells[0].Value.ToString() == "f_004" || item.Cells[0].Value.ToString() == "f_005" || item.Cells[0].Value.ToString() == "f_006")
                {
                    //parametrosYConfiguracionToolStripMenuItem.Visible = true;//parametro
                    fUNCIONARIOSToolStripMenuItem.Visible = true;                    //funcionario
                }
                if (item.Cells[0].Value.ToString() == "M_001" || item.Cells[0].Value.ToString() == "M_002" || item.Cells[0].Value.ToString() == "M_003"
                    || item.Cells[0].Value.ToString() == "M_004" || item.Cells[0].Value.ToString() == "M_005" || item.Cells[0].Value.ToString() == "M_006")
                {
                    //parametrosYConfiguracionToolStripMenuItem.Visible = true;//parametro
                    medicoToolStripMenuItem.Visible = true;//medico
                } 
                if (item.Cells[0].Value.ToString() == "Ts_001" || item.Cells[0].Value.ToString() == "Ts_002" || item.Cells[0].Value.ToString() == "Ts_003"
                   || item.Cells[0].Value.ToString() == "Ts_004" || item.Cells[0].Value.ToString() == "Ts_005" || item.Cells[0].Value.ToString() == "Ts_006")
                {
                    //parametrosYConfiguracionToolStripMenuItem.Visible = true;//parametro
                    tIPOSDESALAToolStripMenuItem.Visible = true;//tipo sala
                } 
                if (item.Cells[0].Value.ToString() == "Sa_001" || item.Cells[0].Value.ToString() == "Sa_002" || item.Cells[0].Value.ToString() == "Sa_003"
                  || item.Cells[0].Value.ToString() == "Sa_004" || item.Cells[0].Value.ToString() == "Sa_005" || item.Cells[0].Value.ToString() == "Sa_006")
                {
                    //parametrosYConfiguracionToolStripMenuItem.Visible = true;//parametro
                    sala.Visible = true;//sala
                }
                if (item.Cells[0].Value.ToString() == "Us_001" || item.Cells[0].Value.ToString() == "Us_002" || item.Cells[0].Value.ToString() == "Us_003"
                   || item.Cells[0].Value.ToString() == "Us_004" || item.Cells[0].Value.ToString() == "Us_005" || item.Cells[0].Value.ToString() == "Us_006")
                {
                    //   administracionToolStripMenuItem.Visible = true;//administrador
                    uSUARIOSToolStripMenuItem.Visible = true;//usuario
                }
                
            }
        }
        // string nodos = "";
        private static Frm_Pantalla_principal instancias;

        private void dtPermisoPrinciapl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eVOLUCIONMEDICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EVOLUCION_MEDICA.Frm_EvolucionMEdica_Mostrar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new EVOLUCION_MEDICA.Frm_EvolucionMEdica_Mostrar();
            frm.Show();
        }

        private void eSTUDIOLABORATORIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Mostrar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            Program.Menu_Principal = 0;
            frm = new ESTUDIO_LABORATORIO.Frm_EstudioLaboratorio_Mostrar();
            frm.Show();
        }

        public static Frm_Pantalla_principal Get_instancias()
        {
            if (Instancias == null)
            {
                Instancias = new Frm_Pantalla_principal();
            }
            return Instancias;
        }


        #endregion
    public void cargarTreview(string codi, string contra, TreeView no)
        {
          

        }
    }
}
