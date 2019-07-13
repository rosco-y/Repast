using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepastLib;

namespace Repast
{
        public partial class frmPasswordGenerator : Form
        {
                public frmPasswordGenerator()
                {
                        InitializeComponent();
                }

                private void CmdGeneratePassword_Click(object sender, EventArgs e)
                {
                        int pLen = 0; ;
                        
                        if (txtPasswordLength.Text.Length > 0)
                        {
                                if (int.TryParse(txtPasswordLength.Text, out pLen))
                                {
                                        PasswordGenerator pGen = new PasswordGenerator(
                                                int.Parse(txtPasswordLength.Text),
                                                chkLowerCaseAlpha.Checked,
                                                chkNumbers.Checked,
                                                chkSpecial.Checked,
                                                chkSpecial2.Checked,
                                                chkSpecial3.Checked,
                                                chkSpecial4.Checked,
                                                chkUpperCaseAlpha.Checked
                                                );

                                        txtGeneratedPassword.Text = pGen.GeneratePassword();
                                }

                        }
                        if (pLen == 0)
                        {
                                MessageBox.Show("Illegal Password Length!", "Not Again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                }

                private void CmdClose_Click(object sender, EventArgs e)
                {
                        this.Close();
                }
        }
}
