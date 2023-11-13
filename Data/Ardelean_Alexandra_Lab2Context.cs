using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Alexandra_Lab2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Ardelean_Alexandra_Lab2.Data
{
    public class Ardelean_Alexandra_Lab2Context : DbContext
    {
        public Ardelean_Alexandra_Lab2Context(DbContextOptions<Ardelean_Alexandra_Lab2Context> options)
            : base(options)
        {

        }

        public DbSet<Ardelean_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ardelean_Alexandra_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Ardelean_Alexandra_Lab2.Models.Author>? Authors { get; set; }

        public DbSet<Ardelean_Alexandra_Lab2.Models.Category>? Category { get; set; }
        public DbSet<Ardelean_Alexandra_Lab2.Models.BookCategory>? BookCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }

        public DbSet<Ardelean_Alexandra_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Ardelean_Alexandra_Lab2.Models.Borrowing>? Borrowing { get; set; }

    }
}
