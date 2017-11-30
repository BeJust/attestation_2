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

namespace _07._01._19
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

            
            
            int[] arr = TypesConverter.StrToArray<int>(input.Text);
            Utilities.ArrayTransformator ts = new Utilities.ArrayTransformator(arr);
            int[] t = ts.IncreaseFirstSeria();
            int[] c = ts.IncreaseLastSeria();
            int[] d = ts.IncreaseLongestSerias();

            resultfirstser.Text = TypesConverter.ArrayToStr(t);
            resultlastser.Text = TypesConverter.ArrayToStr(c);
            resultmaxser.Text = TypesConverter.ArrayToStr(d);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Введите корректные данные.");

            }
        }

       
    }
}
