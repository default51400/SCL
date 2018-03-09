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
    public partial class FormAddData : Form
    {
        public string AdditionalData;
        public bool checkBoxNotary;
        public FormAddData()
        {
            InitializeComponent();
        }

        private void buttonOkFormAddData_Click(object sender, EventArgs e)
        {
            checkBoxNotary = false;
            AdditionalData = textBoxFormAddData.Text;

            if(checkBoxFormAddData.Checked == true)
                checkBoxNotary = true;

            DialogResult = DialogResult.OK;
        }
    }
}
