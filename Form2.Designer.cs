namespace Contact_Tracing_App
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Contact_Tracing_App.Database1DataSet();
            this.contactTracingRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contact_Tracing_RecordsTableAdapter = new Contact_Tracing_App.Database1DataSetTableAdapters.Contact_Tracing_RecordsTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfPersonYouWantToVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitingPurposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dryCoughDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.feverDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.difficultyInBreathingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.achesPainDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTracingRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepPink;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barangay San Jose Antipolo City Contact Tracing";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.homeAddressDataGridViewTextBoxColumn,
            this.dateOfVisitDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.nameOfPersonYouWantToVisitDataGridViewTextBoxColumn,
            this.visitingPurposeDataGridViewTextBoxColumn,
            this.dryCoughDataGridViewCheckBoxColumn,
            this.feverDataGridViewCheckBoxColumn,
            this.difficultyInBreathingDataGridViewCheckBoxColumn,
            this.achesPainDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.contactTracingRecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 305);
            this.dataGridView1.TabIndex = 3;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactTracingRecordsBindingSource
            // 
            this.contactTracingRecordsBindingSource.DataMember = "Contact Tracing Records";
            this.contactTracingRecordsBindingSource.DataSource = this.database1DataSet;
            // 
            // contact_Tracing_RecordsTableAdapter
            // 
            this.contact_Tracing_RecordsTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // homeAddressDataGridViewTextBoxColumn
            // 
            this.homeAddressDataGridViewTextBoxColumn.DataPropertyName = "Home Address";
            this.homeAddressDataGridViewTextBoxColumn.HeaderText = "Home Address";
            this.homeAddressDataGridViewTextBoxColumn.Name = "homeAddressDataGridViewTextBoxColumn";
            // 
            // dateOfVisitDataGridViewTextBoxColumn
            // 
            this.dateOfVisitDataGridViewTextBoxColumn.DataPropertyName = "Date of Visit";
            this.dateOfVisitDataGridViewTextBoxColumn.HeaderText = "Date of Visit";
            this.dateOfVisitDataGridViewTextBoxColumn.Name = "dateOfVisitDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // nameOfPersonYouWantToVisitDataGridViewTextBoxColumn
            // 
            this.nameOfPersonYouWantToVisitDataGridViewTextBoxColumn.DataPropertyName = "Name of Person You Want to Visit";
            this.nameOfPersonYouWantToVisitDataGridViewTextBoxColumn.HeaderText = "Name of Person You Want to Visit";
            this.nameOfPersonYouWantToVisitDataGridViewTextBoxColumn.Name = "nameOfPersonYouWantToVisitDataGridViewTextBoxColumn";
            // 
            // visitingPurposeDataGridViewTextBoxColumn
            // 
            this.visitingPurposeDataGridViewTextBoxColumn.DataPropertyName = "Visiting Purpose";
            this.visitingPurposeDataGridViewTextBoxColumn.HeaderText = "Visiting Purpose";
            this.visitingPurposeDataGridViewTextBoxColumn.Name = "visitingPurposeDataGridViewTextBoxColumn";
            // 
            // dryCoughDataGridViewCheckBoxColumn
            // 
            this.dryCoughDataGridViewCheckBoxColumn.DataPropertyName = "Dry Cough";
            this.dryCoughDataGridViewCheckBoxColumn.HeaderText = "Dry Cough";
            this.dryCoughDataGridViewCheckBoxColumn.Name = "dryCoughDataGridViewCheckBoxColumn";
            // 
            // feverDataGridViewCheckBoxColumn
            // 
            this.feverDataGridViewCheckBoxColumn.DataPropertyName = "Fever";
            this.feverDataGridViewCheckBoxColumn.HeaderText = "Fever";
            this.feverDataGridViewCheckBoxColumn.Name = "feverDataGridViewCheckBoxColumn";
            // 
            // difficultyInBreathingDataGridViewCheckBoxColumn
            // 
            this.difficultyInBreathingDataGridViewCheckBoxColumn.DataPropertyName = "Difficulty in Breathing";
            this.difficultyInBreathingDataGridViewCheckBoxColumn.HeaderText = "Difficulty in Breathing";
            this.difficultyInBreathingDataGridViewCheckBoxColumn.Name = "difficultyInBreathingDataGridViewCheckBoxColumn";
            // 
            // achesPainDataGridViewCheckBoxColumn
            // 
            this.achesPainDataGridViewCheckBoxColumn.DataPropertyName = "Aches/Pain";
            this.achesPainDataGridViewCheckBoxColumn.HeaderText = "Aches/Pain";
            this.achesPainDataGridViewCheckBoxColumn.Name = "achesPainDataGridViewCheckBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.stop_fight_coronavirus_background_44481_403;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Barangay San Jose Antipolo City Contact Tracing";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTracingRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource contactTracingRecordsBindingSource;
        private Database1DataSetTableAdapters.Contact_Tracing_RecordsTableAdapter contact_Tracing_RecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfPersonYouWantToVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitingPurposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dryCoughDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn feverDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn difficultyInBreathingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn achesPainDataGridViewCheckBoxColumn;
    }
}