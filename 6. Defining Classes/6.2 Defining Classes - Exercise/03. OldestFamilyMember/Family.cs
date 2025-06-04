using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class Family
{
    private List<Person> members = new List<Person>();

    public void AddMember(Person newMember)
        => this.members.Add(newMember);

    public Person GetOldestMember()
    {
        if (this.members.Count == 0) return null;
        return members.MaxBy(p => p.Age);
    }
}
