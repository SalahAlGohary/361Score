using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Standing
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("team")]
        [Display(Name = "الفريق")]
        public int TeamId { get; set; }
        [ForeignKey("competitionVersion")]
        [Display(Name = "البطولة")]
        public int ComVerId { get; set; }
        [Display(Name = "المجموعة")]
        public int Group { get; set; }
        [Display(Name = "لعب")]
        public int Play { get; set; }
        [Display(Name = "فوز")]
        public int Win { get; set; }
        [Display(Name = "تعادل")]
        public int Draw { get; set; }
        [Display(Name = "خسارة")]
        public int Lose { get; set; }
        [Display(Name = "أهداف لـ")]
        public int GoalsFor { get; set; }
        [Display(Name = "أهداف ضد")]
        public int GoalsTo { get; set; }
        [Display(Name = "فرق الأهداف")]
        public int GoalsDiff { get; set; }
        [Display(Name = "النقاط")]
        public int Points { get; set; }
        public virtual Team team { get; set; }
        public virtual CompetitionVersion competitionVersion { get; set; }
    }
}