namespace Threads_Semaphore
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
            this.listBoxworking = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxwaiting = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxcreated = new System.Windows.Forms.ListBox();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Threads";
            // 
            // listBoxworking
            // 
            this.listBoxworking.FormattingEnabled = true;
            this.listBoxworking.ItemHeight = 15;
            this.listBoxworking.Location = new System.Drawing.Point(39, 44);
            this.listBoxworking.Name = "listBoxworking";
            this.listBoxworking.Size = new System.Drawing.Size(125, 124);
            this.listBoxworking.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Waiting Threads";
            // 
            // listBoxwaiting
            // 
            this.listBoxwaiting.FormattingEnabled = true;
            this.listBoxwaiting.ItemHeight = 15;
            this.listBoxwaiting.Location = new System.Drawing.Point(207, 44);
            this.listBoxwaiting.Name = "listBoxwaiting";
            this.listBoxwaiting.Size = new System.Drawing.Size(125, 124);
            this.listBoxwaiting.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Created Threads";
            // 
            // listBoxcreated
            // 
            this.listBoxcreated.FormattingEnabled = true;
            this.listBoxcreated.ItemHeight = 15;
            this.listBoxcreated.Location = new System.Drawing.Point(365, 44);
            this.listBoxcreated.Name = "listBoxcreated";
            this.listBoxcreated.Size = new System.Drawing.Size(125, 124);
            this.listBoxcreated.TabIndex = 1;
            this.listBoxcreated.DoubleClick += new System.EventHandler(this.listBoxcreated_DoubleClick);
            // 
            // buttoncreate
            // 
            this.buttoncreate.Location = new System.Drawing.Point(414, 206);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(91, 23);
            this.buttoncreate.TabIndex = 2;
            this.buttoncreate.Text = "Create New";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(47, 205);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Places in Semaphore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 240);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.listBoxcreated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxwaiting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxworking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Threads & Semaphore";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listBoxworking;
        private Label label2;
        private ListBox listBoxwaiting;
        private Label label3;
        private ListBox listBoxcreated;
        private Button buttoncreate;
        private NumericUpDown numericUpDown1;
        private Label label4;
    }
}