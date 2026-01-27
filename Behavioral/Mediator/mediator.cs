// Mediator Pattern in C#

using System;
using System.Collections.Generic;

public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}

public abstract class Colleague
{
    protected Mediator mediator;

    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}

public class User : Colleague
{
    private string name;

    public User(string name, Mediator mediator) : base(mediator)
    {
        this.name = name;
    }

    public void Send(string message)
    {
        Console.WriteLine($"{name} sends: {message}");
        mediator.Send(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{name} receives: {message}");
    }
}

public class ChatRoom : Mediator
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public override void Send(string message, Colleague colleague)
    {
        foreach (User user in users)
        {
            if (user != colleague)
            {
                user.Receive(message);
            }
        }
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        ChatRoom chatRoom = new ChatRoom();
        User user1 = new User("Alice", chatRoom);
        User user2 = new User("Bob", chatRoom);
        chatRoom.AddUser(user1);
        chatRoom.AddUser(user2);

        user1.Send("Hello, Bob!");  // Alice sends: Hello, Bob!
                                    // Bob receives: Hello, Bob!
    }
}