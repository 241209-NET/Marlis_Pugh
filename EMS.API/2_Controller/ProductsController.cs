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






}