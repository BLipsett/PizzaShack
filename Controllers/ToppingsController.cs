using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaShack.Mock;
using PizzaShack.Models;

namespace PizzaShack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class ToppingsController : ControllerBase
  {
    [HttpGet]

    public ActionResult<Dictionary<string, Topping>> Get()
    {
      return FakeDb.AvailToppings;
    }
  }
}