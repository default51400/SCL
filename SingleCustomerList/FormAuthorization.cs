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
using System.Management;

namespace SingleCustomerList
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            textBoxLanguage.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
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
            //foreach (DriveInfo drive in DriveInfo.GetDrives())
            //{
            //    //if (drive.DriveType == DriveType.Removable)
            //    //{
            //        comboBoxSelectToken.Items.Add(drive.Name);
            //    //}
            //}
            string str = "1";
            
            foreach (ManagementObject device in new ManagementObjectSearcher(@"SELECT * FROM Win32_PnpEntity").Get())
            {
                //var example = device.GetPropertyValue.Contains();
                string deviceID = (string)device.GetPropertyValue("Caption");
                str += deviceID + "\n";

            }

            MessageBox.Show(str,"месседжбокс");


            var drives = DriveInfo.GetDrives().Where(driv => driv.IsReady);

            foreach (DriveInfo drive in drives)
            {
                comboBoxSelectToken.Items.Add(drive.Name);
            }
            comboBoxSelectToken.SelectedIndex = 0;
            //MessageBox.Show("asd", System.Windows.);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
