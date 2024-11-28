using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBooking.Models;

    public class MVCLibaryContext : DbContext
    {
        public MVCLibaryContext (DbContextOptions<MVCLibaryContext> options)
            : base(options)
        {
        }

        public DbSet<MVCBooking.Models.Book> Book { get; set; } = default!;
    }
