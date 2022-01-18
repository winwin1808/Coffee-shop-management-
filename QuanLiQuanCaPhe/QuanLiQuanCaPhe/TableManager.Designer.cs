namespace QuanLiQuanCaPhe
{
    partial class TableManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textboxDiscount = new System.Windows.Forms.TextBox();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.btChangeTable = new System.Windows.Forms.Button();
            this.btBill = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmNum = new System.Windows.Forms.NumericUpDown();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 326);
            this.panel2.TabIndex = 3;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.GridLines = true;
            this.lvBill.Location = new System.Drawing.Point(3, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Scrollable = false;
            this.lvBill.Size = new System.Drawing.Size(349, 320);
            this.lvBill.TabIndex = 1;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 100);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textboxDiscount);
            this.panel4.Controls.Add(this.cbChangeTable);
            this.panel4.Controls.Add(this.btChangeTable);
            this.panel4.Controls.Add(this.btBill);
            this.panel4.Location = new System.Drawing.Point(12, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 60);
            this.panel4.TabIndex = 4;
            // 
            // textboxDiscount
            // 
            this.textboxDiscount.Location = new System.Drawing.Point(6, 30);
            this.textboxDiscount.Name = "textboxDiscount";
            this.textboxDiscount.PlaceholderText = "Discount code here";
            this.textboxDiscount.Size = new System.Drawing.Size(154, 23);
            this.textboxDiscount.TabIndex = 7;
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(6, 5);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(74, 23);
            this.cbChangeTable.TabIndex = 6;
            this.cbChangeTable.Text = "Table";
            // 
            // btChangeTable
            // 
            this.btChangeTable.Location = new System.Drawing.Point(86, 5);
            this.btChangeTable.Name = "btChangeTable";
            this.btChangeTable.Size = new System.Drawing.Size(74, 24);
            this.btChangeTable.TabIndex = 5;
            this.btChangeTable.Text = "CHANGE";
            this.btChangeTable.UseVisualStyleBackColor = true;
            // 
            // btBill
            // 
            this.btBill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBill.Location = new System.Drawing.Point(166, 3);
            this.btBill.Name = "btBill";
            this.btBill.Size = new System.Drawing.Size(186, 50);
            this.btBill.TabIndex = 0;
            this.btBill.Text = "BILL";
            this.btBill.UseVisualStyleBackColor = false;
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nmNum);
            this.panel5.Controls.Add(this.btAdd);
            this.panel5.Controls.Add(this.cbDrink);
            this.panel5.Controls.Add(this.cbCategory);
            this.panel5.Location = new System.Drawing.Point(12, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 60);
            this.panel5.TabIndex = 5;
            // 
            // nmNum
            // 
            this.nmNum.Location = new System.Drawing.Point(298, 23);
            this.nmNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmNum.Name = "nmNum";
            this.nmNum.Size = new System.Drawing.Size(47, 23);
            this.nmNum.TabIndex = 3;
            this.nmNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(218, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(74, 50);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(3, 32);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(209, 23);
            this.cbDrink.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(209, 23);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategoryChange);
            // 
            // flpTable
            // 
            this.flpTable.AccessibleDescription = "loadTable";
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(370, 42);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(419, 458);
            this.flpTable.TabIndex = 6;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfomationToolStripMenuItem,
            this.toolStripMenuItem1});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // personalInfomationToolStripMenuItem
            // 
            this.personalInfomationToolStripMenuItem.Name = "personalInfomationToolStripMenuItem";
            this.personalInfomationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.personalInfomationToolStripMenuItem.Text = "Personal Infomation";
            this.personalInfomationToolStripMenuItem.Click += new System.EventHandler(this.personalInfomationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Log out";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí";
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmNum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ListView lvBill;
        private Panel panel5;
        private NumericUpDown nmNum;
        private Button btAdd;
        private ComboBox cbDrink;
        private ComboBox cbCategory;
        private FlowLayoutPanel flpTable;
        private Button btBill;
        private ComboBox cbChangeTable;
        private Button btChangeTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        public TextBox textboxDiscount;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem personalInfomationToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}