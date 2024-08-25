using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaCursos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Infrastructure.Data.Maps
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.HasOne(x => x.Professor)
           .WithMany(p => p.Cursos)
           .HasForeignKey(c => c.IdProfessor);

            builder.HasMany(x => x.Matriculas)
                .WithOne(m => m.Curso)
                .HasForeignKey(m => m.Id);
        }
    }
}
