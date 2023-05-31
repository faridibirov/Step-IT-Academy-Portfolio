namespace TaskManager
{
    partial class BlackList
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxBL = new System.Windows.Forms.ListBox();
            this.textBoxBL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxBL
            // 
            this.listBoxBL.FormattingEnabled = true;
            this.listBoxBL.ItemHeight = 15;
            this.listBoxBL.Location = new System.Drawing.Point(12, 12);
            this.listBoxBL.Name = "listBoxBL";
            this.listBoxBL.Size = new System.Drawing.Size(254, 169);
            this.listBoxBL.TabIndex = 2;
            // 
            // textBoxBL
            // 
            this.textBoxBL.Location = new System.Drawing.Point(34, 200);
            this.textBoxBL.Name = "textBoxBL";
            this.textBoxBL.Size = new System.Drawing.Size(142, 23);
            this.textBoxBL.TabIndex = 3;
            // 
            // BlackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 265);
            this.Controls.Add(this.textBoxBL);
            this.Controls.Add(this.listBoxBL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "BlackList";
            this.Text = "BlackList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBoxBL;
        private TextBox textBoxBL;
    }
}