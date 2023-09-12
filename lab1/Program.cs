// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
class Numbers
{
    private int a;
    private int b;

    public Numbers(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public bool Correct()
    {
        return a > 0 && b > 0;
    }

    public int Nod()
    {
        int x = a;
        int y = b;
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    public int Nok()
    {
        return a * b / Nod();
    }

    public void Print()
    {
        Console.WriteLine($"a = {a}, b = {b}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введiть значення a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введiть значення b: ");
            int b = int.Parse(Console.ReadLine());

            Numbers numbers = new Numbers(a, b);

            Console.WriteLine("Значення полiв об'єкта:");
            numbers.Print();

            if (numbers.Correct())
            {
                Console.WriteLine($"Найбiльший спiльний дiльник: {numbers.Nod()}");
                Console.WriteLine($"Найменше спiльне кратне: {numbers.Nok()}");
            }
            else
            {
                Console.WriteLine("Об'єкт не може iснувати, оскiльки числа не є натуральними.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}