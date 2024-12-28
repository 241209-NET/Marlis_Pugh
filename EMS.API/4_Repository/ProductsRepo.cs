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
        throw new NotImplementedException();
    }

    public void DeleteProductsById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Products> FindAllProducts()
    {
        return _empContext.Products.ToList();
    }

    public Products? GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Products> GetProductsByName(string name)
    {
        throw new NotImplementedException();
    }
}