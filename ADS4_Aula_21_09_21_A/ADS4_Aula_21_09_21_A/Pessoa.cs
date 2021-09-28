using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS4_Aula_21_09_21_A
{
    class Pessoa // modelo
    {
        public String Nome { get; set; }
        public double CPF { get; set; }
        public int RG { get; set; }
        public string RA { get; set; }

        public Pessoa()
        {
            Nome = "Vazio";
            CPF = 123456789;
            RG = 321;
            RA = "111";
        }

    }
}
