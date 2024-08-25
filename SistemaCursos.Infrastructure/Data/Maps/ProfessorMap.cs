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
    internal class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professores");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder.Property(x => x.EMail)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.HasMany(x => x.Cursos)
           .WithOne(c => c.Professor)
           .HasForeignKey(c => c.IdProfessor);
        }
    }
}
