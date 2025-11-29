using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {

            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }

            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

        }

        float GetSelectedToppingsPrice()
        {

            float totalToppings = 0;

            if (chkExtraCheese.Checked)
            {
                totalToppings += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkMushroom.Checked)
            {
                totalToppings += Convert.ToSingle(chkMushroom.Tag);
            }

            if (chkTomatoes.Checked)
            {
                totalToppings += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkOnion.Checked)
            {
                totalToppings += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkOlives.Checked)
            {
                totalToppings += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                totalToppings += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return totalToppings;

        }

        float GetSelectedCrustPrice()
        {

            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

            if (rbSmall.Checked)
            {
                UpdateSize();
            }

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {

            if (rbMedium.Checked)
            {
                UpdateSize();
            }

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {

            if (rbLarge.Checked)
            {
                UpdateSize();
            }

        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings = "Extra Cheese";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushroom.Checked)
            {
                sToppings += ", Mushroom";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings.";

            lblToppings.Text = sToppings;

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        void UpdateCrust()
        {

            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }
            
            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            if (rbThinCrust.Checked)
            {
                UpdateCrust();
            }

        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {

            if (rbThickCrust.Checked)
            {
                UpdateCrust();
            }

        }

        void UpdateWhereToEat()
        {

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out.";
                return;
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                UpdateWhereToEat();
            }
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {

            if (rbTakeOut.Checked)
            {
                UpdateWhereToEat();
            }

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                MessageBox.Show("Order Placed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            chkExtraCheese.Checked = false;
            chkMushroom.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;


            //reset CrustType
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ResetForm();

        }

        void UpdateOrderSummary()
        {

            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UpdateOrderSummary();

        }

    }
}
