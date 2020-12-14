using System;

namespace Bakery.Models
{
  public class OrderCalculator
  {
    public int TotalCost(int breadOrderCost, int pastryOrderCost)
    {
      return breadOrderCost + pastryOrderCost; 
    }
  }
}