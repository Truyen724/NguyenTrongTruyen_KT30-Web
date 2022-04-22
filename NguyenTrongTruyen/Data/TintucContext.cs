using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Truyen.Models;

namespace NguyenTrongTruyen.Data
{
    public class TintucContext : DbContext
    {
        public TintucContext (DbContextOptions<TintucContext> options)
            : base(options)
        {
        }

        public DbSet<Truyen.Models.Category> Categorys { get; set; }
        public DbSet<Truyen.Models.comment> comments { get; set; }
        public DbSet<Truyen.Models.News> Newss { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<comment>().ToTable("comment");
            modelBuilder.Entity<News>().ToTable("News");
        }

    }

}
