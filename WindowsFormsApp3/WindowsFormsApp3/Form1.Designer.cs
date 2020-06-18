namespace WindowsFormsApp3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtmaxtemp = new System.Windows.Forms.TextBox();
            this.txtmintemp = new System.Windows.Forms.TextBox();
            this.txtwindm = new System.Windows.Forms.TextBox();
            this.txtwinddirection = new System.Windows.Forms.TextBox();
            this.txthumidity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max temp (celsius)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min temp (celsius)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wind speed mph";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wind direction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Humidity";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(200, 39);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(136, 20);
            this.txtcity.TabIndex = 6;
            // 
            // txtmaxtemp
            // 
            this.txtmaxtemp.Location = new System.Drawing.Point(200, 92);
            this.txtmaxtemp.Name = "txtmaxtemp";
            this.txtmaxtemp.Size = new System.Drawing.Size(136, 20);
            this.txtmaxtemp.TabIndex = 7;
            // 
            // txtmintemp
            // 
            this.txtmintemp.Location = new System.Drawing.Point(200, 129);
            this.txtmintemp.Name = "txtmintemp";
            this.txtmintemp.Size = new System.Drawing.Size(136, 20);
            this.txtmintemp.TabIndex = 8;
            // 
            // txtwindm
            // 
            this.txtwindm.Location = new System.Drawing.Point(200, 165);
            this.txtwindm.Name = "txtwindm";
            this.txtwindm.Size = new System.Drawing.Size(136, 20);
            this.txtwindm.TabIndex = 9;
            // 
            // txtwinddirection
            // 
            this.txtwinddirection.Location = new System.Drawing.Point(200, 199);
            this.txtwinddirection.Name = "txtwinddirection";
            this.txtwinddirection.Size = new System.Drawing.Size(136, 20);
            this.txtwinddirection.TabIndex = 10;
            // 
            // txthumidity
            // 
            this.txthumidity.Location = new System.Drawing.Point(200, 229);
            this.txthumidity.Name = "txthumidity";
            this.txthumidity.Size = new System.Drawing.Size(136, 20);
            this.txthumidity.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(516, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 75);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Forecast";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(82, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcountry
            // 
            this.txtcountry.Location = new System.Drawing.Point(557, 32);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(100, 20);
            this.txtcountry.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Country code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(683, 328);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txthumidity);
            this.Controls.Add(this.txtwinddirection);
            this.Controls.Add(this.txtwindm);
            this.Controls.Add(this.txtmintemp);
            this.Controls.Add(this.txtmaxtemp);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weather API";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtmaxtemp;
        private System.Windows.Forms.TextBox txtmintemp;
        private System.Windows.Forms.TextBox txtwindm;
        private System.Windows.Forms.TextBox txtwinddirection;
        private System.Windows.Forms.TextBox txthumidity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.Label label8;
    }
}

