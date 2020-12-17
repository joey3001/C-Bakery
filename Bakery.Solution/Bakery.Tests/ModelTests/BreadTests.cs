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
    public void BreadOrder_ProvideInputForNumberOfLoafs_int()
    {
      int numberOfLoafs = 2; 
      int intendedNumberOfLoafs = 2; 

      BreadOrder newBreadOrder = new BreadOrder(numberOfLoafs);

      Assert.AreEqual(intendedNumberOfLoafs, newBreadOrder.NumberOfLoafs);
    }

    [TestMethod]
    public void BreadOrder_SetCostPerLoafTo5_int()
    {
      int loafsOfBread = 2; 
      int intendedCostPerLoaf = 5; 

      BreadOrder newBreadOrder = new BreadOrder(loafsOfBread);

      Assert.AreEqual(intendedCostPerLoaf, newBreadOrder.CostPerLoaf);
    }

    [TestMethod]
    public void OrderCost_CalculateCostOfAmountOfLoafsWithoutDiscount_int()
    {
      int loafsOfBread = 2;
      int intendedOrderCost = 10; 

      BreadOrder newBreadOrder = new BreadOrder(loafsOfBread);
      int breadOrderCost = newBreadOrder.OrderCost(); 

      Assert.AreEqual(intendedOrderCost, breadOrderCost);
    }

    [TestMethod]
    public void OrderCost_CalculateCostOfAmountOfLoafsWithDiscount_int()
    {
      int loafsOfBread = 3;
      int intendedOrderCost = 10; 

      BreadOrder newBreadOrder = new BreadOrder(loafsOfBread);
      int breadOrderCost = newBreadOrder.OrderCost(); 

      Assert.AreEqual(intendedOrderCost, breadOrderCost);
    }
  }
}