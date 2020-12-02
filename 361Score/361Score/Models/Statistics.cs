using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Statistics
    {
        [Key, Column(Order = 0)]
        [ForeignKey("player")]
        [Display(Name = "اللاعب")]
        public int PlayerId { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("team")]
        [Display(Name = "الفريق")]
        public int TeamId { get; set; }
        [Key, Column(Order = 2)]
        [ForeignKey("competitionVersion")]
        [Display(Name = "البطولة")]
        public int ComVerId { get; set; }
        [Display(Name = "أهداف")]
        public int Goals { get; set; }
        [Display(Name = "أسيست")]
        public int Assists { get; set; }
        [Display(Name = "كارت أحمر")]
        public int RedCards { get; set; }
        [Display(Name = "كارت أصفر")]
        public int YellowCards { get; set; }
        [Display(Name = "ضربات جزاء")]
        public int Penalities { get; set; }
        [Display(Name = "لعب")]
        public int PlayTimes { get; set; }
        public virtual Team team { get; set; }
        public virtual Player player { get; set; }
        public virtual CompetitionVersion competitionVersion { get; set; }




    }
}