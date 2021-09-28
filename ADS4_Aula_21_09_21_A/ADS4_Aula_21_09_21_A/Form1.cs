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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Pessoa Frm_Pessoa = new Frm_Pessoa();

            Frm_Pessoa.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form endereco

            Frm_Endereco Frm_Endereco = new Frm_Endereco();

            Frm_Endereco.ShowDialog();
        }
    }
}
