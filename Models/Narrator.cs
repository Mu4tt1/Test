using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Narrator
    {
        [Key]
        public int NarratorId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        [ValidateNever]
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
