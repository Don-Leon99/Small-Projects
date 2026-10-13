// Aggregation:
class Book
{
    public string Title { get; }
    public Member? CurrentBorrower { get; internal set; }
    public Book(string title)
    {
        Title = title;
    }
}
class Member
{
    public string Name { get; }
    private readonly List<Book> _borrowedBooks = new();
    public IReadOnlyList<Book> BorrowedBooks => _borrowedBooks;
    public Member(string name)
    {
        Name = name;
    }
    internal void AddBorrowedBook(Book book) => _borrowedBooks.Add(book);
    internal void RemoveBorrowedBook(Book book) => _borrowedBooks.Remove(book);
}
class Library
{
    public bool Borrow(Book? book, Member? member)
    {
        if (book is null || member is null)
            return false;
        if (book.CurrentBorrower is not null)
            return false;

        book.CurrentBorrower = member;
        member.AddBorrowedBook(book);
        return true;
    }
    public bool Return(Book? book)
    {
        if (book is null)
            return false;

        Member? borrower = book.CurrentBorrower;

        if (borrower is null)
            return false;

        borrower.RemoveBorrowedBook(book);
        book.CurrentBorrower = null;
        return true;
    }
}

class Program
{
    static void Main()
    {
        var library = new Library();
        var book = new Book("Mio, min Mio");
        var member = new Member("Leon");
        bool borrowed = library.Borrow(book, member);

        Console.WriteLine(borrowed); // True
        Console.WriteLine(book.CurrentBorrower?.Name); // Sam
        Console.WriteLine(member.BorrowedBooks.Count); // 1

        library.Return(book);

        Console.WriteLine(book.CurrentBorrower is null); // True
        Console.WriteLine(member.BorrowedBooks.Count); // 0
    }
}