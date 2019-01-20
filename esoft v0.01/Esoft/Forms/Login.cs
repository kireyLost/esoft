using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace Esoft
{
    public partial class Login : Form
    {
        bool tryconnect;

        public Login()
        {
            InitializeComponent();


        }
        private void button1_Click(object sender, EventArgs e)
        { 
            string login = "admin";
            string password = "admin";

            if (textBox1.Text == login && textBox2.Text == password)
            {
                this.Hide();

                if (MessageBox.Show("Вход выполнен! Загрузка главного меню...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("http://vk.com/kirey_lost");
                }

                Thread.Sleep(500);

                Form1 f1 = new Form1();
                f1.Show();
            }
            else if (textBox1.Text != login)
            {
                MessageBox.Show("Пользователя с данным именем не существует", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text != login)
            {
                MessageBox.Show("Неверный пароль", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка...Но могло быть и хуже :)", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
