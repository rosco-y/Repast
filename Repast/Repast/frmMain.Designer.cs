namespace Repast
{
        partial class frmMain
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
                        this.lstCategories = new System.Windows.Forms.ListBox();
                        this.txtCategoryName = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.cmdAddCategory = new System.Windows.Forms.Button();
                        this.cmdAddSite = new System.Windows.Forms.Button();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtSiteName = new System.Windows.Forms.TextBox();
                        this.lstSites = new System.Windows.Forms.ListBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.txtPassword = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.cmdOpenPasswordGenerator = new System.Windows.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // lstCategories
                        // 
                        this.lstCategories.FormattingEnabled = true;
                        this.lstCategories.Location = new System.Drawing.Point(293, 22);
                        this.lstCategories.Name = "lstCategories";
                        this.lstCategories.Size = new System.Drawing.Size(187, 134);
                        this.lstCategories.TabIndex = 0;
                        // 
                        // txtCategoryName
                        // 
                        this.txtCategoryName.Location = new System.Drawing.Point(56, 60);
                        this.txtCategoryName.Name = "txtCategoryName";
                        this.txtCategoryName.Size = new System.Drawing.Size(146, 20);
                        this.txtCategoryName.TabIndex = 1;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(53, 41);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(77, 13);
                        this.label1.TabIndex = 3;
                        this.label1.Text = "Caegory Name";
                        // 
                        // cmdAddCategory
                        // 
                        this.cmdAddCategory.Location = new System.Drawing.Point(56, 90);
                        this.cmdAddCategory.Name = "cmdAddCategory";
                        this.cmdAddCategory.Size = new System.Drawing.Size(120, 23);
                        this.cmdAddCategory.TabIndex = 6;
                        this.cmdAddCategory.Text = "Add Category";
                        this.cmdAddCategory.UseVisualStyleBackColor = true;
                        this.cmdAddCategory.Click += new System.EventHandler(this.CmdAddCategory_Click);
                        // 
                        // cmdAddSite
                        // 
                        this.cmdAddSite.Location = new System.Drawing.Point(56, 321);
                        this.cmdAddSite.Name = "cmdAddSite";
                        this.cmdAddSite.Size = new System.Drawing.Size(120, 23);
                        this.cmdAddSite.TabIndex = 11;
                        this.cmdAddSite.Text = "Add Site";
                        this.cmdAddSite.UseVisualStyleBackColor = true;
                        this.cmdAddSite.Click += new System.EventHandler(this.CmdAddSite_Click);
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(53, 213);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(56, 13);
                        this.label2.TabIndex = 10;
                        this.label2.Text = "Site Name";
                        // 
                        // txtSiteName
                        // 
                        this.txtSiteName.Location = new System.Drawing.Point(56, 232);
                        this.txtSiteName.Name = "txtSiteName";
                        this.txtSiteName.Size = new System.Drawing.Size(146, 20);
                        this.txtSiteName.TabIndex = 9;
                        // 
                        // lstSites
                        // 
                        this.lstSites.FormattingEnabled = true;
                        this.lstSites.Location = new System.Drawing.Point(293, 194);
                        this.lstSites.Name = "lstSites";
                        this.lstSites.Size = new System.Drawing.Size(187, 290);
                        this.lstSites.TabIndex = 8;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(53, 264);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(53, 13);
                        this.label3.TabIndex = 14;
                        this.label3.Text = "Password";
                        // 
                        // txtPassword
                        // 
                        this.txtPassword.Location = new System.Drawing.Point(56, 283);
                        this.txtPassword.Name = "txtPassword";
                        this.txtPassword.Size = new System.Drawing.Size(146, 20);
                        this.txtPassword.TabIndex = 13;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(290, 178);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(30, 13);
                        this.label4.TabIndex = 15;
                        this.label4.Text = "Sites";
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(290, 6);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(54, 13);
                        this.label5.TabIndex = 16;
                        this.label5.Text = "Caegories";
                        // 
                        // cmdOpenPasswordGenerator
                        // 
                        this.cmdOpenPasswordGenerator.Location = new System.Drawing.Point(56, 390);
                        this.cmdOpenPasswordGenerator.Name = "cmdOpenPasswordGenerator";
                        this.cmdOpenPasswordGenerator.Size = new System.Drawing.Size(120, 23);
                        this.cmdOpenPasswordGenerator.TabIndex = 17;
                        this.cmdOpenPasswordGenerator.Text = "Generate Password";
                        this.cmdOpenPasswordGenerator.UseVisualStyleBackColor = true;
                        this.cmdOpenPasswordGenerator.Click += new System.EventHandler(this.CmdOpenPasswordGenerator_Click);
                        // 
                        // frmMain
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(557, 517);
                        this.Controls.Add(this.cmdOpenPasswordGenerator);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.txtPassword);
                        this.Controls.Add(this.cmdAddSite);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.txtSiteName);
                        this.Controls.Add(this.lstSites);
                        this.Controls.Add(this.cmdAddCategory);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.txtCategoryName);
                        this.Controls.Add(this.lstCategories);
                        this.Name = "frmMain";
                        this.Text = "Repast";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.ListBox lstCategories;
                private System.Windows.Forms.TextBox txtCategoryName;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Button cmdAddCategory;
                private System.Windows.Forms.Button cmdAddSite;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.TextBox txtSiteName;
                private System.Windows.Forms.ListBox lstSites;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.TextBox txtPassword;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.Button cmdOpenPasswordGenerator;
        }
}

