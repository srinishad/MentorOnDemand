using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.PaymentService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        
        public int UserId { get; set; }

        public float Amount { get; set; }
      
        public int MentorId { get; set; }

        public string MentorAmount { get; set; }
    }
}
