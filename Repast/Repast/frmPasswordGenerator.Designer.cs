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
                        this.textBox1 = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.checkBox1 = new System.Windows.Forms.CheckBox();
                        this.checkBox2 = new System.Windows.Forms.CheckBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.checkBox3 = new System.Windows.Forms.CheckBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.checkBox4 = new System.Windows.Forms.CheckBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.checkBox5 = new System.Windows.Forms.CheckBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.checkBox6 = new System.Windows.Forms.CheckBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.checkBox7 = new System.Windows.Forms.CheckBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.label9 = new System.Windows.Forms.Label();
                        this.cmdGeneratePassword = new System.Windows.Forms.Button();
                        this.textBox2 = new System.Windows.Forms.TextBox();
                        this.checkBox8 = new System.Windows.Forms.CheckBox();
                        this.button1 = new System.Windows.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // textBox1
                        // 
                        this.textBox1.Location = new System.Drawing.Point(169, 38);
                        this.textBox1.Name = "textBox1";
                        this.textBox1.Size = new System.Drawing.Size(100, 20);
                        this.textBox1.TabIndex = 0;
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
                        this.label2.Size = new System.Drawing.Size(46, 13);
                        this.label2.TabIndex = 2;
                        this.label2.Text = "Symbols";
                        // 
                        // checkBox1
                        // 
                        this.checkBox1.AutoSize = true;
                        this.checkBox1.Location = new System.Drawing.Point(169, 133);
                        this.checkBox1.Name = "checkBox1";
                        this.checkBox1.Size = new System.Drawing.Size(89, 17);
                        this.checkBox1.TabIndex = 3;
                        this.checkBox1.Text = "(e.g. ABCDE)";
                        this.checkBox1.UseVisualStyleBackColor = true;
                        // 
                        // checkBox2
                        // 
                        this.checkBox2.AutoSize = true;
                        this.checkBox2.Location = new System.Drawing.Point(169, 91);
                        this.checkBox2.Name = "checkBox2";
                        this.checkBox2.Size = new System.Drawing.Size(92, 17);
                        this.checkBox2.TabIndex = 5;
                        this.checkBox2.Text = "(e. g. 123456)";
                        this.checkBox2.UseVisualStyleBackColor = true;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(12, 91);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(49, 13);
                        this.label3.TabIndex = 4;
                        this.label3.Text = "Numbers";
                        // 
                        // checkBox3
                        // 
                        this.checkBox3.AutoSize = true;
                        this.checkBox3.Location = new System.Drawing.Point(168, 114);
                        this.checkBox3.Name = "checkBox3";
                        this.checkBox3.Size = new System.Drawing.Size(86, 17);
                        this.checkBox3.TabIndex = 7;
                        this.checkBox3.Text = "(e. g. abcde)";
                        this.checkBox3.UseVisualStyleBackColor = true;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(12, 114);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(59, 13);
                        this.label4.TabIndex = 6;
                        this.label4.Text = "Lowercase";
                        // 
                        // checkBox4
                        // 
                        this.checkBox4.AutoSize = true;
                        this.checkBox4.Location = new System.Drawing.Point(169, 156);
                        this.checkBox4.Name = "checkBox4";
                        this.checkBox4.Size = new System.Drawing.Size(132, 17);
                        this.checkBox4.TabIndex = 9;
                        this.checkBox4.Text = "(e. g. i, I, 1, L, o, O, 0 )";
                        this.checkBox4.UseVisualStyleBackColor = true;
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(12, 137);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(59, 13);
                        this.label5.TabIndex = 8;
                        this.label5.Text = "Uppercase";
                        // 
                        // checkBox5
                        // 
                        this.checkBox5.AutoSize = true;
                        this.checkBox5.Location = new System.Drawing.Point(169, 179);
                        this.checkBox5.Name = "checkBox5";
                        this.checkBox5.Size = new System.Drawing.Size(130, 17);
                        this.checkBox5.TabIndex = 11;
                        this.checkBox5.Text = "(e. g. ({}[]()/\\\'\"`~,;:.<>)";
                        this.checkBox5.UseVisualStyleBackColor = true;
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Location = new System.Drawing.Point(12, 160);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(108, 13);
                        this.label6.TabIndex = 10;
                        this.label6.Text = "Exclude Similar Chars";
                        // 
                        // checkBox6
                        // 
                        this.checkBox6.AutoSize = true;
                        this.checkBox6.Location = new System.Drawing.Point(169, 202);
                        this.checkBox6.Name = "checkBox6";
                        this.checkBox6.Size = new System.Drawing.Size(174, 17);
                        this.checkBox6.TabIndex = 13;
                        this.checkBox6.Text = "Automatically copy to ClipBoard";
                        this.checkBox6.UseVisualStyleBackColor = true;
                        // 
                        // label7
                        // 
                        this.label7.AutoSize = true;
                        this.label7.Location = new System.Drawing.Point(12, 183);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(130, 13);
                        this.label7.TabIndex = 12;
                        this.label7.Text = "Exclude Ambiguous Chars";
                        // 
                        // checkBox7
                        // 
                        this.checkBox7.AutoSize = true;
                        this.checkBox7.Location = new System.Drawing.Point(169, 64);
                        this.checkBox7.Name = "checkBox7";
                        this.checkBox7.Size = new System.Drawing.Size(85, 17);
                        this.checkBox7.TabIndex = 15;
                        this.checkBox7.Text = "(e.g. @#$%)";
                        this.checkBox7.UseVisualStyleBackColor = true;
                        // 
                        // label8
                        // 
                        this.label8.AutoSize = true;
                        this.label8.Location = new System.Drawing.Point(12, 206);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(76, 13);
                        this.label8.TabIndex = 14;
                        this.label8.Text = "Auto-Clipboard";
                        // 
                        // label9
                        // 
                        this.label9.AutoSize = true;
                        this.label9.Location = new System.Drawing.Point(12, 229);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(107, 13);
                        this.label9.TabIndex = 16;
                        this.label9.Text = "Save my preferences";
                        // 
                        // cmdGeneratePassword
                        // 
                        this.cmdGeneratePassword.Location = new System.Drawing.Point(15, 290);
                        this.cmdGeneratePassword.Name = "cmdGeneratePassword";
                        this.cmdGeneratePassword.Size = new System.Drawing.Size(122, 23);
                        this.cmdGeneratePassword.TabIndex = 20;
                        this.cmdGeneratePassword.Text = "Generate Password";
                        this.cmdGeneratePassword.UseVisualStyleBackColor = true;
                        // 
                        // textBox2
                        // 
                        this.textBox2.Location = new System.Drawing.Point(15, 319);
                        this.textBox2.Name = "textBox2";
                        this.textBox2.Size = new System.Drawing.Size(254, 20);
                        this.textBox2.TabIndex = 21;
                        // 
                        // checkBox8
                        // 
                        this.checkBox8.AutoSize = true;
                        this.checkBox8.Location = new System.Drawing.Point(169, 225);
                        this.checkBox8.Name = "checkBox8";
                        this.checkBox8.Size = new System.Drawing.Size(84, 17);
                        this.checkBox8.TabIndex = 22;
                        this.checkBox8.Text = "For next use";
                        this.checkBox8.UseVisualStyleBackColor = true;
                        // 
                        // button1
                        // 
                        this.button1.Location = new System.Drawing.Point(169, 355);
                        this.button1.Name = "button1";
                        this.button1.Size = new System.Drawing.Size(75, 23);
                        this.button1.TabIndex = 23;
                        this.button1.Text = "Close";
                        this.button1.UseVisualStyleBackColor = true;
                        // 
                        // frmPasswordGenerator
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(457, 390);
                        this.Controls.Add(this.button1);
                        this.Controls.Add(this.checkBox8);
                        this.Controls.Add(this.textBox2);
                        this.Controls.Add(this.cmdGeneratePassword);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.checkBox7);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.checkBox6);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.checkBox5);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.checkBox4);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.checkBox3);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.checkBox2);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.checkBox1);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.textBox1);
                        this.Name = "frmPasswordGenerator";
                        this.Text = "frmPasswordGenerator";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.TextBox textBox1;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.CheckBox checkBox1;
                private System.Windows.Forms.CheckBox checkBox2;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.CheckBox checkBox3;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.CheckBox checkBox4;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.CheckBox checkBox5;
                private System.Windows.Forms.Label label6;
                private System.Windows.Forms.CheckBox checkBox6;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.CheckBox checkBox7;
                private System.Windows.Forms.Label label8;
                private System.Windows.Forms.Label label9;
                private System.Windows.Forms.Button cmdGeneratePassword;
                private System.Windows.Forms.TextBox textBox2;
                private System.Windows.Forms.CheckBox checkBox8;
                private System.Windows.Forms.Button button1;
        }
}