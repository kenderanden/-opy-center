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
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
            if(authorization.users.type == "admin") 
            {  
                this.Height = 181; buttonUser.Enabled = true;
            }
        }

        private void buttonКлиенты_Click(object sender, EventArgs e)
        {
            Клиенты кли = new Клиенты();
            кли.Show();
        }

        private void Меню_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonЗаказы_Click(object sender, EventArgs e)
        {
            Заказы зак = new Заказы();
            зак.Show();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            Пользователи пол = new Пользователи();
            пол.Show();
        }
    }
}
