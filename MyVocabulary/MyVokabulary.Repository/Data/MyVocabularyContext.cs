using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyVokabulary.Repository.Models;

namespace MyVokabulary.Repository.Data
{
    public class MyVocabularyContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<LanguageDoublet> LanguageDoublets { get; set; }

        public MyVocabularyContext(DbContextOptions<MyVocabularyContext> options) : base(options)
        {
        }
    }
}
