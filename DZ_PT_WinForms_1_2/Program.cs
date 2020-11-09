using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Задание 2
Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000.
Для запроса к пользователю использовать MessageBox.
После того, как число отгадано, необходимо вывести количество запросов, потребовавшихся для этого,
и предоставить пользователю возможность сыграть еще раз, не выходя из программы
(MessageBox’ы оформляются кнопками и значками соответственно ситуации).*/
namespace DZ_PT_WinForms_1_2
{
    static class Program
    {
        static DialogResult GuessTheNumber()
        {
            int firstNumber = 1;
            int lastNumber = 2000;
            DialogResult result;
            String caption = "Угадывание числа";
            String firstMessage = "Задумайте число от" + firstNumber + " до " + lastNumber +".\n" +
                "Продолжить - ОК.\n" +
                "Выход - Отмена.";
            result = MessageBox.Show(firstMessage, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Cancel) return result;
            do
            {



            } while (result!=DialogResult.);


            return result;
        }



        [STAThread]
        static void Main()
        {
            DialogResult result;
            do
            {
                result = GuessTheNumber();
            } while (result != DialogResult.Cancel);



        }
    }
}
