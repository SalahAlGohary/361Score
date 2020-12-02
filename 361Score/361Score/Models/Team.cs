using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "إسم الفريق")]
        public string Name { get; set; }
        [Display(Name = "الشعار")]
        public string Logo { get; set; }
        [Display(Name = "المدرب")]
        public string CoachName { get; set; }
        [Display(Name = "صورة المدرب")]
        public string CoachImg { get; set; }
        [Display(Name = "نوع الفريق")]
        public Boolean ClubTeam { get; set; }
        [ForeignKey("country")]
        [Display(Name = "البلد")]
        public int Country { get; set; }
        [ForeignKey("continent")]
        [Display(Name = "القارة")]
        public int Continent { get; set; }
        public virtual Country country { get; set; }
        public virtual Continent continent { get; set; }
        public virtual List<TeamCompetition> teamCompetitions { get; set; }
        public virtual List<Match> matches1 { get; set; }
        public virtual List<Match> matches2 { get; set; }
        public virtual List<MatchEvent> matchEvents { get; set; }
        public virtual List<Statistics> statistics { get; set; }
        public virtual List<Standing> Standings { get; set; }




    }
}