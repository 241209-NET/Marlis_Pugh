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
        throw new NotImplementedException();
    }

    public void DeleteProductsById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Products> FindAllProducts()
    {
        var productList = _productsRepository.FindAllProducts();
        return productList;
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