using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReadingLibrary
{
    public partial class Form1 : Form
    {
        const int MAX_XML_LINE = 5;
        public Form1()
        {
            InitializeComponent();
        }

        public static string Reverse(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string reversedString = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            return reversedString;
        }
        private async void OpenFileEvent(object sender, EventArgs e)
        {
            try
            {
                if (RoleBasedSecurityContext.Checked)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt|XML Documents|*.xml", Multiselect = false, ValidateNames = true })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            Output.Text = string.Empty;
                            string[] lines = File.ReadAllLines(ofd.FileName);
                            for (int i = 0; i < Math.Min(MAX_XML_LINE, lines.Count()); i++)
                            {
                                Output.Text += lines[i] + "\n";
                            }
                        }
                    }
                }
                else if (Encrypted.Checked)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt|XML Documents|*.xml", Multiselect = false, ValidateNames = true })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            Output.Text = string.Empty;
                            string[] lines = File.ReadAllLines(ofd.FileName);
                            for (int i = 0; i < lines.Length; i++)
                            {
                                Output.Text += Reverse(lines[i])+ "\n";
                            }

                        }
                    }
                }
                else
                {
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt|XML Documents|*.xml", Multiselect = false, ValidateNames = true })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamReader sr = new StreamReader(ofd.FileName))
                            {
                                Output.Text = await sr.ReadToEndAsync();
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Encrypted_CheckedChanged(object sender, EventArgs e)
        {
            if (Encrypted.Checked)
            {
                RoleBasedSecurityContext.Checked = false;
            }
        }

        private void RoleBasedSecurityContext_CheckedChanged(object sender, EventArgs e)
        {
            if (RoleBasedSecurityContext.Checked)
            {
                Encrypted.Checked = false;
            }
        }
    }
}
