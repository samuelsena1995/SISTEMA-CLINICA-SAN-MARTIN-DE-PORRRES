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
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Frm_Lista_analisis_laboratorio : Form
    {
        public static Frm_Lista_analisis_laboratorio frm_dgv;

        public Frm_Lista_analisis_laboratorio()
        {
            InitializeComponent();
            Program.isnuevo = false;
            Program.ismodificar = false;
            Program.Cambio_Estado = false;
            Program.Consultar = false;
            Program.Eliminar = false;
            Frm_Lista_analisis_laboratorio.frm_dgv = this;         
            Actualizar_dgv();
        }

        private void Frm_Lista_analisis_laboratorio_Load(object sender, EventArgs e)
        {            
            Actualizar_dgv();
            Configurar_Datagridview();
            CenterToScreen();
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
        /// </summary>
        public void Configurar_Datagridview() {
            var dgv = dgvLista;
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
            //dgv.Columns[0].Width = 20;
            dgv.Columns[0].Width = 35;
            dgv.Columns[1].Width = 400;
            dgv.Columns[2].Width = 1065;
            dgv.Columns[3].Width = 95;
           

        }
       
        public void Actualizar_dgv() {
            this.dgvLista.DataSource = N_Lista_analisis_laboratorio.Listar_Todo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Lista_analisis_laboratorio);
            if (listado != null) {
                listado.BringToFront();
                return;
            }
            Program.isnuevo = true;
            Lista_analisis.Frm_Listar_analisis_laboratorio_Registrar obj = new Lista_analisis.Frm_Listar_analisis_laboratorio_Registrar();            
            obj.ShowDialog();
        }

        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0) {
                Program.ismodificar = true;
                this.Datos();
                
            }else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }   
        public void Datos() {

            try
            {

                DataTable codigo = N_Lista_analisis_laboratorio.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Lista_analisis.Frm_Listar_analisis_laboratorio_Registrar frm = Lista_analisis.Frm_Listar_analisis_laboratorio_Registrar.Get_instacnias();

                    //frm.txtCODIGO.Text = codigo.Rows[0][0].ToString();
                    //frm.txtNOMBRE.Text= codigo.Rows[0][1].ToString();
                    //frm.txtDescripcion.Text = codigo.Rows[0][2].ToString();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string desc = codigo.Rows[0][2].ToString();
                    frm.txtCODIGO.Text = co.Trim();
                    frm.txtNOMBRE.Text = nom.Trim();
                    frm.txtDescripcion.Text = desc.Trim();


                    if (codigo.Rows[0][3].ToString() == "D")
                    {
                        string habilitado = "Habilitado";
                        frm.cbESTADO.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbESTADO.Text = Deshabilitado;
                    }
                    //frm.cbESTADO.Text = codigo.Rows[0][3].ToString();
                    //if (Program.isnuevo == true || Program.ismodificar == true)
                    //{
                    //    // frm.btnNUEVO.Visible = true;
                    //    // frm.btnEDITAR.Visible = true;
                    //    frm.btnACEPTAR.Enabled = true;
                    //    frm.btnCANCELAR.Enabled = true;
                    //}
                    if (Program.isnuevo == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar == true)
                    {
                        frm.cbESTADO.Enabled = false;
                        frm.lblestado.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                        if (codigo.Rows[0][3].ToString() == "H")
                        {
                            string habilitado = "Habilitado";
                            frm.cbESTADO.Text = habilitado.ToString();
                        }
                        else
                        {
                            string Deshabilitado = "Deshabilitado";
                            frm.cbESTADO.Text = Deshabilitado;
                        }
                    }                
                    else
                    {
                        if (Program.Cambio_Estado == true)
                        {
                            frm.btnACEPTAR.Enabled = true;
                            frm.btnCANCELAR.Enabled = true;
                            frm.groupBoxDATOS.Enabled = true;
                            frm.cbESTADO.Enabled = false;
                            frm.txtCODIGO.Enabled = false;
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtDescripcion.Enabled = false;
                            frm.cbESTADO.Focus();
                            string Deshabilitado = "Deshabilitado";
                            string habilitado = "Habilitado";
                            if (codigo.Rows[0][3].ToString() == "D")
                            {
                                frm.cbESTADO.Text = habilitado;
                            }
                            else
                            {
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Consultar == true)
                        {
                            frm.txtNOMBRE.Enabled = false;
                            frm.txtDescripcion.Enabled = false;
                            frm.cbESTADO.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
                            if (codigo.Rows[0][3].ToString() == "H")
                            {
                                string habilitado = "Habilitado";
                                frm.cbESTADO.Text = habilitado.ToString();
                            }
                            else
                            {
                                string Deshabilitado = "Deshabilitado";
                                frm.cbESTADO.Text = Deshabilitado;
                            }
                        }                       
                        else
                        {
                            frm.groupBoxDATOS.Enabled = false;
                            frm.btnACEPTAR.Enabled = false;
                            frm.btnCANCELAR.Enabled = false;
                        }
                    }

                    frm.ShowDialog();
                }
            }
            catch (Exception e) {                
                MessageBox.Show("No hay ningun dato");
            }
        }

        public void Datos_Eliminar()
        {

            try
            {

                DataTable codigo = N_Lista_analisis_laboratorio.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["#"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Lista_analisis.Frm_Listar_analisis_laboratorio_eliminar frm = Lista_analisis.Frm_Listar_analisis_laboratorio_eliminar.Get_instacnias();

                    //frm.txtCODIGO.Text = codigo.Rows[0][0].ToString();
                    //frm.txtNOMBRE.Text= codigo.Rows[0][1].ToString();
                    //frm.txtDescripcion.Text = codigo.Rows[0][2].ToString();
                    string co = codigo.Rows[0][0].ToString();
                    string nom = codigo.Rows[0][1].ToString();
                    string desc = codigo.Rows[0][2].ToString();
                    frm.txtCODIGO_elimi.Text = co.Trim();
                    frm.txtNOMBRE_elimi.Text = nom.Trim();
                    frm.txtDescripcion_elimi.Text = desc.Trim();
                    frm.cbESTADO__elimi.Enabled = false;
                    frm.txtCODIGO_elimi.Enabled = false;
                    frm.txtNOMBRE_elimi.Enabled = false;
                    frm.txtDescripcion_elimi.Enabled = false;
                    if (codigo.Rows[0][3].ToString() == "H")
                    {
                        string habilitado = "Habilitado";
                        frm.cbESTADO__elimi.Text = habilitado.ToString();
                    }
                    else
                    {
                        string Deshabilitado = "Deshabilitado";
                        frm.cbESTADO__elimi.Text = Deshabilitado;
                    }
                    frm.ShowDialog();
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }
        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0) {
                Program.Cambio_Estado = true;
                this.Datos();
            }
            else{
                MessageBox.Show("Seleccione un Dato");
            }
        }
   
        private void menustpELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Eliminar = true;
                Datos_Eliminar();
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }        
            //try
            //{
            //    DialogResult Opcion;  
            //    Opcion = MessageBox.Show(String.Format("Esta seguro de eliminar el registro de forma permanente de:\n {0} ?",
            //        this.dgvLista.CurrentRow.Cells["Nombre"].Value.ToString()),
            //        ".: SISTEMA CLINICO :.",
            //        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //    if (Opcion == DialogResult.OK)
            //    {
            //        string Rpta = "";
            //        foreach (DataGridViewRow row in dgvLista.Rows)
            //        {
            //            if (row.Selected)
            //            {
            //                if (this.dgvLista.CurrentRow.Cells["ESTADO"].Value.ToString() == "Deshabilitado")
            //                {
            //                    Rpta = N_Lista_analisis_laboratorio.Eliminar(Convert.ToInt32(dgvLista.CurrentRow.Cells["CODIGO"].Value.ToString()));
            //                    MessageBox.Show("Dato eliminado correctamente", ".:Sistema Clinico:.");
            //                }
            //                else
            //                {
            //                    MessageBox.Show("DESHABILITE PRIMERO EL DATO ", ".:Sistema Clinico:.", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //                }
            //            }
            //        }
            //        if (Rpta.Equals("Ok"))
            //        {

            //        }
            //        else
            //        {
            //            // MessageBox.Show(Rpta);
            //        }
            //        this.Actualizar_dgv();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0) {
                Program.Consultar = true;
                this.Datos();
            }else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            
            dgvLista.DataSource = N_Lista_analisis_laboratorio.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            
               dgvLista.DataSource = N_Lista_analisis_laboratorio.Listar_Todo();
            
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();          
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void eliminar2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.DataSource = N_Lista_analisis_laboratorio.Buscar_campo(txtBusqueda.Text, cbFiltro.Text, cbFiltroEstado.Text);
            if (txtBusqueda.Text == string.Empty)
            {
                dgvLista.DataSource = N_Lista_analisis_laboratorio.Listar_Todo();
            }
        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja obj = new Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja();
            obj.Show();
        }

        private void pARAMETROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja obj = new Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja();
            obj.ShowDialog();
        }

        private void Frm_Lista_analisis_laboratorio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void eliminar2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }      
        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Lista_analisis.Frm_Listar_analisis_laboratorio_eliminar rli = new Lista_analisis.Frm_Listar_analisis_laboratorio_eliminar();
            //rli.Show();

            if (dgvLista.Rows.Count >= 0)
            {
                Program.Eliminar = true;
                Datos_Eliminar();

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
    
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void informe2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja obj = new Lista_analisis.Frm_Reporte_Listar_Analisis_Laboratorio_Caja();
            obj.ShowDialog();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
    }
}
