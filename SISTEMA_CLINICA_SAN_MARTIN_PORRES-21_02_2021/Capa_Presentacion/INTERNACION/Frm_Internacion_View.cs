using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Presentacion.INTERNACION
{
    public partial class Frm_Internacion_View : Form
    {
        public static Frm_Internacion_View frm;
        public Frm_Internacion_View()
        {
            InitializeComponent();
            frm = this;
        }

        private void menustpNUEVO_Click(object sender, EventArgs e)
        {
            Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Internacion_View);
            if (listado != null)
            {
                listado.BringToFront();
                return;
            }
            Program.isnuevo_internacion = true;
            Frm_Internacion_Registrar obj = new Frm_Internacion_Registrar();
            obj.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Internacion_View_Load(object sender, EventArgs e)
        {
            Mostrar();
            Configurar_Datagridview();
        }
        public void Mostrar()
        {
            dgvLista.DataSource = Capa_Negocio.N_INTERNACION.Listar_Todo();
        }
        public void Configurar_Datagridview()
        {
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
            dgv.Columns[0].Width = 75;//codigo
            dgv.Columns[1].Width = 150;//fecha        
            dgv.Columns[2].Width = 50;//codigomedico
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Width = 200;//nombre
            dgv.Columns[4].Width = 50;//codigofuncionari
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Width = 200;//nombre
            dgv.Columns[6].Width = 80;//codigopaciente
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Width = 200;//nombre
            dgv.Columns[8].Width = 1000;
            dgv.Columns[9].Width = 90;//ESTADO           
        }
        private bool Exists_AsignacionSala(string usuarios)
        {
            string consulta = @"select count(*) from ASIGNACION_SALA asi inner join INTERNACION i on i.Codigo=asi.CodigoInternacion
where asi.CodigoInternacion=@Codigo and asi.Estado='H';";
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(Capa_Datos.Conexion.Conexion_bd))
            {
                con.Open();
                cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@Codigo", usuarios);
                int conta = Convert.ToInt32(cmd.ExecuteScalar());
                return conta == 0;
            }
        }
        private void asignarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                if (!Exists_AsignacionSala(dgvLista.CurrentRow.Cells[0].Value.ToString()))//{
                //if (!Capa_Negocio.N_INTERNACION.ExisteAsignacionSala(Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Ya tiene una sala Asignadad");
                }else
                {
                    Program.isnuevo_ASIGNACION_SALA = true;
                    this.Datos();
                }

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
            //Form listado = this.MdiChildren.FirstOrDefault(y => y is Frm_Internacion_View);
            //if (listado != null)
            //{
            //    listado.BringToFront();
            //    return;
            //}
            //Program.isnuevo = true;
            //FRM_ASIGNACION_SALA_REGISTRAR obj = new FRM_ASIGNACION_SALA_REGISTRAR();
            //obj.ShowDialog();
        }
        public void Datos()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_ASIGNACION_SALA.Consultar_codigo(Convert.ToInt32(this.dgvLista.CurrentRow.Cells["CODIGO"].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FRM_ASIGNACION_SALA_REGISTRAR frm = FRM_ASIGNACION_SALA_REGISTRAR.Get_instacnias();


                    string co = codigo.Rows[0][0].ToString();//codi
                    //string nom = codigo.Rows[0][1].ToString();//nombre
                    string nombre = codigo.Rows[0][2].ToString();//obse
                                                               //string nombreTipo = codigo.Rows[0]["TIPO SALA"].ToString();//
                                                               //string codiTipo = codigo.Rows[0][4].ToString();

                    frm.txtcodigoInternacion.Text = co.Trim();
                    frm.txtPaciente.Text = nombre.Trim();
         
                    //if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                    //{
                    //    string habilitado = "Habilitado";
                    //    frm.cbESTADO.Text = habilitado.ToString();
                    //}
                    //else
                    //{
                    //    string Deshabilitado = "Deshabilitado";
                    //    frm.cbESTADO.Text = Deshabilitado;
                    //}
                    if (Program.isnuevo_ASIGNACION_SALA == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_ASIGNACION_SALA == true)
                    {
                        //frm.cbESTADO.Enabled = false;
                        //frm.lblestado.Visible = true;
                        //frm.btnACEPTAR.Enabled = true;
                        //frm.btnCANCELAR.Enabled = true;
                        //if (codigo.Rows[0]["ESTADO"].ToString() == "H")
                        //{
                        //    string habilitado = "Habilitado";
                        //    frm.cbESTADO.Text = habilitado.ToString();
                        //}
                        //else
                        //{
                        //    string Deshabilitado = "Deshabilitado";
                        //    frm.cbESTADO.Text = Deshabilitado;
                        //}
                    }
                    else
                    {
                        if (Program.Cambio_Estado_ASIGNACION_SALA == true)
                        {
                            //frm.btnACEPTAR.Enabled = true;
                            //frm.btnCANCELAR.Enabled = true;
                            //frm.groupBoxDATOS.Enabled = true;
                            //frm.cbESTADO.Enabled = false;
                            //frm.txtCODIGO.Enabled = false;
                            //frm.txtNOMBRE.Enabled = false;
                            //frm.txtobservacion.Enabled = false;
                            //frm.cbESTADO.Focus();
                            //string Deshabilitado = "Deshabilitado";
                            //string habilitado = "Habilitado";
                            //if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                            //{
                            //    frm.cbESTADO.Text = habilitado;
                            //}
                            //else
                            //{
                            //    frm.cbESTADO.Text = Deshabilitado;
                            //}
                        }
                        else if (Program.Consultar_ASIGNACION_SALA == true)
                        {
                            //frm.txtNOMBRE.Enabled = false;
                            //frm.txtobservacion.Enabled = false;
                            //frm.cbESTADO.Enabled = false;
                            //frm.btnACEPTAR.Visible = false;
                            //if (codigo.Rows[0]["ESTADO"].ToString() == "H")
                            //{
                            //    string habilitado = "Habilitado";
                            //    frm.cbESTADO.Text = habilitado.ToString();
                            //}
                            //else
                            //{
                            //    string Deshabilitado = "Deshabilitado";
                            //    frm.cbESTADO.Text = Deshabilitado;
                            //}
                        }
                        else if (Program.Eliminar_ASIGNACION_SALA == true)
                        {
                            //if (codigo.Rows[0][3].ToString() == "H")
                            //{
                            //    string habilitado = "Habilitado";
                            //    frm.cbESTADO.Text = habilitado.ToString();
                            //}
                            //else
                            //{
                            //    string Deshabilitado = "Deshabilitado";
                            //    frm.cbESTADO.Text = Deshabilitado;
                            //}
                        }
                        else
                        {
                           
                            frm.btnACEPTAR.Enabled = false;
                            frm.btnCANCELAR.Enabled = false;
                        }
                    }

                    frm.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }

        public void Datos_Consultar_AsignacionSala()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_ASIGNACION_SALA.CONSULTAR(Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    //  MessageBox.Show("ERROR perro", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("PORFAVOR ASIGNE PRIMERO UNA SALA A LA < INTERNACION >", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FRM_ASIGNACION_SALA_REGISTRAR frm = FRM_ASIGNACION_SALA_REGISTRAR.Get_instacnias();                
                    string codigoAsignacion = codigo.Rows[0][3].ToString();//codi
                    //string nom = codigo.Rows[0][1].ToString();//nombre
                    string codigoPaciente = codigo.Rows[0][1].ToString();
                    string nombrepaciente = codigo.Rows[0][2].ToString();//obse
                    string CodigoInternacion = codigo.Rows[0][0].ToString();//
                    string fecha = codigo.Rows[0][4].ToString();
                    string codigoSala = codigo.Rows[0][5].ToString();
                    string sala = codigo.Rows[0][6].ToString();
                    //string codiTipo = codigo.Rows[0][4].ToString();

                    frm.txtcodigoInternacion.Text = CodigoInternacion.ToString();
                    frm.txtPaciente.Text = nombrepaciente.ToString();
                    frm.lblCodigoSala.Text = codigoSala.ToString();
                    frm.txtNombreSala.Text = sala.ToString();

                    //if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                    //{
                    //    string habilitado = "Habilitado";
                    //    frm.cbESTADO.Text = habilitado.ToString();
                    //}
                    //else
                    //{
                    //    string Deshabilitado = "Deshabilitado";
                    //    frm.cbESTADO.Text = Deshabilitado;
                    //}
                    if (Program.isnuevo_ASIGNACION_SALA == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_ASIGNACION_SALA == true)
                    {
                        //frm.cbESTADO.Enabled = false;
                        //frm.lblestado.Visible = true;
                        //frm.btnACEPTAR.Enabled = true;
                        //frm.btnCANCELAR.Enabled = true;
                        //if (codigo.Rows[0]["ESTADO"].ToString() == "H")
                        //{
                        //    string habilitado = "Habilitado";
                        //    frm.cbESTADO.Text = habilitado.ToString();
                        //}
                        //else
                        //{
                        //    string Deshabilitado = "Deshabilitado";
                        //    frm.cbESTADO.Text = Deshabilitado;
                        //}
                    }
                    else
                    {
                        if (Program.Cambio_Estado_ASIGNACION_SALA == true)
                        {
                            //frm.btnACEPTAR.Enabled = true;
                            //frm.btnCANCELAR.Enabled = true;
                            //frm.groupBoxDATOS.Enabled = true;
                            //frm.cbESTADO.Enabled = false;
                            //frm.txtCODIGO.Enabled = false;
                            //frm.txtNOMBRE.Enabled = false;
                            //frm.txtobservacion.Enabled = false;
                            //frm.cbESTADO.Focus();
                            //string Deshabilitado = "Deshabilitado";
                            //string habilitado = "Habilitado";
                            //if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                            //{
                            //    frm.cbESTADO.Text = habilitado;
                            //}
                            //else
                            //{
                            //    frm.cbESTADO.Text = Deshabilitado;
                            //}
                        }
                        else if (Program.Consultar_ASIGNACION_SALA == true)
                        {
                            //frm.txtNOMBRE.Enabled = false;
                            //frm.txtobservacion.Enabled = false;
                            //frm.cbESTADO.Enabled = false;
                            //frm.btnACEPTAR.Visible = false;
                            frm.txtcodigoInternacion.Enabled = false;
                            frm.txtPaciente.Enabled = false;
                            frm.txtNombreSala.Enabled = false;
                            frm.comboBox1.Enabled = false;
                            frm.dtFechaAsignacionSala.Enabled = false;
                            frm.btnACEPTAR.Visible = false;
                            if (codigo.Rows[0][7].ToString() == "H")
                            {
                                string habilitado = "Habilitado";
                                frm.comboBox1.Text = habilitado.ToString();
                            }
                            else
                            {
                                string Deshabilitado = "Deshabilitado";
                                frm.comboBox1.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Eliminar_ASIGNACION_SALA == true)
                        {
                            //if (codigo.Rows[0][3].ToString() == "H")
                            //{
                            //    string habilitado = "Habilitado";
                            //    frm.cbESTADO.Text = habilitado.ToString();
                            //}
                            //else
                            //{
                            //    string Deshabilitado = "Deshabilitado";
                            //    frm.cbESTADO.Text = Deshabilitado;
                            //}
                        }
                        else
                        {

                            frm.btnACEPTAR.Enabled = false;
                            frm.btnCANCELAR.Enabled = false;
                        }
                    }

                    frm.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }

        public void Datos_Cambio_Estado_Editar()
        {

            try
            {

                DataTable codigo = Capa_Negocio.N_INTERNACION.Consultar_Id_Internacion(Convert.ToInt32(this.dgvLista.CurrentRow.Cells[0].Value.ToString()));
                if (codigo.Rows.Count == 0)
                {
                    MessageBox.Show("ERROR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Frm_Internacion_Registrar frm = Frm_Internacion_Registrar.Get_instancias();


                    string co = codigo.Rows[0][0].ToString();//codi
                    string fecha = codigo.Rows[0][1].ToString();//fecha
                    int codimedico = Convert.ToInt32(codigo.Rows[0][2].ToString());//codigomedico
                    string nombremedcio = codigo.Rows[0][3].ToString();//codigomedico
                    int codifuncionario = Convert.ToInt32(codigo.Rows[0][4].ToString());//codigofuncionario
                    string nombrefuncionario = codigo.Rows[0][5].ToString();//codigofuncioanrio
                    int codipaciente = Convert.ToInt32(codigo.Rows[0][6].ToString());//codigopaciente
                    string nombrepaciente = codigo.Rows[0][7].ToString();//codigopaciente
                    string descripcin = codigo.Rows[0][8].ToString();
                    string estado = codigo.Rows[0][9].ToString();//
                    string fecha_acimeinto = codigo.Rows[0][10].ToString();
                    //string codiTipo = codigo.Rows[0][4].ToString();
                    ///
                    frm.TXTCODIGOINTERNACION.Text = co;
                    frm.dateTimePicker1.Value = Convert.ToDateTime(fecha.ToString());
                    frm.txtcodigomedico.Text = Convert.ToString(codimedico.ToString());
                    frm.txtnombremedico.Text = nombremedcio;
                    frm.txtcodigoFuncionario.Text = Convert.ToString(codifuncionario);
                    frm.txtnombreFuncionario.Text = Convert.ToString(codifuncionario);
                    frm.txtnombreFuncionario.Text = nombrefuncionario;
                    frm.txtcodigopaciente.Text = Convert.ToString(codipaciente);
                    frm.txtnombrepaciente.Text = nombrepaciente;
                    frm.txtfecha_nacicmeintoPaciente.Text = fecha_acimeinto;
                    // frm.cbestado.Text = estado;
                    ///



                    //if (codigo.Rows[0]["ESTADO"].ToString() == "D")
                    //{
                    //    string habilitado = "Habilitado";
                    //    frm.cbestado.Text = habilitado.ToString();
                    //}
                    //else
                    //{
                    //    string Deshabilitado = "Deshabilitado";
                    //    frm.cbestado.Text = Deshabilitado;
                    //}
                    if (Program.isnuevo_internacion == true)
                    {
                        // frm.btnNUEVO.Visible = true;
                        // frm.btnEDITAR.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                    }
                    else if (Program.ismodificar_internacion == true)
                    {
                        //frm.cbESTADO.Enabled = false;
                        //frm.lblestado.Visible = true;
                        frm.btnACEPTAR.Enabled = true;
                        frm.btnCANCELAR.Enabled = true;
                        //if (codigo.Rows[0]["ESTADO"].ToString() == "H")
                        //{
                        //    string habilitado = "Habilitado";
                        //    frm.cbESTADO.Text = habilitado.ToString();
                        //}
                        //else
                        //{
                        //    string Deshabilitado = "Deshabilitado";
                        //    frm.cbESTADO.Text = Deshabilitado;
                        //}
                    }
                    else
                    {
                        if (Program.Cambio_Estado_internacion == true)
                        {
                            frm.TXTCODIGOINTERNACION.Enabled = false;
                            frm.dateTimePicker1.Enabled = false;
                            frm.txtcodigomedico.Enabled = false;
                            frm.txtnombremedico.Enabled = false;
                            frm.txtcodigoFuncionario.Enabled = false;
                            frm.txtnombreFuncionario.Enabled = false;
                            frm.txtnombreFuncionario.Enabled = false;
                            frm.txtcodigopaciente.Enabled = false;
                            frm.txtnombrepaciente.Enabled = false;
                            frm.txtfecha_nacicmeintoPaciente.Enabled = false;
                            string Deshabilitado = "Deshabilitado";
                            string habilitado = "Habilitado";
                            if (codigo.Rows[0]["ESTADO"].ToString() == "Deshabilitado")
                            {
                                frm.cbestado.Text = habilitado;
                            }
                            else
                            {
                                frm.cbestado.Text = Deshabilitado;
                            }
                            frm.cbestado.Enabled = false;
                        }
                        else if (Program.Consultar_internacion == true)
                        {

                            frm.TXTCODIGOINTERNACION.Enabled = false;
                            frm.dateTimePicker1.Enabled = false;
                            frm.txtcodigomedico.Enabled = false;
                            frm.txtnombremedico.Enabled = false;
                            frm.txtcodigoFuncionario.Enabled = false;
                            frm.txtnombreFuncionario.Enabled = false;
                            frm.txtnombreFuncionario.Enabled = false;
                            frm.txtcodigopaciente.Enabled = false;
                            frm.txtnombrepaciente.Enabled = false;
                            frm.txtfecha_nacicmeintoPaciente.Enabled = false;

                            string habilitado = "Habilitado";
                            string Deshabilitado = "Deshabilitado";
                            if (codigo.Rows[0]["ESTADO"].ToString() == "Habilitado")
                            {
                                
                                frm.cbestado.Text = habilitado.ToString();
                            }
                            else
                            {
                               
                                frm.cbestado.Text = Deshabilitado;
                            }
                        }
                        else if (Program.Eliminar_internacion == true)
                        {
                            //if (codigo.Rows[0][3].ToString() == "H")
                            //{
                            //    string habilitado = "Habilitado";
                            //    frm.cbESTADO.Text = habilitado.ToString();
                            //}
                            //else
                            //{
                            //    string Deshabilitado = "Deshabilitado";
                            //    frm.cbESTADO.Text = Deshabilitado;
                            //}
                        }
                        else
                        {

                            frm.btnACEPTAR.Enabled = false;
                            frm.btnCANCELAR.Enabled = false;
                        }
                    }

                    frm.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No hay ningun dato");
            }
        }
        private void menustpEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.ismodificar_internacion = true;
                this.Datos_Cambio_Estado_Editar();

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void menustpCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Cambio_Estado_internacion = true;
                this.Datos_Cambio_Estado_Editar();

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void mostrarAsignacionSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INTERNACION.FRM_ASIGNACION_SALA_MOSTRAR O = new FRM_ASIGNACION_SALA_MOSTRAR();
            O.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Consultar_internacion = true;
                this.Datos_Cambio_Estado_Editar();

            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count >= 0)
            {
                Program.Consultar_ASIGNACION_SALA = true;
                this.Datos_Consultar_AsignacionSala();            
            }
            else
            {
                MessageBox.Show("Seleccione un Dato");
            }
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            EVOLUCION_MEDICA.Frm_EvolucionMedica_Registrar f = (EVOLUCION_MEDICA.Frm_EvolucionMedica_Registrar)Owner;
            f.txtcodigointernacion.Text = dgvLista.CurrentRow.Cells[0].Value.ToString();
            f.txtccodigomedico.Text = dgvLista.CurrentRow.Cells[3].Value.ToString();
            f.lblcodigomedico.Text = dgvLista.CurrentRow.Cells[2].Value.ToString();
            f.txtobservacion.Focus();
           // Program.isnuevo = true;
            this.Close();
        }
    }
}
