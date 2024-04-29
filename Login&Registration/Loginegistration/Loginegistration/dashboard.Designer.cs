namespace Loginegistration
{
    partial class dashboard
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
            dataGridView1 = new DataGridView();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(330, 401);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.Hand;
            txtPassword.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(358, 170);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 34);
            txtPassword.TabIndex = 20;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Green;
            label3.Location = new Point(358, 146);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 19;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Cursor = Cursors.Hand;
            txtUsername.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(358, 103);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 34);
            txtUsername.TabIndex = 18;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Green;
            label2.Location = new Point(358, 79);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 17;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(359, 248);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(239, 43);
            button1.TabIndex = 21;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(358, 325);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(239, 43);
            button2.TabIndex = 22;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(358, 387);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(239, 43);
            button3.TabIndex = 23;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(613, 535);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}