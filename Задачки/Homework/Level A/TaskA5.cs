using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            int count = 0;
            int c2;
            List<int> res_lst = new List<int>();
            while (number > 0)
            {
                number /= 10;
                count++;
            }

            c2 = count;
            count--;
            for (int i = 0; i < c2; i++)
            {
                res_lst.Add(number / Convert.ToInt32(Math.Pow(10, count)));
                count--;
            }
            return res_lst;
        }
    }
}
