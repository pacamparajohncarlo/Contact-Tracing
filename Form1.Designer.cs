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
            this.textBoxdate = new System.Windows.Forms.TextBox();
            this.textBoxbirth = new System.Windows.Forms.TextBox();
            this.textBoxnamevst = new System.Windows.Forms.TextBox();
            this.textBoxpurpose = new System.Windows.Forms.TextBox();
            this.textBoxdrycough = new System.Windows.Forms.TextBox();
            this.textBoxfever = new System.Windows.Forms.TextBox();
            this.textBoxbreathing = new System.Windows.Forms.TextBox();
            this.textBoxaches = new System.Windows.Forms.TextBox();
            this.savebttn = new System.Windows.Forms.Button();
            this.infoCT = new System.Windows.Forms.Label();
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
            this.textBoxname.Location = new System.Drawing.Point(114, 95);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(375, 20);
            this.textBoxname.TabIndex = 13;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(176, 117);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(524, 20);
            this.textBoxaddress.TabIndex = 14;
            // 
            // textBoxdate
            // 
            this.textBoxdate.Location = new System.Drawing.Point(140, 145);
            this.textBoxdate.Name = "textBoxdate";
            this.textBoxdate.Size = new System.Drawing.Size(282, 20);
            this.textBoxdate.TabIndex = 15;
            // 
            // textBoxbirth
            // 
            this.textBoxbirth.Location = new System.Drawing.Point(153, 171);
            this.textBoxbirth.Name = "textBoxbirth";
            this.textBoxbirth.Size = new System.Drawing.Size(241, 20);
            this.textBoxbirth.TabIndex = 16;
            // 
            // textBoxnamevst
            // 
            this.textBoxnamevst.Location = new System.Drawing.Point(297, 198);
            this.textBoxnamevst.Name = "textBoxnamevst";
            this.textBoxnamevst.Size = new System.Drawing.Size(362, 20);
            this.textBoxnamevst.TabIndex = 17;
            // 
            // textBoxpurpose
            // 
            this.textBoxpurpose.Location = new System.Drawing.Point(186, 220);
            this.textBoxpurpose.Name = "textBoxpurpose";
            this.textBoxpurpose.Size = new System.Drawing.Size(265, 20);
            this.textBoxpurpose.TabIndex = 18;
            // 
            // textBoxdrycough
            // 
            this.textBoxdrycough.Location = new System.Drawing.Point(145, 269);
            this.textBoxdrycough.Name = "textBoxdrycough";
            this.textBoxdrycough.Size = new System.Drawing.Size(96, 20);
            this.textBoxdrycough.TabIndex = 19;
            // 
            // textBoxfever
            // 
            this.textBoxfever.Location = new System.Drawing.Point(114, 294);
            this.textBoxfever.Name = "textBoxfever";
            this.textBoxfever.Size = new System.Drawing.Size(96, 20);
            this.textBoxfever.TabIndex = 20;
            // 
            // textBoxbreathing
            // 
            this.textBoxbreathing.Location = new System.Drawing.Point(218, 318);
            this.textBoxbreathing.Name = "textBoxbreathing";
            this.textBoxbreathing.Size = new System.Drawing.Size(96, 20);
            this.textBoxbreathing.TabIndex = 21;
            // 
            // textBoxaches
            // 
            this.textBoxaches.Location = new System.Drawing.Point(153, 347);
            this.textBoxaches.Name = "textBoxaches";
            this.textBoxaches.Size = new System.Drawing.Size(96, 20);
            this.textBoxaches.TabIndex = 22;
            // 
            // savebttn
            // 
            this.savebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebttn.Location = new System.Drawing.Point(326, 374);
            this.savebttn.Name = "savebttn";
            this.savebttn.Size = new System.Drawing.Size(105, 28);
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
            this.infoCT.Size = new System.Drawing.Size(128, 13);
            this.infoCT.TabIndex = 24;
            this.infoCT.Text = "What is Contact Tracing?";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.img_8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoCT);
            this.Controls.Add(this.savebttn);
            this.Controls.Add(this.textBoxaches);
            this.Controls.Add(this.textBoxbreathing);
            this.Controls.Add(this.textBoxfever);
            this.Controls.Add(this.textBoxdrycough);
            this.Controls.Add(this.textBoxpurpose);
            this.Controls.Add(this.textBoxnamevst);
            this.Controls.Add(this.textBoxbirth);
            this.Controls.Add(this.textBoxdate);
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
        private System.Windows.Forms.TextBox textBoxdate;
        private System.Windows.Forms.TextBox textBoxbirth;
        private System.Windows.Forms.TextBox textBoxnamevst;
        private System.Windows.Forms.TextBox textBoxpurpose;
        private System.Windows.Forms.TextBox textBoxdrycough;
        private System.Windows.Forms.TextBox textBoxfever;
        private System.Windows.Forms.TextBox textBoxbreathing;
        private System.Windows.Forms.TextBox textBoxaches;
        private System.Windows.Forms.Button savebttn;
        private System.Windows.Forms.Label infoCT;
    }
}

