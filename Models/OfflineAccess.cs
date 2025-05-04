using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class OfflineAccess
    {
        [Key]
        public int OfflineId { get; set; }
        [ValidateNever]
        public int UserId { get; set; }
        [ValidateNever]
        public int BookId { get; set; }
        public DateTime DownloadDate { get; set; }
        public DateTime ValidUntil { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
