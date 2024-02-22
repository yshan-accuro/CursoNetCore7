﻿// See https://aka.ms/new-console-template for more information
List<int> list = [1, 2, 3, 4];
foreach (var i in list.filter(x => x % 2 == 0))
{
    Console.WriteLine(i);
}

static class enumExtension
{
    public static IEnumerable<T> filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var v in source)
        {
            if (predicate(v))
            {
                yield return v;
            }
        }
    }
}

class Delagados
{

    public delegate int Operation(int x, int y);
    static int Suma(int x, int y)
    {
        return x + y;
    }
    static int Res(int x, int y)
    {
        return x - y;
    }
    static int Mult(int x, int y)
    {
        return x * y;
    }
    static int Div(int x, int y)
    {
        return x / y;
    }

    List<Operation> listOperacion = [Suma, Res, Mult, Div, (a, b) => a + b];
}