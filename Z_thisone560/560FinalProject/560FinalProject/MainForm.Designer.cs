
namespace _560FinalProject
{
    partial class MainForm
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
            this.dataForm = new System.Windows.Forms.DataGridView();
            this.addPerson = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataForm
            // 
            this.dataForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataForm.Location = new System.Drawing.Point(12, 134);
            this.dataForm.Name = "dataForm";
            this.dataForm.Size = new System.Drawing.Size(619, 304);
            this.dataForm.TabIndex = 0;
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(12, 12);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(115, 60);
            this.addPerson.TabIndex = 1;
            this.addPerson.Text = "ADD";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(159, 12);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(115, 60);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "Query one";
            this.queryButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.dataForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataForm;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.Button queryButton;
    }
}