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
    public partial class FormAddCustomer : Form
    {
        private Customer customer;
        private SclContext context;
        private Login login;

        public object Category { get; private set; }

        //private MyOrganization myOrgTakeInfo = new MyOrganization();
        public FormAddCustomer(SclContext context, Customer customer = null)
        {
            this.context = context;

            InitializeComponent();

            InitializeCategories();
            InitializeRegions();
            InitializeCities();

            //comboBoxNewCategory.SelectedIndex = -1;
            //comboBoxNewCustRegion.SelectedIndex = -1;
            //comboBoxNewCustCode.SelectedIndex = -1;

            this.customer = customer ?? new Customer();
            login = new Login();
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

        private void buttonNewCustAdd_Click(object sender, EventArgs e)
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
            //---Получение логина----Донецк-----//
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
            //DialogResult = DialogResult.OK;


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
            //comboBoxNewCustRegion.SelectedItem = 2;
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
            int selectedRegionId = context.Regions.FirstOrDefault(x => x.Name.Equals(comboBoxNewCustRegion.SelectedItem.ToString())).Id;
            comboBoxNewCustCode.DataSource = context.Cities.Where(c => c.Region.Id == selectedRegionId).Select(x => x.Name).ToList();
        }

        private void comboBoxNewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxNewCategory.SelectedText == "Адвокати//ad")
            if (comboBoxNewCategory.SelectedItem.ToString().Equals("Приватна нотаріальна контора"))
            {
                FormAddData formAddData = new FormAddData();

                if (formAddData.ShowDialog() == DialogResult.OK)
                {
                    //loginNumber = formAddData.AdditionalData;
                    //if (formAddData.checkBoxNotary == true)
                    //    loginNumber += "s1";
                    // проверка s1,s2,s3

                }
                

            }
        }

        private void textBoxNewCustSurName_TabIndexChanged(object sender, EventArgs e)
        {
            #region Тема пока не работает, надо вычитать по этому поводу
            MessageBox.Show("asdasdas");
            try
            {
                if (string.IsNullOrEmpty(textBoxNewCustOrgNameReadOnly.ToString()))
                {
                    Organization org = context.Organizations.FirstOrDefault(p => p.OrgName.Contains(textBoxNewCustOrgRC.Text));
                    textBoxNewCustOrgNameReadOnly.Text = org.OrgShortName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n Спробуйте пошукати данну органiзацiю через пошук.\nОпис помилки: " + ex.StackTrace + "\n" + ex.Message + "\nHresult: " + ex.HResult, "Виникла помилка");
            }
            #endregion
        }
            
    }
}
