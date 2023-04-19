using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        for (int n = 0; n < num; n++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(num);
        for (int n = 0; n < num; n++)
        {
            Console.WriteLine(list[n]);
        }
    }
}