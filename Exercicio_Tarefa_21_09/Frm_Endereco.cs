using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Tarefa_21_09
{
    public partial class Frm_Endereco : Form
    {
        public Frm_Endereco()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Endereco Endereco = new Endereco();

            //Populando os dados com na classe MODELO
            Endereco.Rua = textBox1.Text;
            Endereco.Bairro = textBox2.Text;
            Endereco.Numero = Convert.ToInt32(textBox3.Text);

            Ctr_Endereco Ctr_Endereco = new Ctr_Endereco();

           // Ctr_Endereco.Cadastrar(Endereco); //A view passando um OBJETO do tipo ENDERECO para o Metodo Cadastro da classe Controler

            MessageBox.Show(Ctr_Endereco.Cadastrar(Endereco));

        }
    }
}
