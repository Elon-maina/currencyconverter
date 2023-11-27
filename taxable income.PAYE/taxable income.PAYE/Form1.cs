using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxable_income.PAYE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Salary, Netpaid, Taxdeduction, IncomeTaxed, GrossPay, Allowances, Deduction;
            Allowances = Convert.ToDouble(allowance.Text);
            Deduction = Convert.ToDouble(deducts.Text);
            Salary = Convert.ToDouble(salary.Text);
            GrossPay = Allowances + Salary;
            grosspay.Text = Convert.ToString(GrossPay);
            int pay = 1200;

            if (comboBox1.Text.Length > 0)
            {
                if (GrossPay <= 24000)
                {
                    IncomeTaxed = GrossPay - pay;
                    Taxdeduction = 0.1 * IncomeTaxed;
                    Netpaid = (GrossPay - (Deduction + Taxdeduction));

                    Taxdeducted.Text = Convert.ToString(Taxdeduction);
                    NetPay.Text = Convert.ToString(Netpaid);
                    taxablePayment.Text = Convert.ToString(IncomeTaxed);
                    incomeNotTaxed.Text = Convert.ToString(pay);
                }

                else if (GrossPay > 24000 && GrossPay <= 40000)
                {

                    IncomeTaxed = GrossPay - pay;
                    Taxdeduction = 0.15 * IncomeTaxed;
                    Netpaid = (GrossPay - (Deduction + Taxdeduction));

                    Taxdeducted.Text = Convert.ToString(Taxdeduction);
                    NetPay.Text = Convert.ToString(Netpaid);
                    taxablePayment.Text = Convert.ToString(IncomeTaxed);
                    incomeNotTaxed.Text = Convert.ToString(pay);
                }

                else if (GrossPay > 40000 && GrossPay <= 60000)
                {

                    IncomeTaxed = GrossPay - pay;
                    Taxdeduction = 0.2 * IncomeTaxed;
                    Netpaid = (GrossPay - (Deduction + Taxdeduction));

                    Taxdeducted.Text = Convert.ToString(Taxdeduction);
                    NetPay.Text = Convert.ToString(Netpaid);
                    taxablePayment.Text = Convert.ToString(IncomeTaxed);
                    incomeNotTaxed.Text = Convert.ToString(pay);
                }
                else if (GrossPay > 60000 && GrossPay <= 100000)
                {

                    IncomeTaxed = GrossPay - pay;
                    Taxdeduction = 0.25 * IncomeTaxed;
                    Netpaid = (GrossPay - (Deduction + Taxdeduction));

                    Taxdeducted.Text = Convert.ToString(Taxdeduction);
                    NetPay.Text = Convert.ToString(Netpaid);
                    taxablePayment.Text = Convert.ToString(IncomeTaxed);
                    incomeNotTaxed.Text = Convert.ToString(pay);
                }
                else if (GrossPay > 100000 && GrossPay <= 150000)
                {

                    IncomeTaxed = GrossPay - pay;
                    Taxdeduction = 0.3 * IncomeTaxed;
                    Netpaid = (GrossPay - (Deduction + Taxdeduction));

                    Taxdeducted.Text = Convert.ToString(Taxdeduction);
                    NetPay.Text = Convert.ToString(Netpaid);
                    taxablePayment.Text = Convert.ToString(IncomeTaxed);
                    incomeNotTaxed.Text = Convert.ToString(pay);
                }
                else if (GrossPay > 150000 && GrossPay <= 250000)
                {

                    IncomeTaxed = GrossPay - pay;
                    Taxdeduction = 0.35 * IncomeTaxed;
                    Netpaid = (GrossPay - (Deduction + Taxdeduction));

                    Taxdeducted.Text = Convert.ToString(Taxdeduction);
                    NetPay.Text = Convert.ToString(Netpaid);
                    taxablePayment.Text = Convert.ToString(IncomeTaxed);
                    incomeNotTaxed.Text = Convert.ToString(pay);
                }

                else if (GrossPay > 250000)
                {

                    IncomeTaxed = GrossPay - pay;
                    Taxdeduction = 0.4 * IncomeTaxed;
                    Netpaid = (GrossPay - (Deduction + Taxdeduction));

                    Taxdeducted.Text = Convert.ToString(Taxdeduction);
                    NetPay.Text = Convert.ToString(Netpaid);
                    taxablePayment.Text = Convert.ToString(IncomeTaxed);
                    incomeNotTaxed.Text = Convert.ToString(pay);
                }


            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Taxdeducted.Text = "";
            NetPay.Text = "";
            taxablePayment.Text = "";
            incomeNotTaxed.Text = "";
            grosspay.Text = "";
        }

        private void NetPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
