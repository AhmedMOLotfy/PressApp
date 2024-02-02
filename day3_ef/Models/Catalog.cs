using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_ef.Models
{
    public class Catalog
    {
        
        public int id { get; set; }

        [Required]
        [MinLength(3)]
        public string name { get; set; }

        [Required]
        [MinLength(7)]
        public string desc { get; set; }


        // Catalog has number of news
        public virtual List<News> News { get; set; } = new List<News>();
    }
}
