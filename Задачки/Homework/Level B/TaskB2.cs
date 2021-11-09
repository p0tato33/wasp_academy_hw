using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static List<int> OrderWeight(List<int> list)
        {
            int x;
            int s;
            int s2;
            int n2;
            int n;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    n2 = list[i]; n = list[j]; s = n2 % 10; s2 = n % 10;
                    do
                    {
                        n2 /= 10;
                        s += n2 % 10;
                    } while (n2 > 9);
                    do
                    {
                        n /= 10;
                        s2 += n % 10;
                    } while (n > 9);
                    if (s > s2 || s == s2 && string.Compare(list[i].ToString(), list[j].ToString()) > 0)
                    {
                        x = list[i];
                        list[i] = list[j];
                        list[j] = x;
                    }
                }
            }
            return list;
        }
    }
}
