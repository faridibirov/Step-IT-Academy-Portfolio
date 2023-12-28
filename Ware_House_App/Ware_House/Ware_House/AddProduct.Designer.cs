namespace Ware_House
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.savebtn = new System.Windows.Forms.Button();
            this.textproductdesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textproductprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numprodquantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numprodquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.savebtn.Location = new System.Drawing.Point(271, 279);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(60, 33);
            this.savebtn.TabIndex = 25;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // textproductdesc
            // 
            this.textproductdesc.Location = new System.Drawing.Point(144, 159);
            this.textproductdesc.Multiline = true;
            this.textproductdesc.Name = "textproductdesc";
            this.textproductdesc.Size = new System.Drawing.Size(187, 102);
            this.textproductdesc.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantity";
            // 
            // textproductprice
            // 
            this.textproductprice.Location = new System.Drawing.Point(147, 66);
            this.textproductprice.Name = "textproductprice";
            this.textproductprice.Size = new System.Drawing.Size(176, 23);
            this.textproductprice.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Price";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(147, 29);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(176, 23);
            this.txtproductname.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // numprodquantity
            // 
            this.numprodquantity.Location = new System.Drawing.Point(147, 113);
            this.numprodquantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numprodquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numprodquantity.Name = "numprodquantity";
            this.numprodquantity.Size = new System.Drawing.Size(176, 23);
            this.numprodquantity.TabIndex = 26;
            this.numprodquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(381, 337);
            this.Controls.Add(this.numprodquantity);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textproductdesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textproductprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.numprodquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button savebtn;
        private TextBox textproductdesc;
        private Label label5;
        private Label label3;
        private TextBox textproductprice;
        private Label label2;
        private TextBox txtproductname;
        private Label label1;
        private NumericUpDown numprodquantity;
    }
}