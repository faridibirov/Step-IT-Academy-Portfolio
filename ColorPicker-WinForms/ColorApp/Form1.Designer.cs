namespace ColorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelsignin = new System.Windows.Forms.Panel();
            this.btnpshowpass = new System.Windows.Forms.Button();
            this.signinpasstext = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.signinlogintext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signinbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.panelcolorlist = new System.Windows.Forms.Panel();
            this.textBoxhex = new System.Windows.Forms.TextBox();
            this.labelblue = new System.Windows.Forms.Label();
            this.labelgreen = new System.Windows.Forms.Label();
            this.labelred = new System.Windows.Forms.Label();
            this.showcolor = new System.Windows.Forms.Label();
            this.comboBoxcolor = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelbluee = new System.Windows.Forms.Label();
            this.textboxcode = new System.Windows.Forms.TextBox();
            this.labelgreenn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelredd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelcolor = new System.Windows.Forms.Label();
            this.bluetrackbar = new System.Windows.Forms.TrackBar();
            this.greentrackbar = new System.Windows.Forms.TrackBar();
            this.redtrackbar = new System.Windows.Forms.TrackBar();
            this.panelsignin.SuspendLayout();
            this.panelcolorlist.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redtrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsignin
            // 
            this.panelsignin.Controls.Add(this.btnpshowpass);
            this.panelsignin.Controls.Add(this.signinpasstext);
            this.panelsignin.Controls.Add(this.Password);
            this.panelsignin.Controls.Add(this.signinlogintext);
            this.panelsignin.Controls.Add(this.label1);
            this.panelsignin.Controls.Add(this.signinbtn);
            this.panelsignin.Controls.Add(this.signupbtn);
            this.panelsignin.Location = new System.Drawing.Point(456, 410);
            this.panelsignin.Name = "panelsignin";
            this.panelsignin.Size = new System.Drawing.Size(315, 211);
            this.panelsignin.TabIndex = 3;
            // 
            // btnpshowpass
            // 
            this.btnpshowpass.Location = new System.Drawing.Point(231, 80);
            this.btnpshowpass.Name = "btnpshowpass";
            this.btnpshowpass.Size = new System.Drawing.Size(42, 27);
            this.btnpshowpass.TabIndex = 6;
            this.btnpshowpass.Text = "👁";
            this.btnpshowpass.UseVisualStyleBackColor = true;
            this.btnpshowpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btnpshowpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // signinpasstext
            // 
            this.signinpasstext.Location = new System.Drawing.Point(125, 80);
            this.signinpasstext.Name = "signinpasstext";
            this.signinpasstext.Size = new System.Drawing.Size(80, 23);
            this.signinpasstext.TabIndex = 2;
            this.signinpasstext.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(59, 80);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 15);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // signinlogintext
            // 
            this.signinlogintext.Location = new System.Drawing.Point(125, 40);
            this.signinlogintext.Name = "signinlogintext";
            this.signinlogintext.Size = new System.Drawing.Size(80, 23);
            this.signinlogintext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // signinbtn
            // 
            this.signinbtn.Location = new System.Drawing.Point(47, 128);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(69, 31);
            this.signinbtn.TabIndex = 0;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(140, 128);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(74, 31);
            this.signupbtn.TabIndex = 0;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // panelcolorlist
            // 
            this.panelcolorlist.Controls.Add(this.textBoxhex);
            this.panelcolorlist.Controls.Add(this.labelblue);
            this.panelcolorlist.Controls.Add(this.labelgreen);
            this.panelcolorlist.Controls.Add(this.labelred);
            this.panelcolorlist.Controls.Add(this.showcolor);
            this.panelcolorlist.Controls.Add(this.comboBoxcolor);
            this.panelcolorlist.Controls.Add(this.menuStrip2);
            this.panelcolorlist.Location = new System.Drawing.Point(522, 53);
            this.panelcolorlist.Name = "panelcolorlist";
            this.panelcolorlist.Size = new System.Drawing.Size(354, 330);
            this.panelcolorlist.TabIndex = 5;
            // 
            // textBoxhex
            // 
            this.textBoxhex.Location = new System.Drawing.Point(133, 134);
            this.textBoxhex.Name = "textBoxhex";
            this.textBoxhex.Size = new System.Drawing.Size(80, 23);
            this.textBoxhex.TabIndex = 9;
            this.textBoxhex.Text = "#";
            // 
            // labelblue
            // 
            this.labelblue.AutoSize = true;
            this.labelblue.Location = new System.Drawing.Point(255, 242);
            this.labelblue.Name = "labelblue";
            this.labelblue.Size = new System.Drawing.Size(33, 15);
            this.labelblue.TabIndex = 3;
            this.labelblue.Text = "Blue:";
            // 
            // labelgreen
            // 
            this.labelgreen.AutoSize = true;
            this.labelgreen.Location = new System.Drawing.Point(166, 242);
            this.labelgreen.Name = "labelgreen";
            this.labelgreen.Size = new System.Drawing.Size(41, 15);
            this.labelgreen.TabIndex = 3;
            this.labelgreen.Text = "Green:";
            // 
            // labelred
            // 
            this.labelred.AutoSize = true;
            this.labelred.Location = new System.Drawing.Point(59, 242);
            this.labelred.Name = "labelred";
            this.labelred.Size = new System.Drawing.Size(30, 15);
            this.labelred.TabIndex = 3;
            this.labelred.Text = "Red:";
            // 
            // showcolor
            // 
            this.showcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showcolor.Location = new System.Drawing.Point(111, 64);
            this.showcolor.Name = "showcolor";
            this.showcolor.Size = new System.Drawing.Size(121, 47);
            this.showcolor.TabIndex = 2;
            // 
            // comboBoxcolor
            // 
            this.comboBoxcolor.FormattingEnabled = true;
            this.comboBoxcolor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Orange"});
            this.comboBoxcolor.Location = new System.Drawing.Point(106, 188);
            this.comboBoxcolor.Name = "comboBoxcolor";
            this.comboBoxcolor.Size = new System.Drawing.Size(154, 23);
            this.comboBoxcolor.TabIndex = 0;
            this.comboBoxcolor.Text = "Choose Color";
            this.comboBoxcolor.SelectedIndexChanged += new System.EventHandler(this.comboBoxcolor_SelectedIndexChanged);
            this.comboBoxcolor.SelectedValueChanged += new System.EventHandler(this.comboBoxcolor_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(354, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "Color List";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.colorListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem3.Text = "Track Bar";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.trackBarToolStripMenuItem1_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.menuStrip1);
            this.panelmenu.Controls.Add(this.labelbluee);
            this.panelmenu.Controls.Add(this.textboxcode);
            this.panelmenu.Controls.Add(this.labelgreenn);
            this.panelmenu.Controls.Add(this.label3);
            this.panelmenu.Controls.Add(this.labelredd);
            this.panelmenu.Controls.Add(this.label2);
            this.panelmenu.Controls.Add(this.label4);
            this.panelmenu.Controls.Add(this.labelcolor);
            this.panelmenu.Controls.Add(this.bluetrackbar);
            this.panelmenu.Controls.Add(this.greentrackbar);
            this.panelmenu.Controls.Add(this.redtrackbar);
            this.panelmenu.Location = new System.Drawing.Point(4, 12);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(404, 445);
            this.panelmenu.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorListToolStripMenuItem1,
            this.trackBarToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // colorListToolStripMenuItem1
            // 
            this.colorListToolStripMenuItem1.Name = "colorListToolStripMenuItem1";
            this.colorListToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.colorListToolStripMenuItem1.Text = "Color List";
            this.colorListToolStripMenuItem1.Click += new System.EventHandler(this.colorListToolStripMenuItem_Click);
            // 
            // trackBarToolStripMenuItem1
            // 
            this.trackBarToolStripMenuItem1.Name = "trackBarToolStripMenuItem1";
            this.trackBarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.trackBarToolStripMenuItem1.Text = "Track Bar";
            this.trackBarToolStripMenuItem1.Click += new System.EventHandler(this.trackBarToolStripMenuItem1_Click);
            // 
            // labelbluee
            // 
            this.labelbluee.AutoSize = true;
            this.labelbluee.Location = new System.Drawing.Point(296, 411);
            this.labelbluee.Name = "labelbluee";
            this.labelbluee.Size = new System.Drawing.Size(33, 15);
            this.labelbluee.TabIndex = 4;
            this.labelbluee.Text = "Blue:";
            // 
            // textboxcode
            // 
            this.textboxcode.Location = new System.Drawing.Point(177, 129);
            this.textboxcode.Name = "textboxcode";
            this.textboxcode.Size = new System.Drawing.Size(77, 23);
            this.textboxcode.TabIndex = 8;
            this.textboxcode.Text = "#";
            // 
            // labelgreenn
            // 
            this.labelgreenn.AutoSize = true;
            this.labelgreenn.Location = new System.Drawing.Point(207, 411);
            this.labelgreenn.Name = "labelgreenn";
            this.labelgreenn.Size = new System.Drawing.Size(41, 15);
            this.labelgreenn.TabIndex = 5;
            this.labelgreenn.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "BLUE";
            // 
            // labelredd
            // 
            this.labelredd.AutoSize = true;
            this.labelredd.Location = new System.Drawing.Point(100, 411);
            this.labelredd.Name = "labelredd";
            this.labelredd.Size = new System.Drawing.Size(30, 15);
            this.labelredd.TabIndex = 6;
            this.labelredd.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "GREEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "RED";
            // 
            // labelcolor
            // 
            this.labelcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelcolor.Location = new System.Drawing.Point(151, 63);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(121, 47);
            this.labelcolor.TabIndex = 2;
            // 
            // bluetrackbar
            // 
            this.bluetrackbar.Location = new System.Drawing.Point(100, 343);
            this.bluetrackbar.Maximum = 255;
            this.bluetrackbar.Name = "bluetrackbar";
            this.bluetrackbar.Size = new System.Drawing.Size(255, 45);
            this.bluetrackbar.TabIndex = 2;
            this.bluetrackbar.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // greentrackbar
            // 
            this.greentrackbar.Location = new System.Drawing.Point(100, 253);
            this.greentrackbar.Maximum = 255;
            this.greentrackbar.Name = "greentrackbar";
            this.greentrackbar.Size = new System.Drawing.Size(255, 45);
            this.greentrackbar.TabIndex = 3;
            this.greentrackbar.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // redtrackbar
            // 
            this.redtrackbar.Location = new System.Drawing.Point(100, 175);
            this.redtrackbar.Maximum = 255;
            this.redtrackbar.Name = "redtrackbar";
            this.redtrackbar.Size = new System.Drawing.Size(255, 45);
            this.redtrackbar.TabIndex = 4;
            this.redtrackbar.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 693);
            this.Controls.Add(this.panelsignin);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelcolorlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Color Picker App";
            this.panelsignin.ResumeLayout(false);
            this.panelsignin.PerformLayout();
            this.panelcolorlist.ResumeLayout(false);
            this.panelcolorlist.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redtrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelsignin;
        private TextBox signinpasstext;
        private Label Password;
        private TextBox signinlogintext;
        private Label label1;
        private Button signinbtn;
        private Button signupbtn;
        private Panel panelmenu;
        private MenuStrip menuStrip1;
        private Panel panelcolorlist;
        private ComboBox comboBoxcolor;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem colorListToolStripMenuItem1;
        private ToolStripMenuItem trackBarToolStripMenuItem1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Label showcolor;
        private Label labelblue;
        private Label labelgreen;
        private Label labelred;
        private TextBox textboxcode;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label labelcolor;
        private TrackBar bluetrackbar;
        private TrackBar greentrackbar;
        private TrackBar redtrackbar;
        private Label labelbluee;
        private Label labelgreenn;
        private Label labelredd;
        private TextBox textBoxhex;
        private Button btnpshowpass;
    }
}