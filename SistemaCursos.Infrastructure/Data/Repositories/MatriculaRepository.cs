using Microsoft.EntityFrameworkCore;
using SistemaCursos.Core.Domain.Entities;
using SistemaCursos.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Infrastructure.Data.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        private readonly Contexto _contexto;

        public MatriculaRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Matricula BuscarPorId(int id)
        {
            return _contexto.Matriculas.Include(m => m.Aluno)
                                       .Include(m => m.Curso)
                                       .FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Matricula> BuscarTodos()
        {
            return _contexto.Matriculas.Include(m => m.Aluno)
                                       .Include(m => m.Curso)
                                       .ToList();
        }

        public void Adicionar(Matricula matricula)
        {
            _contexto.Matriculas.Add(matricula);
            _contexto.SaveChanges();
        }

        public void Alterar(Matricula matricula)
        {
            _contexto.Matriculas.Update(matricula);
            _contexto.SaveChanges();
        }

        public void Remover(int id)
        {
            var matricula = BuscarPorId(id);
            _contexto.Matriculas.Remove(matricula);
            _contexto.SaveChanges();
        }
    }
}
