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
    public partial class Пользователи : Form
    {
        public Пользователи()
        {
            InitializeComponent();
            обновить_таблицу();
        }

        void обновить_таблицу()
        {
            listView.Items.Clear();
            foreach (Users users in Program.база_данных.Users)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    users.id.ToString(),
                    users.Login,
                    users.Password,
                    users.Type
                });
                item.Tag = users;
                listView.Items.Add(item);
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedItem != null && textBoxLogin.Text != null && textBoxPass.Text != null)
                {
                    try
                    {
                        Users users = new Users();

                        users.Login = textBoxLogin.Text;
                        users.Password = textBoxPass.Text;
                        users.Type = comboBoxType.SelectedItem.ToString();

                        Program.база_данных.Users.Add(users);
                        Program.база_данных.SaveChanges();
                        обновить_таблицу();
                    }
                    catch { MessageBox.Show("Ошибка введённых данных или база данных не доступна"); }
                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    Users users = listView.SelectedItems[0].Tag as Users;

                    if (textBoxLogin.Text != "")
                        users.Login = textBoxLogin.Text;
                    if (textBoxPass.Text != "")
                        users.Password = textBoxPass.Text;
                    if (comboBoxType.SelectedItem.ToString() != "")
                        users.Type = comboBoxType.SelectedItem.ToString();

                    Program.база_данных.SaveChanges();

                    обновить_таблицу();
                }
            }
            catch { }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    Users users = listView.SelectedItems[0].Tag as Users;

                    Program.база_данных.Users.Remove(users);

                    Program.база_данных.SaveChanges();

                    обновить_таблицу();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                Users users = listView.SelectedItems[0].Tag as Users;

                textBoxLogin.Text = users.Login;
                textBoxPass.Text = users.Password;
                comboBoxType.SelectedItem = users.Type;
            }
            else
            {
                textBoxLogin.Text = "";
                textBoxPass.Text = "";
                comboBoxType.SelectedItem = "";
            }
        }


    }
}
