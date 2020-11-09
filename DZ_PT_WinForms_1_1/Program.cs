﻿using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Задание 1
Вывести на экран свое (краткое!!!) резюме с помощью последовательности MessageBox’ов (числом не менее трех).
Причем на заголовке последнего должно отобразиться среднее число символов на странице (общее количество символов в резюме / количество MessageBox’ов).*/
namespace DZ_PT_WinForms_1_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ArrayList resume = new ArrayList()
            {"Чмиль Руслан Владимирович",
             "8 сентября 1982 г",
             "г. Чернигов",
             "Инженер-конструктор",
             "+380674157035",
             "chmilrv@gmail.com"};
            int countMessBoxes = 1;
            int resumeLenght = 0;
            foreach (object res in resume)
            {
                resumeLenght += res.ToString().Length;
                if (countMessBoxes < resume.Count) MessageBox.Show(res.ToString());
                else MessageBox.Show(res.ToString(), (resumeLenght / countMessBoxes).ToString());
                countMessBoxes++;
            }
        }
    }
}
