using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class CompetitionType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "نوع البطولة")]
        public string Type { get; set; }
        public virtual List<Competition> competitions { get; set; }
    }
}