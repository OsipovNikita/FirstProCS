//#define  FIRST
#define SECOND
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPro00
{
    
    internal class NumberTranslation
    {
        /// <summary>
        /// определение функции перевода положительного целого числа
        /// из десятичной системы счисления в любую заданную с основанием от 2 до 16.
        /// </summary>
        /// <param name="number">положительное целое число в десятичной системе счисления</param>
        /// <param name="baseSS">основание системы счисления</param>
        /// <returns>функция возвращает строковое представление записи числа</returns>
       public static string TransNumber(int number, int baseSS)
        {
            // создается стек для хранения целых чисел
            Stack<int> s = new Stack<int>();
            // вычисленные остатки от деления числа
            // на основание системы счисления помещаются в стек
            while(number != 0)
            {
                s.Push(number % baseSS); 
                number = number / baseSS;
            }
            // формирование строкового представления записи числа
            // путем извлечения значений из стека
            string res="";

#if FIRST
            #region trycath
            try
            {
                while (true)
                {
                    int n = s.Pop();
                    if (n < 10)
                        res = res + n;
                    else
                        res = res + (char)((int)'A' + n - 10);
                }
            }
            catch (Exception e) 
            {
                // когда стек становится пустым,
                // представление числа сформировано
                Debug.WriteLine(e.ToString());
            }
            #endregion
#elif SECOND
            #region ifEmpty
            while (s.Count != 0)
                {
                    int n = s.Pop();
                    if (n < 10)
                        res = res + n;
                    else
                        res = res + (char)((int)'A' + n - 10);
                }
            #endregion
#endif
            return res;
        }
    }
}
