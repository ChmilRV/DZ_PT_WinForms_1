using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_1_5
{
    public partial class Form1 : Form
    {
        //Label label;
        int X, Y;
        //int staticNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
        }



        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.Fixed3D;
                if (e.X > X && e.Y > Y)
                    label.Location = new Point(X, Y);
                else if (e.X > X && e.Y < Y)
                    label.Location = new Point(X, e.Y);
                else if (e.X < X && e.Y < Y)
                    label.Location = new Point(e.X, e.Y);
                else
                    label.Location = new Point(e.X, Y);
                if (Math.Abs(e.X - X) >= 50 || Math.Abs(e.Y - Y) >= 50)
                {
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    //label.Text = staticNumber.ToString();
                    //label.ForeColor = Color.White;
                    label.BackColor = Color.IndianRed;
                    Controls.Add(label);
                    //Text = "Статик №" + label.Text + " создан.";
                    //label.MouseClick += LabelClick;
                    //label.MouseDoubleClick += LabelDoubleClick;
                    //staticNumber++;
                }
            }

            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > label.Location.X - 20 && e.X < label.Location.X + label.Width + 20) && (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y + label.Height + 20))
            {
                if (e.X > label.Location.X - 20 && e.X < label.Location.X)//движение курсора с лева по оси Х
                {
                    label.Left += 10;
                }
                else if (e.X < label.Location.X + label.Width + 20 && e.X > label.Location.X + label.Width)//движение курсора с права по оси Х
                {
                    label.Left -= 10;
                }
                else if (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y)//движение курсора с верху по оси У
                {
                    label.Top += 10;
                }
                else if (e.Y < label.Location.Y + label.Height + 20 && e.Y > label.Location.Y + label.Height)//движение курсора с низу по оси У
                {
                    label.Top -= 10;
                }
                //Проверка границ окна и возврат «статика» в центр
                //if ((label.Location.X < 0 || label.Location.X > ClientSize.Width - label.Width) || (label.Location.Y < 0 || label.Location.Y > ClientSize.Height - label.Height))
                //{
                //    LableCenter(label);
                //}
            }
        }





    }
}
