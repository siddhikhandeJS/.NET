using practicemvc.Entities;

namespace practicemvc.Service;

public interface IProductService{
    public List<Product> GetAll();
    public bool AddProduct(Product p);
    public Product GetById(int PId);
    public bool Delete(int PId);
    public bool Update(Product p);
}