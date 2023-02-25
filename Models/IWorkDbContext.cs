using System.IO;

using Microsoft.EntityFrameworkCore;

namespace IWork.Models {
     public class IWorkDbContext : DbContext {
        
        public DbSet<EmployerModel> Employers { get; set; }
        public DbSet<ApplyModel> Applys {get; set; }

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
                entity.Property(x => x.CoverImage).IsRequired();
                entity.Property(x => x.Image1);
                entity.Property(x => x.Image2);
                entity.Property(x => x.StartDate);
                entity.Property(x => x.FPTime);
                entity.HasData(new EmployerModel{
                    Id = 1,
                    Name = "society number 1",
                    Field = "Education",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/fss-logo.png",
                    Image1 = "/images/fss1.png",
                    Image2 = "/images/fss1.png",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 2,
                    Name = "society number 2",
                    Field = "Education",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/fss-logo.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Part Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 3,
                    Name = "society number 3",
                    Field = "Education",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/fss-logo.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 4,
                    Name = "society number 4",
                    Field = "Computer science",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/trip1.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 5,
                    Name = "society number 5",
                    Field = "Computer science",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/trip1.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 6,
                    Name = "society number 6",
                    Field = "Computer science",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/trip1.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 7,
                    Name = "society number 7",
                    Field = "Medical",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/trip2.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 8,
                    Name = "society number 8",
                    Field = "Medical",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/trip2.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel{
                    Id = 9,
                    Name = "society number 9",
                    Field = "Medical",
                    Description = "this is a dumb text description for development gangy",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/trip2.png",
                    Image1 = "",
                    Image2 = "",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
            });

            mb.Entity<ApplyModel>(entity => {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).HasMaxLength(200).IsRequired();
                entity.Property(x => x.Prename).HasMaxLength(200).IsRequired();
                entity.Property(x => x.Email).HasMaxLength(250);
                entity.Property(x => x.Experience).HasMaxLength(250);
                entity.Property(x => x.Description).HasMaxLength(2000).IsRequired();
                entity.Property(x => x.StartDate);  
            });
        }

     }
}