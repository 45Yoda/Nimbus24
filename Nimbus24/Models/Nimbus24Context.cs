using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Nimbus24.Models
{
    public partial class Nimbus24Context : DbContext
    {
        public virtual DbSet<Avaliação> Avaliação { get; set; }
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Morada> Morada { get; set; }
        public virtual DbSet<Preferencia> Preferencia { get; set; }
        public virtual DbSet<Prestador> Prestador { get; set; }
        public virtual DbSet<Serviço> Serviço { get; set; }
        public virtual DbSet<TipoServico> TipoServico { get; set; }

        public Nimbus24Context(DbContextOptions<Nimbus24Context> options)
       : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliação>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Avaliacao).HasColumnName("avaliacao");

                entity.Property(e => e.Obs)
                    .HasColumnName("obs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicoId)
                    .HasColumnName("Servico_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Servico)
                    .WithMany(p => p.Avaliação)
                    .HasForeignKey(d => d.ServicoId)
                    .HasConstraintName("FK_Avaliação_Serviço");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.Cidade1);

                entity.Property(e => e.Cidade1)
                    .HasColumnName("Cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Morada>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CidadeCidade)
                    .HasColumnName("Cidade_cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostal)
                    .HasColumnName("codPostal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Porta).HasColumnName("porta");

                entity.Property(e => e.Rua)
                    .HasColumnName("rua")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CidadeCidadeNavigation)
                    .WithMany(p => p.Morada)
                    .HasForeignKey(d => d.CidadeCidade)
                    .HasConstraintName("FK_Morada_Cidade");
            });

            modelBuilder.Entity<Preferencia>(entity =>
            {
                entity.HasKey(e => new { e.IdPrestador, e.IdCliente });

                entity.Property(e => e.IdPrestador)
                    .HasColumnName("id_Prestador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_Cliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Preferencia)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preferencia_Cliente");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.Preferencia)
                    .HasForeignKey(d => d.IdPrestador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Preferencia_Prestador");
            });

            modelBuilder.Entity<Prestador>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CidadeCidade)
                    .HasColumnName("Cidade_cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.CidadeCidadeNavigation)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.CidadeCidade)
                    .HasConstraintName("FK_Prestador_Cidade");
            });

            modelBuilder.Entity<Serviço>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descrição)
                    .HasColumnName("descrição")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPrestador)
                    .HasColumnName("idPrestador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoradaId).HasColumnName("morada_id");

                entity.Property(e => e.Preço)
                    .HasColumnName("preço")
                    .HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Serviço)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Serviço_Cliente");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.Serviço)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_Serviço_Prestador");

                entity.HasOne(d => d.Morada)
                    .WithMany(p => p.Serviço)
                    .HasForeignKey(d => d.MoradaId)
                    .HasConstraintName("FK_Serviço_Morada");
            });

            modelBuilder.Entity<TipoServico>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPrestador)
                    .HasColumnName("id_Prestador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Negociavel).HasColumnName("negociavel");

                entity.Property(e => e.Preco)
                    .HasColumnName("preco")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.TipoServico)
                    .HasForeignKey(d => d.IdPrestador)
                    .HasConstraintName("FK_TipoServico_Prestador");
            });
        }
    }
}
