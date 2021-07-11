using System.Collections.Generic;
using System.Linq;

namespace PizzaShack.Models
{

  public class OrderRequest
  {
    public string Name { get; set; }
    public List<string> ToppingNames { get; set; }
    public PizzaSizes Size { get; set; }
    Pizza Pizza { get; }
    public OrderRequest()
    {
        
    }
  }
  public class Order
  {
    public List<Pizza> Pizzas { get; set; }

    public decimal TotalPrice
    {
      get
      {
        return Pizzas.Sum(p => p.Price);
      }
    }
  }
}