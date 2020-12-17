using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrder_CreateInstanceOfBreadOrder_BreadOrder()
    {
      int numberOfLoafs = 2; 

      BreadOrder newBreadOrder = new BreadOrder(numberOfLoafs);

      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadOrder_ProvideInputForNumberOfLoafsToPurchaseInBreadOrder_int()
    {
      int numberOfLoafs = 2; 
      int intendedNumberOfLoafs = 2; 

      BreadOrder newBreadOrder = new BreadOrder(numberOfLoafs);
      numberOfLoafs = newBreadOrder.NumberOfLoafs; 

      Assert.AreEqual(intendedNumberOfLoafs, numberOfLoafs);
    }

    [TestMethod]
    public void BreadOrder_SetCostPerLoafTo5_int()
    {
      int numberOfLoafs = 2; 
      int intendedCostPerLoaf = 5; 

      BreadOrder newBreadOrder = new BreadOrder(numberOfLoafs);
      int costPerLoaf = newBreadOrder.CostPerLoaf; 

      Assert.AreEqual(intendedCostPerLoaf, costPerLoaf);
    }

    [TestMethod]
    public void OrderCost_CalculateCostOfBreadOrderWithoutDiscount_int()
    {
      int numberOfLoafs = 2;
      int intendedOrderCost = 10; 

      BreadOrder newBreadOrder = new BreadOrder(numberOfLoafs);
      int breadOrderCost = newBreadOrder.OrderCost(); 

      Assert.AreEqual(intendedOrderCost, breadOrderCost);
    }

    [TestMethod]
    public void OrderCost_CalculateCostOfBreadOrderWithDiscount_int()
    {
      int numberOfLoafs = 3;
      int intendedOrderCost = 10; 

      BreadOrder newBreadOrder = new BreadOrder(numberOfLoafs);
      int breadOrderCost = newBreadOrder.OrderCost(); 

      Assert.AreEqual(intendedOrderCost, breadOrderCost);
    }
  }
}