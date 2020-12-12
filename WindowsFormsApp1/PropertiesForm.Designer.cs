
namespace WindowsFormsApp1
{
    partial class PropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesForm));
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.trackBar_green = new System.Windows.Forms.TrackBar();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.red_label = new System.Windows.Forms.Label();
            this.green_label = new System.Windows.Forms.Label();
            this.blue_label = new System.Windows.Forms.Label();
            this.customize_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_red
            // 
            this.trackBar_red.LargeChange = 1;
            this.trackBar_red.Location = new System.Drawing.Point(138, 65);
            this.trackBar_red.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.Size = new System.Drawing.Size(426, 45);
            this.trackBar_red.TabIndex = 0;
            this.trackBar_red.Value = 255;
            // 
            // trackBar_green
            // 
            this.trackBar_green.LargeChange = 1;
            this.trackBar_green.Location = new System.Drawing.Point(138, 116);
            this.trackBar_green.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_green.Maximum = 255;
            this.trackBar_green.Name = "trackBar_green";
            this.trackBar_green.Size = new System.Drawing.Size(426, 45);
            this.trackBar_green.TabIndex = 1;
            this.trackBar_green.Value = 255;
            // 
            // trackBar_blue
            // 
            this.trackBar_blue.LargeChange = 1;
            this.trackBar_blue.Location = new System.Drawing.Point(138, 165);
            this.trackBar_blue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.Size = new System.Drawing.Size(426, 45);
            this.trackBar_blue.TabIndex = 2;
            this.trackBar_blue.Value = 255;
            // 
            // red_label
            // 
            this.red_label.AutoSize = true;
            this.red_label.ForeColor = System.Drawing.Color.Red;
            this.red_label.Location = new System.Drawing.Point(21, 76);
            this.red_label.Name = "red_label";
            this.red_label.Size = new System.Drawing.Size(88, 13);
            this.red_label.TabIndex = 3;
            this.red_label.Text = "Red color";
            // 
            // green_label
            // 
            this.green_label.AutoSize = true;
            this.green_label.ForeColor = System.Drawing.Color.Green;
            this.green_label.Location = new System.Drawing.Point(21, 127);
            this.green_label.Name = "green_label";
            this.green_label.Size = new System.Drawing.Size(106, 13);
            this.green_label.TabIndex = 4;
            this.green_label.Text = "Green color";
            // 
            // blue_label
            // 
            this.blue_label.AutoSize = true;
            this.blue_label.ForeColor = System.Drawing.Color.Blue;
            this.blue_label.Location = new System.Drawing.Point(21, 175);
            this.blue_label.Name = "blue_label";
            this.blue_label.Size = new System.Drawing.Size(97, 13);
            this.blue_label.TabIndex = 5;
            this.blue_label.Text = "Blue color";
            // 
            // customize_label
            // 
            this.customize_label.AutoSize = true;
            this.customize_label.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customize_label.Location = new System.Drawing.Point(134, 25);
            this.customize_label.Name = "customize_label";
            this.customize_label.Size = new System.Drawing.Size(261, 20);
            this.customize_label.TabIndex = 6;
            this.customize_label.Text = "Customize your window";
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 222);
            this.Controls.Add(this.customize_label);
            this.Controls.Add(this.blue_label);
            this.Controls.Add(this.green_label);
            this.Controls.Add(this.red_label);
            this.Controls.Add(this.trackBar_blue);
            this.Controls.Add(this.trackBar_green);
            this.Controls.Add(this.trackBar_red);
            this.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesForm";
            this.Text = "PropertiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.TrackBar trackBar_green;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.Label red_label;
        private System.Windows.Forms.Label green_label;
        private System.Windows.Forms.Label blue_label;
        private System.Windows.Forms.Label customize_label;
    }
}