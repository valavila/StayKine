using Microsoft.EntityFrameworkCore;
using MillionMealsGoldLeaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillionMealsGoldLeaf.Data
{
    public class EmailContext : DbContext
    {
        public EmailContext(DbContextOptions<EmailContext> options)
            :base(options){}

        public DbSet<Email> Emails { get; set; }
    }
}
