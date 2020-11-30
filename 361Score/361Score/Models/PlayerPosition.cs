using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class PlayerPosition
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="مركز اللاعب")]
        public string Position { get; set; }
        public virtual List<Player> players { get; set; }
    }
}