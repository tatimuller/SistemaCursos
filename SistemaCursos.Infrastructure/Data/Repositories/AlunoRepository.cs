using SistemaCursos.Core.Domain.Entities;
using SistemaCursos.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Infrastructure.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly Contexto _contexto;

        public AlunoRepository(Contexto context)
        {
            _contexto = context;
        }

        public Aluno BuscarPeloId(int id)
        {
            return _contexto.Alunos.Find(id);
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _contexto.Alunos.ToList();
        }

        public void Adicionar(Aluno aluno)
        {
            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();
        }

        public void Alterar(Aluno aluno)
        {
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();
        }

        public void Remover(int id)
        {
            var aluno = BuscarPeloId(id);
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
        }

        public IEnumerable<Aluno> BuscarTodos()
        {
            return _contexto.Alunos.ToList();
        }
    }
}
