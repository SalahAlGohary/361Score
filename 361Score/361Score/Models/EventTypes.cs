using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class EventTypes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "الحدث")]
        public string EventName { get; set; }
        public virtual List<MatchEvent> matchEvents { get; set; }


    }
}