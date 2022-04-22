using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Truyen.Models;

namespace NguyenTrongTruyen.Data
{
    public class NewsContext : DbContext
    {
        public NewsContext (DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public DbSet<Truyen.Models.News> News { get; set; }
    }
}
