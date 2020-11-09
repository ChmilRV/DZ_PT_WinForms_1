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
            int numLeft = firstNumber;
            int numRight = lastNumber;
            int num = ((numRight - numLeft) / 2) + 1;

            do
            {
                
                String message = "Задуманное число больше или равно " + num + "?";
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    numLeft = num;
                    if (MessageBox.Show("Ваше число " + num + "?", caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Число отгадано.", caption);
                        return result = DialogResult.Cancel;

                    };
                    num = ((numRight - numLeft) / 2) + numLeft;

                }
                else if (result == DialogResult.No)
                {
                    numRight = num;
                    num = ((numRight - numLeft) / 2);



                }
                




            } while (result==DialogResult.Cancel);


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
