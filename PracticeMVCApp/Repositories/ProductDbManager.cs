using Microsoft.VisualBasic;
using practicemvc.Entities;
namespace practicemvc.Repositories;

public class ProductDbManager: IProductManager{
    public List<Product> GetAll(){
        using(var context=new CollectionContext()){
            var products=from prod context.Products select prod;
            return products.ToList<Product>();
           
        }
         throw new NotImplementedException();
    }

    public bool AddProduct(Product p){
        using(var context=new CollectionContext()){
            context.Add(p);
            context.SaveChanges();
            return true;
            
        }
        throw new NotImplementedException();
    }

    public Product GetById(int PId){
        using(var context=new CollectionContext()){
            var product=context.Products.Find(PId);
            return product;
        }
        throw new NotImplementedException();
    }

    public bool Delete(int PId){
        using(var context=new CollectionContext()){
            context.Remove(context.Products.Find(PId));
            context.SaveChanges();
            return true;
        }
        throw new NotImplementedException();
    }
    public bool Update(Product PuId){
        using(var context=new CollectionContext()){
            Product prod=context.Products.Find(PuId.PId);
            prod.Name=PuId.Name;
            prod.Price=PuId.Price;
            prod.Type=PuId.Type;
            prod.Brand=PuId.Brand;
            context.SaveChanges();
            return true;
        }
        throw new NotImplementedException();
    }
}