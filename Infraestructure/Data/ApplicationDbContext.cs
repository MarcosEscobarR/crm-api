using Core.Entities.Cases;
using Core.Entities.Clerk;
using Core.Entities.Common;
using Core.Entities.Company;
using Core.Entities.Contact;
using Core.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Clerk> Clerks { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Banca> Bancas { get; set; }
        public DbSet<CivilStatus> CivilStatus { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Case> Cases { get; set; }
    }
}