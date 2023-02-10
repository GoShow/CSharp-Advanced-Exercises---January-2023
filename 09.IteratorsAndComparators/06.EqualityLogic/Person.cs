using System;

namespace EqualityLogic;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        if (Name.CompareTo(other.Name) != 0)
        {
            return Name.CompareTo(other.Name);
        }

        return Age.CompareTo(other.Age);
    }

    public override bool Equals(object obj)
    {
        Person other = obj as Person;

        if (other == null)
        {
            return false;
        }

        return Name == other.Name && Age == other.Age;
    }

    public override int GetHashCode()
    {
        int hashCode = Name.GetHashCode() + Age.GetHashCode();

        return hashCode;
    }
}
