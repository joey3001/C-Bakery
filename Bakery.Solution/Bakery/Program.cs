using System;
using Bakery.Models;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("");
    Console.WriteLine("Hello there! Welcome to Joe's bakery. We have the following specials: ");
    Console.WriteLine("");
    Console.WriteLine("1. Bread is 5 Dollars per Loaf. Buy 2 get 1 free!");
    Console.WriteLine("2. Pastries are 2 Dollars each, or 3 for 5 Dollars!");
    Console.WriteLine("");
    Console.WriteLine("Enter the number of bread loafs you'd like to purchase: ");
    int breadLoafs = int.Parse(Console.ReadLine()); 
    BreadOrder newBreadOrder = new BreadOrder(breadLoafs); 
    Console.WriteLine("Enter the number of pastries you'd like to purchase: ");
    int pastries = int.Parse(Console.ReadLine()); 
    PastryOrder newPastryOrder = new PastryOrder(pastries); 
    Console.WriteLine("");
    Console.WriteLine("The cost of your bread order is: ");
    Console.WriteLine(newBreadOrder.OrderCost() + " Dollars");
    Console.WriteLine("The cost of your pastry order is: ");
    Console.WriteLine(newPastryOrder.OrderCost() + " Dollars");
    OrderCalculator newOrderCalculator = new OrderCalculator(); 
    Console.WriteLine("");
    Console.WriteLine("The total cost of your order is: ");
    Console.WriteLine(newOrderCalculator.TotalCost(newBreadOrder.OrderCost(), newPastryOrder.OrderCost()) + " Dollars");
  }
}
