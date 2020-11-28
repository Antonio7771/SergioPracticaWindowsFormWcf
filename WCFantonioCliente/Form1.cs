using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFantonioCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client anime = new ServiceReference1.Service1Client();
            string[] anime_encontrado;
            anime_encontrado = anime.buscar(int.Parse (textBox1.Text));
            textBox2.Text = anime_encontrado[0];
            textBox3.Text = anime_encontrado[1];
            textBox4.Text = anime_encontrado[2];
            textBox5.Text = anime_encontrado[3];
        }
    }
}
