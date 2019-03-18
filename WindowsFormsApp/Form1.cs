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

namespace WindowsFormsApp
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        // БЛОК ИНИЦИАЛИЗАЦИИ ПЕРЕМЕННЫХ
        // Число для поиска
        public int pivot = 0;
        public String finale;

        // БЛОК МЕТОДОВ СОРТИРОКИ
        //
        // Сортировка Шелла
        //
        public void ShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = array[j];

                    while (j - gap >= 0 && temp < array[j - gap])
                    {
                        array[j] = array[j - gap];
                        j = j - gap;
                    }

                    array[j] = temp;
                }

                gap = gap / 2;
            }
        }

        //
        // Сортровка Хоара (быстрая)
        //
        // Интеллектуальный поиск опорного элемента
        // (можно заменить на средний жлемент подмассива)
        public int partition(int[] array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;

                    marker += 1;
                }
            }

            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;

            return marker;
        }

        // Рекурсивная реализация быстрой сортировки
        public void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivot = partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }

        // БЛОК РАБОТЫ С ПОЛЯМИ ВВОДА
        //
        // Открыть поиск файла
        //
        public void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialogFile.InitialDirectory = "c:\\";
            openFileDialogFile.Filter = "Текстовые файлы|*.txt";

            // Вывести название файла в форму
            if (openFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFail.Text = openFileDialogFile.FileName;
            }
        }

        //
        // Проверка наличия в файле
        //
        public bool isInSeq(int x)
        {
            /**/  bool ans = true;
            // Проверка на успешную конвертацию строк в числа
            try
            {
                //
                // Парсинг файла с числами
                //
                List<int> listNum = new List<int>();
                int arg = 0;
                String str = File.ReadAllText(textBoxFail.Text);
                String[] arrStr = str.Split(' ');

                foreach(String st in arrStr)
                {
                    Int32.TryParse(st, out arg);
                    listNum.Add(arg);
                }

                //
                // Сортировка массива чисел
                //
                int[] arrNum = listNum.ToArray();

                if (checkBoxSortShell.Checked)
                {
                    ShellSort(arrNum);
                }
                else
                {
                    if (checkBoxSortQSort.Checked)
                    {
                        QuickSort(arrNum, 0, arrNum.Length - 1);
                    }
                    else
                    {
                        return false;
                    }
                }

                // Преобразовать массив в список
                // Преведение массива к списку не работает 
                listNum = new List<int>();
                foreach(int varb in arrNum)
                {
                    listNum.Add(varb);
                }

                //
                // Искомого числа нет в файле
                //
                if (listNum.BinarySearch(x) < 0)
                {
                    return false;
                }

                return true;
            }
            catch
            {
                ans = false;
                FormAlert formAlert = new FormAlert();
                formAlert.Focus();
                formAlert.Show();
               
                //return false;
            }

            return ans;
        } // Конец isInSeq()

        //
        // Поиск числа в файле
        //
        public void buttonExe_Click(object sender, EventArgs e)
        {
            // Проверка входных данных пройдена
            if (getFormFilled())
            {
                FormAnswer formAnsewr = new FormAnswer();
                formAnsewr.setLabelAnswer(isInSeq(pivot));
                formAnsewr.Show();

                finale = formAnsewr.labelAnswer.Text;
            }
            else
            {
                FormAlert formAlert = new FormAlert();
                formAlert.Show();
                
                finale = formAlert.label1.Text;
            }
        } // Конец buttonExe_Click()

        //
        // Проверить корректность заполнения полей
        //
        public bool getFormFilled()
        {
            // Проверка поля выбора алгоритма сортировки
            if (checkBoxSortShell.Checked && checkBoxSortQSort.Checked || !(checkBoxSortShell.Checked) && !(checkBoxSortQSort.Checked))
            {
                return false;
            }

            // Проверка поля пути файла
            if (!(System.IO.File.Exists(textBoxFail.Text)))
            {
                return false;
            }

            // Проверка поля с исходным значением 
            if (textBoxArg.Text.Length == 4 || textBoxArg.Text.Length == 3)
            {
                if (!(Int32.TryParse(textBoxArg.Text, out pivot)))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }// Конец getFormFilled()

    }// КОНЕЦ formMain
}
