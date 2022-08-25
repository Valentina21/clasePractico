using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
namespace Libreria
{
    public class ContextDb : DbContext
    {
        public DbSet<PersonDocument> PersonsDocuments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Document> Documents { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonDocument>()
                .HasKey(pp => new { pp.Personld, pp.DocumentId });
            modelBuilder.Entity<Person>(person =>
            {
                person.HasKey(x => x.Id);
                person.HasMany(x => x.Personsdocuments)
                    .WithOne(personDocument => personDocument.Person)
                    .HasForeignKey(personDocument => personDocument.Personld);
            });

            modelBuilder.Entity<Document>(document =>
            {
                document.HasKey(x => x.Id);
                document.HasMany(x => x.Personsdocuments)
                    .WithOne(personDocument => personDocument.Document)
                    .HasForeignKey(personDocument => personDocument.DocumentId);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.\\SQLSERVER;Server=localhost,1433;Database=DBClase1;Trusted_Connection=False;MultipleActiveResultSets=True;User=sa;Password=123abc;");
        }
    }
}
