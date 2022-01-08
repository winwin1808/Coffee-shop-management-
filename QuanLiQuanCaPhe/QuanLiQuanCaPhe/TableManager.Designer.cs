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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAccountProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.btChangeTable = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btDiscount = new System.Windows.Forms.Button();
            this.btBill = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmNum = new System.Windows.Forms.NumericUpDown();
            this.ADD = new System.Windows.Forms.Button();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qToolStripMenuItem,
            this.tableAccountProfile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.qToolStripMenuItem.Text = "Admin";
            this.qToolStripMenuItem.Click += new System.EventHandler(this.qToolStripMenuItem_Click);
            // 
            // tableAccountProfile
            // 
            this.tableAccountProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.tableAccountProfile.Name = "tableAccountProfile";
            this.tableAccountProfile.Size = new System.Drawing.Size(130, 20);
            this.tableAccountProfile.Text = "Account Information";
            this.tableAccountProfile.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Personal Information";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(433, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 326);
            this.panel2.TabIndex = 3;
            // 
            // lvBill
            // 
            this.lvBill.Location = new System.Drawing.Point(3, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(349, 320);
            this.lvBill.TabIndex = 1;
            this.lvBill.UseCompatibleStateImageBehavior = false;
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
            this.panel4.Controls.Add(this.cbChangeTable);
            this.panel4.Controls.Add(this.btChangeTable);
            this.panel4.Controls.Add(this.nmDiscount);
            this.panel4.Controls.Add(this.btDiscount);
            this.panel4.Controls.Add(this.btBill);
            this.panel4.Location = new System.Drawing.Point(433, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 60);
            this.panel4.TabIndex = 4;
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(6, 30);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(74, 23);
            this.cbChangeTable.TabIndex = 6;
            // 
            // btChangeTable
            // 
            this.btChangeTable.Location = new System.Drawing.Point(6, 3);
            this.btChangeTable.Name = "btChangeTable";
            this.btChangeTable.Size = new System.Drawing.Size(74, 24);
            this.btChangeTable.TabIndex = 5;
            this.btChangeTable.Text = "CHANGE";
            this.btChangeTable.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(86, 30);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(74, 23);
            this.nmDiscount.TabIndex = 4;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDiscount
            // 
            this.btDiscount.Location = new System.Drawing.Point(86, 3);
            this.btDiscount.Name = "btDiscount";
            this.btDiscount.Size = new System.Drawing.Size(74, 24);
            this.btDiscount.TabIndex = 1;
            this.btDiscount.Text = "DISCOUNT";
            this.btDiscount.UseVisualStyleBackColor = true;
            // 
            // btBill
            // 
            this.btBill.Location = new System.Drawing.Point(166, 3);
            this.btBill.Name = "btBill";
            this.btBill.Size = new System.Drawing.Size(186, 50);
            this.btBill.TabIndex = 0;
            this.btBill.Text = "BILL";
            this.btBill.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nmNum);
            this.panel5.Controls.Add(this.ADD);
            this.panel5.Controls.Add(this.cbDrink);
            this.panel5.Controls.Add(this.cbCategory);
            this.panel5.Location = new System.Drawing.Point(433, 42);
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
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(218, 5);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(74, 50);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
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
            // 
            // flpTable
            // 
            this.flpTable.AccessibleDescription = "loadTable";
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(8, 40);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(419, 457);
            this.flpTable.TabIndex = 6;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem qToolStripMenuItem;
        private ToolStripMenuItem tableAccountProfile;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ListView lvBill;
        private Panel panel5;
        private NumericUpDown nmNum;
        private Button ADD;
        private ComboBox cbDrink;
        private ComboBox cbCategory;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nmDiscount;
        private Button btDiscount;
        private Button btBill;
        private ComboBox cbChangeTable;
        private Button btChangeTable;
    }
}