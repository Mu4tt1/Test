using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        [ValidateNever]
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}
