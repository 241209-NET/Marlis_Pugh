using Microsoft.EntityFrameworkCore;
using EMS.API.Data;
using EMS.API.Model;


namespace EMS.API.Repository;



public class ProductsRepository : IProductsRepository
{

    private readonly EmployeeContext _empContext;

    public ProductsRepository(EmployeeContext empContext)
    {
        _empContext = empContext;
    }


    public Products CreateProduct(Products newProduct)
    {
         _empContext.Products.Add(newProduct);
            _empContext.SaveChanges();

            return newProduct; 
    }

    public void DeleteProductsById(int id)
    {
        Products? pro = GetProductById(id);
        
            _empContext.Products.Remove(pro!);
            _empContext.SaveChanges();
    }

    public IEnumerable<Products> FindAllProducts()
    {
        return _empContext.Products.ToList();
    }

    public Products? GetProductById(int id)
    {
        return _empContext.Products.Find(id);
    }

    public IEnumerable<Products> GetProductsByName(string name)
    {
        throw new NotImplementedException();
    }

    public Products? UpdateProductById(int id, string name)
    {
        
        Products? pro = GetProductById(id);
        pro!.Name = name; 
        _empContext.Products.Update(pro);
        _empContext.SaveChanges();

        return pro;
    }
}