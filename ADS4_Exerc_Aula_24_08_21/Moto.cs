using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Aula_24_08_21
{
    class Moto
    {
        private string Marca;
        private string Cor;
        private int Ano;

        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string Marca)
        {
            this.Marca = Marca;
        }
        //
        public string GetCor()
        {
            return Cor;
        }
        public void SetCor(string Cor)
        {
            this.Cor = Cor;
        }
        //
        public int GetAno()
        {
            return Ano;
        }
        public void SetAno(int Ano)
        {
            this.Ano = Ano;
        }
        //
    }
}
