using ChanaweeDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Infra.Data.Context
{
    public class ChanaweeDemoDBContext : DbContext
    {
        public ChanaweeDemoDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
