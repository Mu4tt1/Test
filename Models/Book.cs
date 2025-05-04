﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Test.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public TimeSpan Duration { get; set; }
        public string Language { get; set; }
        public float Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPremiumOnly { get; set; }
        [ValidateNever]
        public int NarratorId { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey("NarratorId")]
        public Narrator Narrator { get; set; }
        [ValidateNever]
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        [ValidateNever]
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
        [ValidateNever]
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        [ValidateNever]
        public ICollection<DownloadLog> DownloadLogs { get; set; } = new List<DownloadLog>();
        [ValidateNever]
        public ICollection<OfflineAccess> OfflineAccesses { get; set; } = new List<OfflineAccess>();
        [ValidateNever]
        public ICollection<AuthorCopyright> AuthorCopyrights { get; set; } = new List<AuthorCopyright>();
    }
}
