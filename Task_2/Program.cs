using System;
using Task_2;
using static System.Console;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        WorkWithDictionary.Fill(dictionary);
        while (true)
        {
            WriteLine(" Что вы хотите сделать:" +
                " \n1 - Посмотреть полный список телефонов и их владельцев" +
                " \n2 - Найти владельца по номеру телефона" +
                " \n0 - Добавить еще данных" +
                " \nЛюбая другая клавиша чтобы выйти ");

            ConsoleKeyInfo key = ReadKey();
            switch (key.KeyChar)
            {
                case '0': 
                    WorkWithDictionary.Fill(dictionary);
                    break;
                case '1':
                    WorkWithDictionary.View(dictionary);
                    break;
                case '2':
                    WorkWithDictionary.Find(dictionary);
                    break;
                default:
                    return;
            }
        }    
    }
}