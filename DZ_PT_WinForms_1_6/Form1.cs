using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = TranslateDayOfWeek(dateTimePicker1.Value.DayOfWeek.ToString());
        }

        private string TranslateDayOfWeek(string day)
        {
            Dictionary<string, string> DayOfWeek = new Dictionary<string, string>
            {
                ["Monday"] = "Понедельник",
                ["Tuesday"] = "Вторник",
                ["Wednesday"] = "Среда",
                ["Thursday"] = "Четверг",
                ["Friday"] = "Пятница",
                ["Saturday"] = "Суббота",
                ["Sunday"] = "Воскресенье"
            };
            foreach (KeyValuePair<string, string> days in DayOfWeek)
            {
                if (days.Key == dateTimePicker1.Value.DayOfWeek.ToString())
                    day = days.Value;
            }
            return day;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = TranslateDayOfWeek(dateTimePicker1.Value.DayOfWeek.ToString());
        }
    }
}