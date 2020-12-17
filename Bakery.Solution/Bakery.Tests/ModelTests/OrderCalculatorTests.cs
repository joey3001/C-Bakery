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
    public void TotalCost_AddCostOfPastryOrderToCostOfBreadOrderToCalculateTotalCostOfOrder_int()
    {
      int intendedTotalOrderCost = 15; 

      int numberOfPastries = 3;
      PastryOrder newPastryOrder = new PastryOrder(numberOfPastries);
      int pastryOrderCost = newPastryOrder.OrderCost(); 

      int numberOfLoafs = 2;
      BreadOrder newBreadOrder = new BreadOrder(numberOfLoafs);
      int breadOrderCost = newBreadOrder.OrderCost(); 

      OrderCalculator newOrderCalculator = new OrderCalculator();
      int totalOrderCost = newOrderCalculator.TotalCost(breadOrderCost, pastryOrderCost);

      Assert.AreEqual(intendedTotalOrderCost, totalOrderCost);
    }
  }
}