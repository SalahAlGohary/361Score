using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class CompetitionVersion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "نسخة البطولة")]
        public string Version { get; set; }
        [Required]
        [Display(Name = "البطولة")]
        [ForeignKey("competition")]
        public int CompetitionId { get; set; }
        public virtual Competition competition { get; set; }
        public virtual List<TeamCompetition> teamCompetitions { get; set; }
        public virtual List<Match> matches { get; set; }
    }
}