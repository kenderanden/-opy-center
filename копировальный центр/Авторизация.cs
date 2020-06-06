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
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class authorization : Form
    {
        public static User users = new User();
        public authorization()
        {
            InitializeComponent();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            if(textBoxlogin.Text == "" || textBoxpass.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach(Users user in Program.база_данных.Users)
                {
                    if(textBoxlogin.Text == user.Login && user.Password == textBoxpass.Text)
                    {
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                        break;
                    }
                }
                if(users.login == null)
                {
                    MessageBox.Show("Пользователь не найден или данные введены не верно", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Меню menu = new Меню();
                    menu.Show();
                    this.Hide();
                }
            }
        }
    }
}
