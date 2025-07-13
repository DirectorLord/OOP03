namespace OOP03;
using System;
using System.Drawing;

internal class Program
{
    #region Question1
    //Write a class named Calculator that contains a method named Add. Overload the Add method to
    //●	Accept two integers and return their sum.
    //●	Accept three integers and return their sum.
    //●	Accept two doubles and return their sum
    public class  Calculator
    {
        public int Add(int x, int y) => x + y;
        public int Add(int x, int y, int z) => x + y + z;
        public double Add(double x, double y) => x + y;
    }
    #endregion

    #region Question2
    //    Create a class named Rectangle with the following constructors:
    //●	A parameterless constructor that sets the width and height to 0.
    //●	A constructor that accepts width and height as integers.
    //●	A constructor that accepts a single integer and sets both width and height to that value.
    public class  Rectangle 
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }
    }
    #endregion

    #region Question3
    //Define a class Complex Number that represents a complex number with real and imaginary parts.
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        //adding method
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        //subtracting method
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

    }
    #endregion

    #region Question4
    //a) Create a base class named Employee with method That Work as it prints    "Employee is  working".
    //b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
    public class  Employee
    {
        public virtual void Work() => Console.WriteLine("Employee is working");
    }
    public class Manager : Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing");
        }
    }
    #endregion
    public static void Main(string[] args)
    {
        #region Question1

        #endregion
    }
}