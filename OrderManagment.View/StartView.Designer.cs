namespace OrderManagment.View
{
    partial class StartView
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CmdCustomerManagment = new System.Windows.Forms.Button();
            this.CmdOrderManagment = new System.Windows.Forms.Button();
            this.CmdYearlyCompare = new System.Windows.Forms.Button();
            this.CmdArticleManagment = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCustomerManagment
            // 
            this.CmdCustomerManagment.Location = new System.Drawing.Point(12, 7);
            this.CmdCustomerManagment.Name = "CmdCustomerManagment";
            this.CmdCustomerManagment.Size = new System.Drawing.Size(177, 23);
            this.CmdCustomerManagment.TabIndex = 0;
            this.CmdCustomerManagment.Text = "Kundenverwaltung";
            this.CmdCustomerManagment.UseVisualStyleBackColor = true;
            this.CmdCustomerManagment.Click += new System.EventHandler(this.CmdCustomerManagment_Click);
            // 
            // CmdOrderManagment
            // 
            this.CmdOrderManagment.Location = new System.Drawing.Point(12, 36);
            this.CmdOrderManagment.Name = "CmdOrderManagment";
            this.CmdOrderManagment.Size = new System.Drawing.Size(177, 23);
            this.CmdOrderManagment.TabIndex = 1;
            this.CmdOrderManagment.Text = "Auftragsverwaltung";
            this.CmdOrderManagment.UseVisualStyleBackColor = true;
            this.CmdOrderManagment.Click += new System.EventHandler(this.CmdOrderManagment_Click);
            // 
            // CmdYearlyCompare
            // 
            this.CmdYearlyCompare.Location = new System.Drawing.Point(12, 94);
            this.CmdYearlyCompare.Name = "CmdYearlyCompare";
            this.CmdYearlyCompare.Size = new System.Drawing.Size(177, 23);
            this.CmdYearlyCompare.TabIndex = 2;
            this.CmdYearlyCompare.Text = "Jahresvergleich";
            this.CmdYearlyCompare.UseVisualStyleBackColor = true;
            this.CmdYearlyCompare.Click += new System.EventHandler(this.CmdYearCompare_Click);
            // 
            // CmdArticleManagment
            // 
            this.CmdArticleManagment.Location = new System.Drawing.Point(12, 65);
            this.CmdArticleManagment.Name = "CmdArticleManagment";
            this.CmdArticleManagment.Size = new System.Drawing.Size(177, 23);
            this.CmdArticleManagment.TabIndex = 3;
            this.CmdArticleManagment.Text = "Artikelverwaltung";
            this.CmdArticleManagment.UseVisualStyleBackColor = true;
            this.CmdArticleManagment.Click += new System.EventHandler(this.CmdArticleManagment_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(12, 270);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(177, 23);
            this.CmdClose.TabIndex = 4;
            this.CmdClose.Text = "Beenden";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 305);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdArticleManagment);
            this.Controls.Add(this.CmdYearlyCompare);
            this.Controls.Add(this.CmdOrderManagment);
            this.Controls.Add(this.CmdCustomerManagment);
            this.Name = "StartView";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CmdCustomerManagment;
        private System.Windows.Forms.Button CmdOrderManagment;
        private System.Windows.Forms.Button CmdYearlyCompare;
        private System.Windows.Forms.Button CmdArticleManagment;
        private System.Windows.Forms.Button CmdClose;
    }
}