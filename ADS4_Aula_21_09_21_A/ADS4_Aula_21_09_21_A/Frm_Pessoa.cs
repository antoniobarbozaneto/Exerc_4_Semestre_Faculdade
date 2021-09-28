using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS4_Aula_21_09_21_A
{
    public partial class Frm_Pessoa : Form // view
    {
        public Frm_Pessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //String tmp;
            Erro Erro = new Erro();

            //string Nome; //double Cpf; //int RG;
            Pessoa Pessoa = new Pessoa();

            Pessoa.Nome = textBox1.Text;
            Pessoa.CPF = Convert.ToDouble(textBox2.Text);
            Pessoa.RG = Convert.ToInt32(textBox3.Text);
            Pessoa.RA = (textBox4.Text);

            Ctr_Pessoa Ctr_Pessoa = new Ctr_Pessoa();
            //tmp = 
            Erro=Ctr_Pessoa.Cadastro(Pessoa);
            //(Pessoa.Nome, Pessoa.CPF, Pessoa.RG, Pessoa.RA);
            MessageBox.Show(Erro.Desc);
            //(tmp);


        }
    }
}
