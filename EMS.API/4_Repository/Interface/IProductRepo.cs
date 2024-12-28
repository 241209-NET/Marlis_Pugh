using EMS.API.Model;




namespace EMS.API.Repository;


public interface IProductsRepository
{

Products CreateProduct(Products newProduct);
IEnumerable<Products> FindAllProducts();
Products? GetProductById(int id);
IEnumerable<Products> GetProductsByName(string name);
void DeleteProductsById(int id);





}