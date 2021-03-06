﻿using System;
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
            if (Double.TryParse(textBox_FuelPrice.Text, out double fuelPrice) && Double.TryParse(textBox_FuelVolume.Text, out double fuelVolume))
            {
                label_FuelTotalSumm.Text = Math.Round(fuelPrice * fuelVolume, 2).ToString();
            }

        }

        private void textBox_FuelPrice_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_FuelSumm.Checked)
            {
                double fuelVolume;
                if (Double.TryParse(textBox_FuelSumm.Text, out double fuelSumm) && Double.TryParse(textBox_FuelPrice.Text, out double fuelPrice))
                {
                    try
                    {
                        fuelVolume = Math.Round(fuelSumm / fuelPrice, 2);
                        textBox_FuelVolume.Text = fuelVolume.ToString();
                        if (Double.TryParse(textBox_FuelPrice.Text, out fuelPrice))
                        {
                            label_FuelTotalSumm.Text = Math.Round(fuelPrice * fuelVolume, 2).ToString();
                        }
                    }
                    catch { }
                }
            }
            else if (radioButton_FuelVolume.Checked)
            {
                if (Double.TryParse(textBox_FuelPrice.Text, out double fuelPrice) && Double.TryParse(textBox_FuelVolume.Text, out double fuelVolume))
                {
                    label_FuelTotalSumm.Text = Math.Round(fuelPrice * fuelVolume, 2).ToString();
                }
            }
        }

        private void radioButton_FuelVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBox_FuelVolume.ReadOnly = false;
            textBox_FuelSumm.ReadOnly = true;
            textBox_FuelSumm.Text = string.Empty;
        }

        private void radioButton_FuelSumm_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox_FuelSumm.ReadOnly = false;
            textBox_FuelVolume.ReadOnly = true;
            textBox_FuelVolume.Text = string.Empty;
        }

        private void textBox_FuelSumm_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox_FuelSumm.Text, out double fuelSumm) && Double.TryParse(textBox_FuelPrice.Text, out double fuelPrice))
            {
                try
                {
                    textBox_FuelVolume.Text = Math.Round(fuelSumm / fuelPrice, 2).ToString();
                }
                catch { }
            }

        }
    }
}
