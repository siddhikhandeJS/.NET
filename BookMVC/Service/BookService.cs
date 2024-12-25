using BookProject.Repositories;
using BookProject.Entities;

namespace BookProject.Service;

public class BookService:IBookService{
    private BookRepositories mgr=new BookRepositories();

    public List<Book> GetAll(){
        return mgr.GetAll();
        throw new NotImplementedException();
    }
}