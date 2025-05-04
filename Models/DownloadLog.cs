using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class DownloadLog
    {
        [Key]
        public int LogId { get; set; }
        [ValidateNever]
        public int UserId { get; set; }
        [ValidateNever]
        public int BookId { get; set; }
        public DateTime DownloadDate { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
