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
namespace _08._02._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void run_Click(object sender, EventArgs e)
        {
            IOarrayutils io = new IOarrayutils();
            int[] a = io.StrToArray<int>(input.Text);
            List<int> L1 = new List<int>(a);

            Listutils list = new Listutils(L1);
            list.Process(L1);

            int[] arr = L1.ToArray();
            result.Text = IOarrayutils.ArrayToStr(arr);
            
        }
    }
}
