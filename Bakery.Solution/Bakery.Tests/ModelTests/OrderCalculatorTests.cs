using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderCalculatorTests
  {
    [TestMethod]
    public void OrderCalculator_CreateInstanceOfOrderCalculator_OrderCalculator()
    {
      OrderCalculator newOrderCalculator = new OrderCalculator();

      Assert.AreEqual(typeof(OrderCalculator), newOrderCalculator.GetType());
    }

    [TestMethod]
    public void TotalCost_AddCostOfPastryOrderToCostOfBreadOrderToCalculateTotalOrderCost_int()
    {
      int intendedTotalOrderCost = 15; 

      int numberOfPastries = 3;
      PastryOrder newPastryOrder = new PastryOrder(numberOfPastries);
      int pastryOrderCost = newPastryOrder.OrderCost(); 

      int loafsOfBread = 2;
      BreadOrder newBreadOrder = new BreadOrder(loafsOfBread);
      int breadOrderCost = newBreadOrder.OrderCost(); 

      OrderCalculator newOrderCalculator = new OrderCalculator();
      int totalOrderCost = newOrderCalculator.TotalCost(breadOrderCost, pastryOrderCost);

      Assert.AreEqual(intendedTotalOrderCost, totalOrderCost);
    }
  }
}