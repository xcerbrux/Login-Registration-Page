namespace Loginegistration
{
    partial class frmRegister
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(28, 62);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 112);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.Hand;
            txtUsername.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(28, 129);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 26);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 174);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.Hand;
            txtPassword.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(28, 191);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 26);
            txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 244);
            label4.Name = "label4";
            label4.Size = new Size(142, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Cursor = Cursors.Hand;
            txtConfirmPassword.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(28, 261);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(210, 26);
            txtConfirmPassword.TabIndex = 6;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.Location = new Point(126, 293);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(146, 21);
            checkBoxShowPassword.TabIndex = 7;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(28, 325);
            button1.Name = "button1";
            button1.Size = new Size(216, 32);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Fuchsia;
            button2.Location = new Point(28, 373);
            button2.Name = "button2";
            button2.Size = new Size(216, 32);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(29, 436);
            label5.Name = "label5";
            label5.Size = new Size(215, 20);
            label5.TabIndex = 10;
            label5.Text = "Already Have an Account";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Fuchsia;
            label6.Location = new Point(76, 465);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 11;
            label6.Text = "Back to Login";
            label6.Click += label6_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(280, 535);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtConfirmPassword;
        private CheckBox checkBoxShowPassword;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}
