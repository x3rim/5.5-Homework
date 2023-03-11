using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_Homework_task_2
{
    internal class Program
    {
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        static string EnterString()
        {
            Console.WriteLine("Введите длиное предложение: ");
            return Console.ReadLine();
        }

        static string Reverse(string text)
        {
            string[] split = SplitText(text);
            string str_new = "";

            for (int i = split.Length - 1; i >= 0; i--) 
            {
                str_new += split[i] + " ";
            }
             return str_new;
        }


        static void Main(string[] args)
        {
            //            Задание 2.Перестановка слов в предложении
            //Что нужно сделать
            //Пользователь вводит в программе длинное предложение. Каждое слово отделено пробелом. После ввода пользователь нажимает клавишу Enter.
            //Необходимо создать два метода:

            //первый разделяет слова в предложении;
            //            второй меняет эти слова местами(в обратной последовательности).
            //            Учтите, что один метод вызывается внутри другого метода, то есть в методе main вызывается метод c сигнатурой ReversWords(string inputPhrase).
            //            Внутри этого метода вызывается метод по разделению входной фразы на слова.Метод должен выглядеть так: static string Reverse(string text),
            //            где text — это предложение, в котором необходимо поменять местами слова.


            //Советы и рекомендации
            //Для сложения строк можно использовать конкатенацию строк.
            //Выражение вида ResultString += NewString + “ ” добавит к текущей строке, которая представлена переменной ResultString,
            //новую строку из переменной NewString, а также пробел к концу строки. 
            //Для реализации алгоритма разделения строки на слова можно воспользоваться рекомендациями из задания 1.
            //В программе не должно быть глобальных переменных.Все данные между методами должны передаваться через параметры и возвращаемые значения.

            //Что оценивается
            //Вызов метода по разделению на слова происходит внутри метода, который отвечает непосредственно за инвертирование слов в предложении.

            string text = EnterString();
            Console.WriteLine($"Перевернутый текст - {Reverse(text)}");
            Console.ReadKey();
        }
    }
}
