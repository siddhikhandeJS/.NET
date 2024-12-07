using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using   HRAPP.Services;
using HRAPP.Entities;
namespace EStoreWebApp.Controllers;
public class EmployeesController : Controller
{
    private readonly IEmployeeService _svc;
    public EmployeesController(IEmployeeService svc){
        Console.WriteLine("Employee Controller Constructor is being Invoked..");
        this._svc=svc;
    }

    [HttpGet]
    public IActionResult Index()
    {
        Console.WriteLine("Employee Index Action Method is called...");
        List<Employee> employees=_svc.GetAll();
        //ViewData["employees"]=employees;
        //ViewBag.empList=employees;
        TempData["allEmployees"]=employees;
        return View();
    }


    public IActionResult List()
    {
        Console.WriteLine("Employee Index Action Method is called...");
        List<Employee> employees=_svc.GetAll();
        //ViewData["employees"]=employees;
        //ViewBag.empList=employees;
        //TempData["allEmployees"]=employees;
        //model transfer
        return View(employees);
    }
    public IActionResult Details(int id)
    {
        List<Employee> retrivedEmployees=(List<Employee>)TempData["allEmployees"];

        Console.WriteLine("Employee Details Action Method is called...");
        Employee emp=_svc.GetById(id);
        return View();
    }

     public IActionResult Edit(int id){
         List<Employee> employees=_svc.GetAll();
         var e= employees.Find((emp)=>emp.Id==id);    
        return View(e);
     }



    [HttpPost]
    public IActionResult Edit(Employee emp){   
        Console.WriteLine(emp.Id+ " " + emp.Name);
        if (emp != null && ModelState.IsValid) { 

            //Update this employee to list and
            //and Save it back to json using 
            //serialization
            return RedirectToAction("Index");
        } 
        else      
        return View();
    }






}
