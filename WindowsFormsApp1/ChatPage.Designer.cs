namespace WindowsFormsApp1
{
    partial class ChatPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chatinput = new Krypton.Toolkit.KryptonTextBox();
            this.B_enterinput = new Krypton.Toolkit.KryptonButton();
            this.chatbox = new Krypton.Toolkit.KryptonRichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // chatinput
            // 
            this.chatinput.Location = new System.Drawing.Point(19, 554);
            this.chatinput.Name = "chatinput";
            this.chatinput.Size = new System.Drawing.Size(907, 60);
            this.chatinput.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.chatinput.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.chatinput.StateCommon.Border.Rounding = 30F;
            this.chatinput.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatinput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.chatinput.TabIndex = 0;
            this.chatinput.Text = "Input";
            this.chatinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chatinput_KeyPress);
            // 
            // B_enterinput
            // 
            this.B_enterinput.Location = new System.Drawing.Point(952, 561);
            this.B_enterinput.Name = "B_enterinput";
            this.B_enterinput.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.B_enterinput.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.B_enterinput.OverrideDefault.Back.ColorAngle = 60F;
            this.B_enterinput.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.B_enterinput.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.B_enterinput.OverrideDefault.Border.Rounding = 50F;
            this.B_enterinput.OverrideDefault.Border.Width = 2;
            this.B_enterinput.Size = new System.Drawing.Size(145, 53);
            this.B_enterinput.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.B_enterinput.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.B_enterinput.StateCommon.Back.ColorAngle = 60F;
            this.B_enterinput.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.B_enterinput.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.B_enterinput.StateCommon.Border.Rounding = 50F;
            this.B_enterinput.StateCommon.Border.Width = 2;
            this.B_enterinput.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.B_enterinput.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.B_enterinput.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_enterinput.StatePressed.Back.Color1 = System.Drawing.Color.Green;
            this.B_enterinput.StatePressed.Back.Color2 = System.Drawing.Color.Green;
            this.B_enterinput.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.B_enterinput.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.B_enterinput.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.B_enterinput.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.B_enterinput.TabIndex = 1;
            this.B_enterinput.Values.Text = "Enter";
            this.B_enterinput.Click += new System.EventHandler(this.B_enterinput_Click);
            // 
            // chatbox
            // 
            this.chatbox.Location = new System.Drawing.Point(19, 24);
            this.chatbox.Name = "chatbox";
            this.chatbox.ReadOnly = true;
            this.chatbox.Size = new System.Drawing.Size(1078, 455);
            this.chatbox.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlText;
            this.chatbox.StateCommon.Border.Color1 = System.Drawing.Color.Lime;
            this.chatbox.StateCommon.Border.Color2 = System.Drawing.Color.Lime;
            this.chatbox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.chatbox.StateCommon.Border.Rounding = 20F;
            this.chatbox.StateCommon.Border.Width = 3;
            this.chatbox.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatbox.TabIndex = 2;
            this.chatbox.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 500);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1078, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // ChatPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.B_enterinput);
            this.Controls.Add(this.chatinput);
            this.Name = "ChatPage";
            this.Size = new System.Drawing.Size(1116, 624);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox chatinput;
        private Krypton.Toolkit.KryptonButton B_enterinput;
        private Krypton.Toolkit.KryptonRichTextBox chatbox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
