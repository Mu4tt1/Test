using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [ValidateNever]
        public int UserId { get; set; }
        [ValidateNever]
        public int BookId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
