using SistemaCursos.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Aplication.DTOs
{
    public class MatriculaDTO
    {
        public int Id { get; set; }
        public DateTime DataMatricula { get; set; }
        public EnumStatusMatricula Status { get; set; }
        public AlunoDTO Aluno { get; set; }
        public CursoDTO Curso { get; set; }
    }
}
