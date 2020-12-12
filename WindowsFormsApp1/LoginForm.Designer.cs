
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.accept_button = new System.Windows.Forms.Button();
            this.authorization_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(45, 85);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(74, 17);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(12, 119);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(107, 17);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password:";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(126, 85);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(138, 21);
            this.login_textBox.TabIndex = 2;
            this.login_textBox.Text = "root";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(126, 119);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(138, 21);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.Text = "12345678";
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // accept_button
            // 
            this.accept_button.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_button.ForeColor = System.Drawing.Color.Black;
            this.accept_button.Location = new System.Drawing.Point(126, 155);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(72, 23);
            this.accept_button.TabIndex = 4;
            this.accept_button.Text = "Accept";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // authorization_label
            // 
            this.authorization_label.AutoSize = true;
            this.authorization_label.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorization_label.Location = new System.Drawing.Point(73, 19);
            this.authorization_label.Name = "authorization_label";
            this.authorization_label.Size = new System.Drawing.Size(172, 22);
            this.authorization_label.TabIndex = 5;
            this.authorization_label.Text = "Authorization";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_label.ForeColor = System.Drawing.Color.Tomato;
            this.info_label.Location = new System.Drawing.Point(32, 54);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(258, 19);
            this.info_label.TabIndex = 6;
            this.info_label.Text = "Incorrect login or password";
            this.info_label.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 190);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.authorization_label);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label authorization_label;
        private System.Windows.Forms.Label info_label;
    }
}