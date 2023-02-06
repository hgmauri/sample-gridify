using Microsoft.EntityFrameworkCore;

namespace Sample.Gridify.Core.Context;

public class BookContext : DbContext
{
    protected BookContext(DbContextOptions options) 
        : base(options) { }

    public BookContext(DbContextOptions<BookContext> options) 
        : this((DbContextOptions)options)
    {
    }

    public DbSet<Book> Books { get; set; }
}

public class Book
{
    public Guid BookId { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public DateTime Date { get; set; }
}