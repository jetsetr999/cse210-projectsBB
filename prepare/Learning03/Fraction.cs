using System;
using System.Transactions;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        // initialize variables
        _numerator = 1;
        _denominator = 1;
    }

    // first pass through one number
    public Fraction(int nbr)
    {
        _numerator = nbr;
        _denominator = 1;
    }

    // pass through two numbers
    public Fraction(int t, int b)
    {
        _numerator = t;
        _denominator = b;
    }

    // pass through two numbers to be calculated
    public string calcNumber()
    {

        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    // pass through two decimal numbers
    public double decimalNumber()
    {
        return (double)_numerator / (double)_denominator;
    }
}