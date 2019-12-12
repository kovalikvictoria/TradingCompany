namespace Forms
{
    partial class LoginForm
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
            this.button_create_account = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_create_account
            // 
            this.button_create_account.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_create_account.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_create_account.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_create_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_account.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_create_account.Location = new System.Drawing.Point(54, 162);
            this.button_create_account.Name = "button_create_account";
            this.button_create_account.Size = new System.Drawing.Size(296, 31);
            this.button_create_account.TabIndex = 5;
            this.button_create_account.Text = "Create Account";
            this.button_create_account.UseVisualStyleBackColor = false;
            this.button_create_account.Click += new System.EventHandler(this.button_create_account_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.SystemColors.Control;
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textbox_password.Location = new System.Drawing.Point(137, 77);
            this.textbox_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(213, 28);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.UseSystemPasswordChar = true;
            // 
            // textbox_login
            // 
            this.textbox_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_login.Location = new System.Drawing.Point(137, 43);
            this.textbox_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(213, 28);
            this.textbox_login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(254, 200);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(96, 31);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_sign_in
            // 
            this.button_sign_in.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_sign_in.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sign_in.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign_in.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_sign_in.Location = new System.Drawing.Point(54, 125);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Size = new System.Drawing.Size(296, 31);
            this.button_sign_in.TabIndex = 7;
            this.button_sign_in.Text = "Sign In";
            this.button_sign_in.UseVisualStyleBackColor = false;
            this.button_sign_in.Click += new System.EventHandler(this.button_sign_in_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(398, 274);
            this.Controls.Add(this.button_sign_in);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_create_account);
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(460, 380);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(420, 360);
            this.MinimumSize = new System.Drawing.Size(420, 330);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create_account;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_sign_in;
    }
}