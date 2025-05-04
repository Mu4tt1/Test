using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class BookAuthor
    {
        [Key]
        public int BookAuthorId { get; set; }
        [ValidateNever]
        public int BookId { get; set; }
        [ValidateNever]
        public int AuthorId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
