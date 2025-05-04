using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        [ValidateNever]
        public int UserId { get; set; }
        public string PlanType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CanDownload { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        [ValidateNever]
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();

    }
}
