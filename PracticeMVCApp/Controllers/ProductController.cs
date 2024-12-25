using practicemvc.Service;
using practicemvc.Entities;
using Microsoft.AspNetCore.Mvc;

namespace practicemvc.Controllers;
public class ProductController:Controller{
    public readonly ProductService svc=new ProductService();

    public IActionResult GetAll(){
        List<Product> products=svc.GetAll();
        return View(products);
    }

    public IActionResult AddProduct(Product p){
        svc.AddProduct(p);
        return RedirectToAction("GetAll","Product");
    }

    public IActionResult Details(int Id){
        return View(svc.GetById(Id));
    }

    public IActionResult Delete(int Id){
        svc.Delete(Id);
        return RedirectToAction("GetAll","Product");
    }
    public IActionResult AddForm(){
        return View();
    }
    
    public IActionResult Update(Product p){
        svc.Update(Id);
        return RedirectToAction("GetAll","Product");
    }
    public IActionResult EditForm(int PId){
        Product p = svc.GetById(PId);
        return View(p);
    }
}
