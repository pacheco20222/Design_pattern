using System;
using System.Collections.Generic;

// Interfaz del Visitor
interface IVisitor
{
    void VisitCirculo(Circulo circulo);
    void VisitCuadrado(Cuadrado cuadrado);
}

// Interfaz para elementos que aceptan visitantes
interface IFigura
{
    void Accept(IVisitor visitor);
}

// Clases concretas
class Circulo : IShape
{
    public double Radio { get; set; } = 5;
    public void Accept(IVisitor visitor) => visitor.VisitCirculo(this);
}

class Cuadrado : IShape
{
    public double Lado { get; set; } = 3;
    public void Accept(IVisitor visitor) => visitor.VisitCuadrado(this);
}

// Visitor concreto
class CalculadoraAreas : IVisitor
{
    public void VisitCirculo(Circulo circulo)
    {
        double area = Math.PI * circulo.Radio * circulo.Radio;
        Console.WriteLine($"Área del círculo: {area}");
    }

    public void VisitCuadrado(Cuadrado cuadrado)
    {
        double area = cuadrado.Lado * cuadrado.Lado;
        Console.WriteLine($"Área del cuadrado: {area}");
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        List<IShape> figuras = new List<IShape> { new Circulo(), new Cuadrado() };
        CalculadoraAreas calculadora = new CalculadoraAreas();

        foreach (var figura in figuras)
        {
            figura.Accept(calculadora);
        }
    }
}
