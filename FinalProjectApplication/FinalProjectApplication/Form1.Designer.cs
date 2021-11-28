
namespace FinalProjectApplication
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testDatabaseDataSet = new FinalProjectApplication.TestDatabaseDataSet();
            this.personalDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalDetailsTableAdapter = new FinalProjectApplication.TestDatabaseDataSetTableAdapters.PersonalDetailsTableAdapter();
            this.testDatabaseDataSet1 = new FinalProjectApplication.TestDatabaseDataSet();
            this.testDatabase2DataSet = new FinalProjectApplication.TestDatabase2DataSet();
            this.personalDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personalDetailsTableAdapter1 = new FinalProjectApplication.TestDatabase2DataSetTableAdapters.PersonalDetailsTableAdapter();
            this.testDatabaseDataSet2 = new FinalProjectApplication.TestDatabaseDataSet();
            this.testDatabase2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabase2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "hello";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // testDatabaseDataSet
            // 
            this.testDatabaseDataSet.DataSetName = "TestDatabaseDataSet";
            this.testDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalDetailsBindingSource
            // 
            this.personalDetailsBindingSource.DataMember = "PersonalDetails";
            this.personalDetailsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // personalDetailsTableAdapter
            // 
            this.personalDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // testDatabaseDataSet1
            // 
            this.testDatabaseDataSet1.DataSetName = "TestDatabaseDataSet";
            this.testDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDatabase2DataSet
            // 
            this.testDatabase2DataSet.DataSetName = "TestDatabase2DataSet";
            this.testDatabase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalDetailsBindingSource1
            // 
            this.personalDetailsBindingSource1.DataMember = "PersonalDetails";
            this.personalDetailsBindingSource1.DataSource = this.testDatabase2DataSet;
            // 
            // personalDetailsTableAdapter1
            // 
            this.personalDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // testDatabaseDataSet2
            // 
            this.testDatabaseDataSet2.DataSetName = "TestDatabaseDataSet";
            this.testDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDatabase2DataSetBindingSource
            // 
            this.testDatabase2DataSetBindingSource.DataSource = this.testDatabase2DataSet;
            this.testDatabase2DataSetBindingSource.Position = 0;
            // 
            // dataForm
            // 
            this.dataForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataForm.Location = new System.Drawing.Point(162, 224);
            this.dataForm.Name = "dataForm";
            this.dataForm.Size = new System.Drawing.Size(530, 150);
            this.dataForm.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabase2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TestDatabaseDataSet testDatabaseDataSet;
        private System.Windows.Forms.BindingSource personalDetailsBindingSource;
        private TestDatabaseDataSetTableAdapters.PersonalDetailsTableAdapter personalDetailsTableAdapter;
        private TestDatabaseDataSet testDatabaseDataSet1;
        private TestDatabase2DataSet testDatabase2DataSet;
        private System.Windows.Forms.BindingSource personalDetailsBindingSource1;
        private TestDatabase2DataSetTableAdapters.PersonalDetailsTableAdapter personalDetailsTableAdapter1;
        private TestDatabaseDataSet testDatabaseDataSet2;
        private System.Windows.Forms.BindingSource testDatabase2DataSetBindingSource;
        private System.Windows.Forms.DataGridView dataForm;
    }
}

