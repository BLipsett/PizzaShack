using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaShack.Models;
using PizzaShack.Mock;


namespace PizzaShack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class OrdersController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<Order>> Get()
    {
      return FakeDb.Orders;
    }

    [HttpPost]
    public ActionResult<Order> Create([FromBody] List<OrderRequest> request)
    {
      return null;
    }
  }
}