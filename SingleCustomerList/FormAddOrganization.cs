using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//UserAdd
using System.Configuration;//HandsAddDll
using System.Data.SqlClient;

namespace SingleCustomerList
{
    public partial class FormAddOrganization : Form
    {
        SclContext context;
        public Organization myOrgAdd = new Organization();
        public FormAddOrganization(SclContext context)
        {
            this.context = context;
            InitializeComponent();
            comboBoxNewOrgStatus.SelectedIndex = 0;
            comboBoxNewOrgRegion.SelectedIndex = -1;
            comboBoxNewOrgCategory.SelectedIndex = -1;
            InitializeCategories();
            InitializeRegions();
        }

        public Organization GetOrganization()
        {
            return myOrgAdd;
        }

        private void InitializeRegions()
        {
            comboBoxNewOrgRegion.DataSource = context.Regions.Select(x => x.Name).ToList();
        }

        public void InitializeCategories()
        {
            comboBoxNewOrgCategory.DataSource = context.Categories.Select(x => x.Name).ToList();
        }

        private void buttonNewOrgClear_Click(object sender, EventArgs e)
        {
            comboBoxNewOrgRegion.SelectedIndex = -1;
            textBoxNewOrgName.Clear();
            textBoxNewOrgShortName.Clear();
            comboBoxNewOrgCategory.SelectedIndex = -1;
            textBoxNewOrgRC.Clear();
            comboBoxNewOrgStatus.SelectedIndex = -1;
            textBoxNewOrgAddress.Clear();
            maskedTextBoxNewOrgPhone.Clear();
            textBoxNewOrgEDRPOY.Clear();
            textBoxNewOrgDetail.Clear();

            comboBoxNewOrgCategory.Focus();
        }

        private void buttonNewOrgAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myOrgAdd.OrgRegion = comboBoxNewOrgRegion.SelectedItem.ToString();
                myOrgAdd.OrgName = textBoxNewOrgName.Text;
                myOrgAdd.OrgShortName = textBoxNewOrgShortName.Text;
                myOrgAdd.OrgCategory = comboBoxNewOrgCategory.SelectedItem.ToString();
                myOrgAdd.OrgCodeRc = textBoxNewOrgRC.Text;
                myOrgAdd.OrgStatus = comboBoxNewOrgStatus.SelectedItem.ToString();
                myOrgAdd.OrgAdress = textBoxNewOrgAddress.Text;
                myOrgAdd.OrgPhone = maskedTextBoxNewOrgPhone.Text;
                myOrgAdd.OrgEDRPOY = textBoxNewOrgEDRPOY.Text;
                myOrgAdd.OrgDetail = textBoxNewOrgDetail.Text;
                

                DialogResult = DialogResult.OK;

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("\nОпис помилки: " + ex.Message + "\nHresult: " + ex.HResult , "Виникла помилка");
            }
        }
    }
}
