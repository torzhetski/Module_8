using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// класс для работы с коллекцией Dictionary
    /// </summary>
    public class WorkWithDictionary
    {
        /// <summary>
        /// метод для заполнения коллекции
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static Dictionary<string,string> Fill(Dictionary<string, string> dictionary)
        {
            while (true)
            {
                Console.WriteLine("Введите номер телефона или пустую строку если хотите завершить ввод данных");
                string number = Console.ReadLine();
                if (number == String.Empty) break;
                Console.WriteLine("Введите ФИО владельца номера телефона");
                string fio = Console.ReadLine();
                dictionary.Add(number, fio);
            }
            return dictionary;
        }
        /// <summary>
        /// метод для вывода всей коллекции
        /// </summary>
        /// <param name="dictionary"></param>
        public static void View(Dictionary<string, string> dictionary)
        {
            foreach(var e in dictionary) Console.WriteLine(e);
        }
        /// <summary>
        /// метод для нахождения человека по номеру телефона
        /// </summary>
        /// <param name="dictionary"></param>
        public static void Find(Dictionary<string, string> dictionary)
        {
            Console.WriteLine("Введите номер телефона:");
            string number = Console.ReadLine();
            if (dictionary.TryGetValue(number, out string fio))
            {
                Console.WriteLine($"Владелец этого номера: {fio}");
            }
            else
                Console.WriteLine("Такого номера телефона нет в базе");
        }
    }
}
