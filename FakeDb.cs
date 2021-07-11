using System.Collections.Generic;
using PizzaShack.Models;

namespace PizzaShack.Mock 
{
public static class FakeDb
{
  public static Dictionary<string, Topping> AvailToppings = new Dictionary<string, Topping>()
  {
   {"pep", new Topping("pepperoni", .50m)}
   };

  public static List<Pizza> Pizzas = new List<Pizza>()
  {
    new Pizza(){
      Name = "Pepperoni",
      Toppings = new List<Topping>()
      {
        AvailToppings.GetValueOrDefault("pep")
      }
     
    }
  };

  public static List<Order> Orders = new List<Order>()
  {
    new Order()
    {
      Pizzas = new List<Pizza>(){
        new Pizza()
        {
          Toppings = new List<Topping>(){
            AvailToppings.GetValueOrDefault("pep")
          }
        },
        Pizzas.Find(p => p.Name == "Pepperoni")
      }
    }
  };
}



}