
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
            this.medicalButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.q1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataForm
            // 
            this.dataForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataForm.Location = new System.Drawing.Point(18, 134);
            this.dataForm.Name = "dataForm";
            this.dataForm.Size = new System.Drawing.Size(649, 304);
            this.dataForm.TabIndex = 0;
            // 
            // addPerson
            // 
            this.addPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPerson.Location = new System.Drawing.Point(673, 114);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(115, 60);
            this.addPerson.TabIndex = 1;
            this.addPerson.Text = "ADD";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // queryButton
            // 
            this.queryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.queryButton.Location = new System.Drawing.Point(673, 378);
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
            this.patientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.patientButton.Location = new System.Drawing.Point(673, 312);
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
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "^ UniqueID only";
            // 
            // medicalButton
            // 
            this.medicalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.medicalButton.Location = new System.Drawing.Point(673, 246);
            this.medicalButton.Name = "medicalButton";
            this.medicalButton.Size = new System.Drawing.Size(115, 60);
            this.medicalButton.TabIndex = 9;
            this.medicalButton.Text = "Medical";
            this.medicalButton.UseVisualStyleBackColor = true;
            this.medicalButton.Click += new System.EventHandler(this.medicalButton_Click);
            // 
            // allButton
            // 
            this.allButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.allButton.Location = new System.Drawing.Point(673, 180);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(115, 60);
            this.allButton.TabIndex = 10;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // q1Button
            // 
            this.q1Button.Location = new System.Drawing.Point(260, 12);
            this.q1Button.Name = "q1Button";
            this.q1Button.Size = new System.Drawing.Size(96, 47);
            this.q1Button.TabIndex = 11;
            this.q1Button.Text = "Blood Donations";
            this.q1Button.UseVisualStyleBackColor = true;
            this.q1Button.Click += new System.EventHandler(this.q1Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.q1Button);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.medicalButton);
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
        private System.Windows.Forms.Button medicalButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button q1Button;
    }
}