using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TrainingService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public int TrainingId { get; set; }

        public int UserId { get; set; }

        public int MentorId{get; set;}

        public int SkillId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Timeslot { get; set; }

        public string Status { get; set; }

        public string Progress { get; set; }

        public string Rating { get; set; }
    }
}
