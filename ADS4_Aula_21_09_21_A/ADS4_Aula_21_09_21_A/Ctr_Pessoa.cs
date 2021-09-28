using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS4_Aula_21_09_21_A
{
    class Ctr_Pessoa // controle
    {

        public Erro Cadastro(Pessoa Pessoa)
            //(string Nome,double Cpf, int RG, int RA)
        {
            // cadastro.
            Erro Erro = new Erro();
            Erro.Desc = "funcionou " + Pessoa.Nome + " " + Pessoa.CPF + " " + Pessoa.RG + Pessoa.RA;
          return Erro;
        }
    }
}
