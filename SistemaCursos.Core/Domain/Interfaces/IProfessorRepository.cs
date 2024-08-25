using SistemaCursos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Core.Domain.Interfaces
{
    public interface IProfessorRepository
    {
        Professor BuscarPorId(int id);
        IEnumerable<Professor> BuscarTodos();
        void Adicionar(Professor professor);
        void Alterar(Professor professor);
        void Remover(int id);
    }
}
