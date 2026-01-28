using System;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    private Singleton() { }
    public static Singleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }

    public void ShowMessage()
    {
        Console.WriteLine("Hola desde el Singleton en C#!");
    }
}

// Ejemplo de uso
class Program
{
    static void Main(string[] args)
    {
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;

        Console.WriteLine(s1 == s2);  // True, misma instancia

        s1.ShowMessage();
    }
}