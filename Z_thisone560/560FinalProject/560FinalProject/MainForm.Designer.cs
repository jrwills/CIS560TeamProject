
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.patientButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.addPerson.Location = new System.Drawing.Point(660, 378);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(115, 60);
            this.addPerson.TabIndex = 1;
            this.addPerson.Text = "ADD";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(660, 312);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(115, 60);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "Donors";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Currently viewing: ";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Dubai Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.Location = new System.Drawing.Point(215, 95);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(93, 36);
            this.tableLabel.TabIndex = 4;
            this.tableLabel.Text = "editable";
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(660, 246);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(115, 60);
            this.patientButton.TabIndex = 5;
            this.patientButton.Text = "Patients";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(18, 29);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(156, 20);
            this.searchText.TabIndex = 6;
            this.searchText.Text = "Type Here...";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(180, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(58, 20);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "<- I dont work rn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.dataForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataForm;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
    }
}