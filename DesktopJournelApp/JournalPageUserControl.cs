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
    public partial class JournalPageUserControl : UserControl
    {
        public JournalPageUserControl()
        {
            InitializeComponent();
        }

        

        private void JournalSaveButton_Click(object sender, EventArgs e)
        {
            string text = JournalRichTextBox.Text;
            if (text != string.Empty) {
                SQL.InsertJournalText(text);
            }else
            {
                MessageBox.Show("You did not write anything yet"); 
            }
           
        }

        private void JournalDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = JournalDateTimePicker.Value.Date;

            
            string journalText = SQL.GetJournalTextByDate(selectedDate);

            
            JournalRichTextBox.Text = journalText;

            if (selectedDate != DateTime.Today)
            {
                JournalRichTextBox.ReadOnly = true;
            }
            else
            {
                JournalRichTextBox.ReadOnly = false;
            }

        }
    }
}
