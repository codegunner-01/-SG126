using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examensg
{
    public partial class Form1 : Form
    {
        Vector v1, v2, v3, v4;

 

  


    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            v4 = new Vector();
        }

        //cargar 1

        private void cargarRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }



        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = v1.Descargar();
        }


        //cargar 2
        private void cargarRandomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //v2.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            //textBox5.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = v2.Descargar();
        }

        //llamadas
        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);

            v1.Ejercicio1(a, b, ref v2);

            textBox7.Text = v2.Descargar();
        }

        private void ejercici2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            v1.Ejercicio2(a, b);
            //textBox7.Text = v1.Descargar();

        }
    }
}
