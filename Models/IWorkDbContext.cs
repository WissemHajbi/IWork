using System.IO;

using Microsoft.EntityFrameworkCore;

namespace IWork.Models
{
    public class IWorkDbContext : DbContext
    {

        public DbSet<EmployerModel> Employers { get; set; }
        public DbSet<ApplyModel> Applys { get; set; }

        public IWorkDbContext(DbContextOptions<IWorkDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<EmployerModel>(entity =>
            {
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
                entity.HasData(new EmployerModel
                {
                    Id = 1,
                    Name = "society number 1",
                    Field = "Education",
                    Description = @"We are looking for a Business Intelligence developer in Tunis to help with the workload for our Contact Centre BI team, globally. This is an exciting opportunity for a motivated BI Developer to work, and develop, as part of a multi-disciplined team in a dynamic, fast paced, global organization. The successful candidate will have a strong analytical background, coupled with highly technical skills and should be comfortable working on their own, or as part of a larger group to deliver best in class BI tools.What you will do :
                                    Responsible for the development of Reports, Dashboards & Analytics with an aim to optimise operational business performance.
                                    Collaborate with stakeholders in the analysis, design, development, testing and implementation of premium BI solutions.
                                    Create and automate data flows to improve the data warehouse.
                                    Liaise with both technical and business colleagues located locally and in our international offices.
                                    Provide recommendations to improve system functionality and processes within the BI environment.
                                    Guide and assist the wider development team in leveraging best practices and delivering reusable and scalable strategic components.
                                    Responsible for the development of Custom Web Applications, Dashboards & Analytics with an aim to optimise operational business performance.
                                    What we need from you :
                                    A rigorous, organized and analytical mind.
                                    Fluent in English.
                                    Expertise in SQL and at least one ETL.
                                    Microsoft SQL Server, SSMS, SSRS and SSIS expertise.
                                    Experience of Snowflake and Looker would be an advantage.
                                    Ability to communicate findings, orally and visually, to a variety of audiences
                                    Other Requirements :
                                    Must be expert in Microsoft Excel.
                                    Must be an effective time manager
                                    Must be an effective communicator.
                                    Must be passionate about Reporting and Analytics.About National Pen
                                    At National Pen we strive to be the worldwide leader in providing high value promotional products for businesses and professionals by providing expert knowledge and effective promotional products. With a workforce from over 30 different countries with 18 working languages, we provide a very diverse and multi-cultural environment with on-going training to provide you with the tools to be successful.",
                    Email = "society1@Gmail.com",
                    CoverImage = "/images/fss-logo.png",
                    Image1 = "/images/fss1.png",
                    Image2 = "/images/fss2.png",
                    StartDate = new DateTime(),
                    FPTime = "Full Time"
                });
                entity.HasData(new EmployerModel
                {
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
                entity.HasData(new EmployerModel
                {
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
                entity.HasData(new EmployerModel
                {
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
                entity.HasData(new EmployerModel
                {
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
                entity.HasData(new EmployerModel
                {
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
                entity.HasData(new EmployerModel
                {
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
                entity.HasData(new EmployerModel
                {
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
                entity.HasData(new EmployerModel
                {
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

            mb.Entity<ApplyModel>(entity =>
            {
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