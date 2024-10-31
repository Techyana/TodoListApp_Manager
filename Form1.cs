using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListApp_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newTask = txtTitle.Text;
            // Add new task to your task list (e.g., a ListBox or List)
            lstTaskManager.Items.Add(newTask);
            txtTitle.Clear();
        }
    }
}
