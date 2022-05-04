using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingLottoAdatBazis
{
    public class VikingContext:DbContext
    {
        public DbSet<LottoSzam> LottoSzamok { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Viking0430;Trusted_Connection=true");
        }
    }
    
}
