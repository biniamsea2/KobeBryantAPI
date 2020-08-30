using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeAPI.Models
{
    public class Kobe : ControllerBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public string Team { get; set; }
        public string Record { get; set; }
    }
}
