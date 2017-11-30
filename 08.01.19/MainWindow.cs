
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

namespace _08._01._19
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

           
            
           int n = Convert.ToInt32(inputn.Text);

            TypesConverter io = new TypesConverter();

            
            List<int> list1 = new List<int>(TypesConverter.StrToList<int>(input.Text));
            
            Listutils list = new Listutils(list1);
            list1 = list.CreateNewList(n);

                             
            output.Text = TypesConverter.ListToStr(list1);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Введите корректные данные");
              
            }
        }
       
        
}
}
