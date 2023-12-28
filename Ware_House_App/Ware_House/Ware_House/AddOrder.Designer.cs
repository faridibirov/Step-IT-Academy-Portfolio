namespace Ware_House
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.numorderquantity = new System.Windows.Forms.NumericUpDown();
            this.submitbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxname = new System.Windows.Forms.ComboBox();
            this.comboBoxproduct = new System.Windows.Forms.ComboBox();
            this.dateTimePickerorder = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numorderquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numorderquantity
            // 
            this.numorderquantity.Location = new System.Drawing.Point(133, 93);
            this.numorderquantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numorderquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numorderquantity.Name = "numorderquantity";
            this.numorderquantity.Size = new System.Drawing.Size(163, 23);
            this.numorderquantity.TabIndex = 35;
            this.numorderquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.submitbtn.FlatAppearance.BorderSize = 0;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.submitbtn.Location = new System.Drawing.Point(236, 185);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(69, 33);
            this.submitbtn.TabIndex = 34;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Arrival Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // comboBoxname
            // 
            this.comboBoxname.FormattingEnabled = true;
            this.comboBoxname.Location = new System.Drawing.Point(133, 12);
            this.comboBoxname.Name = "comboBoxname";
            this.comboBoxname.Size = new System.Drawing.Size(163, 23);
            this.comboBoxname.TabIndex = 36;
            // 
            // comboBoxproduct
            // 
            this.comboBoxproduct.FormattingEnabled = true;
            this.comboBoxproduct.Location = new System.Drawing.Point(133, 50);
            this.comboBoxproduct.Name = "comboBoxproduct";
            this.comboBoxproduct.Size = new System.Drawing.Size(163, 23);
            this.comboBoxproduct.TabIndex = 37;
            // 
            // dateTimePickerorder
            // 
            this.dateTimePickerorder.Location = new System.Drawing.Point(133, 139);
            this.dateTimePickerorder.Name = "dateTimePickerorder";
            this.dateTimePickerorder.Size = new System.Drawing.Size(163, 23);
            this.dateTimePickerorder.TabIndex = 38;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(333, 238);
            this.Controls.Add(this.dateTimePickerorder);
            this.Controls.Add(this.comboBoxproduct);
            this.Controls.Add(this.comboBoxname);
            this.Controls.Add(this.numorderquantity);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            ((System.ComponentModel.ISupportInitialize)(this.numorderquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numorderquantity;
        private Button submitbtn;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxname;
        private ComboBox comboBoxproduct;
        private DateTimePicker dateTimePickerorder;
    }
}