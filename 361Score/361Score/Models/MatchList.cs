using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class MatchList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("player")]
        [Display(Name = "إسم اللاعب ")]
        public int PlayerId { get; set; }
        [Required]
        [Display(Name = "نوع المشاركة")]
        public bool ParticipationType { get; set; }
        [Display(Name = "المركز")]
        public int FormationPosition { get; set; }
        public virtual  Player player { get; set; }
        public virtual Modulation modulation1 { get; set; }
        public virtual Modulation modulation2 { get; set; }

    }
}