using EMS.API.Repository;
using EMS.API.Model;

namespace EMS.API.Service;

public class ProductsService : IProductsService
{

    private readonly IProductsRepository _productsRepository;

    public ProductsService(IProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }

    public Products CreateProduct(Products newProduct)
    {
        return _productsRepository.CreateProduct(newProduct);
    }

    public Products? DeleteProductsById(int id)
    {
         var p = GetProductById(id);
        if(p is not null) _productsRepository.DeleteProductsById(id);
        return p;
    }

    public IEnumerable<Products> FindAllProducts()
    {
        var productList = _productsRepository.FindAllProducts();
        return productList;
    }

    public Products? GetProductById(int id)
    {
        if(id < 1) return null;
        return _productsRepository.GetProductById(id);
    }

    public IEnumerable<Products> GetProductsByName(string name)
    {
        throw new NotImplementedException();
    }

    public Products? UpdateProductsById(int id, string name)
    {

        Products? pro = GetProductById(id);
        if(pro is not null) _productsRepository.UpdateProductById(id, name);
        return pro;
       
    }
}