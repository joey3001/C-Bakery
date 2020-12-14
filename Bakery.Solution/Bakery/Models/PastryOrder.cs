
namespace Bakery.Models
{
  public class PastryOrder
  {
    private int _costPerPastry;
    public int CostPerPastry
    {
      get 
      {
        return _costPerPastry;
      }
      set
      {
        _costPerPastry = 2; 
      }
    }
    public int NumberOfPastries { get; set; }
    public PastryOrder(int numberOfPastries)
    {
      CostPerPastry = _costPerPastry; 
      NumberOfPastries = numberOfPastries; 
    }
    public int OrderCost()
    {
      if (NumberOfPastries % 3 == 0)
      {
        return (NumberOfPastries/3) * 5; 
      }
      return NumberOfPastries * CostPerPastry - NumberOfPastries/3; 
    }
  }
}