using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_1_4
{
    public partial class Form1 : Form
    {
        int X, Y;
        int staticNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
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
                if (Math.Abs(e.X - X) <= 10 || Math.Abs(e.Y - Y) <= 10)
                    MessageBox.Show("Статик меньше чем 10х10", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    label.Text = staticNumber.ToString();
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Green;
                    Controls.Add(label);
                    Text = "Статик №" + label.Text + " создан.";
                    label.MouseClick += LabelClick;
                    label.MouseDoubleClick += LabelDoubleClick;
                    staticNumber++;
                }
            }
        }
        private void LabelClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point point = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > point.X &&
                        MousePosition.X < point.X + item.Width &&
                        MousePosition.Y > point.Y &&
                        MousePosition.Y < point.Y + item.Height)
                    {
                        Text = "Статик номер №" + item.Text + ", Площадь " + item.Width * item.Height + ", Координаты Х = " + item.Location.X + " Y = " + item.Location.Y;
                    }
                }
            }
        }
        private void LabelDoubleClick(object sender, MouseEventArgs e)
        {
            int labelCount = staticNumber;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point point = item.PointToScreen(Point.Empty);

                    if (MousePosition.X > point.X &&
                        MousePosition.X < point.X + item.Width &&
                        MousePosition.Y > point.Y &&
                        MousePosition.Y < point.Y + item.Height)
                    {
                        if (labelCount > Convert.ToInt32(item.Text))
                            labelCount = Convert.ToInt32(item.Text);
                    }
                    if (labelCount == Convert.ToInt32(item.Text))
                    {
                        Text = "Статик №" + item.Text + " удалён";
                        Controls.Remove(item);
                        item.MouseClick -= LabelClick;
                        item.MouseDoubleClick -= LabelDoubleClick;
                    }
                }
            }
        }
    }
}