using SistemaCursos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Core.Domain.Interfaces
{
    public interface ICursoRepository
    {
        Curso BuscarPeloId(int id);
        IEnumerable<Curso> BuscarTodos();
        void Adicionar(Curso curso);
        void Alterar(Curso curso);
        void Remover(int id);
    }
}
