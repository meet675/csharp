﻿using System;
class GFG
{

    // adding two integer values.
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating Object
        GFG ob = new GFG();

        int sum1 = ob.Add(1, 2);
        Console.WriteLine("sum of the two "
                          + "integer value : " + sum1);

        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                          + "integer value : " + sum2);
    }
}




--
    using System;
namespace DemoCsharp
{
    class BaseClass
    {
        public virtual int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
    class ChildClass : BaseClass
    {
        public override int Add(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Values could not be less than zero or equals to zero");
                Console.WriteLine("Enter First value : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First value : ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            return (num1 + num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClassObj;
            baseClassObj = new BaseClass();
            Console.WriteLine("Base class method Add :" + baseClassObj.Add(-3, 8));
            baseClassObj = new ChildClass();
            Console.WriteLine("Child class method Add :" + baseClassObj.Add(-2, 2));
            Console.ReadLine();
        }
    }
}