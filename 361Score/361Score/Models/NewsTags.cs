using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class NewsTags
    {
        [Key, Column(Order = 0)]
        [ForeignKey("news")]
        [Display(Name = "الخبر")]
        public int NewsId { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("tags")]
        [Display(Name = "الكلمة الدالة")]
        public int TagId { get; set; }
        public virtual News news { get; set; }
        public virtual Tags tags { get; set; }
    }
}