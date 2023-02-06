using Sample.Gridify.Core.Context;

namespace Sample.Gridify.Core.Extensions;
public static class SeedsExtensions
{
    public static IEnumerable<Book> ReturnBooks()
    {
        var books = new List<Book>
        {
            new() { Title = "Clean Code: By Robert C. Martin", Date = DateTime.Now.AddDays(1) },
            new() { Title = "The Mythical Man-month: By Frederick Brooks", Date = DateTime.Now.AddDays(2) },
            new() { Title = "The Pragmatic Programmer: Your Journey to Mastery", Date = DateTime.Now.AddDays(3) },
            new() { Title = "Code Complete (2 Edition): By Steve McConnell", Date = DateTime.Now.AddDays(4) },
            new() { Title = "The Art of Computer Programming", Date = DateTime.Now.AddDays(5) },
            new() { Title = "Programming Pearls", Date = DateTime.Now.AddDays(6) }
        };

        return books;
    }
}
