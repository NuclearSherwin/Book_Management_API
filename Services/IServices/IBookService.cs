using BookManagement.Models;

namespace BookManagement.Services.IServices;

public interface IBookService
{
    IList<Book> GetAll();
    Book GetById(int id);
    Book Create(Book bookInput);
    Book Update(Book bookInput);
    bool Delete(int id);
}