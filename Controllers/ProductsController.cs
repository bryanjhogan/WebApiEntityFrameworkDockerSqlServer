using Microsoft.AspNetCore.Mvc;
using WebApiEntityFrameworkDockerSqlServer.Data;

namespace WebApiEntityFrameworkDockerSqlServer.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly SalesContext _salesContext;

    public ProductsController (SalesContext salesContext)
    {
        _salesContext = salesContext;
    }

    [HttpGet]
    public ActionResult Get(int take = 10, int skip = 0)
    {
        return Ok(_salesContext.Products.OrderBy(p => p.ProductId).Skip(skip).Take(take));
    }
}