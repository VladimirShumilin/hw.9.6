using System;
using Task2.Model;

namespace Task2
{
    internal class Program
    { 
        //массив фамилий
        private static List<string> data = new List<string>(5)
            { "Дерибаска","Гончаров","Авдеев","Буковский","Верминов" };


        static void Main(string[] args)
        {
            Console.WriteLine("Состояние массива фамилий:");
            data.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("");

            ConsoleReader cr = new();
            cr.OnSort += Cr_OnSort;
            cr.ReadFromConsole();
        }

        private static void Cr_OnSort(ConsoleReader.SortDirection direction)
        {
            if(direction == ConsoleReader.SortDirection.Ascending)
                data = data.OrderBy(x => x).ToList();
            else
                data = data.OrderByDescending(x => x).ToList();

            Console.WriteLine("Сортировка выполнена. Состояние массива фамилий:");
            data.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("");
        }
    }
}