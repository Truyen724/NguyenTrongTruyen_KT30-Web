using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Truyen.Models;

namespace NguyenTrongTruyen.Data
{
    public class CategoryContext : DbContext
    {
        public CategoryContext (DbContextOptions<CategoryContext> options)
            : base(options)
        {
        }

        public DbSet<Truyen.Models.Category> Category { get; set; }
    }
}
