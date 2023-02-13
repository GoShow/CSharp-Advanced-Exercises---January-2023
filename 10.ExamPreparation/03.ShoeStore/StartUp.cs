using System;

namespace ShoeStore
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var store = new ShoeStore("SportiveNation", 10);


            var shoeOne = new Shoe("Nike", "running", 42.5, "textile");
            var shoeTwo = new Shoe("Salomon", "hiking", 42, "textile");
            var shoeThree = new Shoe("Reebok", "running", 38, "textile");
            var shoeFour = new Shoe("LaCoste", "casual", 40.5, "leather");
            var shoeFive = new Shoe("Adidas", "casual", 39, "textile");
            var shoeSix = new Shoe("Nike", "hiking", 42.5, "textile");
            var shoeSeven = new Shoe("Adidas", "casual", 42, "leather");
            var shoeEight = new Shoe("AirJordan", "running", 42, "leather");
            var shoeNine = new Shoe("CalninKlein", "casual", 41.5, "leather");
            var shoeTen = new Shoe("Puma", "hiking", 42, "textile");
            var shoeEleven = new Shoe("Skechers", "casual", 42.5, "leather");

            Console.WriteLine(store.AddShoe(shoeOne));
            // Successfully added running textile pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeTwo));
            // Successfully added hiking textile pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeThree));
            // Successfully added running textile pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeFour));
            // Successfully added casual leather pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeFive));
            // Successfully added casual textile pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeSix));
            // Successfully added hiking textile pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeSeven));
            // Successfully added casual leather pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeEight));
            // Successfully added running leather pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeNine));
            // Successfully added casual leather pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeTen));
            // Successfully added hiking textile pair of shoes to the store.
            Console.WriteLine(store.AddShoe(shoeEleven));
            // No more space in the storage room.

            var runningShoes = store.GetShoesByType("Running");
            var hikingShoes = store.GetShoesByType("hIKING");

            Console.WriteLine(string.Join($"{Environment.NewLine}", runningShoes));
            // Size 42.5, textile Nike running shoe.
            // Size 38, textile Reebok running shoe.
            // Size 42, leather AirJordan running shoe.

            Console.WriteLine(string.Join($"{Environment.NewLine}", hikingShoes));
            // Size 42, textile Salomon hiking shoe.
            // Size 42.5, textile Nike hiking shoe.
            // Size 42, textile Puma hiking shoe.

            Console.WriteLine(store.RemoveShoes("leather"));
            // 4

            var shoeBySize = store.GetShoeBySize(42.5);
            Console.WriteLine(shoeBySize);
            // Size 42.5, textile Nike running shoe.

            Console.WriteLine(store.StockList(42, "hiking"));
            //Stock list for size 42 - hiking shoes:
            //Size 42, textile Salomon hiking shoe.
            //Size 42, textile Puma hiking shoe.

        }
    }
}
