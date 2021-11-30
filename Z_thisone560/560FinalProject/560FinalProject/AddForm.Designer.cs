
namespace _560FinalProject
{
    partial class AddForm
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
            this.firstText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.genderListbox = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.streetText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(122, 90);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(172, 20);
            this.firstText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // lastText
            // 
            this.lastText.Location = new System.Drawing.Point(122, 135);
            this.lastText.Name = "lastText";
            this.lastText.Size = new System.Drawing.Size(172, 20);
            this.lastText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(122, 182);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(172, 20);
            this.emailText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number:";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(122, 227);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(172, 20);
            this.phoneText.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(590, 318);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 68);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // genderListbox
            // 
            this.genderListbox.FormattingEnabled = true;
            this.genderListbox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderListbox.Location = new System.Drawing.Point(523, 79);
            this.genderListbox.Name = "genderListbox";
            this.genderListbox.Size = new System.Drawing.Size(137, 49);
            this.genderListbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic Semilight", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 45);
            this.label7.TabIndex = 16;
            this.label7.Text = "User Information:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Street:";
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(122, 268);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(172, 20);
            this.streetText.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "UniqueID:";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(122, 311);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(172, 20);
            this.idText.TabIndex = 20;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.streetText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderListbox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstText);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox genderListbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idText;
    }
}