using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore;

public class ShoeStore
{
    private List<Shoe> shoes;

    public ShoeStore(string name, int storageCapacity)
    {
        Name = name;
        StorageCapacity = storageCapacity;
        shoes = new List<Shoe>();
    }

    public string Name { get; set; }

    public int StorageCapacity { get; set; }

    public IReadOnlyCollection<Shoe> Shoes => shoes;

    public int Count => shoes.Count;

    public string AddShoe(Shoe shoe)
    {
        if (Shoes.Count == StorageCapacity)
        {
            return "No more space in the storage room.";
        }

        shoes.Add(shoe);

        return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
    }

    public int RemoveShoes(string material)
        => shoes.RemoveAll(s => s.Material == material);

    public List<Shoe> GetShoesByType(string type)
        => shoes.FindAll(s => s.Type.ToLower() == type.ToLower());

    public Shoe GetShoeBySize(double size)
        => shoes.FirstOrDefault(s => s.Size == size);

    public string StockList(double size, string type)
    {
        IEnumerable<Shoe> stockList = shoes
            .Where(s => s.Size == size && s.Type == type);

        StringBuilder sb = new();

        if (!stockList.Any())
        {
            return "No matches found!";
        }
        else
        {
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");

            foreach (Shoe shoe in stockList)
            {
                sb.AppendLine(shoe.ToString());
            }
        }

        return sb.ToString().TrimEnd();
    }
}
