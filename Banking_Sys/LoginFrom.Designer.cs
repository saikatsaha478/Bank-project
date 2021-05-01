namespace Banking_Sys
{
    partial class LoginFrom
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_log = new System.Windows.Forms.Button();
            this.lbl_exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_User
            // 
            this.lbl_User.ForeColor = System.Drawing.Color.Red;
            this.lbl_User.Location = new System.Drawing.Point(42, 67);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(85, 23);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "Username";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pass
            // 
            this.lbl_pass.ForeColor = System.Drawing.Color.Red;
            this.lbl_pass.Location = new System.Drawing.Point(45, 104);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(82, 27);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '.';
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(63, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to our Bank";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_log
            // 
            this.lbl_log.Location = new System.Drawing.Point(145, 148);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(75, 23);
            this.lbl_log.TabIndex = 5;
            this.lbl_log.Text = "Sign In";
            this.lbl_log.UseVisualStyleBackColor = true;
            this.lbl_log.Click += new System.EventHandler(this.lbl_log_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.Location = new System.Drawing.Point(239, 148);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(75, 23);
            this.lbl_exit.TabIndex = 6;
            this.lbl_exit.Text = "Exit";
            this.lbl_exit.UseVisualStyleBackColor = true;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(159, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "New user ?";
            // 
            // lbl_sign
            // 
            this.lbl_sign.Location = new System.Drawing.Point(239, 223);
            this.lbl_sign.Name = "lbl_sign";
            this.lbl_sign.Size = new System.Drawing.Size(75, 23);
            this.lbl_sign.TabIndex = 8;
            this.lbl_sign.Text = "Sign up";
            this.lbl_sign.UseVisualStyleBackColor = true;
            this.lbl_sign.Click += new System.EventHandler(this.lbl_sign_Click);
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 272);
            this.Controls.Add(this.lbl_sign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.textBox1);
            this.Name = "LoginFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lbl_log;
        private System.Windows.Forms.Button lbl_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lbl_sign;
    }
}

