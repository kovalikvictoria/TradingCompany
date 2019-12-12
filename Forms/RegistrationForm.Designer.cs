namespace Forms
{
    partial class RegistrationForm
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.label_pwd2 = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_pwd2 = new System.Windows.Forms.TextBox();
            this.textbox_pwd = new System.Windows.Forms.TextBox();
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_age = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(55, 56);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(62, 22);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(55, 96);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(47, 22);
            this.label_age.TabIndex = 2;
            this.label_age.Text = "Age:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(55, 136);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(59, 22);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Login:";
            this.label_login.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwd.Location = new System.Drawing.Point(55, 176);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(94, 22);
            this.label_pwd.TabIndex = 4;
            this.label_pwd.Text = "Password:";
            // 
            // label_pwd2
            // 
            this.label_pwd2.AutoSize = true;
            this.label_pwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwd2.Location = new System.Drawing.Point(55, 216);
            this.label_pwd2.Name = "label_pwd2";
            this.label_pwd2.Size = new System.Drawing.Size(157, 22);
            this.label_pwd2.TabIndex = 5;
            this.label_pwd2.Text = "Repeat Password:";
            this.label_pwd2.Click += new System.EventHandler(this.label4_Click);
            // 
            // textbox_name
            // 
            this.textbox_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_name.Location = new System.Drawing.Point(241, 50);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(236, 28);
            this.textbox_name.TabIndex = 1;
            // 
            // textbox_pwd2
            // 
            this.textbox_pwd2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox_pwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_pwd2.Location = new System.Drawing.Point(241, 210);
            this.textbox_pwd2.Name = "textbox_pwd2";
            this.textbox_pwd2.PasswordChar = '*';
            this.textbox_pwd2.Size = new System.Drawing.Size(236, 28);
            this.textbox_pwd2.TabIndex = 5;
            this.textbox_pwd2.UseSystemPasswordChar = true;
            // 
            // textbox_pwd
            // 
            this.textbox_pwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_pwd.Location = new System.Drawing.Point(241, 170);
            this.textbox_pwd.Name = "textbox_pwd";
            this.textbox_pwd.PasswordChar = '*';
            this.textbox_pwd.Size = new System.Drawing.Size(236, 28);
            this.textbox_pwd.TabIndex = 4;
            this.textbox_pwd.UseSystemPasswordChar = true;
            // 
            // textbox_login
            // 
            this.textbox_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_login.Location = new System.Drawing.Point(241, 130);
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(236, 28);
            this.textbox_login.TabIndex = 3;
            // 
            // textbox_age
            // 
            this.textbox_age.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_age.Location = new System.Drawing.Point(241, 90);
            this.textbox_age.Name = "textbox_age";
            this.textbox_age.Size = new System.Drawing.Size(236, 28);
            this.textbox_age.TabIndex = 2;
            // 
            // button_create
            // 
            this.button_create.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_create.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.Location = new System.Drawing.Point(57, 297);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(204, 37);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(285, 297);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(191, 37);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(533, 373);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textbox_age);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.textbox_pwd);
            this.Controls.Add(this.textbox_pwd2);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_pwd2);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Name = "RegistrationForm";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Label label_pwd2;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_pwd2;
        private System.Windows.Forms.TextBox textbox_pwd;
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_age;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_cancel;
    }
}