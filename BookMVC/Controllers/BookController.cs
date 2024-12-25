using BookProject.Entities;
using BookProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookProject.Controllers;

public class BookController:Controller{
    private readonly BookService svc=new BookService();

    public IActionResult GetAll(){
        List<Book> books= svc.GetAll();
        return View(books);
    }
}