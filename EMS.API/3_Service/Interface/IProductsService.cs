using EMS.API.Model;


namespace EMS.API.Service;


public interface IProductsService
{

Products CreateProduct(Products newProduct);
IEnumerable<Products> FindAllProducts();
Products? GetProductById(int id);
IEnumerable<Products> GetProductsByName(string name);
void DeleteProductsById(int id);





}