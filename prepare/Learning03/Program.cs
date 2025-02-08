using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        Account savings = new Account();
        //savings._balance = 50;
        savings.Deposit(100);

        Person x = new Person(); 
        Person y = new Person("Jane", "Doe"); 
        Person z = new Person("Mrs.", "Jane", "Doe");

        // start fraction assignment
        Fraction first = new Fraction();
        Console.WriteLine(first.calcNumber());
        Console.WriteLine(first.decimalNumber());

        Fraction second = new Fraction(5);
        Console.WriteLine(second.calcNumber());
        Console.WriteLine(second.decimalNumber());

        Fraction third = new Fraction(3, 4);
        Console.WriteLine(third.calcNumber());
        Console.WriteLine(third.decimalNumber());
        
        Fraction fourth = new Fraction(1, 3);
        Console.WriteLine(fourth.calcNumber());
        Console.WriteLine(fourth.decimalNumber());
    }
}