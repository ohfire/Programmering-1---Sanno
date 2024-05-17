using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class MainForm : Form
    {
        private const string FilePath = "tasks.txt";

        public MainForm()
        {
            InitializeComponent();
            LoadTasksFromFile();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string category = radioButtonImportant.Checked ? "Viktigt" : "Mindre viktigt";
            string task = $"{category}: {textBoxTask.Text}";
            listBoxTasks.Items.Add(task);
            textBoxTask.Clear();
        }

        private void buttonMarkComplete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                string completedTask = listBoxTasks.SelectedItem.ToString() + " (klar)";
                int index = listBoxTasks.SelectedIndex;
                listBoxTasks.Items[index] = completedTask;
            }
        }

        private void buttonSaveTasks_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(FilePath, listBoxTasks.Items.Cast<string>());
        }

        private void buttonLoadTasks_Click(object sender, EventArgs e)
        {
            LoadTasksFromFile();
        }

        private void LoadTasksFromFile()
        {
            if (File.Exists(FilePath))
            {
                listBoxTasks.Items.Clear();
                var tasks = File.ReadAllLines(FilePath);
                 }
            }
    }
}




