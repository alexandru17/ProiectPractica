using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProiectPractica.Models;

namespace ProiectPractica.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        // Add profile data for application users by adding properties to the ApplicationUser class

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Proiect> Proiecte { get; set; }
        public DbSet<TaskProiect> Taskuri { get; set; }
        public DbSet<Subcontractor> Subcontractori { get; set; }
        public DbSet<ResponsabilProiect> ResponsabiliProiecte { get; set; }

        public DbSet<ActAditional> ActeAditionale { get; set; }
        public DbSet<PrelungireContract> PrelungiriContracte { get; set; }
        public DbSet<ModificareValoare> ModificariValoare { get; set; }
        public DbSet<ModificareLivrabile> ModificariLivrabile { get; set; }
    }
}
