namespace Banking_Sys
{
    partial class Menu2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_pass = new System.Windows.Forms.Button();
            this.btn_fd = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.textBox_show = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_log);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_pass);
            this.groupBox1.Controls.Add(this.btn_fd);
            this.groupBox1.Controls.Add(this.btn_transfer);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 356);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(9, 317);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(86, 31);
            this.btn_log.TabIndex = 6;
            this.btn_log.Text = "Log out";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_pass
            // 
            this.btn_pass.Location = new System.Drawing.Point(6, 280);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(86, 31);
            this.btn_pass.TabIndex = 4;
            this.btn_pass.Text = "Change Pass";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // btn_fd
            // 
            this.btn_fd.Location = new System.Drawing.Point(6, 243);
            this.btn_fd.Name = "btn_fd";
            this.btn_fd.Size = new System.Drawing.Size(86, 31);
            this.btn_fd.TabIndex = 3;
            this.btn_fd.Text = "Fixed Deposit";
            this.btn_fd.UseVisualStyleBackColor = true;
            this.btn_fd.Click += new System.EventHandler(this.btn_fd_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(6, 206);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(86, 31);
            this.btn_transfer.TabIndex = 2;
            this.btn_transfer.Text = "Transfer Credit";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_show);
            this.groupBox2.Controls.Add(this.textBox_show);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(0, 69);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(59, 25);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // textBox_show
            // 
            this.textBox_show.Location = new System.Drawing.Point(0, 43);
            this.textBox_show.Name = "textBox_show";
            this.textBox_show.Size = new System.Drawing.Size(134, 20);
            this.textBox_show.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Show Profile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(184, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 356);
            this.dataGridView1.TabIndex = 3;
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 404);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu2";
            this.Text = "Menu2";
            this.Load += new System.EventHandler(this.Menu2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Button btn_fd;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox textBox_show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_log;
    }
}