using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DetallesDb : DbContext
    {
        public DetallesDb() : base("name=ConStr")
        {

        }

        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Grupos> Grupo { get; set; }
        public DbSet<GruposEstudiantes> GruposEstudiantes { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Grupos>()
        //        .HasMany<Estudiantes>(g => g.Estudiante)
        //        .WithMany(e => e.Grupos)
        //        .Map(Ge =>
        //        {
        //            Ge.MapLeftKey("GrupoId");
        //            Ge.MapRightKey("EstudianteId");
        //            Ge.ToTable("GruposEstudiantes");
        //        });
        //}
    }
}
