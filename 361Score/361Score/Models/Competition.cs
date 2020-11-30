using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "إسم البطولة")]
        public string CompetionName { get; set; }
        [Required]
        [ForeignKey("category")]
        public int Category { get; set; }
        [Display(Name = "شعار المنافسة")]
        public string Logo { get; set; }
        [Required]
        [ForeignKey("country")]
        [Display(Name = "بلد البطولة")]
        public int Country { get; set; }

       [Required]
       [ForeignKey("continent")]
       [Display(Name = "قارة البطولة")]
        public int Contenent { get; set; }
       [Required]
       [ForeignKey("competitionType")]
       [Display(Name = "نوع البطولة")]
        public int Type { get; set; }
        public virtual Country country { get; set; }
       public virtual Continent continent { get; set; }
       public virtual CompetitionType competitionType { get; set; }
       public virtual List<CompetitionVersion> competitionVersions { get; set; }
       public virtual CompetitionCategory category { get; set; }

    }
}