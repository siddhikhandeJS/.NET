using BookProject.Entities;

namespace BookProject.Repositories;
public interface IBookRepositories{

    public List<Book> GetAll();
}