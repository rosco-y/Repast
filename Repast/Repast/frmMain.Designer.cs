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
                        this.cmdRefreshCategories = new System.Windows.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // lstCategories
                        // 
                        this.lstCategories.FormattingEnabled = true;
                        this.lstCategories.Location = new System.Drawing.Point(304, 41);
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
                        // cmdRefreshCategories
                        // 
                        this.cmdRefreshCategories.Location = new System.Drawing.Point(56, 119);
                        this.cmdRefreshCategories.Name = "cmdRefreshCategories";
                        this.cmdRefreshCategories.Size = new System.Drawing.Size(120, 23);
                        this.cmdRefreshCategories.TabIndex = 7;
                        this.cmdRefreshCategories.Text = "Refresh Category List";
                        this.cmdRefreshCategories.UseVisualStyleBackColor = true;
                        this.cmdRefreshCategories.Click += new System.EventHandler(this.CmdRefreshCategories_Click);
                        // 
                        // frmMain
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(557, 517);
                        this.Controls.Add(this.cmdRefreshCategories);
                        this.Controls.Add(this.cmdAddCategory);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.txtCategoryName);
                        this.Controls.Add(this.lstCategories);
                        this.Name = "frmMain";
                        this.Text = "Form1";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.ListBox lstCategories;
                private System.Windows.Forms.TextBox txtCategoryName;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Button cmdAddCategory;
                private System.Windows.Forms.Button cmdRefreshCategories;
        }
}

