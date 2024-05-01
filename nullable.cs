using System;
class Program
{
    public static void Main()
    {
        // assigning 'null' to integer type variable x 
        Nullable<int> x = null;

        // assigning 'null' to boolean type variable y
        Nullable<bool> y = null;

        // assigning 'null' to floating point type variable z 
        Nullable<float> z = null;


        // access Nullable types
        Console.WriteLine("Value of x: " + x.GetValueOrDefault());
        Console.WriteLine("Value of y: " + y.GetValueOrDefault());
        Console.WriteLine("Value of z: " + z.GetValueOrDefault());
    }
}