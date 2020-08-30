using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeAPI.Data
{
    public class KobeDbContext : DbContext
    {
        public KobeDbContext(DbContextOptions<KobeDbContext> options) : base(options)
        {

        }
    }
}
