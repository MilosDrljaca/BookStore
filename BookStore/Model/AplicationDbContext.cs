using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions <AplicationDbContext> options ) :base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
