using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Tags
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "الكلمات الدالة")]
        public string Name { get; set; }
        public virtual List<NewsTags> newsTags { get; set; }
    }
}