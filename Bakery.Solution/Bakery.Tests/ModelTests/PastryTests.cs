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
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void PastryOrder_ProvideInputForNumberOfPastries_2()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(2, newPastryOrder.NumberOfPastries);
    }

    [TestMethod]
    public void PastryOrder_SetCostPerPastryTo2_2()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(2, newPastryOrder.CostPerPastry);
    }

    [TestMethod]
    public void OrderCost_CalculateOrderCostsForPastries_15()
    {
      PastryOrder newPastryOrder = new PastryOrder(9);
      Assert.AreEqual(10, newPastryOrder.OrderCost());
    }
  }
}