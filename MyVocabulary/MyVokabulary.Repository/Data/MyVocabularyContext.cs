using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyVokabulary.Repository.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MyVokabulary.Repository.Data
{
    public class MyVocabularyContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<LanguageDoublet> LanguageDoublets { get; set; }

        public MyVocabularyContext(DbContextOptions<MyVocabularyContext> options)
        : base(options)
        {
            Database.EnsureCreated();
            Console.WriteLine("pis");
        }
        //public MyVocabularyContext() => Database.EnsureCreated();
        public MyVocabularyContext() 
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Integrated Security=True;Initial Catalog=MyVocabulary;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
        }
    }
}
