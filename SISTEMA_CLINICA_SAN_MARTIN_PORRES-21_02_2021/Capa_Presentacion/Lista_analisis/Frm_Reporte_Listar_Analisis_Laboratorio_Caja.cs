using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Capa_Presentacion.Lista_analisis
{
    public partial class Frm_Reporte_Listar_Analisis_Laboratorio_Caja : Form
    {
        public Frm_Reporte_Listar_Analisis_Laboratorio_Caja()
        {
            InitializeComponent();
        
        }
       
        private void btnBuscar_1_Click(object sender, EventArgs e)
        {
            //Reporte.Reporte_General_Caja obj = new Reporte.Reporte_General_Caja();
            Reporte.Reporte_General_Caja2 obj = new Reporte.Reporte_General_Caja2();
            
            obj.SET_REPORTE_LISTA_NUEVO(cboEstado.Text,cbTipo.Text,textBox1.Text);
            obj.ShowDialog();
        }

        private void Frm_Reporte_Listar_Analisis_Laboratorio_Caja_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            cboEstado.Text = "Todos";
            cbTipo.Text = "Todos";
                
        }      
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// </summary>

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboEstado.Text == "Habilitado" && cbTipo.Text == "Nombre")
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;                  
                }                
            }
         else   if (cboEstado.Text == "Deshabilitado" && cbTipo.Text == "Nombre")
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (cboEstado.Text == "Deshabilitado" && cbTipo.Text == "Codigo")
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            else
            {
                if (cboEstado.Text == "Habilitado" && cbTipo.Text == "Codigo")
                {
                    if (Char.IsDigit(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                
                }
                
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//cbtipo
        {
            if (cbTipo.Text == "Todos" && cboEstado.Text == "Todos")
            {
                textBox1.Enabled = false;
            }
            //else
            //{

            //    textBox1.Enabled = true;
            //}
              if (cbTipo.Text == "Nombre" && cboEstado.Text == "Todos")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = true;
              }
              if (cbTipo.Text == "Codigo" && cboEstado.Text == "Todos")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = true;
              }
              //
                          ////////////////////
              if (cbTipo.Text == "Codigo" && cboEstado.Text == "Habilitado")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = true;
              }
              if (cbTipo.Text == "Nombre" && cboEstado.Text == "Habilitado")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = true;
              }
              ////
              if (cbTipo.Text == "Nombre" && cboEstado.Text == "Deshabilitado")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = true;
              }
              if (cbTipo.Text == "Codigo" && cboEstado.Text == "Deshabilitado")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = true;
              }
              ////

              if (cbTipo.Text == "Todos" && cboEstado.Text == "Habilitado")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = false;
              }
              if (cbTipo.Text == "Todos" && cboEstado.Text == "Deshabilitado")
              {
                  textBox1.Text = "";
                  textBox1.Enabled = false;
              }
            //
        }
        public void bloquearCaja() {
       
        }

        private void cboCampo_1_SelectedIndexChanged(object sender, EventArgs e)//estado
        {
            if (cbTipo.Text == "Todos" && cboEstado.Text == "Todos")
            {
                textBox1.Enabled = false;
            }
            else {

                textBox1.Enabled = true;
            }
           if (cbTipo.Text == "Nombre" && cboEstado.Text == "Todos")
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
            }
            if (cbTipo.Text == "Codigo" && cboEstado.Text == "Todos")
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
            }
            //
            ////////////////////
            if (cbTipo.Text == "Codigo" && cboEstado.Text == "Habilitado")
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
            }
            if (cbTipo.Text == "Nombre" && cboEstado.Text == "Habilitado")
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
            }
            ////
            if (cbTipo.Text == "Nombre" && cboEstado.Text == "Deshabilitado")
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
            }
            if (cbTipo.Text == "Codigo" && cboEstado.Text == "Habilitado")
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
            }
            ////

            if (cbTipo.Text == "Todos" && cboEstado.Text == "Habilitado")
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
            if (cbTipo.Text == "Todos" && cboEstado.Text == "Deshabilitado")
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
            //
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }       
    }
}
