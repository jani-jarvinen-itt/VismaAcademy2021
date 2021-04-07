using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMigraatiot
{
    public class OmaKonteksti : DbContext
    {
        public virtual DbSet<Tehtävä> Tehtävät { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MunOmaKanta;Trusted_Connection=True;");
            }
        }
    }
}
