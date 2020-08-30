using KobeAPI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeAPI.Models.Service
{
    public class KobeService : IKobe
    {
        public IEnumerable<Kobe> GetAllRecords()
        {
            var records = new List<Kobe>()
            {
            new Kobe { ID = 0, Age = 20, Name = "Kobe", Record = "dunk", Team = "Lakers", Year = 2001 },
            new Kobe { ID = 1, Age = 21, Name = "Kobe", Record = "free throw", Team = "Lakers", Year = 2002 },
            new Kobe { ID = 1, Age = 22, Name = "Kobe", Record = "shooting", Team = "Lakers", Year = 2003 }
            };
            return records;
        }


        public Kobe GetOneRecord(int id)
        {
            return new Kobe { ID = 0, Age = 20, Name = "Kobe", Record = "IDK", Team = "Lakers", Year = 2000 };
        }
    }
}

