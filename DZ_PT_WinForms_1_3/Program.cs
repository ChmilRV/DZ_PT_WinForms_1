﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Задание 3
Представьте, что у вас на форме есть прямоугольник,
границы которого на 10 пикселей отстоят от границ рабочей области формы.
Необходимо создать следующие обработчики:
■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том,
  где находится текущая точка: внутри прямоугольника, снаружи, на границе прямоугольника.
  Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;
■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
  (рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вашего окна;
■ Обработчик перемещения указателя мыши в пределах рабочей области,
  который должен выводить в заголовок окна текущие координаты мыши x и y.*/
namespace DZ_PT_WinForms_1_3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
