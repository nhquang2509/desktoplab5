﻿namespace lab5
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
            this.btnJSon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJSon
            // 
            this.btnJSon.Location = new System.Drawing.Point(298, 100);
            this.btnJSon.Name = "btnJSon";
            this.btnJSon.Size = new System.Drawing.Size(75, 23);
            this.btnJSon.TabIndex = 0;
            this.btnJSon.Text = "JSon";
            this.btnJSon.UseVisualStyleBackColor = true;
            this.btnJSon.Click += new System.EventHandler(this.btnJSon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJSon;
    }
}

