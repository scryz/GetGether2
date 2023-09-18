using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GetGether2.Models
{
    
        public class DbContexts : DbContext
        {
            public DbContexts(DbContextOptions<DbContexts> options) : base(options)
            {
            }

            public DbSet<Survey> Surveys { get; set; }



        }
    
}
