using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Truyen.Models;

namespace NguyenTrongTruyen.Data
{
    public class commentContext : DbContext
    {
        public commentContext (DbContextOptions<commentContext> options)
            : base(options)
        {
        }

        public DbSet<Truyen.Models.comment> comment { get; set; }
    }
}
