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
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq.Expressions;

namespace SingleCustomerList 
{
    public partial class FormSCL : Form
    {
        SclContext context;
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripMenuItem SaveToDocument = new ToolStripMenuItem("Iмпорт в документ");
        ToolStripMenuItem ChangeStatusCustomer = new ToolStripMenuItem("Змінити статус");
        Timer timer;
        public FormSCL()
        {
            InitializeComponent();
            context = new SclContext();
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            InitializeCategories();
            InitializeRegions();
            comboBoxRegion.SelectedIndex = -1;
            comboBoxCategory.SelectedIndex = -1;
            comboBoxOrgCategory.SelectedIndex = -1;
            comboBoxOrgRegion.SelectedIndex = -1;


            dataGridViewCustomers.AutoGenerateColumns = false;
            //ToolStripMenuItem
            contextMenuStripDataGridView.Items.AddRange(new[] { SaveToDocument, ChangeStatusCustomer });
            dataGridViewCustomers.ContextMenuStrip = contextMenuStripDataGridView;
            SaveToDocument.Click += SaveToDocument_Click;
            ChangeStatusCustomer.Click += ChangeStatusCustomer_Click;

                        
            //Get 1 sec Timer for a clock 
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();


        }

       
        //Get Now Time and Data
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void InitializeRegions()
        {
            comboBoxRegion.DataSource = context.Regions.Select(x => x.Name).ToList();
            comboBoxOrgRegion.DataSource = context.Regions.Select(x => x.Name).ToList();
        }

        public void InitializeCategories()
        {
            comboBoxCategory.DataSource = context.Categories.Select(x => x.Name).ToList();
            comboBoxOrgCategory.DataSource = context.Categories.Select(x => x.Name).ToList();
        }

        private void SaveToDocument_Click(object sender, EventArgs e)
        {            
            string custId = dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
            int cuID = System.Convert.ToInt32(custId);

            using (SclContext db = new SclContext())
            {
                var getCust = db.Customers.Where(cust => cust.CustomerId.Equals(cuID)).ToList();
                // MessageBox.Show(getCust[0].Phone.ToString());
                MessageBox.Show("Приложение требует ексель");

                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
                excelApp.Visible = true;

                workSheet.Cells[1, "A"] = "Назва організації";
                workSheet.Cells[1, "B"] = "ПІБ";
                workSheet.Cells[1, "C"] = "Посада";
                workSheet.Cells[1, "D"] = "Логін";
                workSheet.Cells[1, "E"] = "Пароль";

                var OrgName = context.Organizations.Where(p => p.OrgShortName.Equals(dataGridViewCustomers.CurrentRow.Cells[6].Value));

                //workSheet.Cells[2, "A"] = OrgName.ToString();//.Value.ToString();
                workSheet.Cells[2, "B"] = ""+dataGridViewCustomers.CurrentRow.Cells[1].Value.ToString()+" "
                    + dataGridViewCustomers.CurrentRow.Cells[2].Value.ToString()+" "
                    + dataGridViewCustomers.CurrentRow.Cells[3].Value.ToString();
                workSheet.Cells[2, "C"] = dataGridViewCustomers.CurrentRow.Cells[7].Value.ToString();
                workSheet.Cells[2, "D"] = dataGridViewCustomers.CurrentRow.Cells[10].Value.ToString();
                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files 2003(*.xls)|*.xls|Excel files 2007(*.xlsx)|*.xlsx| All files(*.*)|*.*";
                saveFileDialog.DefaultExt = ".xlsx";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                saveFileDialog.Title = "Введіть назву та виберіть шлях для збереження файлу";
                saveFileDialog.OverwritePrompt = true;

                
                try
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;
                    excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка:" + ex.ToString());
                }

                excelApp.ActiveWorkbook.Close(false);
                excelApp.Quit();
            }


        }

        private void ChangeStatusCustomer_Click(object sender, EventArgs e)
        {
            string custId = dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
            int cuID = System.Convert.ToInt32(custId);
            using (SclContext context = new SclContext())
            {
                Customer cust = context.Customers.FirstOrDefault(p => p.CustomerId.Equals(cuID));
                if (cust.UserStatus.Equals("Не діє"))
                {
                    cust.UserStatus = "Діє";
                }
                else if (cust.UserStatus.Equals("Діє"))
                {
                    cust.UserStatus = "Не діє";
                }
                else MessageBox.Show("Статус користувача має не допустиме значення");



                context.SaveChanges();
            }
        }
        /*ADO.net*/
        //static string connectionString = ConfigurationManager.ConnectionStrings["MYSQLConnection"].ConnectionString;
        // SqlConnection connection1 = new SqlConnection(connectionString);


        private void buttonClearData_Click(object sender, EventArgs e)
        {
            //comboBoxRegion.SelectedIndex = -1;
            //comboBoxRegion.ResetText();
            comboBoxRegion.SelectedIndex = -1;
            comboBoxUserStatus.SelectedIndex = -1;
            comboBoxCategory.SelectedIndex = -1;
            textBoxFIO.Clear();
            textBoxWorkPosition.Clear();
            textBoxUserINN.Clear();
            textBoxEDRPOU.Clear();
            textBoxCustNameOrganization.Clear();
            MyClearDataGridView(dataGridViewCustomers);
            textBoxFIO.Focus();

        }

        public void FillHeaderOrganizationDataGridView1()
        {
            dataGridViewOrganizations.Columns.Clear();
            DataGridViewTextBoxColumn dgvCol1 = new DataGridViewTextBoxColumn();
            dgvCol1.DataPropertyName = "OrganizationId";
            dgvCol1.HeaderText = "Ід орг.";
            DataGridViewTextBoxColumn dgvCol2 = new DataGridViewTextBoxColumn();
            dgvCol2.DataPropertyName = "OrgName";
            dgvCol2.HeaderText = "Назва організації";
            DataGridViewTextBoxColumn dgvCol3 = new DataGridViewTextBoxColumn();
            dgvCol3.DataPropertyName = "OrgShortName";
            dgvCol3.HeaderText = "Скор. назва організації";
            DataGridViewTextBoxColumn dgvCol4 = new DataGridViewTextBoxColumn();
            dgvCol4.DataPropertyName = "OrgCategory";
            dgvCol4.HeaderText = "Категорія";
            DataGridViewTextBoxColumn dgvCol5 = new DataGridViewTextBoxColumn();
            dgvCol5.DataPropertyName = "OrgCodeRc";
            dgvCol5.HeaderText = "Код РК";
            DataGridViewTextBoxColumn dgvCol6 = new DataGridViewTextBoxColumn();
            dgvCol6.DataPropertyName = "OrgStatus";
            dgvCol6.HeaderText = "Статус";
            DataGridViewTextBoxColumn dgvCol7 = new DataGridViewTextBoxColumn();
            dgvCol7.DataPropertyName = "OrgAdress";
            dgvCol7.HeaderText = "Адреса";
            DataGridViewTextBoxColumn dgvCol8 = new DataGridViewTextBoxColumn();
            dgvCol8.DataPropertyName = "OrgPhone";
            dgvCol8.HeaderText = "Телефон";
            DataGridViewTextBoxColumn dgvCol9 = new DataGridViewTextBoxColumn();
            dgvCol9.DataPropertyName = "OrgEDRPOY";
            dgvCol9.HeaderText = "ЄДРПОУ";
            DataGridViewTextBoxColumn dgvCol10 = new DataGridViewTextBoxColumn();
            dgvCol10.DataPropertyName = "OrgDetail";
            dgvCol10.HeaderText = "Деталі";
            DataGridViewTextBoxColumn dgvCol11 = new DataGridViewTextBoxColumn();
            dgvCol11.DataPropertyName = "OrgRegion";
            dgvCol11.HeaderText = "Регіон";


            dataGridViewOrganizations.Columns.AddRange(new[] { dgvCol1, dgvCol2, dgvCol3, dgvCol4, dgvCol5, dgvCol6, dgvCol7, dgvCol8, dgvCol9, dgvCol10, dgvCol11 });

        }

        public void FillHeaderCustomerDataGridView1()
        {
            dataGridViewCustomers.Columns.Clear();
            DataGridViewTextBoxColumn dgvCol0 = new DataGridViewTextBoxColumn();
            dgvCol0.DataPropertyName = "CustomerId";
            dgvCol0.HeaderText = "Ід кор.";
            DataGridViewTextBoxColumn dgvCol1 = new DataGridViewTextBoxColumn();
            dgvCol1.DataPropertyName = "SurName";
            dgvCol1.HeaderText = "Прізвище";
            DataGridViewTextBoxColumn dgvCol2 = new DataGridViewTextBoxColumn();
            dgvCol2.DataPropertyName = "FirstName";
            dgvCol2.HeaderText = "Ім'я";
            DataGridViewTextBoxColumn dgvCol3 = new DataGridViewTextBoxColumn();
            dgvCol3.DataPropertyName = "LastName";
            dgvCol3.HeaderText = "По батькові";
            DataGridViewTextBoxColumn dgvCol4 = new DataGridViewTextBoxColumn();
            dgvCol4.DataPropertyName = "UserStatus";
            dgvCol4.HeaderText = "Стан кор.";
            DataGridViewTextBoxColumn dgvCol5 = new DataGridViewTextBoxColumn();
            dgvCol5.DataPropertyName = "UserIdINN";
            dgvCol5.HeaderText = "Ідент.н.п.п.";
            DataGridViewTextBoxColumn dgvCol6 = new DataGridViewTextBoxColumn();
            dgvCol6.DataPropertyName = "OrganizationName";
            dgvCol6.HeaderText = "Назва організації";
            DataGridViewTextBoxColumn dgvCol7 = new DataGridViewTextBoxColumn();
            dgvCol7.DataPropertyName = "WorkingPosition";
            dgvCol7.HeaderText = "Посада";
            DataGridViewTextBoxColumn dgvCol8 = new DataGridViewTextBoxColumn();
            dgvCol8.DataPropertyName = "Phone";
            dgvCol8.HeaderText = "Телефон";
            DataGridViewTextBoxColumn dgvCol9 = new DataGridViewTextBoxColumn();
            dgvCol9.DataPropertyName = "Detail";
            dgvCol9.HeaderText = "Деталі";
            DataGridViewTextBoxColumn dgvCol10 = new DataGridViewTextBoxColumn();
            dgvCol10.DataPropertyName = "Login";
            dgvCol10.HeaderText = "Логін";

            dataGridViewCustomers.Columns.AddRange(new[] { dgvCol0, dgvCol1, dgvCol2, dgvCol3, dgvCol4, dgvCol5, dgvCol6, dgvCol7, dgvCol8, dgvCol9, dgvCol10,  });

        }

        public void MyClearDataGridView(DataGridView dataGridView)
        {
            ArrayList empty = new ArrayList();
            if (dataGridView == dataGridViewCustomers)
            {
                dataGridViewCustomers.DataSource = empty;
                dataGridViewCustomers.Columns.Clear();
            }

            if (dataGridView == dataGridViewOrganizations)
            {
                dataGridViewOrganizations.DataSource = empty;
                dataGridViewOrganizations.Columns.Clear();
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //connection1.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddCustomer formAddCustomer = new FormAddCustomer(context);

            if (formAddCustomer.ShowDialog() == DialogResult.OK)
            {
                
                Login login = formAddCustomer.GetLogin();
                AddLogin(login);

                Customer customer = formAddCustomer.GetCustomer();
                customer.Logins.Add(login);
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        private void buttonAddOrganization_Click(object sender, EventArgs e)
        {
            FormAddOrganization formAddOrganization = new FormAddOrganization(context);
            if (formAddOrganization.ShowDialog() == DialogResult.OK)
            {
                Organization organization = formAddOrganization.GetOrganization();
                context.Organizations.Add(organization);
                context.SaveChanges();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if ((MessageBox.Show("Ви впевнені, що бажаєте закрити програму?", "Закриття програми", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    this.Close();
                    //connection1.Close();
                }
                else return;
            }
        }

        /*private void ConnectionInfoMYSQL_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings.ElementInformation.Properties.ToString();
            MessageBox.Show(conn, "");
            /* if ( connection1.State == ConnectionState.Open)
             {
                 string connInfo = ("Свойства подключения: \nСтрока подключения:  " + connection1.ConnectionString + "\nБаза данных: " + connection1.Database + "\nСервер: " + connection1.DataSource + "\nВерсия сервера: " + connection1.ServerVersion + "\nСостояние:" + connection1.State + "\nРабочая станция:" + connection1.WorkstationId);
                 MessageBox.Show(connInfo, "Подключено к реестру пользователей", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
             else MessageBox.Show("База данных не подключена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
             
        }*/

        private void buttonFindMask_Click(object sender, EventArgs e)
        {
            string fioText = textBoxFIO.Text;
            string[] fio = fioText.Split(' ');

            try
            {
                //Dictionary<string, string> maskList = new Dictionary<string, string>();
                //dictionary
                IQueryable<Customer> query = null;

                if (!string.IsNullOrEmpty(textBoxFIO.Text.Trim()))
                    query = query?.Where(с => с.SurName.Contains(textBoxFIO.Text))
                        ?? context.Customers.Where(с => с.SurName.Contains(textBoxFIO.Text));
                /*добавить знак вопроса перед where: query = query?.Where(c => ...)
                 * это если переменная перед знаком вопроса null, то программа не вычисляет дальше 
                 * ничего и возвращает null (чтобы избежать null reference exception)
                 */
                if (!string.IsNullOrEmpty(textBoxUserINN.Text.Trim()))
                    query = query?.Where(c => c.UserIdINN.Contains(textBoxUserINN.Text))
                        ?? context.Customers.Where(c => c.UserIdINN.Contains(textBoxUserINN.Text));
                //query = query.Include(x => x.Login);
                /*РЕГИОН ЧЕРЕЗ ЛОГИН ДОСТАВАТЬ НАДО*/
                //if (!string.IsNullOrEmpty(comboBoxRegion.SelectedItem.ToString()))
                //    query = query?.Where(c => c.UserIdINN.Equals(comboBoxRegion.SelectedItem.ToString()))
                //        ?? context.Customers.Where(c => c.UserIdINN.Equals(comboBoxRegion.SelectedItem.ToString()));


                //if (!string.IsNullOrEmpty(textBoxNameOrganization.Text.Trim()))
                //    query = query.Where(c => c.OrganizationOrgCodeRC.Equals(textBoxUserINN.Text))
                //        ?? context.Customers.Where(c => c.OrganizationOrgCodeRC.Equals(textBoxUserINN.Text));

                //if (!string.IsNullOrEmpty(comboBoxUserStatus.Text.Trim()))
                //    query = query.Where(c => c.OrganizationOrgCodeRC.Equals(comboBoxUserStatus.Text))
                //        ?? context.Customers.Where(c => c.OrganizationOrgCodeRC.Equals(comboBoxUserStatus.Text));




                if (query == null)
                {
                    MessageBox.Show("Введіть критерій пошуку", "Данні для пошуку не знайдено");
                    return;
                }
                FillHeaderCustomerDataGridView1();
                
                dataGridViewCustomers.DataSource = query
                    .Select(x =>
                    new
                    {
                        x.CustomerId,
                        x.FirstName,
                        x.LastName,
                        x.SurName,
                        x.UserStatus,
                        x.UserIdINN,
                        x.WorkingPosition,
                        x.Phone,
                        x.Detail,
                        x.OrganizationName,
                        Login = x.Logins.FirstOrDefault(l => l.IsActive).FormatLogin
                    })
                    .ToList();

                //if (textBoxFIO.Text != String.Empty)
                //{
                //    //maskList.Add(textBoxFIO.Text);
                //    maskList.AddRange(new string[] 
                //    { fio.ToString() });
                //}
                //if (textBoxNameOrganization.Text != String.Empty)
                //{
                //    maskList.Add(textBoxNameOrganization.Text);
                //}
                //if (textBoxWorkPosition.Text != String.Empty)
                //{
                //    maskList.Add(textBoxWorkPosition.Text);
                //}
                //    if (textBoxUserINN.Text != String.Empty)
                //{
                //    maskList.Add(textBoxUserINN.Text);
                //}
                //if (textBoxEDRPOU.Text != String.Empty)
                //{
                //    maskList.Add(textBoxEDRPOU.Text);
                //}
                //if (comboBoxRegion.SelectedItem.ToString() != String.Empty)
                //{
                //   // maskList.Add(comboBoxRegion.SelectedText.ToString());
                //    MessageBox.Show(comboBoxRegion.SelectedText.ToString());
                //}
                //if (comboBoxType.SelectedItem.ToString() != String.Empty)
                //{
                //    maskList.Add(comboBoxRegion.SelectedItem.ToString());
                //}
                //foreach (KeyValuePair<string, string> filter in maskList)
                //{

                //}

                //var maskResult = MyCustomer
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nОпис помилки: " + ex.StackTrace + "\n" + ex.Message + "\nHresult: " + ex.HResult, "Виникла помилка");
            }
            

            //dataGridView1.DataSource = db.Customers.ToList();



            /*ADO.net*//*
            string expression = "Surname = '%" + textBoxFIO.Text + "%' AND UserId = '%" + textBoxUserINN.Text + "%'";

            string sqlExpression = "SELECT * FROM SCLdbTable1 WHERE (Surname LIKE  '%" + textBoxFIO.Text + "%' )";//AND UserId = '%" + textBoxUserINN.Text + "%' )";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection1);

            DataSet ds = new DataSet();                   // Create object Dataset
            adapter.Fill(ds);                            // Fill Dataset
            dataGridView1.DataSource = ds.Tables[0];    // View data*/

        }


        private void buttonFindMaskOrg_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("find org click!");
            try
            {
                //Dictionary<string, string> maskList = new Dictionary<string, string>();
                //dictionary
                IQueryable<Organization> query = null;

                if (!string.IsNullOrEmpty(textBoxNameOrganization.Text.Trim()))
                    query = query?.Where(с => с.OrgName.Contains(textBoxNameOrganization.Text))
                        ?? context.Organizations.Where(с => с.OrgName.Contains(textBoxNameOrganization.Text));
                /*добавить знак вопроса перед where: query = query?.Where(c => ...)
                 * это если переменная перед знаком вопроса null, то программа не вычисляет дальше 
                 * ничего и возвращает null (чтобы избежать null reference exception)
                 */
                if (!string.IsNullOrEmpty(textBoxOrgEDRPOY.Text.Trim()))
                    query = query?.Where(c => c.OrgEDRPOY.Contains(textBoxOrgEDRPOY.Text))
                        ?? context.Organizations.Where(c => c.OrgEDRPOY.Contains(textBoxOrgEDRPOY.Text));



                if (query == null)
                {
                    MessageBox.Show("Введіть критерій пошуку", "Данні для пошуку не знайдено");
                    return;
                }
                FillHeaderOrganizationDataGridView1();
                dataGridViewOrganizations.DataSource = query.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show("\nОпис помилки: " + ex.StackTrace + "\n" + ex.Message + "\nHresult: " + ex.HResult, "Виникла помилка");
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
        }
        //bool proFlag = false;
        //Task task = new Task(ProgressBarStart);
        //static void ProgressBarStart()
        //{
        //    circularProgressBar1.Text = "Завантаження \n данних";
        //    circularProgressBar1.Visible = true;

        //    for (int i=1; i<=100; i++)
        //    {
        //        //circularProgressBar1.PerformStep();
        //        //circularProgressBar1.Value = 10*i;
        //        //circularProgressBar1.Update();
        //    }
        //}
        private void buttonFindAllCustomers_Click(object sender, EventArgs e)
        {
            //доделать прогрессбар
            //circularProgressBar1.Minimum = 1;
            //circularProgressBar1.Maximum = 100;
            //circularProgressBar1.Step = 1;
            //proFlag = true;
            //ProgressBarStart();
            FillHeaderCustomerDataGridView1();
            //dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic();
            dataGridViewCustomers.DataSource = context.Customers.Select(x =>
                    new
                    {
                        x.CustomerId,
                        x.FirstName,
                        x.LastName,
                        x.SurName,
                        x.UserStatus,
                        x.UserIdINN,
                        x.WorkingPosition,
                        x.Phone,
                        x.Detail,
                        x.OrganizationName,
                        Login = x.Logins.FirstOrDefault(l => l.IsActive).FormatLogin
                    })
                    .ToList();
            //proFlag = false;
            //circularProgressBar1.Visible = false;

            /*ADO.NET*  string sqlExpression = "SELECT * FROM SCLdbTable1";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection1);

            DataSet ds = new DataSet();                   // Create object Dataset
            adapter.Fill(ds);                            // Fill Dataset
            dataGridView1.DataSource = ds.Tables[0];    // View data*/
        }

        private void buttonFindAllOrganizations_Click(object sender, EventArgs e)
        {
            FillHeaderOrganizationDataGridView1();
            dataGridViewOrganizations.DataSource = context.Organizations.ToList();
        }

        private void dataGridViewCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            if (e.RowIndex == -1 && dataGridViewCustomers.SelectedCells.Count > 0)
                return;

            int selectedRowIndex = dataGridViewCustomers.SelectedCells[0].RowIndex;
            dataGridViewCustomers.Rows[selectedRowIndex].Selected = true;
            //TODO: Refactor this shit, because selcust is not original and have changes (+login,region...)
            dynamic selectedCustomer = dataGridViewCustomers.Rows[selectedRowIndex].DataBoundItem;
            int customerId = selectedCustomer.CustomerId;
            Customer customer = context
                .Customers
                .Where(x => x.CustomerId == customerId)
                .Include(c => c.Logins)
                .Include(c => c.Logins.Select(s => s.Category))
                .Include(c => c.Logins.Select(s => s.Region))
                .Include(c => c.Logins.Select(s => s.City))
                .FirstOrDefault();
            FormChangeCustomer formChangeCustomer = new FormChangeCustomer(context, customer);
            //formChangeCustomer.ShowDialog();
            //DataGridView dgv = sender as DataGridView;
            //var x = dgv.SelectedCells;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (formChangeCustomer.ShowDialog() == DialogResult.OK)
            {
                if (formChangeCustomer.changeLogin == true)
                {
                    foreach (Login existingLogin in customer.Logins)
                    {
                        existingLogin.IsActive = false;
                    }
                    Login login = formChangeCustomer.GetLogin();
                    AddLogin(login);
                    Customer customerCh = formChangeCustomer.GetCustomer();
                    //тут будут множиться логины, так как он не изменяется, а формируется новый
                    customerCh.Logins.Add(login);
                    customer = customerCh;
                    context.SaveChanges();
                }
                if (formChangeCustomer.changeLogin == false)
                {
                    Customer customerCh = formChangeCustomer.GetCustomer();
                    customer = customerCh;
                    context.SaveChanges();
                }
            }
        }

        private void dataGridViewOrganizations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && dataGridViewOrganizations.SelectedCells.Count > 0)
                return;

            int selectedRowIndex = dataGridViewOrganizations.SelectedCells[0].RowIndex;
            dataGridViewOrganizations.Rows[selectedRowIndex].Selected = true;
            int id = Convert.ToInt32(dataGridViewOrganizations.Rows[e.RowIndex].Cells[0].Value.ToString());
            //var selectedOrganization = context.Organizations.Where(p=>p.OrganizationId == id);/*.FirstOrDefault(p=>p.OrganizationId.Equals(id));*/
            dynamic selectedOrganization = dataGridViewOrganizations.Rows[selectedRowIndex].DataBoundItem;
            
            int organizationId = selectedOrganization.OrganizationId;
            Organization organization = context
                .Organizations
                .Where(x => x.OrganizationId.Equals(organizationId))
                .FirstOrDefault();


            FormChangeOrganization formChangeOrganization = new FormChangeOrganization(context, organization);

            if (formChangeOrganization.ShowDialog() == DialogResult.OK)
            {

                Organization orgCh = formChangeOrganization.GetOrganization();
                organization = orgCh;
                context.SaveChanges();

            }
        }

        private void AddLogin(Login login)
        {
            IEnumerable<Login> logins = context.Logins
                                .Where(x => x.Region.LoginRegion.Equals(login.Region.LoginRegion)
                                && x.City.LoginCode.Equals(login.City.LoginCode)
                                && x.Category.LoginCategory.Equals(login.Category.LoginCategory));
            string lastCreatedNumber = logins.OrderByDescending(x => x.Number).FirstOrDefault()?.Number;
            int number;
            Int32.TryParse(lastCreatedNumber, out number);
            number++;
            login.Number = number.ToString("D4");
            login.BuildLogin();
            login.IsActive = true;
            context.Logins.Add(login);
        }

        private void buttonFindOrganization_Click(object sender, EventArgs e)
        {
                tabControlFind.SelectedTab = tabPageOrganizations;
        }

        private void buttonOrgClearData_Click(object sender, EventArgs e)
        {
            comboBoxOrgRegion.SelectedIndex = -1;
            comboBoxOrgStatus.SelectedIndex = -1;
            comboBoxOrgCategory.SelectedIndex = -1;
            textBoxNameOrganization.Clear();
            textBoxOrgEDRPOY.Clear();
            MyClearDataGridView(dataGridViewOrganizations);
            textBoxNameOrganization.Focus();
        }

        private void buttonOrgCustomers_Click(object sender, EventArgs e)
        {
            tabControlFind.SelectedTab = tabPageCustomers;
        }

        private void tabControlFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlFind.SelectedTab == tabPageCustomers)
            {
                //Enter as buttonFindMask in tabCustomers
                this.AcceptButton = this.buttonFindMask;
            }
            if (tabControlFind.SelectedTab == tabPageOrganizations)
            {
                //Enter as buttonFindMaskOrg in tabOrganizations
                this.AcceptButton = this.buttonFindMaskOrg;
            }

        }

        private void очиститьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (context.Database.Delete() == true)
            {
                MessageBox.Show("Успешно удалена база данных и вся информация в ней!");
            }
            else
                MessageBox.Show("Проблеммы с удалением базы данных!");

            context.Database.Create();
            
            //context.Database.Delete();

            //if (context.Database.Create() == true)
            //{
            //    MessageBox.Show("Успешно удалена база данных и вся информация в ней!");
            //}
            //else
            //    MessageBox.Show("Проблеммы с удалением базы данных!");

        }

        private void dataGridViewCustomers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dataGridViewCustomers.ClearSelection();

                    this.dataGridViewCustomers.CurrentCell =  dataGridViewCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.dataGridViewCustomers.CurrentCell.Selected = true;
                    //this.dataGridViewCustomers.SelectedCells
                }
            }
        }
    }
}
