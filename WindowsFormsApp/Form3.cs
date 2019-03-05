using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormAnswer : Form
    {
        public bool isClose = false;

        public FormAnswer()
        {
            InitializeComponent();
        }

        // Закрыть окно
        public void button1_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close();
        }

        // Вывести сообщение
        public void setLabelAnswer(bool isFound)
        {
            if (isFound)
            {
                labelAnswer.Text = "Число найдено";
            }
            else
            {
                labelAnswer.Text = "Число не найдено";
            }
        }
    }
}
