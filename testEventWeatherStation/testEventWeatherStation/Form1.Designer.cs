namespace testEventWeatherStation
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbhumid = new System.Windows.Forms.TextBox();
            this.tbtemp = new System.Windows.Forms.TextBox();
            this.lbreading = new System.Windows.Forms.ListBox();
            this.lbaverage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbhumid
            // 
            this.tbhumid.Location = new System.Drawing.Point(46, 196);
            this.tbhumid.Name = "tbhumid";
            this.tbhumid.Size = new System.Drawing.Size(100, 20);
            this.tbhumid.TabIndex = 1;
            // 
            // tbtemp
            // 
            this.tbtemp.Location = new System.Drawing.Point(46, 151);
            this.tbtemp.Name = "tbtemp";
            this.tbtemp.Size = new System.Drawing.Size(100, 20);
            this.tbtemp.TabIndex = 2;
            // 
            // lbreading
            // 
            this.lbreading.FormattingEnabled = true;
            this.lbreading.Location = new System.Drawing.Point(273, 76);
            this.lbreading.Name = "lbreading";
            this.lbreading.Size = new System.Drawing.Size(233, 95);
            this.lbreading.TabIndex = 3;
            // 
            // lbaverage
            // 
            this.lbaverage.FormattingEnabled = true;
            this.lbaverage.Location = new System.Drawing.Point(273, 196);
            this.lbaverage.Name = "lbaverage";
            this.lbaverage.Size = new System.Drawing.Size(233, 95);
            this.lbaverage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 448);
            this.Controls.Add(this.lbaverage);
            this.Controls.Add(this.lbreading);
            this.Controls.Add(this.tbtemp);
            this.Controls.Add(this.tbhumid);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbhumid;
        private System.Windows.Forms.TextBox tbtemp;
        private System.Windows.Forms.ListBox lbreading;
        private System.Windows.Forms.ListBox lbaverage;
    }
}

