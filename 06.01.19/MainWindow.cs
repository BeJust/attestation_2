using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
namespace _06._01._19
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs exeption)
        {
            try
            {



                string str = input.Text;
                char symb1 = Convert.ToChar(inputSymb1.Text);
                char symb2 = Convert.ToChar(inputSymb2.Text);
                int NumberOfSymb1 = 0, NumberOfSymb2 = 0;
                var s = new StringUtilities(input.Text, symb1, symb2);


                s.CountChars(symb1, symb2, out NumberOfSymb1, out NumberOfSymb2);
                resultA.Text = Convert.ToString(NumberOfSymb1);
                resultE.Text = Convert.ToString(NumberOfSymb2);

                if (s.CountChars(symb1, symb2, out NumberOfSymb1, out NumberOfSymb2))
                {
                    LogicResult.Text = "В строке есть искомые символы";
                }
                else
                {
                    LogicResult.Text = "В строке нет искомых символов";
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Введите корректные данные");
            }

        }
    }
}
