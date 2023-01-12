using System;
using static System.Console;
using task_1;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        WorkWithList.Fill(list);
        WorkWithList.View(list);
        WorkWithList.Remove(list);
        WriteLine();
        WorkWithList.View(list);
    }
}