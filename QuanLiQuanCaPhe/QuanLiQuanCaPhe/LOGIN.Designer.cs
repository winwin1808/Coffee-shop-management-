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
            System.Windows.Forms.Button button_LOGIN;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textbox_PASSWORD = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textbox_LOGIN = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            button_LOGIN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LOGIN
            // 
            button_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(252)))));
            button_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_LOGIN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_LOGIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button_LOGIN.Location = new System.Drawing.Point(11, 133);
            button_LOGIN.Name = "button_LOGIN";
            button_LOGIN.Size = new System.Drawing.Size(240, 61);
            button_LOGIN.TabIndex = 2;
            button_LOGIN.Text = "Login";
            button_LOGIN.UseVisualStyleBackColor = false;
            button_LOGIN.Click += new System.EventHandler(this.button_LOGIN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(button_LOGIN);
            this.panel1.Controls.Add(this.button_EXIT);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(34, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 242);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_EXIT
            // 
            this.button_EXIT.BackColor = System.Drawing.Color.Pink;
            this.button_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EXIT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_EXIT.ForeColor = System.Drawing.Color.White;
            this.button_EXIT.Location = new System.Drawing.Point(11, 200);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(240, 39);
            this.button_EXIT.TabIndex = 3;
            this.button_EXIT.Text = "Exit";
            this.button_EXIT.UseVisualStyleBackColor = false;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.textbox_PASSWORD);
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 54);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(172)))), ((int)(((byte)(194)))));
            this.panel6.Location = new System.Drawing.Point(8, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 3);
            this.panel6.TabIndex = 3;
            // 
            // textbox_PASSWORD
            // 
            this.textbox_PASSWORD.BackColor = System.Drawing.Color.White;
            this.textbox_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_PASSWORD.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textbox_PASSWORD.Location = new System.Drawing.Point(38, 16);
            this.textbox_PASSWORD.Name = "textbox_PASSWORD";
            this.textbox_PASSWORD.PlaceholderText = "Password";
            this.textbox_PASSWORD.Size = new System.Drawing.Size(199, 22);
            this.textbox_PASSWORD.TabIndex = 1;
            this.textbox_PASSWORD.Text = "123";
            this.textbox_PASSWORD.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.textbox_LOGIN);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 54);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(172)))), ((int)(((byte)(194)))));
            this.panel5.Location = new System.Drawing.Point(8, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 3);
            this.panel5.TabIndex = 2;
            // 
            // textbox_LOGIN
            // 
            this.textbox_LOGIN.BackColor = System.Drawing.Color.White;
            this.textbox_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_LOGIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_LOGIN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textbox_LOGIN.Location = new System.Drawing.Point(38, 12);
            this.textbox_LOGIN.Name = "textbox_LOGIN";
            this.textbox_LOGIN.PlaceholderText = "Username";
            this.textbox_LOGIN.Size = new System.Drawing.Size(199, 22);
            this.textbox_LOGIN.TabIndex = 1;
            this.textbox_LOGIN.Text = "admin";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(-22, -12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 428);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vogue-ExtraBold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(127, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AcceptButton = button_LOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button_EXIT;
            this.ClientSize = new System.Drawing.Size(282, 397);
            this.Controls.Add(this.panel4);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FormClosing);
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox textbox_PASSWORD;
        private Button button_LOGIN;
        private Button button_EXIT;
        private Panel panel2;
        private TextBox textbox_LOGIN;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
    }
}