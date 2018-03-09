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
using System.Data.Entity;
using System.Collections;

namespace SingleCustomerList
{
    public partial class FormChangeCustomer : Form
    {
        private Customer customer;
        private SclContext context;
        private Login login;
        public bool changeLogin = false; 

        public object Category { get; private set; }

        //private MyOrganization myOrgTakeInfo = new MyOrganization();
        public FormChangeCustomer(SclContext context, Customer customer = null)
        {
            this.context = context;
            InitializeComponent();
            InitializeCategories();
            InitializeRegions();
            InitializeCities();
            groupBoxLoginFormChangeCustomer.Enabled = false;

            this.customer = customer ?? new Customer();
            login = new Login();

            InitializeForm();

        }

        private void InitializeForm()
        {
            if (customer.CustomerId != 0)
            {
                textBoxNewCustSurName.Text = customer.SurName;
                textBoxNewCustFirstName.Text = customer.FirstName;
                textBoxNewCustLastName.Text = customer.LastName;
                comboBoxStatusChangeCustomer.Text = customer.UserStatus;
                textBoxNewCustUserIdINN.Text = customer.UserIdINN;
                textBoxNewCustWorkPosit.Text = customer.WorkingPosition;
                maskedTextBoxNewCustPhone.Text = customer.Phone;
                textBoxNewCustDetail.Text = customer.Detail;
                textBoxNewCustOrgNameReadOnly.Text = customer.OrganizationName;
                Login login = customer.Logins.FirstOrDefault(x => x.IsActive);
                Category category = context.Categories.FirstOrDefault(x => x.LoginCategory.Equals(login.Category.LoginCategory));
                comboBoxNewCategory.Text = category?.Name;

                City city = context.Cities.FirstOrDefault(x => x.LoginCode.Equals(login.City.LoginCode));
                comboBoxNewCustCode.Text = city?.Name;

                Region region = context.Regions.FirstOrDefault(x => x.LoginRegion.Equals(login.Region.LoginRegion));
                comboBoxNewCustRegion.Text = region?.Name;
            }
        }

        private void InitializeCities()
        {
            comboBoxNewCustCode.DataSource = context.Cities.Select(x => x.Name).ToList();
        }

        private void InitializeRegions()
        {
            comboBoxNewCustRegion.DataSource = context.Regions.Select(x => x.Name).ToList();
        }

        public void InitializeCategories()
        {
            comboBoxNewCategory.DataSource = context.Categories.Select(x => x.Name).ToList();
        }

        //static string connectionString = ConfigurationManager.ConnectionStrings["MYSQLConnection"].ConnectionString;
        //SqlConnection connection1 = new SqlConnection(connectionString);
        public Customer GetCustomer()
        {
            return customer;
        }

        public Login GetLogin()
        {
            return login;
        }
        

        private void buttonCustChange_Click(object sender, EventArgs e)
        {
            try
            {
                //id автоматом                                               
                customer.SurName = textBoxNewCustSurName.Text;           
                customer.FirstName = textBoxNewCustFirstName.Text;        
                customer.LastName = textBoxNewCustLastName.Text;          
                customer.UserStatus = "Діє";                              
                customer.UserIdINN = textBoxNewCustUserIdINN.Text;       
                customer.WorkingPosition = textBoxNewCustWorkPosit.Text;  
                customer.Phone = maskedTextBoxNewCustPhone.Text;          
                customer.Detail = textBoxNewCustDetail.Text;              
                customer.OrganizationName = textBoxNewCustOrgNameReadOnly.Text;

                /*---Получение логина---*/
                //if (comboBoxNewCustRegion.SelectedItem.ToString().Equals("Дніпропетровська обл.") == true)
                string selectedCategory = comboBoxNewCategory.SelectedItem.ToString();
                Category category = context.Categories.FirstOrDefault(x => x.Name.Equals(selectedCategory));
                login.Category = category;
                string selectedRegion = comboBoxNewCustRegion.SelectedItem.ToString();
                Region region = context.Regions.FirstOrDefault(x => x.Name.Equals(selectedRegion));
                login.Region = region;
                string selectedCity = comboBoxNewCustCode.SelectedItem.ToString();
                City city = context.Cities.FirstOrDefault(x => x.Name.Equals(selectedCity));
                login.City = city;


                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nОпис помилки: " + ex.StackTrace + "\n" + ex.Message + "\nHresult: " + ex.HResult, "Виникла помилка");
            }
            //---Получение логина-------//
            //if (comboBoxNewCustRegion.SelectedItem.ToString().Equals("Донецька обл.") == true)
            //{
            //    loginReg = "do";

            //    //case выбор организации
            //    //loginCategory = "DO";
            //}


            /*Если неправильно заполнили форму  + не забыть про DialogResult*/
            //string msgError = "";
            //if (comboBoxNewCustRegion.SelectedIndex == -1)
            //{
            //    msgError += "\nВиберіть регіон, де знаходиться організація";
            //}
            //if (comboBoxNewCategory.SelectedIndex == -1)
            //    msgError += "\nВиберіть категорію організації";
            //if (textBoxNewCustFirstName.Text == string.Empty)
            //    msgError += "\nВведіть прізвище";
            //if (msgError != "")
            //{
            //    MessageBox.Show(msgError, "Виникла помилка", MessageBoxButtons.OK);
            //    DialogResult = DialogResult.Abort;
            //}


            //loginCombined = loginReg + loginCode + loginCategory + ++loginNumber;
            //проверка наличия логина в бд
            //using (MyCustomersModel db = new MyCustomersModel())
            //{
            //    MyCustomer dbc = new MyCustomer();

            //    // db.Customers.Find(x.Login.Equals(loginCombined)
            //    ////while(myCustAdd.UserLogin.Equals(loginCombined))
            //    //if (dbc.UserLogin.Contains(loginCombined) == true)
            //    //{
            //    //    DialogResult = DialogResult.Ignore;
            //    //    loginCombined = loginReg + loginCode + loginCategory + ++loginNumber;
            //    //}


            //}


            //string sqlExpression = "INSERT INTO SCLdbTable1 (Id, Surname, FirstName, LastName, UserId, WorkingPosition, OrganizationId, OrganizationName, Region, OtherDetail) " +
            //    "VALUES (3,@_textBoxNewCustSurName, @_textBoxNewCustFirstName, @_textBoxNewCustLastName, @_textBoxNewCustUserIdINN, @_textBoxNewCustWorkPosit, @_textBoxNewCustOrgId, @_textBoxNewCustOrgName, @_comboBoxNewCustRegion, @_textBoxNewCustDetail)";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("\nОпис помилки: " + ex.Message + "\nHresult: " + ex.HResult, "Виникла помилка");
            //}
            this.Close();
        }



        private void buttonNewCustClear_Click(object sender, EventArgs e)
        {
            comboBoxNewCustRegion.SelectedIndex = -1;
            textBoxNewCustSurName.Clear();
            textBoxNewCustFirstName.Clear();
            textBoxNewCustLastName.Clear();
            textBoxNewCustUserIdINN.Clear();
            textBoxNewCustWorkPosit.Clear();
            textBoxNewCustOrgNameReadOnly.Clear();
            textBoxNewCustOrgRC.Clear();
            textBoxNewCustDetail.Clear();

            comboBoxNewCustRegion.Focus();
        }

        private void buttonNewCustAddFindOrgRC_Click(object sender, EventArgs e)
        {
            FormFindOrgRC formFindOrgRC = new FormFindOrgRC();
            if (formFindOrgRC.ShowDialog() == DialogResult.OK)
            {
                textBoxNewCustOrgRC.Text = formFindOrgRC.GetOrgRcFromFindForm;//получение код рк
                textBoxNewCustOrgNameReadOnly.Text = formFindOrgRC.GetOrgNameFromFindForm;
            }

        }

        private void comboBoxNewCustRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //рассписать поетапно
            //int selectedRegionId = context.Regions.FirstOrDefault(x => x.Name.Equals(comboBoxNewCustRegion.SelectedItem.ToString())).Id;
            //comboBoxNewCustCode.DataSource = context.Cities.Where(c => c.Region.Id == selectedRegionId).Select(x => x.Name).ToList();
        }

        private void comboBoxNewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxNewCategory.SelectedText == "Адвокати//ad")
            //if (comboBoxNewCategory.SelectedItem.ToString().Equals("Приватна нотаріальна контора"))
            //{
            //    FormAddData formAddData = new FormAddData();

            //    if (formAddData.ShowDialog() == DialogResult.OK)
            //    {
            //        //loginNumber = formAddData.AdditionalData;
            //        //if (formAddData.checkBoxNotary == true)
            //        //    loginNumber += "s1";
            //        // проверка s1,s2,s3

            //    }


            //}
        }

        private void checkBoxFormLogin_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxFormLogin.Checked == true)
            {
                if (MessageBox.Show("Ця дія приведе к видаленню логіну з бази данних:", "Увага!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    groupBoxLoginFormChangeCustomer.Enabled = true;
                    checkBoxFormLogin.Checked = true;
                    changeLogin = true;
                }
                else
                {
                    checkBoxFormLogin.Checked = false;
                    changeLogin = false;
                }

            }
            if (checkBoxFormLogin.Checked == false)
            {
                groupBoxLoginFormChangeCustomer.Enabled = false;
                checkBoxFormLogin.Checked = false;
                changeLogin = false;
            }
            context.SaveChanges();
        }
    }
}
