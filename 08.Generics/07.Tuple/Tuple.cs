namespace Tuple;

public class CustomTuple<T1, T2>
{
    public CustomTuple(T1 item1, T2 item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public T1 Item1 { get; private set; }
    public T2 Item2 { get; private set; }

    public override string ToString()
    {
        return $"{Item1} -> {Item2}";
    }
}
