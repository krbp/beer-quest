using System;

public class BeerEncapsulator
{
    private double _availableBeerVolume = 330;
    private int _availableBottles = 10;
    private int _availableCapsules = 10;
    
    public void AddBeer()
    {
        _availableBeerVolume -= 33;
    }

    public int ProduceEncapsulatedBeerBottles(int bottles)
    {
        int _producedBottles = 0;
      
        while (_producedBottles != bottles)
        {
            if (_availableBeerVolume > 0 && _availableCapsules > 0 && _availableBottles > 0)
            {
                AddBeer();
                _availableCapsules -= 1;
                _availableBottles -= 1;
                _producedBottles += 1;
              
                if (_producedBottles == bottles)
                {
                    Console.WriteLine($"{_producedBottles}");
                }
            }
            else
            {
                Console.WriteLine(0);
                return 0;
            }
        }
        return _producedBottles;
    }

}
namespace a
{
    public class Program
    {

        public static void Main()
        {
            BeerEncapsulator produceBottleFail = new BeerEncapsulator();
          
            BeerEncapsulator produceBottleSuccess = new BeerEncapsulator();
          
            Console.WriteLine($"Result when not enough material: ");
            produceBottleFail.ProduceEncapsulatedBeerBottles(11);
          
            Console.WriteLine($"Result when enough material: ");
            produceBottleSuccess.ProduceEncapsulatedBeerBottles(10);
        }
    }
}
