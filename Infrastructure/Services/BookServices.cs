using System.Collections.Immutable;
using Domain;

namespace Infrastructure;

public class BookServices
{

    public List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public List<Book> GetAllBooks()
    {
        return _books;
    }

    public Book GetById(int id)
    {

        return _books.FirstOrDefault(e => e.Id == id);

    }

    public void UpdateBook(Book book)
    {
        var updatedBook = _books.FirstOrDefault(e => e.Id == book.Id);
        updatedBook.Year = book.Year;
        updatedBook.Description = book.Description;
        updatedBook.Tittle = book.Tittle;

    }

    public void Delete(int id)
    {
        var delete = _books.FirstOrDefault(e => e.Id == id);
        _books.Remove(delete);
    }

    public List<Book> GetBooksByAuthor(string author)
    {
       return _books.Where(e => e.Author == author).ToList();
    }
}
