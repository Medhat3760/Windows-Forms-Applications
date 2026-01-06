using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsCalculator calc = new clsCalculator();

        private void btnNumber_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            calc.InputDigit(btn.Text[0]);
            txtDisplay.Text = calc.Display;

        }

        private void TrySetOperation(enOperationType opType)
        {

            try
            {

                calc.SetOperation(opType);

            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                calc.Clear();

            }

            txtDisplay.Text = calc.Display;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            TrySetOperation(enOperationType.Add);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            TrySetOperation(enOperationType.Divide);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            TrySetOperation(enOperationType.Subtract);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            TrySetOperation(enOperationType.Multiply);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            try
            {
                calc.Equal();
                txtDisplay.Text = calc.Display;

            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                calc.Clear();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            calc.Clear();
            txtDisplay.Text = calc.Display;

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

            calc.Backspace();
            txtDisplay.Text = calc.Display;

        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {

            calc.InputDecimalPoint();
            txtDisplay.Text = calc.Display;


        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

            calc.Percent();
            txtDisplay.Text = calc.Display;

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

            calc.ToggleSign();
            txtDisplay.Text = calc.Display;

        }
    }
}
