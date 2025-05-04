using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string SubscriptionType { get; set; } // ENUM(Free, Premium)
        public DateTime CreatedAt { get; set; }
        [ValidateNever]
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
        [ValidateNever]
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        [ValidateNever]
        public ICollection<DownloadLog> DownloadLogs { get; set; } = new List<DownloadLog>();
        [ValidateNever]
        public ICollection<OfflineAccess> OfflineAccesses { get; set; } = new List<OfflineAccess>();

    }
}
