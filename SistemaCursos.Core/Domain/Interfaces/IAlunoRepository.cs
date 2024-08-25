using SistemaCursos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Core.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        Aluno BuscarPeloId(int id);
        IEnumerable<Aluno> BuscarTodos();
        void Adicionar(Aluno aluno);
        void Alterar(Aluno aluno);
        void Remover(int id);
    }
}
