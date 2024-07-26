using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournelApp
{
    public partial class TaskPlannerPageUserControl : UserControl
    {
        public TaskPlannerPageUserControl()
        {
            InitializeComponent();
            LoadToDoItems();
            TPdataGridView.CellFormatting += TPdataGridView_CellFormatting;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadToDoItems();
        }

        
        private void LoadToDoItems()
        {
            ToDoPanel.Controls.Clear();
            DataTable toDoItems = SQL.GetToDoItems(MainAppForm._userId);
            foreach (DataRow row in toDoItems.Rows)
            {
                AddToDoItemToPanel(Convert.ToInt32(row["Id"]), row["ToDos"].ToString());
            }
        }

        private void AddToDoItemToPanel(int id, string todo)
        {
            Panel panel = new Panel() { Height = 30, Dock = DockStyle.Top };

            CheckBox checkBox = new CheckBox()
            {
                Text = todo,
                Dock = DockStyle.Left,
                Width = 200,
                Font = new Font("Courier New", 12)
            };
            checkBox.CheckStateChanged += (s, e) =>
            {
                if (checkBox.Checked)
                {
                    checkBox.Font = new Font(checkBox.Font, FontStyle.Strikeout);
                }
                else
                {
                    checkBox.Font = new Font(checkBox.Font, FontStyle.Regular);
                }
            };

            Button deleteButton = new Button() { Text = "X", Dock = DockStyle.Right, Width = 30 };
            deleteButton.Click += (s, e) =>
            {
                SQL.DeleteToDoItem(MainAppForm._userId, id);
                LoadToDoItems();
            };

            panel.Controls.Add(checkBox);
            panel.Controls.Add(deleteButton);
            ToDoPanel.Controls.Add(panel);
            ToDoPanel.Controls.SetChildIndex(panel, 0); // Add the panel at the top


        }

        private void TPSaveButton_Click(object sender, EventArgs e)
        {
            string name = TPNameTextBox.Text;
            string description = TPDescTextBox.Text;
            DateTime deadline = TPDeadlineDateTimePicker.Value;
            string priority = TPPrioComboBox.Text;
            string tag = TPTaskTagComboBox.Text;
            bool state = TPStateCheckBox.Checked;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(priority) && !string.IsNullOrEmpty(tag)) 
            {
                // Check if the deadline is equal to or greater than today's date
                if (deadline >= DateTime.Today)
                {
                    SQL.InsertTask(name, description, deadline, priority, tag, state);
                    string query = "SELECT * FROM TaskPlannerTable WHERE UserId = @UserId";
                    SQL.BindToGrid(query, TPdataGridView, MainAppForm._userId);

                    // Clear the input fields after saving
                    TPNameTextBox.Clear();
                    TPDescTextBox.Clear();
                    TPPrioComboBox.SelectedIndex = -1;
                    TPTaskTagComboBox.SelectedIndex = -1;
                    TPStateCheckBox.Checked = false;
                }
                else
                {
                    MessageBox.Show("The deadline must be equal to or greater than today's date.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private void TPListTasksButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TaskPlannerTable WHERE UserId=@UserId";
            SQL.BindToGrid(query, TPdataGridView, MainAppForm._userId);
        }

        private void TPUpdateButton_Click(object sender, EventArgs e)
        {
            if (TPdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TPdataGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string name = TPNameTextBox.Text;
                string description = TPDescTextBox.Text;
                DateTime deadline = TPDeadlineDateTimePicker.Value;
                string priority = TPPrioComboBox.Text;
                string tag = TPTaskTagComboBox.Text;
                bool state = TPStateCheckBox.Checked;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(priority) && !string.IsNullOrEmpty(tag))
                {
                    SQL.UpdateTask(id, name, description, deadline, priority, tag, state);

                    // Optionally, refresh the DataGridView after updating
                    string query = "SELECT * FROM TaskPlannerTable WHERE UserId = @UserId";
                    SQL.BindToGrid(query, TPdataGridView, MainAppForm._userId);
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void TPDeleteButton_Click(object sender, EventArgs e)
        {
            if (TPdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TPdataGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                SQL.DeleteTask(id);

                // refresh the DataGridView after deleting
                string query = "SELECT * FROM TaskPlannerTable WHERE UserId = @UserId";
                SQL.BindToGrid(query, TPdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void TPdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = TPdataGridView.Rows[e.RowIndex];

                // Assuming the column names in your DataGridView are the same as in your database
                TPNameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                TPDescTextBox.Text = selectedRow.Cells["Description"].Value.ToString();
                TPDeadlineDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells["Deadline"].Value);
                TPPrioComboBox.Text = selectedRow.Cells["Priority"].Value.ToString();
                TPTaskTagComboBox.Text = selectedRow.Cells["Tag"].Value.ToString();
                TPStateCheckBox.Checked = selectedRow.Cells["State"].Value.ToString() == "Completed";
            }
        }

        private void TPSearchButton_Click(object sender, EventArgs e)
        {
            string tag = TPSearchComboBox.Text;
            string name = TPSearchTextBox.Text;

            if (tag == "All")
            {
                tag = ""; // Set tag to an empty string to ignore it in the search
            }

            if (!string.IsNullOrEmpty(tag) || !string.IsNullOrEmpty(name))
            {
                SQL.SearchTaskByTagAndName(tag, name, TPdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("Please enter a tag or name to search.");
            }
        }

        private void TPFilterByDatesButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = TPStartDateTimePicker.Value;
            DateTime endDate = TPFinishDateTimePicker.Value;

            if (startDate <= endDate)
            {
                SQL.FilterTasksByDeadline(startDate, endDate, TPdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("The start date must be earlier than or equal to the end date.");
            }
        }

        private void TPListStateButton_Click(object sender, EventArgs e)
        {
            string state = TPStateFilterComboBox.Text;

            if (!string.IsNullOrEmpty(state))
            {
                SQL.FilterTasksByState(state, TPdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("Please select a state to filter.");
            }
        }

        private void TPPriorityButton_Click(object sender, EventArgs e)
        {
            if (TPPrioCheckedListBox.Visible == true)
            {
                TPPrioCheckedListBox.Visible = false;
            }
            else
            {
                TPPrioCheckedListBox.Visible = true;
            }
        }

        private void TPFilterByPrioButton_Click(object sender, EventArgs e)
        {

            List<string> selectedPriorities = new List<string>();
            foreach (object item in TPPrioCheckedListBox.CheckedItems)
            {
                selectedPriorities.Add(item.ToString());
            }

            if (selectedPriorities.Count > 0)
            {
                SQL.FilterTasksByPriorities(selectedPriorities, TPdataGridView, MainAppForm._userId);
            }
            else
            {
                MessageBox.Show("Please select at least one priority to filter.");
            }

            TPPrioCheckedListBox.Visible = false;
        }

        private void AddToDoButton_Click(object sender, EventArgs e)
        {
            string todo = ToDoTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(todo))
            {
                SQL.InsertToDoItem(MainAppForm._userId, todo);
                ToDoTextBox.Clear();
                LoadToDoItems();
            }
            else
            {
                MessageBox.Show("Please enter a to-do item.");
            }
        }

        private void TPdataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TPdataGridView.Columns[e.ColumnIndex].Name == "State")
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "Done")
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (e.Value.ToString() == "Not Done")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }
        }
    }
    
}
