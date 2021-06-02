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
            this.brgyaddress = new System.Windows.Forms.Label();
            this.purposeCT = new System.Windows.Forms.Button();
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
            // purposeCT
            // 
            this.purposeCT.BackColor = System.Drawing.Color.White;
            this.purposeCT.Location = new System.Drawing.Point(634, 416);
            this.purposeCT.Name = "purposeCT";
            this.purposeCT.Size = new System.Drawing.Size(143, 22);
            this.purposeCT.TabIndex = 1;
            this.purposeCT.Text = "What is Contract Tracing?";
            this.purposeCT.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.img_8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purposeCT);
            this.Controls.Add(this.brgyaddress);
            this.Name = "MainPage";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brgyaddress;
        private System.Windows.Forms.Button purposeCT;
    }
}

