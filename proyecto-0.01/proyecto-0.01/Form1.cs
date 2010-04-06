using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//holocracia

namespace proyecto_0._01
{
    public partial class Form1 : Form
    {
        DateTime hora;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label3.Text = DateTime.Now.ToLongTimeString();

            if (comboBox1.Text == "Apagar" && hora.ToShortTimeString() == DateTime.Now.ToShortTimeString())
            {
                 System.Diagnostics.Process.Start("shutdown.exe", "-s -f -t 00");
               
                

            }
            else if (comboBox1.Text == "Reiniciar" && hora.ToShortTimeString() == DateTime.Now.ToShortTimeString())
            {
                System.Diagnostics.Process.Start("shutdown.exe", "-r -f -t 00");
              
               

            }

            else if (comboBox1.Text == "Hibernar" && hora.ToShortTimeString() == DateTime.Now.ToShortTimeString())
            {
                System.Diagnostics.Process.Start("rundll32.exe", "PowrProf.dll SetSuspendState Hibernate");
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hora = Convert.ToDateTime(textBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -f -t 00");
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("shutdown.exe", "-s -f -t 00");
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "PowrProf.dll SetSuspendState Hibernate");
           
        }




    }
}
