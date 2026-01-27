using System;

public class Prototype : ICloneable
{
    public string Value { get; set; }

    public Prototype(string value)
    {
        Value = value;
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Valor: {Value}");
    }
}

// Ejemplo de uso
class Program
{
    static void Main(string[] args)
    {
        Prototype original = new Prototype("Original");
        Prototype clone = (Prototype)original.Clone();

        Console.WriteLine("Original:");
        original.ShowInfo();

        Console.WriteLine("Clon:");
        clone.ShowInfo();

        // Modificar el clon
        clone.Value = "Modificado";
        Console.WriteLine("Después de modificar el clon:");
        original.ShowInfo();
        clone.ShowInfo();
    }
}