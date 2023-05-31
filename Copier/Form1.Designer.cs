namespace Copier
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfrom = new System.Windows.Forms.TextBox();
            this.textBoxto = new System.Windows.Forms.TextBox();
            this.buttonfrom = new System.Windows.Forms.Button();
            this.buttonto = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttoncopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // textBoxfrom
            // 
            this.textBoxfrom.Location = new System.Drawing.Point(78, 37);
            this.textBoxfrom.Name = "textBoxfrom";
            this.textBoxfrom.Size = new System.Drawing.Size(284, 23);
            this.textBoxfrom.TabIndex = 1;
            // 
            // textBoxto
            // 
            this.textBoxto.Location = new System.Drawing.Point(78, 71);
            this.textBoxto.Name = "textBoxto";
            this.textBoxto.Size = new System.Drawing.Size(284, 23);
            this.textBoxto.TabIndex = 1;
            // 
            // buttonfrom
            // 
            this.buttonfrom.Location = new System.Drawing.Point(376, 36);
            this.buttonfrom.Name = "buttonfrom";
            this.buttonfrom.Size = new System.Drawing.Size(75, 23);
            this.buttonfrom.TabIndex = 2;
            this.buttonfrom.Text = "File...";
            this.buttonfrom.UseVisualStyleBackColor = true;
            this.buttonfrom.Click += new System.EventHandler(this.buttonfrom_Click);
            // 
            // buttonto
            // 
            this.buttonto.Location = new System.Drawing.Point(376, 71);
            this.buttonto.Name = "buttonto";
            this.buttonto.Size = new System.Drawing.Size(75, 23);
            this.buttonto.TabIndex = 2;
            this.buttonto.Text = "File...";
            this.buttonto.UseVisualStyleBackColor = true;
            this.buttonto.Click += new System.EventHandler(this.buttonto_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 120);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(328, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // buttoncopy
            // 
            this.buttoncopy.Location = new System.Drawing.Point(376, 120);
            this.buttoncopy.Name = "buttoncopy";
            this.buttoncopy.Size = new System.Drawing.Size(75, 23);
            this.buttoncopy.TabIndex = 2;
            this.buttoncopy.Text = "Copy";
            this.buttoncopy.UseVisualStyleBackColor = true;
            this.buttoncopy.Click += new System.EventHandler(this.buttoncopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(304, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 167);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttoncopy);
            this.Controls.Add(this.buttonto);
            this.Controls.Add(this.buttonfrom);
            this.Controls.Add(this.textBoxto);
            this.Controls.Add(this.textBoxfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FileCopier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxfrom;
        private TextBox textBoxto;
        private Button buttonfrom;
        private Button buttonto;
        private ProgressBar progressBar1;
        private Button buttoncopy;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Label label3;
    }
}