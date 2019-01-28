using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GG1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string Email = textBox2.Text;
            string Password = textBox3.Text;
            string kpass = textBox4.Text;
            int g = 0;
            if (Password != kpass)
            {
                MessageBox.Show("Пароли не совпадают");
                g++;
            }
            if (Password.Length < 6 || Password.Length > 18)
            {
                MessageBox.Show("Длина символов пароля недостаточна или превышает лимит");
                g++;
            }
            if (Password.Contains('0') | Password.Contains('1') | Password.Contains('2') | Password.Contains('3') | Password.Contains('4') | Password.Contains('5') | Password.Contains('6') | Password.Contains('7') | Password.Contains('8') | Password.Contains('9'))
            {

            }
            else
            {
                MessageBox.Show("В пароле должны присутствовать цифры");
                g++;
            }
            if (Password.Contains('*') | Password.Contains('&') | Password.Contains('{') | Password.Contains('}') | Password.Contains('|') | Password.Contains('+') | Password.Contains('.'))
            {
                MessageBox.Show("Присутствуют обязательные символы из допустимого набора: * & { } | + . ");
            }
            else
            {
                MessageBox.Show("Отсутсвует обязательный символ из допустимого набора: * & { } | + .");
                g++;
            }
            for (int i = 0; i < Password.Length - 2; i++)
            {
                if (Password[i] == Password[i + 1] && Password[i + 1] == Password[i + 2])
                {
                    MessageBox.Show("Не должно присутствовать 3 повторных символов");
                    g++;
                    return;
                }
                if (g == 0)
                {
                    MessageBox.Show("Вы зарегестрированы");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


