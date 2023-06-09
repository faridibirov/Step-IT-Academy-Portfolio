namespace Ware_House
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.listViewproduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.listViewclient = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnSurname = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.columnPhone = new System.Windows.Forms.ColumnHeader();
            this.columnAddress = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelsignin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpshowpass = new System.Windows.Forms.Button();
            this.signinpasstext = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.signinlogintext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signinbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelorder = new System.Windows.Forms.Panel();
            this.textBoxfilter = new System.Windows.Forms.TextBox();
            this.labelfilter = new System.Windows.Forms.Label();
            this.listVieworder = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelmenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelsignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelorder.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.listViewproduct);
            this.panelmenu.Controls.Add(this.listViewclient);
            this.panelmenu.Controls.Add(this.menuStrip1);
            this.panelmenu.Location = new System.Drawing.Point(542, 18);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(584, 395);
            this.panelmenu.TabIndex = 1;
            // 
            // listViewproduct
            // 
            this.listViewproduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewproduct.FullRowSelect = true;
            this.listViewproduct.Location = new System.Drawing.Point(-3, 68);
            this.listViewproduct.Name = "listViewproduct";
            this.listViewproduct.Size = new System.Drawing.Size(584, 371);
            this.listViewproduct.TabIndex = 3;
            this.listViewproduct.UseCompatibleStateImageBehavior = false;
            this.listViewproduct.View = System.Windows.Forms.View.Details;
            this.listViewproduct.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 350;
            // 
            // listViewclient
            // 
            this.listViewclient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSurname,
            this.columnEmail,
            this.columnPhone,
            this.columnAddress});
            this.listViewclient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewclient.FullRowSelect = true;
            this.listViewclient.Location = new System.Drawing.Point(0, 24);
            this.listViewclient.Name = "listViewclient";
            this.listViewclient.Size = new System.Drawing.Size(584, 371);
            this.listViewclient.TabIndex = 2;
            this.listViewclient.UseCompatibleStateImageBehavior = false;
            this.listViewclient.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnSurname
            // 
            this.columnSurname.Text = "Surname";
            this.columnSurname.Width = 150;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 150;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone";
            this.columnPhone.Width = 150;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 195;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.productToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.listToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "&Client";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptToolStripMenuItem,
            this.listToolStripMenuItem1});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "&Order";
            // 
            // acceptToolStripMenuItem
            // 
            this.acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            this.acceptToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.acceptToolStripMenuItem.Text = "Accept";
            this.acceptToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.listToolStripMenuItem1.Text = "List";
            this.listToolStripMenuItem1.Click += new System.EventHandler(this.listToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.listToolStripMenuItem2});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "&Product";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // listToolStripMenuItem2
            // 
            this.listToolStripMenuItem2.Name = "listToolStripMenuItem2";
            this.listToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.listToolStripMenuItem2.Text = "List";
            this.listToolStripMenuItem2.Click += new System.EventHandler(this.listToolStripMenuItem2_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.closeAppToolStripMenuItem});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.logOutToolStripMenuItem.Text = "&Exit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.closeAppToolStripMenuItem.Text = "Close App";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // panelsignin
            // 
            this.panelsignin.Controls.Add(this.pictureBox1);
            this.panelsignin.Controls.Add(this.label2);
            this.panelsignin.Controls.Add(this.btnpshowpass);
            this.panelsignin.Controls.Add(this.signinpasstext);
            this.panelsignin.Controls.Add(this.Password);
            this.panelsignin.Controls.Add(this.signinlogintext);
            this.panelsignin.Controls.Add(this.label1);
            this.panelsignin.Controls.Add(this.signinbtn);
            this.panelsignin.Controls.Add(this.signupbtn);
            this.panelsignin.Location = new System.Drawing.Point(12, 12);
            this.panelsignin.Name = "panelsignin";
            this.panelsignin.Size = new System.Drawing.Size(524, 401);
            this.panelsignin.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome to Ware House App";
            // 
            // btnpshowpass
            // 
            this.btnpshowpass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnpshowpass.FlatAppearance.BorderSize = 0;
            this.btnpshowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpshowpass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpshowpass.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpshowpass.Location = new System.Drawing.Point(352, 200);
            this.btnpshowpass.Name = "btnpshowpass";
            this.btnpshowpass.Size = new System.Drawing.Size(42, 27);
            this.btnpshowpass.TabIndex = 6;
            this.btnpshowpass.Text = "👁";
            this.btnpshowpass.UseVisualStyleBackColor = false;
            this.btnpshowpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btnpshowpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // signinpasstext
            // 
            this.signinpasstext.Location = new System.Drawing.Point(234, 200);
            this.signinpasstext.Name = "signinpasstext";
            this.signinpasstext.Size = new System.Drawing.Size(100, 23);
            this.signinpasstext.TabIndex = 2;
            this.signinpasstext.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(156, 201);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 19);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // signinlogintext
            // 
            this.signinlogintext.Location = new System.Drawing.Point(234, 160);
            this.signinlogintext.Name = "signinlogintext";
            this.signinlogintext.Size = new System.Drawing.Size(100, 23);
            this.signinlogintext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // signinbtn
            // 
            this.signinbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.signinbtn.FlatAppearance.BorderSize = 0;
            this.signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signinbtn.Location = new System.Drawing.Point(156, 248);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(69, 31);
            this.signinbtn.TabIndex = 0;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.signupbtn.FlatAppearance.BorderSize = 0;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signupbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signupbtn.Location = new System.Drawing.Point(249, 248);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(74, 31);
            this.signupbtn.TabIndex = 0;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "warehouse.png");
            // 
            // panelorder
            // 
            this.panelorder.Controls.Add(this.textBoxfilter);
            this.panelorder.Controls.Add(this.labelfilter);
            this.panelorder.Controls.Add(this.listVieworder);
            this.panelorder.Controls.Add(this.menuStrip2);
            this.panelorder.Location = new System.Drawing.Point(168, 495);
            this.panelorder.Name = "panelorder";
            this.panelorder.Size = new System.Drawing.Size(607, 460);
            this.panelorder.TabIndex = 4;
            // 
            // textBoxfilter
            // 
            this.textBoxfilter.Location = new System.Drawing.Point(404, 37);
            this.textBoxfilter.Name = "textBoxfilter";
            this.textBoxfilter.Size = new System.Drawing.Size(89, 23);
            this.textBoxfilter.TabIndex = 4;
            this.textBoxfilter.TextChanged += new System.EventHandler(this.textBoxfilter_TextChanged);
            // 
            // labelfilter
            // 
            this.labelfilter.AutoSize = true;
            this.labelfilter.Location = new System.Drawing.Point(351, 40);
            this.labelfilter.Name = "labelfilter";
            this.labelfilter.Size = new System.Drawing.Size(33, 15);
            this.labelfilter.TabIndex = 3;
            this.labelfilter.Text = "Filter";
            // 
            // listVieworder
            // 
            this.listVieworder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listVieworder.FullRowSelect = true;
            this.listVieworder.Location = new System.Drawing.Point(0, 66);
            this.listVieworder.Name = "listVieworder";
            this.listVieworder.Size = new System.Drawing.Size(606, 397);
            this.listVieworder.TabIndex = 2;
            this.listVieworder.UseCompatibleStateImageBehavior = false;
            this.listVieworder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Product";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Quantity";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Arrival Date";
            this.columnHeader12.Width = 150;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem7,
            this.toolStripMenuItem10});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(607, 24);
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
            this.toolStripMenuItem1.Text = "Client";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Add";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "List";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem4.Text = "Order";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem5.Text = "Accept";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem6.Text = "List";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.listToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem7.Text = "Product";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem8.Text = "Add";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem9.Text = "List";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.listToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem10.Text = "Exit";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem11.Text = "Log Out";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem12.Text = "Close App";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1329, 749);
            this.Controls.Add(this.panelorder);
            this.Controls.Add(this.panelsignin);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ware House";
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelsignin.ResumeLayout(false);
            this.panelsignin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelorder.ResumeLayout(false);
            this.panelorder.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelmenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem acceptToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem listToolStripMenuItem2;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panelsignin;
        private Button btnpshowpass;
        private TextBox signinpasstext;
        private Label Password;
        private TextBox signinlogintext;
        private Label label1;
        private Button signinbtn;
        private Button signupbtn;
        private Label label2;
        private ListView listViewclient;
        private ColumnHeader columnName;
        private ColumnHeader columnSurname;
        private ColumnHeader columnEmail;
        private ColumnHeader columnPhone;
        private ColumnHeader columnAddress;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem closeAppToolStripMenuItem;
        private ListView listViewproduct;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panelorder;
        private TextBox textBoxfilter;
        private Label labelfilter;
        private ListView listVieworder;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
    }
}