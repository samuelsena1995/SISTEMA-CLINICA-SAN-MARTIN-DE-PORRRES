﻿using System;
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
    public partial class Frm_Reporte_Usuario : Form
    {
        public Frm_Reporte_Usuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_1_Click(object sender, EventArgs e)
        {
            Reporte.Frm_USUARIO_Reporte obj = new Reporte.Frm_USUARIO_Reporte();

            obj.SET_REPORTE_USUARIO_NUEVO(cboEstado.Text, cbTipo.Text, textBox1.Text);
            obj.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
