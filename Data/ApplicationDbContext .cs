using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace gestionDetteWeb2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Définition des DbSet pour vos entités
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<InscriptionEtudiant> InscriptionEtudiants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration pour `Etudiant`
            modelBuilder.Entity<Etudiant>()
                .HasMany(e => e.inscriptionEtudiants)
                .WithOne(ie => ie.etudiant)
                .HasForeignKey(ie => ie.etudiant._Id);

            modelBuilder.Entity<Etudiant>()
                .HasMany(e => e.absences)
                .WithOne(a => a.Etudiant)
                .HasForeignKey(a => a.Etudiant._Id);

            modelBuilder.Entity<Etudiant>()
                .HasMany(e => e.Lcours)
                .WithOne()
                .HasForeignKey(c => c._Id);

            // Configuration pour `Inscription`
            modelBuilder.Entity<Inscription>()
                .HasMany(i => i.inscriptionEtudiants)
                .WithOne(ie => ie.Inscription)
                .HasForeignKey(ie => ie.Inscription._Id);

            // Configuration pour `Cours`
            modelBuilder.Entity<Cours>()
                .HasMany(c => c.absences)
                .WithOne(a => a.Cours)
                .HasForeignKey(a => a.Cours._Id);

            // Configuration pour `Absence`
            modelBuilder.Entity<Absence>()
                .HasOne(a => a.Etudiant)
                .WithMany(e => e.absences)
                .HasForeignKey(a => a.Etudiant._Id);

            modelBuilder.Entity<Absence>()
                .HasOne(a => a.Cours)
                .WithMany(c => c.absences)
                .HasForeignKey(a => a.Cours._Id);

            // Configuration pour les clés primaires automatiques
            modelBuilder.Entity<Etudiant>().HasKey(e => e._Id);
            modelBuilder.Entity<Cours>().HasKey(c => c._Id);
            modelBuilder.Entity<Absence>().HasKey(a => a._Id);
            modelBuilder.Entity<Inscription>().HasKey(i => i._Id);
            modelBuilder.Entity<InscriptionEtudiant>().HasKey(ie => ie._Id);
        }
    }
}
