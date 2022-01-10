namespace QuanLiQuanCaPhe
{
    partial class LOGIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_LOGIN = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textbox_PASSWORD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textbox_LOGIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_LOGIN);
            this.panel1.Controls.Add(this.button_EXIT);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 164);
            this.panel1.TabIndex = 0;
            // 
            // button_LOGIN
            // 
            this.button_LOGIN.Location = new System.Drawing.Point(343, 123);
            this.button_LOGIN.Name = "button_LOGIN";
            this.button_LOGIN.Size = new System.Drawing.Size(75, 23);
            this.button_LOGIN.TabIndex = 2;
            this.button_LOGIN.Text = "LOGIN";
            this.button_LOGIN.UseVisualStyleBackColor = true;
            this.button_LOGIN.Click += new System.EventHandler(this.button_LOGIN_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(441, 123);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(75, 23);
            this.button_EXIT.TabIndex = 3;
            this.button_EXIT.Text = "EXIT";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textbox_PASSWORD);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 54);
            this.panel3.TabIndex = 1;
            // 
            // textbox_PASSWORD
            // 
            this.textbox_PASSWORD.Location = new System.Drawing.Point(141, 15);
            this.textbox_PASSWORD.Name = "textbox_PASSWORD";
            this.textbox_PASSWORD.Size = new System.Drawing.Size(274, 23);
            this.textbox_PASSWORD.TabIndex = 1;
            this.textbox_PASSWORD.Text = "123";
            this.textbox_PASSWORD.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textbox_LOGIN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 54);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textbox_LOGIN
            // 
            this.textbox_LOGIN.BackColor = System.Drawing.Color.White;
            this.textbox_LOGIN.Location = new System.Drawing.Point(141, 16);
            this.textbox_LOGIN.Name = "textbox_LOGIN";
            this.textbox_LOGIN.Size = new System.Drawing.Size(274, 23);
            this.textbox_LOGIN.TabIndex = 1;
            this.textbox_LOGIN.Text = "Hao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LOGIN
            // 
            this.AcceptButton = this.button_LOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button_EXIT;
            this.ClientSize = new System.Drawing.Size(560, 213);
            this.Controls.Add(this.panel1);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FormClosing);
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox textbox_PASSWORD;
        private Label label2;
        private TextBox textbox_LOGIN;
        private Button button_LOGIN;
        private Button button_EXIT;
    }
}