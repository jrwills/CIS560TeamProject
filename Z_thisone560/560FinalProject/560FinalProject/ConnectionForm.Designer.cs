
namespace _560FinalProject
{
    partial class ConnectionForm
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
            this.connLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connLabel
            // 
            this.connLabel.AutoSize = true;
            this.connLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.connLabel.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connLabel.Location = new System.Drawing.Point(-12, 86);
            this.connLabel.Name = "connLabel";
            this.connLabel.Size = new System.Drawing.Size(425, 37);
            this.connLabel.TabIndex = 1;
            this.connLabel.Text = "Welcome to the Health Database System";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(377, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connLabel);
            this.Name = "ConnectionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label connLabel;
        private System.Windows.Forms.Button button1;
    }
}

