using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Narrator> Narrators { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DownloadLog> DownloadLogs { get; set; }
        public DbSet<OfflineAccess> OfflineAccesses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<AuthorCopyright> AuthorCopyrights { get; set; }

        
    }
}
