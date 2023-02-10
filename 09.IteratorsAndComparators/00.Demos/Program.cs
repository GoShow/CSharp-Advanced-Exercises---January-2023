using System;
using System.Collections;
using System.Collections.Generic;

Stadium staduim = new(new List<int> { 1, 2, 3 });

foreach (var seat in staduim)
{
    Console.WriteLine(seat);
}

//StadiumEnumerator stadiumEnumerator = new(new List<int> { 1, 2, 3 });

//while (stadiumEnumerator.MoveNext())
//{
//    Console.WriteLine(stadiumEnumerator.Current);
//}


public class Stadium : IEnumerable<int>
{
    private List<int> seats;

    public Stadium(List<int> seats)
    {
        this.seats = seats;
    }


    public IEnumerator<int> GetEnumerator()
    {
        return new StadiumEnumerator(seats);

        //foreach (var seat in seats)
        //{
        //    yield return seat;
        //}
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class StadiumEnumerator : IEnumerator<int>
{
    private int index = -1;
    private List<int> seats;

    public StadiumEnumerator(List<int> seats)
    {
        this.seats = seats;
    }

    public int Current => seats[index];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        index++;

        return index < seats.Count;
    }

    public void Reset()
    {
        index = -1;
    }

    public void Dispose()
    {
    }
}