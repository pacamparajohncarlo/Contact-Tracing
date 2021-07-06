namespace Contact_Tracing_App
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.brgyaddress = new System.Windows.Forms.Label();
            this.namebttn = new System.Windows.Forms.Label();
            this.addressbttn = new System.Windows.Forms.Label();
            this.datevisit = new System.Windows.Forms.Label();
            this.bdaybttn = new System.Windows.Forms.Label();
            this.purposevisit = new System.Windows.Forms.Label();
            this.symptoms = new System.Windows.Forms.Label();
            this.drycough = new System.Windows.Forms.Label();
            this.fever = new System.Windows.Forms.Label();
            this.breathing = new System.Windows.Forms.Label();
            this.aches = new System.Windows.Forms.Label();
            this.namewantvst = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxnamevst = new System.Windows.Forms.TextBox();
            this.textBoxpurpose = new System.Windows.Forms.TextBox();
            this.savebttn = new System.Windows.Forms.Button();
            this.infoCT = new System.Windows.Forms.Label();
            this.yes1 = new System.Windows.Forms.CheckBox();
            this.yes2 = new System.Windows.Forms.CheckBox();
            this.yes3 = new System.Windows.Forms.CheckBox();
            this.yes4 = new System.Windows.Forms.CheckBox();
            this.no1 = new System.Windows.Forms.CheckBox();
            this.no2 = new System.Windows.Forms.CheckBox();
            this.no3 = new System.Windows.Forms.CheckBox();
            this.no4 = new System.Windows.Forms.CheckBox();
            this.viewrecords = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.database1DataSet = new Contact_Tracing_App.Database1DataSet();
            this.contactTracingRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contact_Tracing_RecordsTableAdapter = new Contact_Tracing_App.Database1DataSetTableAdapters.Contact_Tracing_RecordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTracingRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brgyaddress
            // 
            this.brgyaddress.AutoSize = true;
            this.brgyaddress.BackColor = System.Drawing.Color.White;
            this.brgyaddress.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brgyaddress.Location = new System.Drawing.Point(91, 34);
            this.brgyaddress.Name = "brgyaddress";
            this.brgyaddress.Size = new System.Drawing.Size(585, 27);
            this.brgyaddress.TabIndex = 0;
            this.brgyaddress.Text = "Sitio Paenaan Barangay San Jose Antipolo City";
            // 
            // namebttn
            // 
            this.namebttn.AutoSize = true;
            this.namebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebttn.Location = new System.Drawing.Point(55, 96);
            this.namebttn.Name = "namebttn";
            this.namebttn.Size = new System.Drawing.Size(53, 16);
            this.namebttn.TabIndex = 2;
            this.namebttn.Text = "Name:";
            // 
            // addressbttn
            // 
            this.addressbttn.AutoSize = true;
            this.addressbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressbttn.Location = new System.Drawing.Point(55, 121);
            this.addressbttn.Name = "addressbttn";
            this.addressbttn.Size = new System.Drawing.Size(115, 16);
            this.addressbttn.TabIndex = 3;
            this.addressbttn.Text = "Home Address:";
            // 
            // datevisit
            // 
            this.datevisit.AutoSize = true;
            this.datevisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datevisit.Location = new System.Drawing.Point(55, 146);
            this.datevisit.Name = "datevisit";
            this.datevisit.Size = new System.Drawing.Size(79, 16);
            this.datevisit.TabIndex = 4;
            this.datevisit.Text = "Date Visit:";
            // 
            // bdaybttn
            // 
            this.bdaybttn.AutoSize = true;
            this.bdaybttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdaybttn.Location = new System.Drawing.Point(55, 172);
            this.bdaybttn.Name = "bdaybttn";
            this.bdaybttn.Size = new System.Drawing.Size(92, 16);
            this.bdaybttn.TabIndex = 5;
            this.bdaybttn.Text = "Day of Birth:";
            // 
            // purposevisit
            // 
            this.purposevisit.AutoSize = true;
            this.purposevisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purposevisit.Location = new System.Drawing.Point(55, 224);
            this.purposevisit.Name = "purposevisit";
            this.purposevisit.Size = new System.Drawing.Size(125, 16);
            this.purposevisit.TabIndex = 6;
            this.purposevisit.Text = "Visiting Purpose:";
            // 
            // symptoms
            // 
            this.symptoms.AutoSize = true;
            this.symptoms.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms.Location = new System.Drawing.Point(55, 249);
            this.symptoms.Name = "symptoms";
            this.symptoms.Size = new System.Drawing.Size(487, 16);
            this.symptoms.TabIndex = 7;
            this.symptoms.Text = "Have you Encounter Some Common Covid Symptoms? (Yer or No)";
            // 
            // drycough
            // 
            this.drycough.AutoSize = true;
            this.drycough.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drycough.Location = new System.Drawing.Point(55, 273);
            this.drycough.Name = "drycough";
            this.drycough.Size = new System.Drawing.Size(84, 16);
            this.drycough.TabIndex = 8;
            this.drycough.Text = "Dry Cough:";
            // 
            // fever
            // 
            this.fever.AutoSize = true;
            this.fever.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fever.Location = new System.Drawing.Point(56, 297);
            this.fever.Name = "fever";
            this.fever.Size = new System.Drawing.Size(52, 16);
            this.fever.TabIndex = 9;
            this.fever.Text = "Fever:";
            // 
            // breathing
            // 
            this.breathing.AutoSize = true;
            this.breathing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathing.Location = new System.Drawing.Point(55, 322);
            this.breathing.Name = "breathing";
            this.breathing.Size = new System.Drawing.Size(157, 16);
            this.breathing.TabIndex = 10;
            this.breathing.Text = "Difficulty in Breathing:";
            // 
            // aches
            // 
            this.aches.AutoSize = true;
            this.aches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aches.Location = new System.Drawing.Point(56, 347);
            this.aches.Name = "aches";
            this.aches.Size = new System.Drawing.Size(91, 16);
            this.aches.TabIndex = 11;
            this.aches.Text = "Aches/Pain:";
            // 
            // namewantvst
            // 
            this.namewantvst.AutoSize = true;
            this.namewantvst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namewantvst.Location = new System.Drawing.Point(55, 198);
            this.namewantvst.Name = "namewantvst";
            this.namewantvst.Size = new System.Drawing.Size(236, 16);
            this.namewantvst.TabIndex = 12;
            this.namewantvst.Text = "Name of Person you want to visit:";
            this.namewantvst.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTracingRecordsBindingSource, "Name", true));
            this.textBoxname.Location = new System.Drawing.Point(114, 94);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(375, 20);
            this.textBoxname.TabIndex = 13;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTracingRecordsBindingSource, "Home Address", true));
            this.textBoxaddress.Location = new System.Drawing.Point(176, 117);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(524, 20);
            this.textBoxaddress.TabIndex = 14;
            // 
            // textBoxnamevst
            // 
            this.textBoxnamevst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTracingRecordsBindingSource, "Name of Person You Want to Visit", true));
            this.textBoxnamevst.Location = new System.Drawing.Point(297, 198);
            this.textBoxnamevst.Name = "textBoxnamevst";
            this.textBoxnamevst.Size = new System.Drawing.Size(362, 20);
            this.textBoxnamevst.TabIndex = 17;
            // 
            // textBoxpurpose
            // 
            this.textBoxpurpose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactTracingRecordsBindingSource, "Visiting Purpose", true));
            this.textBoxpurpose.Location = new System.Drawing.Point(186, 220);
            this.textBoxpurpose.Name = "textBoxpurpose";
            this.textBoxpurpose.Size = new System.Drawing.Size(265, 20);
            this.textBoxpurpose.TabIndex = 18;
            this.textBoxpurpose.TextChanged += new System.EventHandler(this.TextBoxpurpose_TextChanged);
            // 
            // savebttn
            // 
            this.savebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebttn.Location = new System.Drawing.Point(346, 373);
            this.savebttn.Name = "savebttn";
            this.savebttn.Size = new System.Drawing.Size(105, 27);
            this.savebttn.TabIndex = 23;
            this.savebttn.Text = "Save";
            this.savebttn.UseVisualStyleBackColor = true;
            this.savebttn.Click += new System.EventHandler(this.Savebttn_Click);
            // 
            // infoCT
            // 
            this.infoCT.AutoSize = true;
            this.infoCT.Location = new System.Drawing.Point(660, 428);
            this.infoCT.Name = "infoCT";
            this.infoCT.Size = new System.Drawing.Size(0, 13);
            this.infoCT.TabIndex = 24;
            // 
            // yes1
            // 
            this.yes1.AutoSize = true;
            this.yes1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Dry Cough", true));
            this.yes1.Location = new System.Drawing.Point(145, 271);
            this.yes1.Name = "yes1";
            this.yes1.Size = new System.Drawing.Size(44, 17);
            this.yes1.TabIndex = 25;
            this.yes1.Text = "Yes";
            this.yes1.UseVisualStyleBackColor = true;
            // 
            // yes2
            // 
            this.yes2.AutoSize = true;
            this.yes2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Fever", true));
            this.yes2.Location = new System.Drawing.Point(114, 297);
            this.yes2.Name = "yes2";
            this.yes2.Size = new System.Drawing.Size(44, 17);
            this.yes2.TabIndex = 26;
            this.yes2.Text = "Yes";
            this.yes2.UseVisualStyleBackColor = true;
            // 
            // yes3
            // 
            this.yes3.AutoSize = true;
            this.yes3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Difficulty in Breathing", true));
            this.yes3.Location = new System.Drawing.Point(218, 321);
            this.yes3.Name = "yes3";
            this.yes3.Size = new System.Drawing.Size(44, 17);
            this.yes3.TabIndex = 27;
            this.yes3.Text = "Yes";
            this.yes3.UseVisualStyleBackColor = true;
            // 
            // yes4
            // 
            this.yes4.AutoSize = true;
            this.yes4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Aches/Pain", true));
            this.yes4.Location = new System.Drawing.Point(153, 345);
            this.yes4.Name = "yes4";
            this.yes4.Size = new System.Drawing.Size(44, 17);
            this.yes4.TabIndex = 28;
            this.yes4.Text = "Yes";
            this.yes4.UseVisualStyleBackColor = true;
            // 
            // no1
            // 
            this.no1.AutoSize = true;
            this.no1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Dry Cough", true));
            this.no1.Location = new System.Drawing.Point(195, 270);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(40, 17);
            this.no1.TabIndex = 29;
            this.no1.Text = "No";
            this.no1.UseVisualStyleBackColor = true;
            // 
            // no2
            // 
            this.no2.AutoSize = true;
            this.no2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Fever", true));
            this.no2.Location = new System.Drawing.Point(164, 296);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(40, 17);
            this.no2.TabIndex = 30;
            this.no2.Text = "No";
            this.no2.UseVisualStyleBackColor = true;
            // 
            // no3
            // 
            this.no3.AutoSize = true;
            this.no3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Difficulty in Breathing", true));
            this.no3.Location = new System.Drawing.Point(268, 322);
            this.no3.Name = "no3";
            this.no3.Size = new System.Drawing.Size(40, 17);
            this.no3.TabIndex = 31;
            this.no3.Text = "No";
            this.no3.UseVisualStyleBackColor = true;
            this.no3.CheckedChanged += new System.EventHandler(this.No3_CheckedChanged);
            // 
            // no4
            // 
            this.no4.AutoSize = true;
            this.no4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactTracingRecordsBindingSource, "Aches/Pain", true));
            this.no4.Location = new System.Drawing.Point(203, 345);
            this.no4.Name = "no4";
            this.no4.Size = new System.Drawing.Size(40, 17);
            this.no4.TabIndex = 32;
            this.no4.Text = "No";
            this.no4.UseVisualStyleBackColor = true;
            // 
            // viewrecords
            // 
            this.viewrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewrecords.Location = new System.Drawing.Point(335, 406);
            this.viewrecords.Name = "viewrecords";
            this.viewrecords.Size = new System.Drawing.Size(123, 29);
            this.viewrecords.TabIndex = 33;
            this.viewrecords.Text = "View Records";
            this.viewrecords.UseVisualStyleBackColor = true;
            this.viewrecords.Click += new System.EventHandler(this.Viewrecords_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactTracingRecordsBindingSource, "Date of Visit", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactTracingRecordsBindingSource, "Date of Birth", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 170);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker2.TabIndex = 35;
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.img_8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.viewrecords);
            this.Controls.Add(this.no4);
            this.Controls.Add(this.no3);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.yes4);
            this.Controls.Add(this.yes3);
            this.Controls.Add(this.yes2);
            this.Controls.Add(this.yes1);
            this.Controls.Add(this.infoCT);
            this.Controls.Add(this.savebttn);
            this.Controls.Add(this.textBoxpurpose);
            this.Controls.Add(this.textBoxnamevst);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.namewantvst);
            this.Controls.Add(this.aches);
            this.Controls.Add(this.breathing);
            this.Controls.Add(this.fever);
            this.Controls.Add(this.drycough);
            this.Controls.Add(this.symptoms);
            this.Controls.Add(this.purposevisit);
            this.Controls.Add(this.bdaybttn);
            this.Controls.Add(this.datevisit);
            this.Controls.Add(this.addressbttn);
            this.Controls.Add(this.namebttn);
            this.Controls.Add(this.brgyaddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Barangay San Jose Contact Tracing Form";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTracingRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brgyaddress;
        private System.Windows.Forms.Label namebttn;
        private System.Windows.Forms.Label addressbttn;
        private System.Windows.Forms.Label datevisit;
        private System.Windows.Forms.Label bdaybttn;
        private System.Windows.Forms.Label purposevisit;
        private System.Windows.Forms.Label symptoms;
        private System.Windows.Forms.Label drycough;
        private System.Windows.Forms.Label fever;
        private System.Windows.Forms.Label breathing;
        private System.Windows.Forms.Label aches;
        private System.Windows.Forms.Label namewantvst;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxnamevst;
        private System.Windows.Forms.TextBox textBoxpurpose;
        private System.Windows.Forms.Button savebttn;
        private System.Windows.Forms.Label infoCT;
        private System.Windows.Forms.CheckBox yes1;
        private System.Windows.Forms.CheckBox yes2;
        private System.Windows.Forms.CheckBox yes3;
        private System.Windows.Forms.CheckBox yes4;
        private System.Windows.Forms.CheckBox no1;
        private System.Windows.Forms.CheckBox no2;
        private System.Windows.Forms.CheckBox no3;
        private System.Windows.Forms.CheckBox no4;
        private System.Windows.Forms.Button viewrecords;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource contactTracingRecordsBindingSource;
        private Database1DataSetTableAdapters.Contact_Tracing_RecordsTableAdapter contact_Tracing_RecordsTableAdapter;
    }
}

