using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sistema_de_reserva_bilhetes.Models;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Data
{
    public partial class BaseTeatrosContext : DbContext
    {
        public BaseTeatrosContext()
        {
        }

        public BaseTeatrosContext(DbContextOptions<BaseTeatrosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ComprarBilhete> ComprarBilhetes { get; set; }
        public virtual DbSet<Espetaculo> Espetaculos { get; set; }
        public virtual DbSet<RegistaEspetaculo> RegistaEspetaculos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Sessao> Sessaos { get; set; }
        public virtual DbSet<Teatro> Teatros { get; set; }
        public virtual DbSet<Utilizador> Utilizadors { get; set; }
        
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    if (!optionsBuilder.IsConfigured)
                    {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BaseTeatros;Trusted_Connection=True;");
                    }
                }

                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

                    modelBuilder.Entity<ComprarBilhete>(entity =>
                    {
                        entity.HasKey(e => e.IdCompra)
                            .HasName("PK__comprar___C4BAA6046100FA35");

                        entity.HasOne(d => d.IdReservaNavigation)
                            .WithMany(p => p.ComprarBilhetes)
                            .HasForeignKey(d => d.IdReserva)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__comprar_b__id_re__3F466844");

                        entity.HasOne(d => d.IdUtilizadorNavigation)
                            .WithMany(p => p.ComprarBilhetes)
                            .HasForeignKey(d => d.IdUtilizador)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__comprar_b__id_ut__3E52440B");
                    });

                    modelBuilder.Entity<Espetaculo>(entity =>
                    {
                        entity.HasKey(e => e.IdEspetaculo)
                            .HasName("PK__espetacu__61B3E24FA954C9F9");

                        entity.Property(e => e.Nome).IsUnicode(false);

                        entity.Property(e => e.Sinopse).IsUnicode(false);
                    });

                    modelBuilder.Entity<RegistaEspetaculo>(entity =>
                    {
                        entity.HasKey(e => e.IdRegisto)
                            .HasName("PK__regista___CCF65B4368671D8C");

                        entity.HasOne(d => d.IdEspetaculoNavigation)
                            .WithMany(p => p.RegistaEspetaculos)
                            .HasForeignKey(d => d.IdEspetaculo)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__regista_e__id_es__34C8D9D1");

                        entity.HasOne(d => d.IdSessaoNavigation)
                            .WithMany(p => p.RegistaEspetaculos)
                            .HasForeignKey(d => d.IdSessao)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__regista_e__id_se__33D4B598");

                        entity.HasOne(d => d.IdTeatroNavigation)
                            .WithMany(p => p.RegistaEspetaculos)
                            .HasForeignKey(d => d.IdTeatro)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__regista_e__id_te__35BCFE0A");
                    });

                    modelBuilder.Entity<Reserva>(entity =>
                    {
                        entity.HasKey(e => e.IdReserva)
                            .HasName("PK__reserva__423CBE5DB46428E7");

                        entity.HasOne(d => d.IdRegistoNavigation)
                            .WithMany(p => p.Reservas)
                            .HasForeignKey(d => d.IdRegisto)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__reserva__id_regi__3A81B327");
                    });

                    modelBuilder.Entity<Sessao>(entity =>
                    {
                        entity.HasKey(e => e.IdSessao)
                            .HasName("PK__sessao__D45775D416284B0B");
                    });

                    modelBuilder.Entity<Teatro>(entity =>
                    {
                        entity.HasKey(e => e.IdTeatro)
                            .HasName("PK__teatro__B34DF8E56D1289C4");

                        entity.Property(e => e.Email).IsUnicode(false);

                        entity.Property(e => e.Localizacao).IsUnicode(false);

                        entity.Property(e => e.MoradaTeatro).IsUnicode(false);

                        entity.Property(e => e.NomeTeatro).IsUnicode(false);
                    });

              
                    modelBuilder.Entity<Utilizador>(entity =>
                    {
                        entity.HasKey(e => e.IdUtilizador)
                            .HasName("PK__Utilizad__71C53683E162F4E5");

                        entity.Property(e => e.Localidade).IsUnicode(false);

                        entity.Property(e => e.Nif).IsUnicode(false);

                        entity.Property(e => e.Nome).IsUnicode(false);

                        entity.Property(e => e.Pass).IsUnicode(false);

                        entity.Property(e => e.Username).IsUnicode(false);

                        entity.Property(e => e.Tipoutilizador).IsUnicode(false);
                    });

                    OnModelCreatingPartial(modelBuilder);
                }

                partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
            }
        
    }

