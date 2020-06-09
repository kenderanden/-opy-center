using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace копировальный_центр
{
    public partial class authorization : Form
    {
        public struct User
        {
            public string login;
            public string password;
            public string type;
        }
        public static User users = new User();
        public authorization()
        {
            InitializeComponent();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxlogin.Text == "" || textBoxpass.Text == "")
                {
                    MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (Users user in Program.база_данных.Users)
                    {
                        if (textBoxlogin.Text == user.Login && user.Password == textBoxpass.Text)
                        {
                            users.login = user.Login;
                            users.password = user.Password;
                            users.type = user.Type;
                            break;
                        }
                    }
                    if (users.login == null && users.type != "Недоступен")
                    {
                        MessageBox.Show("Пользователь не найден или данные введены не верно", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (users.type == "Недоступен")
                    {
                        MessageBox.Show("Админ не подтвердил учётную запись", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Меню menu = new Меню();
                        menu.Show();
                        this.Hide();
                    }
                }
            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Регистрация рег = new Регистрация();
            рег.Show();
        }
    }
}
