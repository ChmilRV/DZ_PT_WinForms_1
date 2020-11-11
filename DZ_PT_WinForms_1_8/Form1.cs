using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void comboBox_Fuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_FuelPrice.Text = textBox_FuelPrice.AutoCompleteCustomSource[comboBox_Fuel.SelectedIndex];
            
        }


        private void radioButton1_FuelVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBox_FuelVolume.ReadOnly = false;
            textBox_FuelSumm.ReadOnly = true;


        }

        private void radioButton2_FuelSumm_CheckedChanged(object sender, EventArgs e)
        {
            textBox_FuelSumm.ReadOnly = false;
            textBox_FuelVolume.ReadOnly = true;



        }

        private void textBox1_FuelVolume_TextChanged(object sender, EventArgs e)
        {
            label_FuelTotalSumm.Text = (Double.Parse(textBox_FuelPrice.Text) * Double.Parse(textBox_FuelVolume.Text)).ToString();


        }

        private void textBox_FuelPrice_TextChanged(object sender, EventArgs e)
        {
            label_FuelTotalSumm.Text = (Double.Parse(textBox_FuelPrice.Text) * Double.Parse(textBox_FuelVolume.Text)).ToString();
        }
    }
}
