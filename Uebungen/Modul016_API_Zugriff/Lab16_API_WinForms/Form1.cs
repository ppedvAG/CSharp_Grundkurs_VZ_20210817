using Lab16_API_Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16_API_WinForms
{
    public partial class Form1 : Form
    {
        TodoItemAPI api = new TodoItemAPI(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void ItemInfo(TodoItem item)
        {
            if (item != null)
            {

                tbId.Text = item.Id.ToString();
                tbName.Text = item.Name;
                cbIsComplete.Checked = item.IsComplete;
            }
            else
            {
                tbId.Text = "";
                tbName.Text = "";
                cbIsComplete.Checked = false;
            }
        }

        private void btnSuche_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(tbSuche.Text, out id))
            {
                TodoItem item = api.Get(id);
                ItemInfo(item);

                dgItems.DataSource = new List<TodoItem>() { item };
            }
            else
            {
                ItemInfo(null);
                List<TodoItem> items = api.GetAll(); 
                dgItems.DataSource = items;
            }

        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            TodoItem item = new TodoItem();
            item.Name = tbName.Text;
            item.IsComplete = cbIsComplete.Checked;

            Uri itemUri = api.Post(item);

            ItemInfo(api.Get(itemUri.PathAndQuery));

            dgItems.DataSource = new List<TodoItem>() { api.Get(itemUri.PathAndQuery) };
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(tbId.Text, out id))
            {
                TodoItem item = new TodoItem();
                item.Id = id;
                item.Name = tbName.Text;
                item.IsComplete = cbIsComplete.Checked;

                ItemInfo(api.Put(item));

                dgItems.DataSource = new List<TodoItem>() { item };
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(tbId.Text, out id))
            {
                var code = api.Delete(id);

                ItemInfo(null);
                List<TodoItem> items = api.GetAll();
                dgItems.DataSource = items;

                MessageBox.Show($"Code: {code}");
            }
        }
    }
}
