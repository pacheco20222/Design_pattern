// Interpreter Pattern in C#

using System;
using System.Collections.Generic;

public abstract class Expression
{
    public abstract int Interpret(Dictionary<string, int> context);
}

public class Number : Expression
{
    private int number;

    public Number(int number)
    {
        this.number = number;
    }

    public override int Interpret(Dictionary<string, int> context)
    {
        return number;
    }
}

public class Add : Expression
{
    private Expression left;
    private Expression right;

    public Add(Expression left, Expression right)
    {
        this.left = left;
        this.right = right;
    }

    public override int Interpret(Dictionary<string, int> context)
    {
        return left.Interpret(context) + right.Interpret(context);
    }
}

public class Subtract : Expression
{
    private Expression left;
    private Expression right;

    public Subtract(Expression left, Expression right)
    {
        this.left = left;
        this.right = right;
    }

    public override int Interpret(Dictionary<string, int> context)
    {
        return left.Interpret(context) - right.Interpret(context);
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        Expression expression = new Add(new Number(1), new Add(new Number(2), new Number(3)));
        int result = expression.Interpret(new Dictionary<string, int>());
        Console.WriteLine(result);  // 6
    }
}