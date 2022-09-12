using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiChatIdra.Models
{
    public partial class chatIdraContext : DbContext
    {
      

        public chatIdraContext(DbContextOptions<chatIdraContext> options) : base(options)
        {

        }

        public virtual DbSet<Mensaje> Mensajes { get; set; } = null!;
        public virtual DbSet<SalasChat> SalasChats { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioSala> UsuarioSalas { get; set; } = null!;

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=DESKTOP-B4HOPRI\\SQLEXPRESS;Database=chatIdra;Trusted_Connection=True;");
        //            }
        //        }

        //        protected override void OnModelCreating(ModelBuilder modelBuilder)
        //        {
        //            modelBuilder.Entity<Mensaje>(entity =>
        //            {
        //                entity.Property(e => e.Id).HasColumnName("id");

        //                entity.Property(e => e.IdSala).HasColumnName("Id_Sala");

        //                entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

        //                entity.Property(e => e.Mensaje1).HasColumnName("Mensaje");

        //                entity.HasOne(d => d.IdSalaNavigation)
        //                    .WithMany(p => p.Mensajes)
        //                    .HasForeignKey(d => d.IdSala)
        //                    .OnDelete(DeleteBehavior.ClientSetNull)
        //                    .HasConstraintName("fk_mensajes_salaschat");

        //                entity.HasOne(d => d.IdUsuarioNavigation)
        //                    .WithMany(p => p.Mensajes)
        //                    .HasForeignKey(d => d.IdUsuario)
        //                    .OnDelete(DeleteBehavior.ClientSetNull)
        //                    .HasConstraintName("fk_mensajes_usuario");
        //            });

        //            modelBuilder.Entity<SalasChat>(entity =>
        //            {
        //                entity.ToTable("SalasChat");

        //                entity.Property(e => e.IdTipoSala)
        //                    .HasColumnName("Id_TipoSala")
        //                    .HasComment("0 publico\\n1 privado");
        //            });

        //            modelBuilder.Entity<Usuario>(entity =>
        //            {
        //                entity.ToTable("Usuario");

        //                entity.Property(e => e.Usuario1).HasColumnName("Usuario");
        //            });

        //            modelBuilder.Entity<UsuarioSala>(entity =>
        //            {
        //                entity.HasNoKey();

        //                entity.ToTable("Usuario_Salas");

        //                entity.Property(e => e.IdSala).HasColumnName("Id_Sala");

        //                entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

        //                entity.HasOne(d => d.IdSalaNavigation)
        //                    .WithMany()
        //                    .HasForeignKey(d => d.IdSala)
        //                    .HasConstraintName("fk_usuario_salas_salaschat");

        //                entity.HasOne(d => d.IdUsuarioNavigation)
        //                    .WithMany()
        //                    .HasForeignKey(d => d.IdUsuario)
        //                    .HasConstraintName("fk_usuario_salas_usuario");
        //            });

        //            OnModelCreatingPartial(modelBuilder);
        //        }

        //        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        //    }
        //}
    }
}