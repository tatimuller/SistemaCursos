using SistemaCursos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Core.Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Matricula BuscarPorId(int id);
        IEnumerable<Matricula> BuscarTodos();
        void Adicionar(Matricula matricula);
        void Alterar(Matricula matricula);
        void Remover(int id);
    }
}
