using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using KobeBryantAPI.Model;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace KobeBryantAPI.Data
{
    public class KobeDBContext : DbContext
    {
        public KobeDBContext(DbContextOptions<KobeDBContext> options) : base(options)
        {
        }
    }
}
