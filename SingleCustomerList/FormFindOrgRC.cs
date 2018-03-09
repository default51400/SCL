using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleCustomerList
{
    public partial class FormFindOrgRC : Form
    {
        public string GetOrgRcFromFindForm = "";
        public string GetOrgNameFromFindForm = "";
        public FormFindOrgRC()
        {
            InitializeComponent();
            this.AcceptButton = this.buttonFormFindOrgRC;
        }

        private void buttonFormFindOrgRC_Click(object sender, EventArgs e)
        {
            using (SclContext db = new SclContext())
            {
                var org = db.Organizations.Where(p => p.OrgName.Contains(textBoxNameOrganizationFormFindOrgRC.Text));
                
                dataGridViewFindOrgRc.DataSource = org.ToList();
            }

        }

        public void dataGridViewFindOrgRc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetOrgNameFromFindForm = dataGridViewFindOrgRc.CurrentRow.Cells[2].Value.ToString();
            GetOrgRcFromFindForm = dataGridViewFindOrgRc.CurrentRow.Cells[5].Value.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
