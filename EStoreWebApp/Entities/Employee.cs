namespace HRAPP.Entities;

[Serializable]
public class Employee{
    public Employee(){
        Console.WriteLine("Employee constructor invoked....");
    }
    public int Id{get;set;}
    public string Name{get;set;}
}
