namespace Farid2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Dabutton = new System.Windows.Forms.Button();
            this.Netbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы довольны своей зарплатой?";
            // 
            // Dabutton
            // 
            this.Dabutton.Location = new System.Drawing.Point(76, 120);
            this.Dabutton.Name = "Dabutton";
            this.Dabutton.Size = new System.Drawing.Size(53, 33);
            this.Dabutton.TabIndex = 1;
            this.Dabutton.Text = "Да";
            this.Dabutton.UseVisualStyleBackColor = true;
            this.Dabutton.Click += new System.EventHandler(this.Dabutton_Click);
            // 
            // Netbutton
            // 
            this.Netbutton.Location = new System.Drawing.Point(205, 120);
            this.Netbutton.Name = "Netbutton";
            this.Netbutton.Size = new System.Drawing.Size(53, 33);
            this.Netbutton.TabIndex = 2;
            this.Netbutton.Text = "Нет";
            this.Netbutton.UseVisualStyleBackColor = true;
            this.Netbutton.MouseLeave += new System.EventHandler(this.Netbutton_MouseHover);
            this.Netbutton.MouseHover += new System.EventHandler(this.Netbutton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 283);
            this.Controls.Add(this.Netbutton);
            this.Controls.Add(this.Dabutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Dabutton;
        private Button Netbutton;
    }
}