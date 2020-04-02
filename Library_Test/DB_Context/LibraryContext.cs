using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_Test.Entities;
using Library_Test.Helpers;

namespace Library_Test.DB_Context
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Users> User { get; set; }
        public DbSet<Books> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            { 
                entity.Property(e => e.CoverPrice)
                    .IsRequired()
                    .HasColumnType("money"); 
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.DateOfCheckout)
                   .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Books>().HasData(new Books
            {
                BookId = Guid.NewGuid(),
                Title = "Being a great Staff of Health Station",
                Isbn = "1234-PPL-HS",
                PublishYear = "2020",
                CoverPrice= 1800.00,
                AvailabilityStatus= "check-in" 


            }, new Books
            {
                BookId = Guid.NewGuid(),
                Title = "INterview 101",
                Isbn = "13454-PPL-HS",
                PublishYear = "2020",
                CoverPrice = 1800.00,
                AvailabilityStatus = "check-Out"
            });

            modelBuilder.Entity<Users>().HasData(new Users
            {
                UserId = Guid.NewGuid(),
                FullName = "Lawrence Olaoluwa",
                Email = "lawrenceolaoluwa1@gmail.com",
                PhoneNumber = "08161813410",
                NationalIdentificationNumber = "12345678",
                DateOfCheckout = DateTime.Now,
                ExpectedDateOfReturn = DateTimeExtensions.AddWorkdays(DateTime.Now, 10),
                BookId = Guid.Parse("54E6C636-55F6-4176-97CA-60CB32E8ED8E")
                

            }, new Users
            {
                UserId = Guid.NewGuid(),
                FullName = "Joseph Olaoluwa",
                Email = "lawrenceolaolaoluwa@outlook.com",
                PhoneNumber = "12345678980",
                NationalIdentificationNumber = "123",
                DateOfCheckout = DateTime.Now,
                ExpectedDateOfReturn = DateTimeExtensions.AddWorkdays(DateTime.Now, 10),
                BookId = Guid.Parse("54E6C636-55F6-4176-97CA-60CB32E8ED8E")

            });


        }
    }
}
