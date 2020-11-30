using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "الإسم الأول")]
        public string FName { get; set; }
        [Display(Name = "الإسم الأخير")]
        public string LName { get; set; }
        [Display(Name = "النادي")]
        public int ClubId { get; set; }
        [Display(Name = "تيشرت النادي")]
        public int ClubNum { get; set; }
        [Display(Name = "المنتخب")]
        public int TeamId { get; set; }
        [Display(Name = "تيشرت المنتخب")]
        public int TeamNum { get; set; }
        [Display(Name = "صورة اللاعب")]
        public string ImagePath { get; set; }
        [Display(Name = "المركز")]
        [ForeignKey("position")]
        public int Position { get; set; }
        [Display(Name = "الجنسية")]
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual PlayerPosition position { get; set; }
        public virtual Country Country { get; set; }
    }
}