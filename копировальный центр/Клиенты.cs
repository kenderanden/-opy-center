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
    public partial class Клиенты : Form
    {
        public Клиенты()
        {
            InitializeComponent();
            обновить_таблицу();
        }

        void обновить_таблицу()
        {
            listView.Items.Clear();
            if (textBoxПоиск.Text == "")
                foreach (Clients client in Program.база_данных.Clients)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    client.id.ToString(),
                    client.Name,
                    client.tel.ToString(),
                    client.mail
                    });
                    item.Tag = client;
                    listView.Items.Add(item);
                }
            else
                foreach (Clients client in Program.база_данных.Clients)
                {
                    if (textBoxПоиск.Text == client.tel.ToString())
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                    client.id.ToString(),
                    client.Name,
                    client.tel.ToString(),
                    client.mail
                        });
                        item.Tag = client;
                        listView.Items.Add(item);
                    }
                }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Clients client = new Clients();

                client.Name = textBoxимя.Text;
                client.tel = Convert.ToInt32(textBoxтелефон.Text);
                client.mail = textBoxпочта.Text;

                Program.база_данных.Clients.Add(client);
                Program.база_данных.SaveChanges();

                обновить_таблицу();
            }
            catch { MessageBox.Show("Данные используются или сервер не доступен"); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    Clients client = listView.SelectedItems[0].Tag as Clients;

                    client.Name = textBoxимя.Text;
                    client.tel = Convert.ToInt32(textBoxтелефон.Text);
                    client.mail = textBoxпочта.Text;

                    Program.база_данных.SaveChanges();

                    обновить_таблицу();
                }
            }
            catch { MessageBox.Show("Данные используются или сервер не доступен"); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    Clients clients = listView.SelectedItems[0].Tag as Clients;
                    Program.база_данных.Clients.Remove(clients);
                    Program.база_данных.SaveChanges();
                    обновить_таблицу();
                }
            }
            catch { MessageBox.Show("Данные используются или сервер не доступен"); }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                Clients clients = listView.SelectedItems[0].Tag as Clients;

                textBoxимя.Text = clients.Name;
                textBoxтелефон.Text = clients.tel.ToString();
                textBoxпочта.Text = clients.mail;
            }
            else
            {
                textBoxимя.Text = "";
                textBoxтелефон.Text = "";
                textBoxпочта.Text = "";
            }
        }

        private void buttonПоиск_Click(object sender, EventArgs e)
        {
            обновить_таблицу();
        }
    }
}
