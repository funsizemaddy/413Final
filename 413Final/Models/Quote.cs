using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string quote { get; set; }
        [Required]
        public string author { get; set; }
        public string date { get; set; }
        public string subject { get; set; }
        public string citation { get; set; }

    }
}
