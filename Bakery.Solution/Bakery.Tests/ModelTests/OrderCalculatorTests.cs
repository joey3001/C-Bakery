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
    public void TotalCost_AddTwoNumbersTogether_int()
    {
      int firstNumber = 14; 
      int secondNumber = 16; 
      int intendedSum = 30; 

      OrderCalculator newOrderCalculator = new OrderCalculator();
      int calculatedSum = newOrderCalculator.TotalCost(firstNumber, secondNumber);
      
      Assert.AreEqual(intendedSum, calculatedSum);
    }
  }
}