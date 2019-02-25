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
        public FormAnswer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Закрыть окно
        private void button1_Click(object sender, EventArgs e)
        {
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
