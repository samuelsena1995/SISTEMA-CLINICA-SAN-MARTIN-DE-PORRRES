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
using System.Runtime.InteropServices;
namespace Capa_Presentacion.Usuario
{
    public partial class FRM_PERMISO : Form
    {
        public static FRM_PERMISO frm_dg;
        public FRM_PERMISO()
        {
            InitializeComponent();
            frm_dg = this;
         //   BLOQUEAR_MENU();
        }

        private void FRM_PERMISO_Load(object sender, EventArgs e)
        {
            MOSTRARPERMISOS();
            Configurar_Datagridview();
            //  cargarDAtos();
            Frm_Pantalla_principal.frm_princiapal.PRIVILEGIOS_MIO();
            Frm_Pantalla_principal.frm_princiapal.MOSTRAR_Id_Permiso_Pantalla_principal();
           // BLOQUEAR_MENU();
        }
       

   

        public void BLOQUEAR_MENU() {
            for (int i = 0; i < dgvPermisos.Rows.Count; i++)
            {
                if ((bool)dgvPermisos.Rows[i].Cells["PERMITIR"].Value) {
                    //MessageBox.Show(i.ToString());
                    if (i ==1||i==2 || i==3 ||i == 4 || i == 5 || i == 6) {
                        Frm_Pantalla_principal.frm_princiapal.internacionToolStripMenuItem.Visible = true;
                        Frm_Pantalla_principal.frm_princiapal.pACIENTEToolStripMenuItem.Visible = true;
                    }else
                    {
                      //  Frm_Pantalla_principal.frm_princiapal.pACIENTEToolStripMenuItem.Visible = false;
                        Frm_Pantalla_principal.frm_princiapal.internacionToolStripMenuItem.Visible = false;
                    }if (i == 7 || i == 8 || i == 9 || i == 10 || i == 11 || i == 12)
                    {
                        Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = true;
                        Frm_Pantalla_principal.frm_princiapal.fUNCIONARIOSToolStripMenuItem.Visible = true;
                    }
                    else {
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = false;
                        Frm_Pantalla_principal.frm_princiapal.fUNCIONARIOSToolStripMenuItem.Visible = false;
                    }
                    if (i == 13 || i == 14 || i == 15 || i == 16 || i == 17 || i == 18)
                    {
                        Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = true;
                        Frm_Pantalla_principal.frm_princiapal.medicoToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = false;
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = false;
                        Frm_Pantalla_principal.frm_princiapal.medicoToolStripMenuItem.Visible = false;
                    }
                    if (i == 19 || i == 20 || i == 21 || i == 22 || i == 23 || i == 24)
                    {
                        Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = true;
                        Frm_Pantalla_principal.frm_princiapal.tIPOSDESALAToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = false;
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible =false;
                        Frm_Pantalla_principal.frm_princiapal.tIPOSDESALAToolStripMenuItem.Visible = false;
                    }
                    if (i == 25 || i == 26 || i == 27 || i == 28 || i == 29 || i == 30)
                    {
                        Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = true;
                        Frm_Pantalla_principal.frm_princiapal.sala.Visible = true;
                    }
                    else
                    {
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = false;
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = false;
                        Frm_Pantalla_principal.frm_princiapal.sala.Visible = false;
                    }
                    if (i == 31 || i == 32 || i == 33 || i == 34 || i == 35 || i == 36)
                    {
                        Frm_Pantalla_principal.frm_princiapal.administracionToolStripMenuItem.Visible = true;
                        Frm_Pantalla_principal.frm_princiapal.uSUARIOSToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        //Frm_Pantalla_principal.frm_princiapal.parametrosYConfiguracionToolStripMenuItem.Visible = false;
                       // Frm_Pantalla_principal.frm_princiapal.administracionToolStripMenuItem.Visible = false;
                        Frm_Pantalla_principal.frm_princiapal.uSUARIOSToolStripMenuItem.Visible = false;
                    }
                }
            }
        }
        public void MOSTRARPERMISOS() {
            //   dataGridView1.DataSource = Capa_Negocio.N_USUARIOS.MOSTRARPERMISOS();
            dgvPermisos.DataSource = Capa_Negocio.N_USUARIOS.MOSTRAR_PERMISOS_HABILITADOS(txtvodigo.Text);
        }

        #region Instancia
        public static FRM_PERMISO Instancias
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
        private static FRM_PERMISO instancias;

        public static FRM_PERMISO Get_instancias()
        {
            if (Instancias == null)
            {
                Instancias = new FRM_PERMISO();
            }
            return Instancias;
        }
        #endregion
        public DataTable MostrarLosPermisos(string caja)
        {
            DataTable tableResultado = new DataTable();
            SqlConnection sqlconex = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            try
            {
                sqlconex.ConnectionString = Capa_Datos.Conexion.Conexion_bd;
                sqlcmd.Connection = sqlconex;
                sqlcmd.CommandText = "select u.Codigo,a.IdPermiso from USUARIO u inner join AsigancionPermiso a on a.IdUsuario = u.Codigoinner join PERMISO p on p.Codigo = a.IdUsuario where u.Codigo =@Codigo";
                sqlcmd.CommandType = CommandType.Text;

                sqlcmd.Parameters.AddWithValue("@Codigo", caja);

                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcmd);
                sqldata.Fill(tableResultado);
            }
            catch (Exception ex)
            {
                tableResultado = null;
            }
            return tableResultado;
        }
        public void guardar()
        {

            try
            {

                SqlConnection sql = new SqlConnection();
                sql.ConnectionString = Capa_Datos.Conexion.Conexion_bd;
                sql.Open();
                string insertar = "insert into hora values(@IdPermiso)";
                SqlCommand sqlcm = new SqlCommand(insertar, sql);
                foreach (DataGridViewRow item in dgvPermisos.Rows)
                {
                    if (Convert.ToBoolean(item.Cells[3].Value))
                    {
                        sqlcm.Parameters.Clear();
                        sqlcm.Parameters.AddWithValue("@IdPermiso", Convert.ToInt32(item.Cells[0].Value));
                        sqlcm.ExecuteNonQuery();

                    }


                }
                sql.Close();
                MessageBox.Show("se guardo ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarDAtos()
        {
            SqlConnection sql = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataReader dr;
            sql.ConnectionString = Capa_Datos.Conexion.Conexion_bd;
            sqlcmd.Connection = sql;

            sqlcmd.CommandText = "select p.Codigo,p.Modulo,p.Descripcion,p.Estado from PERMISOS p";
            sqlcmd.CommandType = CommandType.Text;

            sql.Open();

            dgvPermisos.Rows.Clear();

            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                int renglon = dgvPermisos.Rows.Add();

                dgvPermisos.Rows[renglon].Cells[0].Value = dr.GetString(dr.GetOrdinal("Codigo")).ToString();
                dgvPermisos.Rows[renglon].Cells[1].Value = dr.GetString(dr.GetOrdinal("Modulo")).ToString();
                dgvPermisos.Rows[renglon].Cells[2].Value = dr.GetString(dr.GetOrdinal("Descripcion")).ToString();
                dgvPermisos.Rows[renglon].Cells[3].Value = dr.GetString(dr.GetOrdinal("Estado")).ToString();
                for (int i = 0; i < dgvPermisos.Rows.Count; i++)
                {
                    if (dgvPermisos.Rows[0].Cells[3].Value.ToString() == "H")
                    {
                        dgvPermisos.Rows[i].Cells[4].Value = true;
                    }



                }

            }
            sql.Close();
        }

        public void Configurar_Datagridview()
        {
            var dgv = dgvPermisos;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Orange;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Oxygen", 12);
            dgv.ColumnHeadersHeight = 40;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = true;

            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = true;

            //ajustar el tamaño de la tabla
            //dgv.AutoResizeColumns(); 

            dgvPermisos.Columns[0].Width = 95;//codigo
            dgvPermisos.Columns[1].Width = 140;//modulo            
            dgvPermisos.Columns[2].Width = 242;//descripcion
            dgvPermisos.Columns[3].Width = 100;///permitir

            //dataGridView1.Columns[4].Width = 75;///estado
            // dgvLista.Columns[5].Width = 95;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPermisos.Columns["PERMITIR"].Index)
            {
                DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)dgvPermisos.Rows[e.RowIndex].Cells["PERMITIR"];

                ck.Value = !Convert.ToBoolean(ck.Value);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPermisos.Rows.Count == 0)
                {
                    return;
                }
                SqlConnection sql = new SqlConnection();
                sql.ConnectionString = Capa_Datos.Conexion.Conexion_bd;
                sql.Open();
                string insertar = "insert into AsignacionPermiso(IdUsuario,IdPermiso,Estado) values(@IdUsuario,@IdPermiso,@Estado)";
                SqlCommand sqlcm = new SqlCommand(insertar, sql);
                foreach (DataGridViewRow item in dgvPermisos.Rows)
                {
                    if (Convert.ToBoolean(item.Cells["ck"].Value)) {
                        sqlcm.Parameters.Clear();
                        sqlcm.Parameters.AddWithValue("@IdPermiso", item.Cells["CODIGO"].Value);
                        sqlcm.Parameters.AddWithValue("@IdUsuario", txtvodigo.Text.ToString());
                        sqlcm.Parameters.AddWithValue("@Estado", "S");

                        sqlcm.ExecuteNonQuery();
                    }
                }
                sql.Close();

                MessageBox.Show("se guardo ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //   MessageBox.Show(dgvPermisos.CurrentRow.Cells["PERMITIR"].ToString());

        }
        public void eliminarHoteles(int id_ciudad)
        {
            SqlConnection sql = new SqlConnection(Capa_Datos.Conexion.Conexion_bd);
            SqlCommand delete = new SqlCommand();
            delete.Connection = sql;


            delete.CommandText = "DELETE from AsigancionPermiso where IdUsuario = @ID";
            delete.Parameters.AddWithValue("@ID", id_ciudad);

            sql.Open();
            delete.ExecuteNonQuery();
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = Capa_Datos.Conexion.Conexion_bd;
            using (sql)
            {
                sql.Open();
                string query = "INSERT INTO hora  VALUES (@IdPermiso)";
                SqlCommand cmd = new SqlCommand(query, sql);
                foreach (DataGridViewRow row in dgvPermisos.Rows)
                {
                    CheckBox check = row.Cells[3].Value as CheckBox;
                    if (check.Checked)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@IdPErmiso", row.Cells[3].Value);
                        //cmd.Parameters.AddWithValue("@TIENDA", row.Cells(2).Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPermisos.DataSource = Capa_Negocio.N_Permiso.Buscar_PRUEBA(textBox1.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          //  Frm_Pantalla_principal.frm_princiapal.PRIVILEGIOS_MIO();
          //  Frm_Pantalla_principal.frm_princiapal.MOSTRAR_Id_Permiso_Pantalla_principal();
            Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {                
                foreach (DataGridViewRow row in dgvPermisos.Rows)
                {
                    row.Cells["PERMITIR"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvPermisos.Rows)
                {
                    row.Cells["PERMITIR"].Value = false;
                }
            }
        }
        string resp = "";
        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                resp = Capa_Negocio.N_USUARIOS.ELIMINAR_ASIGNACION_PERMISO_IDUSUARIO(txtvodigo.Text);
                foreach (DataGridViewRow item in dgvPermisos.Rows)
                {
                    if (Convert.ToBoolean(item.Cells["PERMITIR"].Value))
                    {                       
                        resp = Capa_Negocio.N_USUARIOS.registrar_PERMISO(txtvodigo.Text, Convert.ToString(item.Cells["CODIGO"].Value), "S");
                    }
                }                            
                if (resp.Equals("OK")) {
                    MessageBox.Show("SE REGISTRO DE FORMA CORRECTA LOS PERMISOS");
                }
                Frm_Pantalla_principal o = Frm_Pantalla_principal.Get_instancias();
                o.PRIVILEGIOS_MIO();
                o.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvPermisos.DataSource = Capa_Negocio.N_USUARIOS.MOSTRAR_PERMISOS_HABILITADOS(txtvodigo.Text);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        /*         
    mover el formulario sin borde
    */
        /// <summary>
        /// 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Pantalla_principal.frm_princiapal.MOSTRAR_Id_Permiso_Pantalla_principal();
            Frm_Pantalla_principal.frm_princiapal.PRIVILEGIOS_MIO();
            Program.isnuevo = false;
            Program.ismodificar = false;
            Program.Cambio_Estado = false;
            Instancias = null;
            Close();
        }

        private void FRM_PERMISO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Pantalla_principal.frm_princiapal.PRIVILEGIOS_MIO();
            Frm_Pantalla_principal.frm_princiapal.MOSTRAR_Id_Permiso_Pantalla_principal();
            
        }

        private void FRM_PERMISO_FormClosed(object sender, FormClosedEventArgs e)
        {
              Frm_Pantalla_principal.frm_princiapal.PRIVILEGIOS_MIO();
             Frm_Pantalla_principal.frm_princiapal.MOSTRAR_Id_Permiso_Pantalla_principal();
            

            //BLOQUEAR_MENU();
                        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvPermisos.Columns["PERMITIR"].ReadOnly = true;
        }

        /// </summary>
    }
}

