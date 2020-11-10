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
        Label label;
        public Form1()
        {
            InitializeComponent();
            label = new Label();
        }
        private void LableCenter(Label lable)
        {
            label.Left = (ClientSize.Width - label.Size.Width) / 2;
            label.Top = (ClientSize.Height - label.Size.Height) / 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Size = new Size(150, 150);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;
            label.BackColor = Color.Red;
            Controls.Add(label);
            LableCenter(label);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > label.Location.X - 20 &&
                 e.X < label.Location.X + label.Width + 20) &&
                (e.Y > label.Location.Y - 20 &&
                 e.Y < label.Location.Y + label.Height + 20))
            {
                if (e.X > label.Location.X - 20 &&
                    e.X < label.Location.X)
                {
                    label.Left += 5;
                }
                else if (e.X < label.Location.X + label.Width + 20 && e.X > label.Location.X + label.Width)
                {
                    label.Left -= 5;
                }
                else if (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y)
                {
                    label.Top += 5;
                }
                else if (e.Y < label.Location.Y + label.Height + 20 && e.Y > label.Location.Y + label.Height)
                {
                    label.Top -= 5;
                }
                if ((label.Location.X < 0 ||
                     label.Location.X > ClientSize.Width - label.Width) ||
                    (label.Location.Y < 0 ||
                     label.Location.Y > ClientSize.Height - label.Height))
                {
                    LableCenter(label);
                }
            }
        }
    }
}
