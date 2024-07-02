namespace WindowsFormsApp1
{
    partial class HistoryPage
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
            this.chatbox = new Krypton.Toolkit.KryptonRichTextBox();
            this.datebox = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datebox)).BeginInit();
            this.SuspendLayout();
            // 
            // chatbox
            // 
            this.chatbox.Location = new System.Drawing.Point(24, 82);
            this.chatbox.Name = "chatbox";
            this.chatbox.ReadOnly = true;
            this.chatbox.Size = new System.Drawing.Size(1078, 515);
            this.chatbox.StateCommon.Back.Color1 = System.Drawing.SystemColors.Desktop;
            this.chatbox.StateCommon.Border.Color1 = System.Drawing.Color.DarkCyan;
            this.chatbox.StateCommon.Border.Color2 = System.Drawing.Color.Teal;
            this.chatbox.StateCommon.Border.ColorAngle = 36F;
            this.chatbox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.chatbox.StateCommon.Border.Rounding = 30F;
            this.chatbox.StateCommon.Border.Width = 3;
            this.chatbox.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatbox.TabIndex = 3;
            this.chatbox.Text = "";
            // 
            // datebox
            // 
            this.datebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datebox.DropDownWidth = 268;
            this.datebox.IntegralHeight = false;
            this.datebox.Location = new System.Drawing.Point(24, 21);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(1078, 53);
            this.datebox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.datebox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.datebox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.datebox.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.datebox.StateCommon.ComboBox.Border.Rounding = 0F;
            this.datebox.StateCommon.ComboBox.Border.Width = 1;
            this.datebox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.datebox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.datebox.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.datebox.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.datebox.StateCommon.DropBack.ColorAngle = 45F;
            this.datebox.TabIndex = 4;
            this.datebox.SelectedIndexChanged += new System.EventHandler(this.datebox_SelectedIndexChanged);
            // 
            // HistoryPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.chatbox);
            this.Name = "HistoryPage";
            this.Size = new System.Drawing.Size(1116, 624);
            ((System.ComponentModel.ISupportInitialize)(this.datebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonRichTextBox chatbox;
        private Krypton.Toolkit.KryptonComboBox datebox;
    }
}
