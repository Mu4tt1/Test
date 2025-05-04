using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class BookCategory
    {
        [Key]
        [ValidateNever]
        public int BookId { get; set; }
        [ValidateNever]
        public int CategoryId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
}
