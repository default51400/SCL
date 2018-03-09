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
    public partial class FormChangeOrganization : Form
    {
        SclContext context;
        //public Organization myOrgCh;// = new Organization();
        private Organization organization;
        public FormChangeOrganization(SclContext context, Organization organization = null)
        {
            this.context = context;
            InitializeComponent();
            InitializeCategories();
            InitializeRegions();
            //comboBoxNewOrgStatus.SelectedIndex = 0;
            //comboBoxNewOrgRegion.SelectedIndex = -1;
            //comboBoxNewOrgCategory.SelectedIndex = -1;
            this.organization = organization ?? new Organization();
            InitializeForm();

        }

        public Organization GetOrganization()
        {
            return organization;
        }

        private void InitializeForm()
        {
            if (organization.OrganizationId != 0)
            {
                comboBoxNewOrgRegion.Text = organization.OrgRegion;
                textBoxNewOrgName.Text = organization.OrgName;
                textBoxNewOrgShortName.Text = organization.OrgShortName;
                comboBoxNewOrgCategory.Text = organization.OrgCategory;
                textBoxNewOrgRC.Text = organization.OrgCodeRc;
                comboBoxNewOrgStatus.Text = organization.OrgStatus;
                textBoxNewOrgAddress.Text = organization.OrgAdress;
                maskedTextBoxNewOrgPhone.Text = organization.OrgPhone;
                textBoxNewOrgEDRPOY.Text = organization.OrgEDRPOY;
                textBoxNewOrgDetail.Text = organization.OrgDetail;
            }
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

        private void buttonNewOrgChange_Click(object sender, EventArgs e)
        {
            try
            {
                organization.OrgRegion = comboBoxNewOrgRegion.SelectedItem.ToString();
                organization.OrgName = textBoxNewOrgName.Text;
                organization.OrgShortName = textBoxNewOrgShortName.Text;
                organization.OrgCategory = comboBoxNewOrgCategory.SelectedItem.ToString();
                organization.OrgCodeRc = textBoxNewOrgRC.Text;
                organization.OrgStatus = comboBoxNewOrgStatus.SelectedItem.ToString();
                organization.OrgAdress = textBoxNewOrgAddress.Text;
                organization.OrgPhone = maskedTextBoxNewOrgPhone.Text;
                organization.OrgEDRPOY = textBoxNewOrgEDRPOY.Text;
                organization.OrgDetail = textBoxNewOrgDetail.Text;
                

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
