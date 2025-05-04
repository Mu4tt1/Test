using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class AuthorCopyright
    {
        [Key]
        public int BookCopyrightId { get; set; }
        public string Publisher { get; set; }
        public string LicenseType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Terms { get; set; }
        public DateTime CreatedAt { get; set; }
        [ValidateNever]
        public int AuthorId { get; set; }
        [ValidateNever]
        public int BookId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
