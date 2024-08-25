using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Core.Domain.Entities
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string ?Nome { get; set; }
        public string ?EMail { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string eMail)
        {
            Nome = nome;
            EMail = eMail;
        }

    }
}
