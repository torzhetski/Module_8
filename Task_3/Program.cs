using System;
using static System.Console;

class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();
        WriteLine("Вводите числа через Enter для завершения ввода чисел введите нечисловую строку");
        while (true)
        {
            int number;
            if (int.TryParse(ReadLine(), out number))
            {
                if (!(set.Contains(number)))
                {
                    set.Add(number);
                    WriteLine($"Число {number} успешно добалено");
                }
                else WriteLine
                        ($"Число {number} уже присутствует в множестве");
            }
            else
            {
                WriteLine("Все введенные вами числа:");
                foreach(var e in set) Console.Write($"{e} ");
                return;
            }
        }
    }
}