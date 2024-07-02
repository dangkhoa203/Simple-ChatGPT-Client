namespace WindowsFormsApp1
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_back = new System.Windows.Forms.Button();
            this.b_about = new System.Windows.Forms.Button();
            this.b_history = new System.Windows.Forms.Button();
            this.b_chat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fclose = new System.Windows.Forms.Button();
            this.fminimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chatPage1 = new WindowsFormsApp1.ChatPage();
            this.historyPage1 = new WindowsFormsApp1.HistoryPage();
            this.aboutPage1 = new WindowsFormsApp1.AboutPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.b_back);
            this.panel1.Controls.Add(this.b_about);
            this.panel1.Controls.Add(this.b_history);
            this.panel1.Controls.Add(this.b_chat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 708);
            this.panel1.TabIndex = 0;
            // 
            // b_back
            // 
            this.b_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_back.FlatAppearance.BorderSize = 0;
            this.b_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_back.Font = new System.Drawing.Font("Ebrima", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_back.ForeColor = System.Drawing.Color.Red;
            this.b_back.Image = ((System.Drawing.Image)(resources.GetObject("b_back.Image")));
            this.b_back.Location = new System.Drawing.Point(0, 0);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(226, 129);
            this.b_back.TabIndex = 6;
            this.b_back.Text = " BACK";
            this.b_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // b_about
            // 
            this.b_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_about.FlatAppearance.BorderSize = 0;
            this.b_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_about.Font = new System.Drawing.Font("Ebrima", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_about.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_about.Image = ((System.Drawing.Image)(resources.GetObject("b_about.Image")));
            this.b_about.Location = new System.Drawing.Point(0, 457);
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(226, 96);
            this.b_about.TabIndex = 5;
            this.b_about.Text = "About";
            this.b_about.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_about.UseVisualStyleBackColor = true;
            this.b_about.Click += new System.EventHandler(this.b_about_Click);
            // 
            // b_history
            // 
            this.b_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_history.FlatAppearance.BorderSize = 0;
            this.b_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_history.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_history.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_history.Image = ((System.Drawing.Image)(resources.GetObject("b_history.Image")));
            this.b_history.Location = new System.Drawing.Point(0, 306);
            this.b_history.Name = "b_history";
            this.b_history.Size = new System.Drawing.Size(226, 96);
            this.b_history.TabIndex = 4;
            this.b_history.Text = "History";
            this.b_history.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_history.UseVisualStyleBackColor = true;
            this.b_history.Click += new System.EventHandler(this.b_history_Click);
            // 
            // b_chat
            // 
            this.b_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_chat.FlatAppearance.BorderSize = 0;
            this.b_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_chat.Font = new System.Drawing.Font("Ebrima", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_chat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_chat.Image = ((System.Drawing.Image)(resources.GetObject("b_chat.Image")));
            this.b_chat.Location = new System.Drawing.Point(0, 158);
            this.b_chat.Name = "b_chat";
            this.b_chat.Size = new System.Drawing.Size(226, 96);
            this.b_chat.TabIndex = 3;
            this.b_chat.Text = "Chat";
            this.b_chat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_chat.UseVisualStyleBackColor = true;
            this.b_chat.Click += new System.EventHandler(this.b_chat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.fclose);
            this.panel2.Controls.Add(this.fminimize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 72);
            this.panel2.TabIndex = 1;
            // 
            // fclose
            // 
            this.fclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fclose.BackgroundImage")));
            this.fclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fclose.Location = new System.Drawing.Point(1060, 11);
            this.fclose.Name = "fclose";
            this.fclose.Size = new System.Drawing.Size(44, 34);
            this.fclose.TabIndex = 3;
            this.fclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fclose.UseVisualStyleBackColor = true;
            this.fclose.Click += new System.EventHandler(this.fclose_Click);
            // 
            // fminimize
            // 
            this.fminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fminimize.BackgroundImage")));
            this.fminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fminimize.Location = new System.Drawing.Point(1000, 12);
            this.fminimize.Name = "fminimize";
            this.fminimize.Size = new System.Drawing.Size(44, 33);
            this.fminimize.TabIndex = 2;
            this.fminimize.UseVisualStyleBackColor = true;
            this.fminimize.Click += new System.EventHandler(this.fminimize_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1116, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chatPage1
            // 
            this.chatPage1.Location = new System.Drawing.Point(226, 72);
            this.chatPage1.Name = "chatPage1";
            this.chatPage1.Size = new System.Drawing.Size(1116, 636);
            this.chatPage1.TabIndex = 3;
            // 
            // historyPage1
            // 
            this.historyPage1.Location = new System.Drawing.Point(226, 72);
            this.historyPage1.Name = "historyPage1";
            this.historyPage1.Size = new System.Drawing.Size(1116, 636);
            this.historyPage1.TabIndex = 2;
            // 
            // aboutPage1
            // 
            this.aboutPage1.Location = new System.Drawing.Point(226, 72);
            this.aboutPage1.Name = "aboutPage1";
            this.aboutPage1.Size = new System.Drawing.Size(1116, 636);
            this.aboutPage1.TabIndex = 4;
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1342, 708);
            this.ControlBox = false;
            this.Controls.Add(this.chatPage1);
            this.Controls.Add(this.historyPage1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aboutPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button fminimize;
        private System.Windows.Forms.Button fclose;
        private System.Windows.Forms.Button b_chat;
        private System.Windows.Forms.Button b_about;
        private System.Windows.Forms.Button b_history;
        private System.Windows.Forms.Label label1;
        private HistoryPage historyPage1;
        private ChatPage chatPage1;
        private AboutPage aboutPage1;
        private System.Windows.Forms.Button b_back;
    }
}