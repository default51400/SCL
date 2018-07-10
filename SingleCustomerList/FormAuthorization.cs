using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SingleCustomerList
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            textBoxLanguage.Text = InputLanguage.CurrentInputLanguage.Culture.ThreeLetterWindowsLanguageName;
            InitializeACSK();
            InitializeTokens();
        }

        private void InitializeACSK()
        {
            comboBoxACSK.Items.Add("АЦСК ОРГАНІВ ЮСТИЦІЇ України");
            comboBoxACSK.Items.Add("АЦСК ДФС");
            comboBoxACSK.Items.Add("АЦСК Приватбанк");
            comboBoxACSK.SelectedIndex = 0;
        }

        private void InitializeTokens()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    comboBoxSelectToken.Items.Add(drive.Name);
                }
            }
            comboBoxSelectToken.SelectedIndex = 0;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
