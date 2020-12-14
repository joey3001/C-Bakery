
namespace Bakery.Models
{
  public class BreadOrder
  {
    private int _costPerLoaf;
    public int CostPerLoaf 
    {
      get
      {
          return _costPerLoaf; 
      }
      set
      {
          _costPerLoaf = 5; 
      }
    }
    public int NumberOfLoafs { get; set; }
    public BreadOrder(int numberOfLoafs)
    {
      CostPerLoaf = _costPerLoaf; 
      NumberOfLoafs = numberOfLoafs; 
    }
    public int OrderCost()
    {
      if (NumberOfLoafs % 3 == 0)
      {
        return (NumberOfLoafs * 2 / 3) * CostPerLoaf; 
      }
      return (NumberOfLoafs - NumberOfLoafs/3) * CostPerLoaf;
    }
  }
}