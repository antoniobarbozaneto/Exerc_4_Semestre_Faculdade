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
    public partial class Frm_Endereco : Form
    {
        public Frm_Endereco()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Endereco Endereco = new Endereco();

            Endereco.Rua = textBox1.Text;
            Endereco.Bairro = textBox2.Text;
            Endereco.Numero = Convert.ToInt32(textBox3.Text);

            //
            Ctr_Endereco Ctr_Endereco = new Ctr_Endereco();
            //
            MessageBox.Show(Ctr_Endereco.Cadastro(Endereco));//esse mtd tem retorno
        }
    }
}
