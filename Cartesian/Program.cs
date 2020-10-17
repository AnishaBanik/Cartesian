using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        char[] chars = { 'X', 'Y', 'Z' };
        int[] num = { 1, 2, 3 };
        string[] color = { "Orange", "Red" };



        var Prod = from lett in chars
                   from numb in num
                   from col in color
                   select new { lett, numb, col };

        Console.Write("The Product sets are : \n");
        foreach (var prod1 in Prod)
        {
            Console.WriteLine(prod1);
        }

    }
}
