﻿namespace EventsPracticeCode
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
            this.btnRaiseTheEvent = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRaiseTheEvent
            // 
            this.btnRaiseTheEvent.Location = new System.Drawing.Point(75, 55);
            this.btnRaiseTheEvent.Name = "btnRaiseTheEvent";
            this.btnRaiseTheEvent.Size = new System.Drawing.Size(195, 59);
            this.btnRaiseTheEvent.TabIndex = 0;
            this.btnRaiseTheEvent.Text = "Raise The Event";
            this.btnRaiseTheEvent.UseVisualStyleBackColor = true;
            this.btnRaiseTheEvent.Click += new System.EventHandler(this.btnRaiseTheEvent_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(79, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(663, 436);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 712);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRaiseTheEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaiseTheEvent;
        private System.Windows.Forms.ListBox listBox1;
    }
}

