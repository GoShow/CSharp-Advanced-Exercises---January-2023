using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses;

public class Family
{
    private List<Person> people;

    public Family()
    {
        this.people = new();
    }

    public List<Person> People
    {
        get
        {
            return this.people;
        }
        set
        {
            this.people = value;
        }
    }

    public void AddMember(Person person)
    {
        this.people.Add(person);
    }

    public Person GetOldestMember()
    {
        return this.people.MaxBy(p => p.Age);
    }
}
