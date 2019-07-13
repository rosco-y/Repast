namespace Repast
{
        partial class frmPasswordGenerator
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
                        this.txtPasswordLength = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.chkUpperCaseAlpha = new System.Windows.Forms.CheckBox();
                        this.chkNumbers = new System.Windows.Forms.CheckBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.chkLowerCaseAlpha = new System.Windows.Forms.CheckBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.chkExcludeSimilarChars = new System.Windows.Forms.CheckBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.chkExcludeAmbiguousChars = new System.Windows.Forms.CheckBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.chkAutoClipboard = new System.Windows.Forms.CheckBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.chkSpecial = new System.Windows.Forms.CheckBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.label9 = new System.Windows.Forms.Label();
                        this.cmdGeneratePassword = new System.Windows.Forms.Button();
                        this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
                        this.chkSavePreferences = new System.Windows.Forms.CheckBox();
                        this.chkSpecial2 = new System.Windows.Forms.CheckBox();
                        this.label11 = new System.Windows.Forms.Label();
                        this.chkSpecial3 = new System.Windows.Forms.CheckBox();
                        this.label12 = new System.Windows.Forms.Label();
                        this.chkSpecial4 = new System.Windows.Forms.CheckBox();
                        this.label13 = new System.Windows.Forms.Label();
                        this.cmdClose = new System.Windows.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // txtPasswordLength
                        // 
                        this.txtPasswordLength.Location = new System.Drawing.Point(169, 38);
                        this.txtPasswordLength.Name = "txtPasswordLength";
                        this.txtPasswordLength.Size = new System.Drawing.Size(100, 20);
                        this.txtPasswordLength.TabIndex = 0;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(12, 41);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(92, 13);
                        this.label1.TabIndex = 1;
                        this.label1.Text = "Password Length:";
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(12, 68);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(42, 13);
                        this.label2.TabIndex = 2;
                        this.label2.Text = "Special";
                        // 
                        // chkUpperCaseAlpha
                        // 
                        this.chkUpperCaseAlpha.AutoSize = true;
                        this.chkUpperCaseAlpha.Location = new System.Drawing.Point(169, 197);
                        this.chkUpperCaseAlpha.Name = "chkUpperCaseAlpha";
                        this.chkUpperCaseAlpha.Size = new System.Drawing.Size(89, 17);
                        this.chkUpperCaseAlpha.TabIndex = 8;
                        this.chkUpperCaseAlpha.Text = "(e.g. ABCDE)";
                        this.chkUpperCaseAlpha.UseVisualStyleBackColor = true;
                        // 
                        // chkNumbers
                        // 
                        this.chkNumbers.AutoSize = true;
                        this.chkNumbers.Location = new System.Drawing.Point(169, 155);
                        this.chkNumbers.Name = "chkNumbers";
                        this.chkNumbers.Size = new System.Drawing.Size(92, 17);
                        this.chkNumbers.TabIndex = 6;
                        this.chkNumbers.Text = "(e. g. 123456)";
                        this.chkNumbers.UseVisualStyleBackColor = true;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(12, 155);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(49, 13);
                        this.label3.TabIndex = 4;
                        this.label3.Text = "Numbers";
                        // 
                        // chkLowerCaseAlpha
                        // 
                        this.chkLowerCaseAlpha.AutoSize = true;
                        this.chkLowerCaseAlpha.Location = new System.Drawing.Point(168, 178);
                        this.chkLowerCaseAlpha.Name = "chkLowerCaseAlpha";
                        this.chkLowerCaseAlpha.Size = new System.Drawing.Size(86, 17);
                        this.chkLowerCaseAlpha.TabIndex = 7;
                        this.chkLowerCaseAlpha.Text = "(e. g. abcde)";
                        this.chkLowerCaseAlpha.UseVisualStyleBackColor = true;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(12, 178);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(59, 13);
                        this.label4.TabIndex = 6;
                        this.label4.Text = "Lowercase";
                        // 
                        // chkExcludeSimilarChars
                        // 
                        this.chkExcludeSimilarChars.AutoSize = true;
                        this.chkExcludeSimilarChars.Location = new System.Drawing.Point(169, 220);
                        this.chkExcludeSimilarChars.Name = "chkExcludeSimilarChars";
                        this.chkExcludeSimilarChars.Size = new System.Drawing.Size(132, 17);
                        this.chkExcludeSimilarChars.TabIndex = 9;
                        this.chkExcludeSimilarChars.Text = "(e. g. i, I, 1, L, o, O, 0 )";
                        this.chkExcludeSimilarChars.UseVisualStyleBackColor = true;
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(12, 201);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(59, 13);
                        this.label5.TabIndex = 8;
                        this.label5.Text = "Uppercase";
                        // 
                        // chkExcludeAmbiguousChars
                        // 
                        this.chkExcludeAmbiguousChars.AutoSize = true;
                        this.chkExcludeAmbiguousChars.Location = new System.Drawing.Point(169, 243);
                        this.chkExcludeAmbiguousChars.Name = "chkExcludeAmbiguousChars";
                        this.chkExcludeAmbiguousChars.Size = new System.Drawing.Size(130, 17);
                        this.chkExcludeAmbiguousChars.TabIndex = 10;
                        this.chkExcludeAmbiguousChars.Text = "(e. g. ({}[]()/\\\'\"`~,;:.<>)";
                        this.chkExcludeAmbiguousChars.UseVisualStyleBackColor = true;
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Location = new System.Drawing.Point(12, 224);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(108, 13);
                        this.label6.TabIndex = 10;
                        this.label6.Text = "Exclude Similar Chars";
                        // 
                        // chkAutoClipboard
                        // 
                        this.chkAutoClipboard.AutoSize = true;
                        this.chkAutoClipboard.Location = new System.Drawing.Point(169, 266);
                        this.chkAutoClipboard.Name = "chkAutoClipboard";
                        this.chkAutoClipboard.Size = new System.Drawing.Size(174, 17);
                        this.chkAutoClipboard.TabIndex = 11;
                        this.chkAutoClipboard.Text = "Automatically copy to ClipBoard";
                        this.chkAutoClipboard.UseVisualStyleBackColor = true;
                        // 
                        // label7
                        // 
                        this.label7.AutoSize = true;
                        this.label7.Location = new System.Drawing.Point(12, 247);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(130, 13);
                        this.label7.TabIndex = 12;
                        this.label7.Text = "Exclude Ambiguous Chars";
                        // 
                        // chkSpecial
                        // 
                        this.chkSpecial.AutoSize = true;
                        this.chkSpecial.Location = new System.Drawing.Point(169, 64);
                        this.chkSpecial.Name = "chkSpecial";
                        this.chkSpecial.Size = new System.Drawing.Size(128, 17);
                        this.chkSpecial.TabIndex = 1;
                        this.chkSpecial.Text = "! \" # $ % && \' ( ) + , - . /";
                        this.chkSpecial.UseVisualStyleBackColor = true;
                        // 
                        // label8
                        // 
                        this.label8.AutoSize = true;
                        this.label8.Location = new System.Drawing.Point(12, 270);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(76, 13);
                        this.label8.TabIndex = 14;
                        this.label8.Text = "Auto-Clipboard";
                        // 
                        // label9
                        // 
                        this.label9.AutoSize = true;
                        this.label9.Location = new System.Drawing.Point(12, 293);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(107, 13);
                        this.label9.TabIndex = 16;
                        this.label9.Text = "Save my preferences";
                        // 
                        // cmdGeneratePassword
                        // 
                        this.cmdGeneratePassword.Location = new System.Drawing.Point(14, 329);
                        this.cmdGeneratePassword.Name = "cmdGeneratePassword";
                        this.cmdGeneratePassword.Size = new System.Drawing.Size(122, 23);
                        this.cmdGeneratePassword.TabIndex = 13;
                        this.cmdGeneratePassword.Text = "Generate Password";
                        this.cmdGeneratePassword.UseVisualStyleBackColor = true;
                        this.cmdGeneratePassword.Click += new System.EventHandler(this.CmdGeneratePassword_Click);
                        // 
                        // txtGeneratedPassword
                        // 
                        this.txtGeneratedPassword.Location = new System.Drawing.Point(14, 358);
                        this.txtGeneratedPassword.Name = "txtGeneratedPassword";
                        this.txtGeneratedPassword.Size = new System.Drawing.Size(254, 20);
                        this.txtGeneratedPassword.TabIndex = 14;
                        // 
                        // chkSavePreferences
                        // 
                        this.chkSavePreferences.AutoSize = true;
                        this.chkSavePreferences.Location = new System.Drawing.Point(169, 289);
                        this.chkSavePreferences.Name = "chkSavePreferences";
                        this.chkSavePreferences.Size = new System.Drawing.Size(84, 17);
                        this.chkSavePreferences.TabIndex = 12;
                        this.chkSavePreferences.Text = "For next use";
                        this.chkSavePreferences.UseVisualStyleBackColor = true;
                        // 
                        // chkSpecial2
                        // 
                        this.chkSpecial2.AutoSize = true;
                        this.chkSpecial2.Location = new System.Drawing.Point(169, 86);
                        this.chkSpecial2.Name = "chkSpecial2";
                        this.chkSpecial2.Size = new System.Drawing.Size(85, 17);
                        this.chkSpecial2.TabIndex = 3;
                        this.chkSpecial2.Text = ": ; < = > ? @";
                        this.chkSpecial2.UseVisualStyleBackColor = true;
                        // 
                        // label11
                        // 
                        this.label11.AutoSize = true;
                        this.label11.Location = new System.Drawing.Point(12, 90);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(48, 13);
                        this.label11.TabIndex = 26;
                        this.label11.Text = "Special2";
                        // 
                        // chkSpecial3
                        // 
                        this.chkSpecial3.AutoSize = true;
                        this.chkSpecial3.Location = new System.Drawing.Point(169, 111);
                        this.chkSpecial3.Name = "chkSpecial3";
                        this.chkSpecial3.Size = new System.Drawing.Size(67, 17);
                        this.chkSpecial3.TabIndex = 4;
                        this.chkSpecial3.Text = "[ \\ ] ^ _ `";
                        this.chkSpecial3.UseVisualStyleBackColor = true;
                        // 
                        // label12
                        // 
                        this.label12.AutoSize = true;
                        this.label12.Location = new System.Drawing.Point(12, 115);
                        this.label12.Name = "label12";
                        this.label12.Size = new System.Drawing.Size(48, 13);
                        this.label12.TabIndex = 28;
                        this.label12.Text = "Special3";
                        // 
                        // chkSpecial4
                        // 
                        this.chkSpecial4.AutoSize = true;
                        this.chkSpecial4.Location = new System.Drawing.Point(169, 133);
                        this.chkSpecial4.Name = "chkSpecial4";
                        this.chkSpecial4.Size = new System.Drawing.Size(52, 17);
                        this.chkSpecial4.TabIndex = 5;
                        this.chkSpecial4.Text = "{ | } ~";
                        this.chkSpecial4.UseVisualStyleBackColor = true;
                        // 
                        // label13
                        // 
                        this.label13.AutoSize = true;
                        this.label13.Location = new System.Drawing.Point(12, 137);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(48, 13);
                        this.label13.TabIndex = 30;
                        this.label13.Text = "Special4";
                        // 
                        // cmdClose
                        // 
                        this.cmdClose.Location = new System.Drawing.Point(114, 402);
                        this.cmdClose.Name = "cmdClose";
                        this.cmdClose.Size = new System.Drawing.Size(75, 23);
                        this.cmdClose.TabIndex = 31;
                        this.cmdClose.Text = "Close";
                        this.cmdClose.UseVisualStyleBackColor = true;
                        this.cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
                        // 
                        // frmPasswordGenerator
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(376, 466);
                        this.Controls.Add(this.cmdClose);
                        this.Controls.Add(this.chkSpecial4);
                        this.Controls.Add(this.label13);
                        this.Controls.Add(this.chkSpecial3);
                        this.Controls.Add(this.label12);
                        this.Controls.Add(this.chkSpecial2);
                        this.Controls.Add(this.label11);
                        this.Controls.Add(this.chkSavePreferences);
                        this.Controls.Add(this.txtGeneratedPassword);
                        this.Controls.Add(this.cmdGeneratePassword);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.chkSpecial);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.chkAutoClipboard);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.chkExcludeAmbiguousChars);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.chkExcludeSimilarChars);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.chkLowerCaseAlpha);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.chkNumbers);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.chkUpperCaseAlpha);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.txtPasswordLength);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.MaximizeBox = false;
                        this.MinimizeBox = false;
                        this.Name = "frmPasswordGenerator";
                        this.Text = "frmPasswordGenerator";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.TextBox txtPasswordLength;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.CheckBox chkUpperCaseAlpha;
                private System.Windows.Forms.CheckBox chkNumbers;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.CheckBox chkLowerCaseAlpha;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.CheckBox chkExcludeSimilarChars;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.CheckBox chkExcludeAmbiguousChars;
                private System.Windows.Forms.Label label6;
                private System.Windows.Forms.CheckBox chkAutoClipboard;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.CheckBox chkSpecial;
                private System.Windows.Forms.Label label8;
                private System.Windows.Forms.Label label9;
                private System.Windows.Forms.Button cmdGeneratePassword;
                private System.Windows.Forms.TextBox txtGeneratedPassword;
                private System.Windows.Forms.CheckBox chkSavePreferences;
                private System.Windows.Forms.CheckBox chkSpecial2;
                private System.Windows.Forms.Label label11;
                private System.Windows.Forms.CheckBox chkSpecial3;
                private System.Windows.Forms.Label label12;
                private System.Windows.Forms.CheckBox chkSpecial4;
                private System.Windows.Forms.Label label13;
                private System.Windows.Forms.Button cmdClose;
        }
}