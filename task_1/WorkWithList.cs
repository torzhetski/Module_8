using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    /// <summary>
    /// класс для работы с коллекцией типа List
    /// </summary>
    public class WorkWithList
    {
        /// <summary>
        /// метод для заполнения коллекции
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> Fill(List<int> list)
        {
            Random random = new Random();
            for(int i = 0; i < 100; i++)
                list.Add(random.Next(100));
            return list;
        } 
        /// <summary>
        /// метод для вывода на экран элементов коллекции
        /// </summary>
        /// <param name="list"></param>
        public static void View(List<int> list)
        {
            foreach(int item in list)
                Console.Write($"{item} ");
        }
        /// <summary>
        /// метод удаляения элементов которые больше 25 и меньше 50
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> Remove(List<int> list)
        {
            for(int i = 26; i<50;i++)
                list.Remove(i);
            return list;
        }
    }
}
