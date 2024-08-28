using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAV2.Entities
{
    class Produto
    {
        public string NomeP { get; set; }
        public double PrecoP { get; set; }

        public Produto(string nomeP, double precoP)
        {
            NomeP = nomeP;
            PrecoP = precoP;
        }
    }
}
