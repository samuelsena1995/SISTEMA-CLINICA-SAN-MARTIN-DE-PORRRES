using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Messager
{
    public partial class FrmAlerta : Form
    {
        public FrmAlerta()
        {
            InitializeComponent();
        }

        private void FrmAlerta_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Timer1.Interval = 1000;
           
        }    
        public enum alertTypeEnum
        {
            Success,
            Warning,
            Error,
            Info
        }

        private int x, y;
        public void setAlert(string msg, FrmAlerta.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FrmAlerta f = (FrmAlerta)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case FrmAlerta.alertTypeEnum.Success:
                   this.pictureBox1.Image = Capa_Presentacion.Properties.Resources.checkmark_96px;
                    // this.BackColor = Color.FromArgb(42, 171, 160);
                    panel1.BackColor = Color.FromArgb(42, 171, 160);
                    break;
                /*case FrmAlerta.alertTypeEnum.Warning:
                    // this.GunaPictureBox1.Image = Resources.Warning_28px;
                    this.BackColor = Color.FromArgb(71, 169, 248);
                    break;*/
                case FrmAlerta.alertTypeEnum.Error:

                    this.pictureBox1.Image = Capa_Presentacion.Properties.Resources.warning_48px;
                    panel1.BackColor = Color.FromArgb(255, 121, 70);
                    break;
             //   case FrmAlerta.alertTypeEnum.Info:
               //     this.GunaPictureBox1.Image = Resources.Info_28px;
                 //   this.BackColor = Color.FromArgb(71, 169, 248);
                  //  break;
            }
            this.label2.Text = msg;

            //this.TopMost = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            this.Timer1.Interval = 1;
            this.Timer1.Start();


        }

        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private FrmAlerta.actionEnum action;


      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAlerta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer1.Interval = 3000;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Timer1.Interval = 5000;
            this.action = FrmAlerta.actionEnum.close;
        }

        private void lblDato_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case FrmAlerta.actionEnum.wait:
                    this.Timer1.Interval = 4000;
                    this.action = FrmAlerta.actionEnum.close;
                    break;
                case FrmAlerta.actionEnum.start:
                    this.Timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = FrmAlerta.actionEnum.wait;
                        }
                    }
                    break;
                case FrmAlerta.actionEnum.close:
                    this.Timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

      
    }
}
