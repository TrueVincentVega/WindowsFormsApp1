namespace WindowsFormsApp1
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.autorization_label = new System.Windows.Forms.Label();
            this.information_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.accept_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autorization_label
            // 
            this.autorization_label.AutoSize = true;
            this.autorization_label.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorization_label.Location = new System.Drawing.Point(133, 21);
            this.autorization_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autorization_label.Name = "autorization_label";
            this.autorization_label.Size = new System.Drawing.Size(174, 25);
            this.autorization_label.TabIndex = 0;
            this.autorization_label.Text = "Authorization";
            // 
            // information_label
            // 
            this.information_label.AutoSize = true;
            this.information_label.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.information_label.Location = new System.Drawing.Point(8, 71);
            this.information_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.information_label.Name = "information_label";
            this.information_label.Size = new System.Drawing.Size(398, 17);
            this.information_label.TabIndex = 1;
            this.information_label.Text = "Incorrect login or password. Try again.";
            this.information_label.Visible = false;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(73, 116);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(74, 17);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(171, 116);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(171, 21);
            this.textBox_login.TabIndex = 4;
            this.textBox_login.Text = "root";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(171, 151);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(171, 21);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.Text = "12345678";
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // accept_button
            // 
            this.accept_button.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accept_button.Location = new System.Drawing.Point(156, 193);
            this.accept_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(112, 23);
            this.accept_button.TabIndex = 6;
            this.accept_button.Text = "Accept";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 228);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.information_label);
            this.Controls.Add(this.autorization_label);
            this.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autorization_label;
        private System.Windows.Forms.Label information_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button accept_button;
    }
}