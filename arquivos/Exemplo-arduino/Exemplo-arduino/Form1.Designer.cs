namespace Exemplo_arduino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_on
            // 
            this.btn_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_on.Image = ((System.Drawing.Image)(resources.GetObject("btn_on.Image")));
            this.btn_on.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_on.Location = new System.Drawing.Point(47, 12);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(169, 81);
            this.btn_on.TabIndex = 0;
            this.btn_on.Text = "Turn On";
            this.btn_on.UseVisualStyleBackColor = false;
            this.btn_on.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_off
            // 
            this.btn_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_off.Image = ((System.Drawing.Image)(resources.GetObject("btn_off.Image")));
            this.btn_off.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_off.Location = new System.Drawing.Point(47, 135);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(169, 81);
            this.btn_off.TabIndex = 1;
            this.btn_off.Text = "Turn Off";
            this.btn_off.UseVisualStyleBackColor = false;
            this.btn_off.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_off;
    }
}

