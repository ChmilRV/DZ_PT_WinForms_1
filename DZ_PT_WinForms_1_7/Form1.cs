using System;
using System.Windows.Forms;
namespace DZ_PT_WinForms_1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "YYYY/MM/DD";
            label3.Text = "0";
            radioButton_Year.Checked = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dayCalc = new DateTime();
                dayCalc = DateTime.Parse(textBox1.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan diffDay = dayCalc - dayNow;
                if (dayCalc > dayNow)
                {
                    if (radioButton_Year.Checked)
                        label3.Text = Math.Round(diffDay.TotalDays / 365.25, 1).ToString() + " лет";
                    if (radioButton_Month.Checked)
                        label3.Text = Math.Round(diffDay.TotalDays / 30, 1).ToString() + " месяцев";
                    if (radioButton_Day.Checked)
                        label3.Text = ((int)diffDay.TotalDays).ToString() + " дней";
                    if (radioButton_Minute.Checked)
                        label3.Text = ((int)diffDay.TotalMinutes).ToString() + " минут";
                    if (radioButton_Second.Checked)
                        label3.Text = ((int)diffDay.TotalSeconds).ToString() + " секунд";
                }
                else
                    label3.Text = "Прошлое...";
            }
            catch (Exception)
            {
                label3.Text = " Неформат...";
            }
        }
    }
}