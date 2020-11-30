using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class MatchStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "حالة المباراة")]
        public string Status { get; set; }
        public virtual List<Match> Matches { get; set; }
    }
}