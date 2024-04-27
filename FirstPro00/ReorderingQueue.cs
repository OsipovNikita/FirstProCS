using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPro00
{
    internal class ReorderingQueue
    {
        /// <summary>
        /// Пусть дан массив целых чисел. 
        /// Распечатать элементы этого массива по группам: сначала все числа, заканчивающиеся на 0, 
        /// затем - на 1, и т.д.
        /// Для решения задачи будем использовать массив очередей.
        /// Каждая очередь из массива будет хранить коллекцию чисел, заканчивающихся на цифру, 
        /// которая одновременно является номером очереди
        /// </summary>
        /// <param name="x">массив для преобразования</param>
      public static void Reordering(int[] x)
        {
            // Создаем массив очередей для хранения чисел, в которых
            // последние цифры совпадают с номером элемента массива
            Queue[] numbers = new Queue[10];
            for (int i = 0; i < 10; i++)
                numbers[i] = new Queue();
            // Распределяем числа из массива по соответствующим очередям
            foreach (int el in x)
            {
                int k = el % 10;
                numbers[k].Enqueue(el);
            }
            // Печать групп чисел путем извлечения элементов из очередей
            for (int i = 0; i < 10; i++)
            {
                // Пока i-тая очередь не пуста, извлекаем из нее числа и печатаем их.
                // Когда очередь станет пустой, попытка
                // извлечь элемент, приведет к возникновению
                // исключительной ситуации, произойдет выход из цикла
                try
                {
                    while (true)
                        Console.WriteLine("" +
                        (int)numbers[i].Dequeue() + "\t");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"For {i} {e.Message}");
                }
            }
        }
    }
}
