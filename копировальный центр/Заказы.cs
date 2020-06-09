using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace копировальный_центр
{
    public partial class Заказы : Form
    {
        public Заказы()
        {
            InitializeComponent();
            обновить_клиенты();
            обновить_таблицу();
        }

        void обновить_таблицу()
        {
            listView.Items.Clear();
            if (textBoxПоиск.Text == "")
                foreach (Orders orders in Program.база_данных.Orders)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    orders.id.ToString(),
                    orders.idClient.ToString(),
                    orders.Orders1,
                    orders.status,
                    orders.address,
                    orders.Clients.tel.ToString(),
                    orders.price.ToString()
                    });
                    item.Tag = orders;
                    listView.Items.Add(item);
                }
            else
                foreach (Orders orders in Program.база_данных.Orders)
                {
                    if (textBoxПоиск.Text == orders.Clients.tel.ToString())
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                    orders.id.ToString(),
                    orders.idClient.ToString(),
                    orders.Orders1,
                    orders.status,
                    orders.address,
                    orders.Clients.tel.ToString(),
                    orders.price.ToString()
                        });
                        item.Tag = orders;
                        listView.Items.Add(item);
                    }
                }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void обновить_клиенты()
        {
            comboBoxКлиенты.Items.Clear();
            if (textBoxПоиск.Text == "")
                foreach (Clients clients in Program.база_данных.Clients)
                {
                    string[] item = { "id." + clients.id + ". ", clients.tel + " ", clients.Name };
                    comboBoxКлиенты.Items.Add(string.Join(" ", item));
                }
            else
                foreach (Clients clients in Program.база_данных.Clients)
                {
                    if (clients.tel.ToString() == textBoxПоиск.Text)
                    {
                        string[] item = { "id." + clients.id + ". ", clients.tel + " ", clients.Name };
                        comboBoxКлиенты.Items.Add(string.Join(" ", item));
                    }
                }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxКлиенты.SelectedItem != null && textBoxЗаказы.Text != null && textBoxАдрес.Text != null)
            {
                try
                {
                    Orders orders = new Orders();
                    orders.idClient = Convert.ToInt32(comboBoxКлиенты.SelectedItem.ToString().Split('.')[1]);
                    orders.Orders1 = textBoxЗаказы.Text;
                    orders.address = textBoxАдрес.Text;
                    orders.price = Convert.ToInt32(textBoxЦена.Text);
                    orders.status = "Принят";
                    Program.база_данных.Orders.Add(orders);
                    Program.база_данных.SaveChanges();
                    обновить_таблицу();
                }
                catch { MessageBox.Show("Ошибка введённых данных или база данных не доступна"); }
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    Orders orders = listView.SelectedItems[0].Tag as Orders;

                    if (comboBoxКлиенты.Text != "")
                        orders.idClient = Convert.ToInt32(comboBoxКлиенты.SelectedItem.ToString().Split('.')[1]);
                    if (textBoxЗаказы.Text != "")
                        orders.Orders1 = textBoxЗаказы.Text;
                    if (textBoxАдрес.Text != "")
                        orders.address = textBoxАдрес.Text;
                    if (textBoxЦена.Text != "")
                        orders.price = Convert.ToInt32(textBoxЦена.Text);

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
                    Orders clientsSet = listView.SelectedItems[0].Tag as Orders;

                    Program.база_данных.Orders.Remove(clientsSet);

                    Program.база_данных.SaveChanges();

                    обновить_таблицу();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonПоиск_Click(object sender, EventArgs e)
        {
            обновить_клиенты();
            обновить_таблицу();
        }

        private void buttonСтатус_завершён_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                Orders orders = listView.SelectedItems[0].Tag as Orders;
                orders.status = "Завершён";
                Program.база_данных.SaveChanges();
                обновить_таблицу();
            }
        }
    }
}
