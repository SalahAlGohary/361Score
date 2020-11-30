using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "البلد")]
        public string CountryName { get; set; }
        public virtual List<Player> players { get; set; }
        public virtual List<Team> teams { get; set; }
        public virtual List<Competition> competitions { get; set; }
    }
}