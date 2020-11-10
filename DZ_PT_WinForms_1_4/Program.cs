﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Задание 4. Разработать приложение, созданное на основе форме.
■ Пользователь «щелкает» левой кнопкой мыши по форме и, не отпуская кнопку,
  ведет по ней мышку, а в момент отпускания кнопки по полученным координатам прямоугольника
  необходимо создать «статик» (статический элемент управления, например - Label),
  который содержит свой порядковый номер (имеется в виду порядок появления на форме).
■ Минимальный размер «статика» составляет 10х10, при попытке создания элемента меньших размеров
  пользователь должен увидеть соответствующее предупреждение.
■ При щелчке правой кнопкой мыши над поверхностью «статика» в заголовке окна должна появиться
  информация о его площади и координатах (относительно формы).
  В случае, если в точке щелчка находится несколько «статиков»,
  то предпочтение отдается «статику» с наибольшим порядковым номером.
■ При двойном щелчке левой кнопки мыши над поверхностью «статика» он должен исчезнуть с формы.
  В случае, если в точке щелчка находится несколько «статиков»,
  то предпочтение отдается «статику» с наименьшим порядковым номером.*/
namespace DZ_PT_WinForms_1_4
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
