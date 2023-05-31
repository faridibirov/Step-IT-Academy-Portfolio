namespace TaskManager
{
    partial class TaskManager
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
            this.buttonnewtask = new System.Windows.Forms.Button();
            this.buttonendtask = new System.Windows.Forms.Button();
            this.buttonblist = new System.Windows.Forms.Button();
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonnewtask
            // 
            this.buttonnewtask.Location = new System.Drawing.Point(12, 12);
            this.buttonnewtask.Name = "buttonnewtask";
            this.buttonnewtask.Size = new System.Drawing.Size(75, 23);
            this.buttonnewtask.TabIndex = 1;
            this.buttonnewtask.Text = "Add Task";
            this.buttonnewtask.UseVisualStyleBackColor = true;
            this.buttonnewtask.Click += new System.EventHandler(this.buttonnewtask_Click);
            // 
            // buttonendtask
            // 
            this.buttonendtask.Location = new System.Drawing.Point(144, 12);
            this.buttonendtask.Name = "buttonendtask";
            this.buttonendtask.Size = new System.Drawing.Size(75, 23);
            this.buttonendtask.TabIndex = 1;
            this.buttonendtask.Text = "End Task";
            this.buttonendtask.UseVisualStyleBackColor = true;
            this.buttonendtask.Click += new System.EventHandler(this.buttonendtask_Click);
            // 
            // buttonblist
            // 
            this.buttonblist.Location = new System.Drawing.Point(280, 12);
            this.buttonblist.Name = "buttonblist";
            this.buttonblist.Size = new System.Drawing.Size(75, 23);
            this.buttonblist.TabIndex = 1;
            this.buttonblist.Text = "BlackList";
            this.buttonblist.UseVisualStyleBackColor = true;
            this.buttonblist.Click += new System.EventHandler(this.buttonblist_Click);
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2});
            this.listViewData.FullRowSelect = true;
            this.listViewData.Location = new System.Drawing.Point(12, 57);
            this.listViewData.MultiSelect = false;
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(375, 352);
            this.listViewData.TabIndex = 15;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Threads";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Priority";
            this.columnHeader2.Width = 80;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 432);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.buttonblist);
            this.Controls.Add(this.buttonendtask);
            this.Controls.Add(this.buttonnewtask);
            this.Name = "TaskManager";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonnewtask;
        private Button buttonendtask;
        private Button buttonblist;
        private ListView listViewData;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private System.Windows.Forms.Timer timer1;
        private ColumnHeader columnHeader2;
    }
}