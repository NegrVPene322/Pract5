using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pract5
{
    internal class Triad
    {
        int triad1;
        int triad2;
        int triad3;

        //Свойства для проверки троек на нечетность
        /// <summary>
        /// Первое число проверяется на нечетность и на то, является ли тройкой
        /// </summary>
        public int Triad1
        {
            get
            {
                return triad1;
            }
            set
            {
                if ((value < 999) && (value > 99))
                {
                    if (value % 2 != 0) triad1 = value;
                    else MessageBox.Show("Тройка четная");
                }
                else MessageBox.Show("Вы ввели не тройку");
            }
        }
        /// <summary>
        /// Второе число проверяется на нечетность и на то, является ли тройкой
        /// </summary>
        public int Triad2
        {
            get
            {
                return triad2;
            }
            set
            {
                if ((value < 999) && (value > 99))
                {
                    if (value % 2 != 0) triad2 = value;
                    else MessageBox.Show("Тройка четная");
                }
                else MessageBox.Show("Вы ввели не тройку");
            }
        }
        /// <summary>
        /// Третье число проверяется на нечетность и на то, является ли тройкой
        /// </summary>
        public int Triad3
        {
            get
            {
                return triad3;
            }
            set
            {
                if ((value < 999) && (value > 99))
                {
                    if (value % 2 != 0) triad3 = value;
                    else MessageBox.Show("Тройка четная");
                }
                else MessageBox.Show("Вы ввели не тройку");
            }
        }
        /// <summary>
        /// Сравнивает 2 числа между собой
        /// </summary>
        /// <param name="a">  Параметр a </param>
        /// <param name="b">  Параметр b </param>
        /// <returns> Возвращает true или false </returns>
        public bool SravnTriad(int a, int b)
        {
            if (a == b) return true;
            else return false;
        }
        /// <summary>
        /// Сравнивает 3 числа между собой
        /// </summary>
        /// <param name="triad1"> Первое число</param>
        /// <param name="triad2">Второе число</param>
        /// <param name="triad3"> Третье число</param>
        /// <returns> Возвращает true или false </returns>
        public bool SravnTriad(int triad1, int triad2, int triad3)
        {
            if ((triad1 == triad2) && (triad1 == triad3)) return true;
            else return false;
        }


    }
}

