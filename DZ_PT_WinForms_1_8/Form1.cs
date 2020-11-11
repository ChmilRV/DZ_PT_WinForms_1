using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_1_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox_Fuel.SelectedIndex = 0;
            this.radioButton_FuelVolume.Checked = true;
            this.label_FuelTotalSumm.Text = "0,00";
            this.textBox_FuelVolume.Text = "10";
            //this.textBox_FuelSumm.Text = "100";

        }

        private void comboBox_Fuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_FuelPrice.Text = textBox_FuelPrice.AutoCompleteCustomSource[comboBox_Fuel.SelectedIndex];
            
        }
        private void textBox_FuelVolume_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label_FuelTotalSumm.Text = (Math.Round(Convert.ToDouble(textBox_FuelPrice.Text) * Convert.ToDouble(textBox_FuelVolume.Text), 2)).ToString();
                //textBox_FuelSumm.Text = label_FuelTotalSumm.Text;

            }
            catch 
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


        private void textBox_FuelPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label_FuelTotalSumm.Text = (Math.Round(Convert.ToDouble(textBox_FuelPrice.Text) * Convert.ToDouble(textBox_FuelVolume.Text), 2)).ToString();
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void radioButton_FuelVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBox_FuelVolume.ReadOnly = false;
            textBox_FuelSumm.ReadOnly = true;
        }

        private void radioButton_FuelSumm_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox_FuelSumm.ReadOnly = false;
            textBox_FuelVolume.ReadOnly = true;



        }

        private void textBox_FuelSumm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_FuelVolume.Text = (Math.Round( Convert.ToDouble(textBox_FuelSumm.Text) / Convert.ToDouble(textBox_FuelPrice.Text), 2)).ToString();
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
