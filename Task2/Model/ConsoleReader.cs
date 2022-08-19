using Exeptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    internal class ConsoleReader
    {
        public delegate void Sort(SortDirection direction);
        public event Sort? OnSort;

        public enum SortDirection
        {
            Ascending,
            Descending
        }

        public  void ReadFromConsole()
        {
            string? line = "";
            int num = 0;

            Console.WriteLine("Введите 1 или 2 для сортировки. Или нажмите Ctrl+c для выхода");
            while (true)
            {
                try
                {
                     line = Console.ReadLine();

                    if (string.IsNullOrEmpty(line))
                        throw new NumberExeption();

                    num = Convert.ToInt32(line, CultureInfo.InvariantCulture);

                    switch (num)
                    {
                        case 1:
                            OnSort?.Invoke(SortDirection.Ascending);
                            break;
                        case 2:
                            OnSort?.Invoke(SortDirection.Descending);
                            break;
                        default:
                            throw new NumberExeption();
                    }
                }
                //Console.ReadLine
                catch (IOException ex) { Console.WriteLine(ex); }
                catch (OutOfMemoryException ex) { Console.WriteLine(ex); }
                catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex); }
                //Convert.ToInt32
                catch (FormatException ex) { Console.WriteLine(ex); }
                catch (OverflowException ex) { Console.WriteLine(ex); }
                //логика ReadFromConsole
                catch (NumberExeption ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
