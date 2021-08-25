using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc_Aula_24_08_21
{
    public partial class Form1 : Form
    {
        Carro C1;
        Moto M1;
        public Form1()
        {
            InitializeComponent();
            C1 = new Carro();
            M1 = new Moto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            C1.Marca = textBox1.Text;
            C1.Cor = textBox2.Text;
            C1.Ano = Convert.ToInt32(textBox3.Text);
            //
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            textBox4.Text = C1.Marca;
            textBox5.Text = C1.Cor;
            textBox6.Text = Convert.ToString(C1.Ano);
        }

        private void btn_Gravar2_Click(object sender, EventArgs e)
        {
            M1.SetMarca(textBox10.Text);
            M1.SetCor(textBox11.Text);
            M1.SetAno(Convert.ToInt32(textBox12.Text));
            //
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }

        private void btn_Exibir2_Click(object sender, EventArgs e)
        {
            textBox13.Text = M1.GetMarca();
            textBox14.Text = M1.GetCor();
            textBox15.Text = Convert.ToString(M1.GetAno());
        }
    }
}
