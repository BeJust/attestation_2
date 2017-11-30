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
namespace _07._02._19
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

            
            
            int sequanceStart, maxLength;
            TypesConverter io = new TypesConverter();
            int[] arr = TypesConverter.StrToArray<int>(input.Text);
            
            ArrayTransformator a = new ArrayTransformator(arr);

            a.FindLongestSubsequence(out maxLength, out sequanceStart);
           int[] result = a.GetSubsequence(maxLength,sequanceStart);
            result_1.Text = TypesConverter.ArrayToStr(result);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Введите корректные данные");

            }

        }

       
    }
}
