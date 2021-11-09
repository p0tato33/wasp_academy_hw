using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        public static string Reverser(string s)
        {
            char[] rev = s.ToCharArray();   //получаем массив чаров
            Array.Reverse(rev);
            s = new string(rev);
            string[] sp_new = s.Split(' ');
            Array.Reverse(sp_new);
            string result = string.Join(" ", sp_new); //joinim через проьбел
            return result;
        }
    }
}
