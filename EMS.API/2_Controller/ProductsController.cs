using Microsoft.AspNetCore.Authorization;
using EMS.API.Model;
using EMS.API.Service;
using Microsoft.AspNetCore.Mvc;


namespace EMS.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    
    private readonly IProductsService _productsService;

    public ProductsController (IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet]
    public IActionResult GetAllProducts() 
    {
        var proList = _productsService.FindAllProducts();
        IActionResult VerbStatus = Ok(proList);
        
        return VerbStatus;
    }

    [HttpPost]
    public IActionResult CreateProducts(Products newProduct)
    {
        var pro = _productsService.CreateProduct(newProduct);
        var VerbStatus = Ok(pro);
        return VerbStatus;
    }

     [HttpDelete]
    public IActionResult DeleteProducts(int id)
    {
        var deletePro = _productsService.DeleteProductsById(id);

        if(deletePro is null) return NotFound();
        var VerbStatus = Ok(deletePro);

        return VerbStatus;
    }

     [HttpPut]
    public IActionResult UpdateProducts(int id, string name)
    {
        var updatePro = _productsService.UpdateProductsById(id, name);

        if(updatePro is null) return NotFound();
        var VerbStatus = Ok(updatePro);

        return VerbStatus;
    }






}