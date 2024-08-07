using OpenAI_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.data;

namespace WindowsFormsApp1
{
    public partial class Main : Krypton.Toolkit.KryptonForm
    {
        private int running = 0;
        public Main()
        {
            InitializeComponent();
        }
        private void kryptonTextBox1_Click(object sender, EventArgs e)
        {
            apikey.SelectAll();
        }
        private async void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                running++;
                Enter.Enabled = false;
                APIAuthentication aPIAuthentication = new APIAuthentication(apikey.Text);
                bool result = await aPIAuthentication.ValidateAPIKey();
                if (result)
                {
                    this.Hide();
                    MainPage access = new MainPage(apikey.Text);
                    access.EnterPage = this;
                    access.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"{apikey.Text} can't be use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally {
                running--;
                Enter.Enabled = true;
            }
            
        }

        private void apikey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (running == 0)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    Enter_Click(sender, e);
                }
            }

        }
    }
}
