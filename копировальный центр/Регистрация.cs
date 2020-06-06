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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            bool log = true;
            foreach(Users users in Program.база_данных.Users)
            {
                if(users.Login == textBoxlogin.Text)
                {
                    log = false;
                    MessageBox.Show("Пользователь с такин ником уже существует", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if(textBoxlogin.Text != "" && textBoxpass.Text != "" && log)
            {
                Users us = new Users();
                us.Login = textBoxlogin.Text;
                us.Password = textBoxpass.Text;
                us.Type = "Недоступен";
                Program.база_данных.Users.Add(us);
                Program.база_данных.SaveChanges();
                textBoxlogin.Text = "";
                textBoxpass.Text = "";
                MessageBox.Show("Регистрация успешно завершена", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
