using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_ef.Models
{
    public class News
    {
        public int id { get; set; }
        
        [Required]
        public string title { get; set; }
        public string brief { get; set; }
        public string desc { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }

        [ForeignKey("auther")]
        public int auther_id { get; set; }

        [ForeignKey("catalog")]
        public int cat_id { get; set; } 

        public virtual Auther auther { get; set; }
        public virtual Catalog catalog { get; set; }

    }
}
