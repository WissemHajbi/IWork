using Microsoft.EntityFrameworkCore;

namespace IWork.Models {
     public class IWorkDbContext : DbContext {
        
        public DbSet<EmployerModel> Employers { get; set; }

        public IWorkDbContext(DbContextOptions<IWorkDbContext> options ): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder mb){
            mb.Entity<EmployerModel>(entity => {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id);
                entity.Property(x => x.Name).HasMaxLength(200).IsRequired();
                entity.Property(x => x.Field).HasMaxLength(200).IsRequired();
                entity.Property(x => x.Description).HasMaxLength(2000).IsRequired();
                entity.Property(x => x.Email).HasMaxLength(250);
                entity.HasData(new EmployerModel{
                    Id = 1,
                    Name = "society number 1",
                    Field = "Education",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com"
                });
            });
        }
     }
}