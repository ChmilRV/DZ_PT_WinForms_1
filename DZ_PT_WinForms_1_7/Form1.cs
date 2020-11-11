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
        private string Calculate()
        {
            string calc = string.Empty;
            try
            {
                DateTime dayCalc = new DateTime();
                dayCalc = DateTime.Parse(textBox1.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan diffDay = dayCalc - dayNow;
                if (dayCalc > dayNow)
                {
                    if (radioButton_Year.Checked)
                        calc = Math.Round(diffDay.TotalDays / 365.25, 1).ToString() + " лет";
                    if (radioButton_Month.Checked)
                        calc = Math.Round(diffDay.TotalDays / 30, 1).ToString() + " месяцев";
                    if (radioButton_Day.Checked)
                        calc = ((int)diffDay.TotalDays).ToString() + " дней";
                    if (radioButton_Minute.Checked)
                        calc = ((int)diffDay.TotalMinutes).ToString() + " минут";
                    if (radioButton_Second.Checked)
                        calc = ((int)diffDay.TotalSeconds).ToString() + " секунд";
                }
                else
                    calc = "Прошлое...";
            }
            catch (Exception)
            {
                calc = " Неформат...";
            }
            return calc;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = Calculate();
        }
        private void radioButton_Year_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = Calculate();
        }
        private void radioButton_Month_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = Calculate();
        }
        private void radioButton_Day_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = Calculate();
        }
        private void radioButton_Minute_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = Calculate();
        }
        private void radioButton_Second_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = Calculate();
        }
    }
}