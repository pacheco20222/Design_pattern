using System;
using System.Collections;
using System.Collections.Generic;

// Iterator interface
interface IIterator<T>
{
    bool HasNext();
    T Next();
}

// Aggregate interface
interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}

// Concrete collection
class NameCollection : IAggregate<string>
{
    private List<string> names = new List<string> { "Ana", "Luis", "María" };

    public IIterator<string> CreateIterator()
    {
        return new NameIterator(names);
    }
}

// Concrete iterator
class NameIterator : IIterator<string>
{
    private List<string> _names;
    private int _position = 0;

    public NameIterator(List<string> names)
    {
        _names = names;
    }

    public bool HasNext()
    {
        return _position < _names.Count;
    }

    public string Next()
    {
        return _names[_position++];
    }
}

// Client
class Program
{
    static void Main()
    {
        var collection = new NameCollection();
        var iterator = collection.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
