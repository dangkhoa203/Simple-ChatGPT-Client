using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.services;
using WindowsFormsApp1.model;
namespace WindowsFormsApp1
{
    public partial class HistoryPage : UserControl
    {
        public historywork historywork;
        public HistoryPage()
        {
            InitializeComponent();
        }
        public void updatecombobox(List<string> key)
        {
            datebox.DataSource = key.ToList();
        }

        private void ChatboxAppend(string text, Color color)
        {
            chatbox.SelectionStart = chatbox.TextLength;
            chatbox.SelectionLength = 0;
            chatbox.SelectionColor = color;
            chatbox.AppendText(text);
            chatbox.SelectionColor = chatbox.ForeColor;
        }
        public void update()
        {
            chatbox.Clear();
            foreach (conversation tem in historywork.find(datebox.Text))
            {
                ChatboxAppend("\n\n(" + tem.TimeOfChat + ") User: " + tem.Prompt, Color.White);
                ChatboxAppend("\n\n(" + tem.TimeOfMessage + ") Bot: " + tem.Message, Color.Green);
            }
        }
        private void datebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
