using Microsoft.EntityFrameworkCore;
using SistemaCursos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCursos.Infrastructure.Data.Maps
{
    internal class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder.Property(x => x.EMail)
                .HasColumnType("nvarchar(50)")
                .IsRequired();


            builder.Property(a => a.Endereco)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder.Property(a => a.Ativo)
                .IsRequired();

            builder.HasMany(x => x.Matriculas)
                .WithOne(m => m.Aluno)
                .HasForeignKey(m => m.IdAluno);
        }
    }
}
