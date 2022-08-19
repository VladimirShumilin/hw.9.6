using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    public class NumberExeption: ArgumentException
    {
        public NumberExeption() : this("Введен неверный номер. Введите число от 1 до 2") {
        }

        public NumberExeption(string Message) :base(Message) 
        {
            HelpLink = "Здесь ссылка на раздел в справке или на сайт с разделом справки";
        }
    }
}
