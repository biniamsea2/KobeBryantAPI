using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeAPI.Models.Interface
{
    public class IKobe
    {
        //Get individual record
        IEnumerable<Kobe> GetAllRecords();

        //Get all records
        Kobe GetOneRecord(int id);

    }
}
