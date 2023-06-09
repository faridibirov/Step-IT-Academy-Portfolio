namespace MyApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.signupbtn = new System.Windows.Forms.Button();
            this.signinbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.signinlogintext = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.signinpasstext = new System.Windows.Forms.TextBox();
            this.btnpshowpass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelsignin = new System.Windows.Forms.Panel();
            this.panelsignin.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "warehouse.png");
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(197, 236);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(74, 31);
            this.signupbtn.TabIndex = 0;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // signinbtn
            // 
            this.signinbtn.Location = new System.Drawing.Point(104, 236);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(69, 31);
            this.signinbtn.TabIndex = 0;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // signinlogintext
            // 
            this.signinlogintext.Location = new System.Drawing.Point(182, 148);
            this.signinlogintext.Name = "signinlogintext";
            this.signinlogintext.Size = new System.Drawing.Size(100, 23);
            this.signinlogintext.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(116, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 15);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // signinpasstext
            // 
            this.signinpasstext.Location = new System.Drawing.Point(182, 188);
            this.signinpasstext.Name = "signinpasstext";
            this.signinpasstext.Size = new System.Drawing.Size(100, 23);
            this.signinpasstext.TabIndex = 2;
            this.signinpasstext.UseSystemPasswordChar = true;
            // 
            // btnpshowpass
            // 
            this.btnpshowpass.Location = new System.Drawing.Point(300, 188);
            this.btnpshowpass.Name = "btnpshowpass";
            this.btnpshowpass.Size = new System.Drawing.Size(42, 27);
            this.btnpshowpass.TabIndex = 6;
            this.btnpshowpass.Text = "👁";
            this.btnpshowpass.UseVisualStyleBackColor = true;
            this.btnpshowpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btnpshowpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome to MyApp";
            // 
            // panelsignin
            // 
            this.panelsignin.BackColor = System.Drawing.Color.Khaki;
            this.panelsignin.Controls.Add(this.label2);
            this.panelsignin.Controls.Add(this.btnpshowpass);
            this.panelsignin.Controls.Add(this.signinpasstext);
            this.panelsignin.Controls.Add(this.Password);
            this.panelsignin.Controls.Add(this.signinlogintext);
            this.panelsignin.Controls.Add(this.label1);
            this.panelsignin.Controls.Add(this.signinbtn);
            this.panelsignin.Controls.Add(this.signupbtn);
            this.panelsignin.Location = new System.Drawing.Point(31, 12);
            this.panelsignin.Name = "panelsignin";
            this.panelsignin.Size = new System.Drawing.Size(408, 351);
            this.panelsignin.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(479, 366);
            this.Controls.Add(this.panelsignin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyApp";
            this.panelsignin.ResumeLayout(false);
            this.panelsignin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList1;
        private Button signupbtn;
        private Button signinbtn;
        private Label label1;
        private TextBox signinlogintext;
        private Label Password;
        private TextBox signinpasstext;
        private Button btnpshowpass;
        private Label label2;
        private Panel panelsignin;
    }
}