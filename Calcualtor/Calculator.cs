﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

       
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            SetNum("1");
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        public void SetNum(string num)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = num;
            else
                NumScreen.Text = NumScreen.Text + num;
        }

    }
}
