using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        [ValidateNever]
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        [ValidateNever]
        public ICollection<AuthorCopyright> AuthorCopyrights { get; set; } = new List<AuthorCopyright>();
    }
}
