using BookProject.Entities;

namespace BookProject.Repositories;

public class BookRepositories:IBookRepositories{

    public List<Book> GetAll(){
        using(var context=new CollectionContext()){
            var books=from bk in context.Books select bk;
            return books.ToList<Book>();
        }
         
    }
}