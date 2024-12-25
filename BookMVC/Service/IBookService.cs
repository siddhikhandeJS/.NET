using BookProject.Entities;

namespace BookProject.Service;

public interface IBookService{
    public List<Book> GetAll();
}
