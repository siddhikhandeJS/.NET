using practicemvc.Repositories;
using practicemvc.Entities;
namespace practicemvc.Service;

public class ProductService:IProductService{
    public ProductDbManager mgr=new ProductDbManager();

    public List<Product> GetAll(){
        return mgr.GetAll();
        throw new NotImplementedException();
    }

    public bool AddProduct(Product p){
        mgr.AddProduct(p);
        return true;
        throw new NotImplementedException();
    }

    public Product GetById(int PId){
        return mgr.GetById(PId);
        throw new NotImplementedException();
    }

    public bool Delete(int PId){
        mgr.Delete(PId);
        return true;
        throw new NotImplementedException();
    }
    public bool Update(Product p){
        mgr.Update(p);
        return true;
        throw new NotImplementedException();
    }
}