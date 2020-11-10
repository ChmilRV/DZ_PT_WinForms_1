using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dayT = new DateTime();
                dayT = DateTime.Parse(textBox1.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan tempDay = dayT - dayNow;
                if (dayT > dayNow)
                {
                    if (radioButton_Year.Checked)
                    {
                        label3.Text = (tempDay.TotalDays / 365).ToString();
                    }
                    if (radioButton_Month.Checked)
                    {
                        label3.Text = (tempDay.TotalDays / 30).ToString();
                    }
                    if (radioButton_Day.Checked)
                    {
                        label3.Text = ((int)tempDay.TotalDays).ToString();
                    }
                    if (radioButton_Minute.Checked)
                    {
                        label3.Text = ((int)tempDay.TotalMinutes).ToString();
                    }
                    if (radioButton_Second.Checked)
                    {
                        label3.Text = ((int)tempDay.TotalSeconds).ToString();
                    }
                }
                else
                {
                    label3.Text = "Эта дата уже прошла!";
                }
            }
            catch (Exception)
            {
                label3.Text = " Неверный формат даты";
            }


        }
    }
}
