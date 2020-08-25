using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KobeBryantAPI.Model
{
    public class Kobe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
        public int Year { get; set; }
        public string Record { get; set; }
    }
}
