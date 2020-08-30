using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KobeAPI.Data
{
    public class KobeDbContext : DbContext
    {
        public KobeDbContext(DbContextOptions<KobeDbContext> options) : base(options))
        {

        }
    }
}
