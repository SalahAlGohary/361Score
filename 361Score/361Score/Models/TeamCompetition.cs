using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _361Score.Models
{
    public class TeamCompetition
    {

        [Key, Column(Order = 0)]
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("CompetitionVersion")]
        public int CompetitionVersionId { get; set; }
        public virtual CompetitionVersion CompetitionVersion { get; set; }
        public virtual Team Team { get; set; }
    }
}