using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Tarefa_21_09
{
    class Ctr_Endereco
    {

        public string Cadastrar(Endereco Endereco)
        {
            string temp;

            return temp = "Cadastrado com sucesso! "+ Endereco.Rua + " " + Endereco.Bairro + " " + Endereco.Numero;
        }
    }
}
