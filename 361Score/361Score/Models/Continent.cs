using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Continent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "القارة")]
        public string ContinentName { get; set; }
        public virtual List<Team> teams { get; set; }
        public virtual List<Competition> competitions { get; set; }
    }
}