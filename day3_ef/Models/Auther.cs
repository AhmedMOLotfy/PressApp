using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_ef.Models
{
    public class Auther
    {
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string name { get; set; }
        public int? age { get; set; }

        // Auther has number of news
        public virtual List<News> news { get; set; } = new List<News>();
    }
}
