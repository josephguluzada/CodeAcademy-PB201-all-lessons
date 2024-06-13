using System;

namespace PB201Enums.Models;

public class Company
{
    public Person[] People;
    public int Id { get; set; }

    public Company()
    {
        People = Array.Empty<Person>();
    }

    public void Add(Person person)
    {
        Array.Resize(ref People, People.Length + 1);
        People[^1] = person;
    }

    public Person[] FilterByPosition(string position)
    {
        Person[] filteredPeople = Array.Empty<Person>();

        foreach (var ppl in People)
        {
            if(ppl.Position.ToString().ToLower().Contains(position.Trim().ToLower()))
            {
                Array.Resize(ref filteredPeople, filteredPeople.Length + 1);
                filteredPeople[^1] = ppl;
            }
        }
        if(filteredPeople.Length == 0) 
        { 
            throw new PersonNotFoundException("Nobody found!");
        }

        return filteredPeople;
    }

    public Person[] FilterByPosition(byte position)
    {
        Person[] filteredPeople = Array.Empty<Person>();

        foreach (var ppl in People)
        {
            if ((byte)ppl.Position == position)
            {
                Array.Resize(ref filteredPeople, filteredPeople.Length + 1);
                filteredPeople[^1] = ppl;
            }
        }
        return filteredPeople;
    }


}
