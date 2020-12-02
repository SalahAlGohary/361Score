using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class MatchEvent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "الدقيقة")]
        public int Minute { get; set; }
        [Display(Name = "الوقت الإضافي")]
        public int Extra { get; set; }
        [Required]
        [Display(Name = "الفريق")]
        [ForeignKey("team")]
        public int TeamId { get; set; }
        [Required]
        [Display(Name = "المباراة")]
        [ForeignKey("match")]
        public int MatchId { get; set; }
        [Required]
        [Display(Name = "اللاعب")]
        [ForeignKey("player")]
        public int PlayerId { get; set; }
        [Required]
        [Display(Name = "الحدث")]
        [ForeignKey("eventTypes")]
        public int EventType { get; set; }
        public virtual Player player { get; set; }
        public virtual Team team { get; set; }
        public virtual Match match { get; set; }
        public virtual EventTypes eventTypes { get; set; }

    }
}