namespace OrderManagment.View
{
    partial class ArticleManagmentView
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
            this.TabArticle = new System.Windows.Forms.TabControl();
            this.TbpArticle = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TbpArticleGroupe = new System.Windows.Forms.TabPage();
            this.LblArticle = new System.Windows.Forms.Label();
            this.CmdSaveArticle = new System.Windows.Forms.Button();
            this.CmdSaveArticleGroups = new System.Windows.Forms.Button();
            this.LblArticlegroups = new System.Windows.Forms.Label();
            this.TrvArticlegroupe = new System.Windows.Forms.TreeView();
            this.TabArticle.SuspendLayout();
            this.TbpArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TbpArticleGroupe.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabArticle
            // 
            this.TabArticle.Controls.Add(this.TbpArticle);
            this.TabArticle.Controls.Add(this.TbpArticleGroupe);
            this.TabArticle.Location = new System.Drawing.Point(0, 0);
            this.TabArticle.Name = "TabArticle";
            this.TabArticle.SelectedIndex = 0;
            this.TabArticle.Size = new System.Drawing.Size(802, 449);
            this.TabArticle.TabIndex = 0;
            // 
            // TbpArticle
            // 
            this.TbpArticle.Controls.Add(this.CmdSaveArticle);
            this.TbpArticle.Controls.Add(this.LblArticle);
            this.TbpArticle.Controls.Add(this.dataGridView1);
            this.TbpArticle.Location = new System.Drawing.Point(4, 22);
            this.TbpArticle.Name = "TbpArticle";
            this.TbpArticle.Padding = new System.Windows.Forms.Padding(3);
            this.TbpArticle.Size = new System.Drawing.Size(794, 423);
            this.TbpArticle.TabIndex = 0;
            this.TbpArticle.Text = "Artikel";
            this.TbpArticle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // TbpArticleGroupe
            // 
            this.TbpArticleGroupe.Controls.Add(this.TrvArticlegroupe);
            this.TbpArticleGroupe.Controls.Add(this.CmdSaveArticleGroups);
            this.TbpArticleGroupe.Controls.Add(this.LblArticlegroups);
            this.TbpArticleGroupe.Location = new System.Drawing.Point(4, 22);
            this.TbpArticleGroupe.Name = "TbpArticleGroupe";
            this.TbpArticleGroupe.Padding = new System.Windows.Forms.Padding(3);
            this.TbpArticleGroupe.Size = new System.Drawing.Size(794, 423);
            this.TbpArticleGroupe.TabIndex = 1;
            this.TbpArticleGroupe.Text = "Artikelgruppen";
            this.TbpArticleGroupe.UseVisualStyleBackColor = true;
            // 
            // LblArticle
            // 
            this.LblArticle.AutoSize = true;
            this.LblArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticle.Location = new System.Drawing.Point(8, 20);
            this.LblArticle.Name = "LblArticle";
            this.LblArticle.Size = new System.Drawing.Size(90, 31);
            this.LblArticle.TabIndex = 1;
            this.LblArticle.Text = "Artikel";
            // 
            // CmdSaveArticle
            // 
            this.CmdSaveArticle.Location = new System.Drawing.Point(709, 393);
            this.CmdSaveArticle.Name = "CmdSaveArticle";
            this.CmdSaveArticle.Size = new System.Drawing.Size(75, 23);
            this.CmdSaveArticle.TabIndex = 2;
            this.CmdSaveArticle.Text = "Speichern";
            this.CmdSaveArticle.UseVisualStyleBackColor = true;
            // 
            // CmdSaveArticleGroups
            // 
            this.CmdSaveArticleGroups.Location = new System.Drawing.Point(709, 393);
            this.CmdSaveArticleGroups.Name = "CmdSaveArticleGroups";
            this.CmdSaveArticleGroups.Size = new System.Drawing.Size(75, 23);
            this.CmdSaveArticleGroups.TabIndex = 5;
            this.CmdSaveArticleGroups.Text = "Speichern";
            this.CmdSaveArticleGroups.UseVisualStyleBackColor = true;
            // 
            // LblArticlegroups
            // 
            this.LblArticlegroups.AutoSize = true;
            this.LblArticlegroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticlegroups.Location = new System.Drawing.Point(8, 20);
            this.LblArticlegroups.Name = "LblArticlegroups";
            this.LblArticlegroups.Size = new System.Drawing.Size(189, 31);
            this.LblArticlegroups.TabIndex = 4;
            this.LblArticlegroups.Text = "Artikelgruppen";
            // 
            // TrvArticlegroupe
            // 
            this.TrvArticlegroupe.Location = new System.Drawing.Point(14, 54);
            this.TrvArticlegroupe.Name = "TrvArticlegroupe";
            this.TrvArticlegroupe.Size = new System.Drawing.Size(770, 333);
            this.TrvArticlegroupe.TabIndex = 6;
            // 
            // ArticleManagmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabArticle);
            this.Name = "ArticleManagmentView";
            this.Text = "ArticleManagment";
            this.TabArticle.ResumeLayout(false);
            this.TbpArticle.ResumeLayout(false);
            this.TbpArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TbpArticleGroupe.ResumeLayout(false);
            this.TbpArticleGroupe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabArticle;
        private System.Windows.Forms.TabPage TbpArticle;
        private System.Windows.Forms.TabPage TbpArticleGroupe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdSaveArticle;
        private System.Windows.Forms.Label LblArticle;
        private System.Windows.Forms.Button CmdSaveArticleGroups;
        private System.Windows.Forms.Label LblArticlegroups;
        private System.Windows.Forms.TreeView TrvArticlegroupe;
    }
}