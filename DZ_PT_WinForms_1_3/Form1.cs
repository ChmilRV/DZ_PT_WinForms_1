using System;
using System.Threading;
using System.Windows.Forms;

namespace DZ_PT_WinForms_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String CoordinatesToString(MouseEventArgs e)
        {
            return "Координаты мыши: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "Текущая точка ";
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                    this.Close();
                if ((e.X < 10 || e.X > ClientSize.Width - 10) ||
                    (e.Y < 10 || e.Y > ClientSize.Height - 10))
                    message += "снаружи прямоугольника.";
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) ||
                         (e.Y == 10 || e.Y == ClientSize.Height - 10))
                    message += "на границе прямоугольника.";
                else
                    message += "внутри прямоугольника.";
                MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = "Ширина = " + ClientSize.Width + ", Высота = " + ClientSize.Height;
                Thread.Sleep(1000);
            }
        }
    }
}
