using BlazorApp.Shared;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly List<Product> _products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Product 1",
            Description = "Description 1",
            Quantity = 10
        },
        new Product
        {
            Id = 2,
            Name = "Product 2",
            Description = "Description 2",
            Quantity = 5
        }
    };

    [HttpGet]
    public LoadResult Get(DataSourceLoadOptions loadOptions)
    {
        return DataSourceLoader.Load(_products.AsQueryable(), loadOptions);
    }
}