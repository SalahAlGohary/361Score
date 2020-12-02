using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "عنوان الخبر")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "تفاصيل الخبر")]
        public string Description { get; set; }
        [Display(Name = "صورة الخبر")]
        public string Image { get; set; }
        [Required]
        [Display(Name = "تاريخ الخبر")]
        public DateTime DateTime { get; set; }
        [Display(Name = "الزيارات")]
        public int Count { get; set; }
        public virtual List<NewsTags> newsTags { get; set; }

    }
}