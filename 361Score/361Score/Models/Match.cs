using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("teamH")]
        [Display(Name = "الفريق المستضيف")]
        public int TeamH { get; set; }
        [Required]
        [ForeignKey("teamA")]
        [Display(Name = "الفريق الضيف")]
        public int TeamA { get; set; }
        [Required]
        [Display(Name = "تاريخ المباراة")]
        public DateTime DateTime { get; set; }
        [Display(Name = "القناة الناقلة")]
        public string TVChannel { get; set; }
        [Display(Name = " الجولة")]
        public int Round { get; set; }
        [Required]
        [ForeignKey("matchStatus")]
        [Display(Name = " حالة المباراة")]
        public int Status { get; set; }
        public int HResult { get; set; }
        public int AResult { get; set; }
        [Required]
        [ForeignKey("competitionVersion")]
        [Display(Name = " البطولة")]
        public int ComVerId { get; set; }
        public virtual MatchStatus matchStatus { get; set; }
        public virtual Team teamH { get; set; }
        public virtual Team teamA { get; set; }
        public CompetitionVersion competitionVersion { get; set; }
        public virtual List<Modulation> modulations { get; set; }
        public virtual List<MatchEvent> matchEvents { get; set; }



    }
}