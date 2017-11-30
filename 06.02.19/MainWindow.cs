using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace _06._02._19
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            try
            {


                int N = 0;
                int Ndiv10 = 0;
                double x = Convert.ToDouble(inputx.Text);
                double E = Convert.ToDouble(inpute.Text);
              

                CountingSum s = new CountingSum(x, E);
                double sum = s.CountSumDirectly();
                double sumE = s.CountSumAproximatly(E, out N);
                double sumE10 = s.CountSumAproximatly(E / 10, out Ndiv10);
                double function = Math.Cos(x);
                resultsum.Text = Convert.ToString(sum);
                resultsume.Text = Convert.ToString(sumE);
                resultsume10.Text = Convert.ToString(sumE10);
                resultfunction.Text = Convert.ToString(function);
                resultN.Text = Convert.ToString(N);
                resultediv10.Text = Convert.ToString(Ndiv10);
            }

            catch (FormatException exception)
            {
                MessageBox.Show("Введите корректные данные");
               
            }




        }

        
    }
}
