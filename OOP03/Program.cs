namespace OOP03;
using System;
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
    public static void Main(string[] args)
    {
        #region Question1

        #endregion
    }
}