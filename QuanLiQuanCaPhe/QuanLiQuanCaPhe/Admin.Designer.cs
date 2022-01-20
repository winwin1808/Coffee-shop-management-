namespace QuanLiQuanCaPhe
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabpageAccount = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBoxAccountType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonViewAccount = new System.Windows.Forms.Button();
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.tabpageRevenue = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonViewBill = new System.Windows.Forms.Button();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerFromDay = new System.Windows.Forms.DateTimePicker();
            this.tabControlBill = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.tabpageAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.tabpageRevenue.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControlBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpageAccount
            // 
            this.tabpageAccount.Controls.Add(this.panel1);
            this.tabpageAccount.Controls.Add(this.panel18);
            this.tabpageAccount.Location = new System.Drawing.Point(4, 24);
            this.tabpageAccount.Name = "tabpageAccount";
            this.tabpageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAccount.Size = new System.Drawing.Size(790, 398);
            this.tabpageAccount.TabIndex = 4;
            this.tabpageAccount.Text = "Account";
            this.tabpageAccount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEditAccount);
            this.panel1.Controls.Add(this.buttonViewAccount);
            this.panel1.Controls.Add(this.buttonAddAccount);
            this.panel1.Controls.Add(this.buttonDeleteAccount);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Location = new System.Drawing.Point(500, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 386);
            this.panel1.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.textBoxAccountType);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Location = new System.Drawing.Point(3, 152);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(275, 66);
            this.panel13.TabIndex = 2;
            // 
            // textBoxAccountType
            // 
            this.textBoxAccountType.Location = new System.Drawing.Point(9, 24);
            this.textBoxAccountType.Name = "textBoxAccountType";
            this.textBoxAccountType.ReadOnly = true;
            this.textBoxAccountType.Size = new System.Drawing.Size(266, 23);
            this.textBoxAccountType.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "User/Admin";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.textBoxUserName);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Location = new System.Drawing.Point(6, 74);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(275, 72);
            this.panel14.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(6, 24);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(266, 23);
            this.textBoxUserName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBoxDisplayName);
            this.panel15.Controls.Add(this.label7);
            this.panel15.Location = new System.Drawing.Point(6, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(275, 65);
            this.panel15.TabIndex = 1;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Location = new System.Drawing.Point(6, 24);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(266, 23);
            this.textBoxDisplayName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Displayname";
            // 
            // buttonViewAccount
            // 
            this.buttonViewAccount.Location = new System.Drawing.Point(23, 242);
            this.buttonViewAccount.Name = "buttonViewAccount";
            this.buttonViewAccount.Size = new System.Drawing.Size(115, 62);
            this.buttonViewAccount.TabIndex = 3;
            this.buttonViewAccount.Text = "VIEW";
            this.buttonViewAccount.UseVisualStyleBackColor = true;
            this.buttonViewAccount.Click += new System.EventHandler(this.buttonViewAccount_Click);
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonEditAccount.Location = new System.Drawing.Point(143, 242);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(116, 62);
            this.buttonEditAccount.TabIndex = 2;
            this.buttonEditAccount.Text = "EDIT";
            this.buttonEditAccount.UseVisualStyleBackColor = true;
            this.buttonEditAccount.Click += new System.EventHandler(this.buttonEditAccount_Click);
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Location = new System.Drawing.Point(23, 310);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(114, 62);
            this.buttonDeleteAccount.TabIndex = 1;
            this.buttonDeleteAccount.Text = "DELETE";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Location = new System.Drawing.Point(143, 310);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(116, 62);
            this.buttonAddAccount.TabIndex = 0;
            this.buttonAddAccount.Text = "ADD";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dataGridViewAccount);
            this.panel18.Location = new System.Drawing.Point(6, 6);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(488, 386);
            this.panel18.TabIndex = 4;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AllowUserToOrderColumns = true;
            this.dataGridViewAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.RowTemplate.Height = 25;
            this.dataGridViewAccount.Size = new System.Drawing.Size(481, 380);
            this.dataGridViewAccount.TabIndex = 0;
            // 
            // tabpageRevenue
            // 
            this.tabpageRevenue.Controls.Add(this.panel4);
            this.tabpageRevenue.Controls.Add(this.panel3);
            this.tabpageRevenue.Location = new System.Drawing.Point(4, 24);
            this.tabpageRevenue.Name = "tabpageRevenue";
            this.tabpageRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageRevenue.Size = new System.Drawing.Size(790, 398);
            this.tabpageRevenue.TabIndex = 0;
            this.tabpageRevenue.Text = "Revenue";
            this.tabpageRevenue.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonViewBill);
            this.panel4.Controls.Add(this.dataGridViewBill);
            this.panel4.Location = new System.Drawing.Point(6, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(778, 366);
            this.panel4.TabIndex = 1;
            // 
            // buttonViewBill
            // 
            this.buttonViewBill.Location = new System.Drawing.Point(235, 324);
            this.buttonViewBill.Name = "buttonViewBill";
            this.buttonViewBill.Size = new System.Drawing.Size(310, 36);
            this.buttonViewBill.TabIndex = 2;
            this.buttonViewBill.Text = "View";
            this.buttonViewBill.UseVisualStyleBackColor = true;
            this.buttonViewBill.Click += new System.EventHandler(this.buttonViewBill_Click);
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowTemplate.Height = 25;
            this.dataGridViewBill.Size = new System.Drawing.Size(772, 315);
            this.dataGridViewBill.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePickerFromDay);
            this.panel3.Location = new System.Drawing.Point(6, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 36);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimePickerFromDay
            // 
            this.dateTimePickerFromDay.Location = new System.Drawing.Point(549, 3);
            this.dateTimePickerFromDay.Name = "dateTimePickerFromDay";
            this.dateTimePickerFromDay.Size = new System.Drawing.Size(226, 23);
            this.dateTimePickerFromDay.TabIndex = 0;
            this.dateTimePickerFromDay.ValueChanged += new System.EventHandler(this.dateTimePickerFromDay_ValueChanged);
            // 
            // tabControlBill
            // 
            this.tabControlBill.Controls.Add(this.tabpageRevenue);
            this.tabControlBill.Controls.Add(this.tabpageAccount);
            this.tabControlBill.Location = new System.Drawing.Point(12, 12);
            this.tabControlBill.Name = "tabControlBill";
            this.tabControlBill.SelectedIndex = 0;
            this.tabControlBill.Size = new System.Drawing.Size(798, 426);
            this.tabControlBill.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.tabControlBill);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.tabpageAccount.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.tabpageRevenue.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControlBill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private TabPage tabpageAccount;
        private Panel panel1;
        private Panel panel13;
        private Label label6;
        private Panel panel14;
        private TextBox textBoxDisplayName;
        private Label label7;
        private Panel panel15;
        private TextBox textBoxUserName;
        private Label label8;
        private Button buttonViewAccount;
        private Button buttonEditAccount;
        private Button buttonDeleteAccount;
        private Button buttonAddAccount;
        private Panel panel18;
        private DataGridView dataGridViewAccount;
        private TabPage tabpageRevenue;
        private Panel panel4;
        private Button buttonViewBill;
        private DataGridView dataGridViewBill;
        private Panel panel3;
        private DateTimePicker dateTimePickerFromDay;
        private TabControl tabControlBill;
        private TextBox textBoxAccountType;
    }
}