using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAV2.Entities
{
    class Cliente
    {
        public string NomeC { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public Cliente(string nomeC, string email, DateTime nascimento)
        {
            NomeC = nomeC;
            Email = email;
            Nascimento = nascimento;
        }
    }
}
