using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS4_Aula_21_09_21_A
{
    class Ctr_Endereco
    {

        public string Cadastro(Endereco Endereco)
        {
            string temp;

            //Aqui vai gravar no BD
            return temp = "Cadastrado com sucesso!!!" + Endereco.Rua + " " + Endereco.Bairro + " " + Endereco.Numero;
        }
    }
}
