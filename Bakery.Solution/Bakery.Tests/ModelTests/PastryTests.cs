using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrder_CreateInstanceOfPastryOrder_PastryOrder()
    {
      int numberOfPastries = 4; 

      PastryOrder newPastryOrder = new PastryOrder(numberOfPastries);

      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void PastryOrder_ProvideInputForNumberOfPastriesToPurchaseInPastryOrder_int()
    {
      int numberOfPastries = 4; 
      int intendedNumberOfPastries = 4; 

      PastryOrder newPastryOrder = new PastryOrder(numberOfPastries);
      numberOfPastries = newPastryOrder.NumberOfPastries;

      Assert.AreEqual(intendedNumberOfPastries, numberOfPastries);
    }

    [TestMethod]
    public void PastryOrder_SetCostPerPastryTo2_int()
    {
      int numberOfPastries = 4; 
      int intendedCostPerPastry = 2; 

      PastryOrder newPastryOrder = new PastryOrder(numberOfPastries);
      int costPerPastry = newPastryOrder.CostPerPastry; 

      Assert.AreEqual(intendedCostPerPastry, costPerPastry);
    }

    [TestMethod]
    public void OrderCost_CalculateCostOfAmountOfPastriesWithoutDiscount_int()
    {
      int numberOfPastries = 2;
      int intendedOrderCost = 4; 

      PastryOrder newPastryOrder = new PastryOrder(numberOfPastries);
      int pastryOrderCost = newPastryOrder.OrderCost(); 

      Assert.AreEqual(intendedOrderCost, pastryOrderCost);
    }

   [TestMethod]
    public void OrderCost_CalculateCostOfAmountOfPastriesWithDiscount_int()
    {
      int numberOfPastries = 3;
      int intendedOrderCost = 5; 

      PastryOrder newPastryOrder = new PastryOrder(numberOfPastries);
      int pastryOrderCost = newPastryOrder.OrderCost(); 

      Assert.AreEqual(intendedOrderCost, pastryOrderCost);
    }
  }
}