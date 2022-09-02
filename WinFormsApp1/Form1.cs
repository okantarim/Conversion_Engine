using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the conversion engine");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbBox1.SelectedItem.ToString() == "string")
            {
                lbl1.Text = txtBox1.Text;
            }
            else if (cmbBox1.SelectedItem.ToString() == "int")
            {
                try
                {
                    int number1 = Convert.ToInt32(txtBox1.Text);
                    lbl1.Text = Convert.ToString(number1);
                }
                catch (FormatException)
                {

                    MessageBox.Show("Please enter an integer value.");
                }
            }
            else if (cmbBox1.SelectedItem.ToString() == "double")
            {
                try
                {
                    double number2 = Convert.ToDouble(txtBox1.Text);
                    lbl1.Text = Convert.ToString(number2);
                }
                catch (FormatException)
                {

                    MessageBox.Show("Please enter an double type data.");
                }
            }
            else if (cmbBox1.SelectedItem.ToString() == "float")
            {
                try
                {
                    float number3 = float.Parse(txtBox1.Text);
                    lbl1.Text = Convert.ToString(number3);
                }
                catch (FormatException)
                {

                    MessageBox.Show("Please enter a float type data.");
                }
            }
            else if (cmbBox1.SelectedItem.ToString() == "char")
            {
                try
                {
                    char[] number4 = txtBox1.Text.ToCharArray();
                    lbl1.Text = Convert.ToString(number4);
                }
                catch (FormatException)
                {

                    MessageBox.Show("Please enter a char type data.");
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

