using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Modulation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("matchList1")]
        [Display(Name = "قائمة الفريق المستضيف ")]
        public int ListH { get; set; }
        [Required]
        [ForeignKey("matchList2")]
        [Display(Name = "قائمة الفريق الضيف ")]
        public int ListA { get; set; }
        [Required]
        [ForeignKey("match")]
        [Display(Name = " المباراة")]
        public int MatchId { get; set; }
        [Required]
        [Display(Name = " تشكيلة الفريق المستضيف")]
        public string FormationH { get; set; }
        [Required]
        [Display(Name = " تشكيلة الفريق الضيف")]
        public string FormationA { get; set; }
        public virtual MatchList matchList1 { get; set; }
        public virtual MatchList matchList2 { get; set; }
        public virtual Match match { get; set; }

    }
}