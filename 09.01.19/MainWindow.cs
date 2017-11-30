using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using InterfaceUtils;
using Utilities;


namespace _09._01._19
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.inputGridView.Rows.Add("0", "0");
            this.inputGridView.Rows.Add("0", "0");

            this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory;
            this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;
        }
       
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = GridViewUtils.GridToArray2<int>(inputGridView);
                MatrixUtils<int> utils = new MatrixUtils<int>(matrix);

                bool result = utils.IsOrderedSequenceExists(MatrixUtils<int>.OrderType.Asc) ||
                              utils.IsOrderedSequenceExists(MatrixUtils<int>.OrderType.Desc);

                string answer = "Элементы образуют упорядоченную последовательность";

                if (!result)
                {
                    answer = "Элементы не образуют упорядоченную последовательность";
                }

                this.OutputTextLbl.Text = "Результат проверки: " + Environment.NewLine + answer;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            // Задаём начальные пути для диалогов открытия/сохранения файла
            this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory;
            this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            // Инициализируем наши DataGridView (задаём им начальные свойства)
            GridViewUtils.InitGridForArr(inputGridView, 40, false, true, true, true, true);
        }

        private void MainMenuFileOpen_Click(object sender, EventArgs e)
        {
            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Читаем содержимое выбранного файла и преобразуем его в массив
                    string arrText = FilesUtils.Read(LoadFileDialog.FileName);
                    int[,] arr = TypesConverter.StrToArray2D<int>(arrText);
                    
                    // Копируем полученный массив в DataGridView
                    GridViewUtils.Array2ToGrid(inputGridView, arr);
                    if (arr.GetLength(1) == 0 || arr.GetLength(0) == 0)
                    {
                        throw new Exception();
                    }
                    MessagesUtils.Show("Данные загружены");
                }
                catch (Exception exception)
                {
                    MessagesUtils.ShowError("Ошибка загрузки данных");
                }
            }
        }

        private void MainMenuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Записываем текст из блока результатов вычислений в файл
                string answer = OutputTextLbl.Text;

                if (answer == "")
                    throw new Exception();

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilesUtils.Write(SaveFileDialog.FileName, answer);

                    MessagesUtils.Show("Данные сохранены");

                }
            }
            catch (Exception exception )
            {
                MessagesUtils.ShowError("Ошибка сохранения данных");
            }
        }

        private void MainMenuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
