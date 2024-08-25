using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Core.Domain.Entities
{
    public class Professor : Pessoa
    {
        public List<Curso> Cursos { get; set; } = new List<Curso>();

        public Professor() { }

        public Professor(string nome, string eMail) : base(nome, eMail)
        {

        }
    }
}
