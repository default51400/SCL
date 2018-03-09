namespace SingleCustomerList
{
    partial class FormSCL
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSCL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.МенюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisonnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionInfoMYSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.Label();
            this.contextMenuStripDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlFind = new System.Windows.Forms.TabControl();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.buttonFindOrganization = new System.Windows.Forms.Button();
            this.buttonFindMask = new System.Windows.Forms.Button();
            this.labelEDRPOU = new System.Windows.Forms.Label();
            this.textBoxEDRPOU = new System.Windows.Forms.TextBox();
            this.comboBoxUserStatus = new System.Windows.Forms.ComboBox();
            this.labelUserStatus = new System.Windows.Forms.Label();
            this.labelUserINN = new System.Windows.Forms.Label();
            this.textBoxUserINN = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.buttonFindAllCustomers = new System.Windows.Forms.Button();
            this.labelNameOrganization = new System.Windows.Forms.Label();
            this.textBoxCustNameOrganization = new System.Windows.Forms.TextBox();
            this.textBoxWorkPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.tabPageOrganizations = new System.Windows.Forms.TabPage();
            this.dataGridViewOrganizations = new System.Windows.Forms.DataGridView();
            this.buttonOrgCustomers = new System.Windows.Forms.Button();
            this.buttonFindMaskOrg = new System.Windows.Forms.Button();
            this.buttonOrgClearData = new System.Windows.Forms.Button();
            this.textBoxOrgEDRPOY = new System.Windows.Forms.TextBox();
            this.textBoxNameOrganization = new System.Windows.Forms.TextBox();
            this.comboBoxOrgRegion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFindAllOrganizations = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOrgCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxOrgStatus = new System.Windows.Forms.ComboBox();
            this.buttonAddOrganization = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCLdbTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControlFind.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPageOrganizations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCLdbTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.МенюToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // МенюToolStripMenuItem1
            // 
            this.МенюToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьБДToolStripMenuItem});
            resources.ApplyResources(this.МенюToolStripMenuItem1, "МенюToolStripMenuItem1");
            this.МенюToolStripMenuItem1.Name = "МенюToolStripMenuItem1";
            // 
            // очиститьБДToolStripMenuItem
            // 
            this.очиститьБДToolStripMenuItem.Name = "очиститьБДToolStripMenuItem";
            resources.ApplyResources(this.очиститьБДToolStripMenuItem, "очиститьБДToolStripMenuItem");
            this.очиститьБДToolStripMenuItem.Click += new System.EventHandler(this.очиститьБДToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            resources.ApplyResources(this.ConnectToolStripMenuItem, "ConnectToolStripMenuItem");
            // 
            // DisonnectToolStripMenuItem
            // 
            this.DisonnectToolStripMenuItem.Name = "DisonnectToolStripMenuItem";
            resources.ApplyResources(this.DisonnectToolStripMenuItem, "DisonnectToolStripMenuItem");
            // 
            // ConnectionInfoMYSQL
            // 
            this.ConnectionInfoMYSQL.Name = "ConnectionInfoMYSQL";
            resources.ApplyResources(this.ConnectionInfoMYSQL, "ConnectionInfoMYSQL");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // contextMenuStripDataGridView
            // 
            this.contextMenuStripDataGridView.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStripDataGridView, "contextMenuStripDataGridView");
            // 
            // tabControlFind
            // 
            this.tabControlFind.Controls.Add(this.tabPageCustomers);
            this.tabControlFind.Controls.Add(this.tabPageOrganizations);
            resources.ApplyResources(this.tabControlFind, "tabControlFind");
            this.tabControlFind.Name = "tabControlFind";
            this.tabControlFind.SelectedIndex = 0;
            this.tabControlFind.SelectedIndexChanged += new System.EventHandler(this.tabControlFind_SelectedIndexChanged);
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.circularProgressBar1);
            this.tabPageCustomers.Controls.Add(this.buttonFindOrganization);
            this.tabPageCustomers.Controls.Add(this.buttonFindMask);
            this.tabPageCustomers.Controls.Add(this.labelEDRPOU);
            this.tabPageCustomers.Controls.Add(this.textBoxEDRPOU);
            this.tabPageCustomers.Controls.Add(this.comboBoxUserStatus);
            this.tabPageCustomers.Controls.Add(this.labelUserStatus);
            this.tabPageCustomers.Controls.Add(this.labelUserINN);
            this.tabPageCustomers.Controls.Add(this.textBoxUserINN);
            this.tabPageCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabPageCustomers.Controls.Add(this.buttonAdd);
            this.tabPageCustomers.Controls.Add(this.buttonClearData);
            this.tabPageCustomers.Controls.Add(this.buttonFindAllCustomers);
            this.tabPageCustomers.Controls.Add(this.labelNameOrganization);
            this.tabPageCustomers.Controls.Add(this.textBoxCustNameOrganization);
            this.tabPageCustomers.Controls.Add(this.textBoxWorkPosition);
            this.tabPageCustomers.Controls.Add(this.label1);
            this.tabPageCustomers.Controls.Add(this.labelRegion);
            this.tabPageCustomers.Controls.Add(this.comboBoxRegion);
            this.tabPageCustomers.Controls.Add(this.labelFIO);
            this.tabPageCustomers.Controls.Add(this.textBoxFIO);
            this.tabPageCustomers.Controls.Add(this.labelType);
            this.tabPageCustomers.Controls.Add(this.comboBoxCategory);
            resources.ApplyResources(this.tabPageCustomers, "tabPageCustomers");
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.circularProgressBar1, "circularProgressBar1");
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.ControlDark;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Teal;
            this.circularProgressBar1.OuterMargin = -15;
            this.circularProgressBar1.OuterWidth = 8;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.SkyBlue;
            this.circularProgressBar1.ProgressWidth = 20;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 67;
            // 
            // buttonFindOrganization
            // 
            resources.ApplyResources(this.buttonFindOrganization, "buttonFindOrganization");
            this.buttonFindOrganization.Name = "buttonFindOrganization";
            this.buttonFindOrganization.UseVisualStyleBackColor = true;
            this.buttonFindOrganization.Click += new System.EventHandler(this.buttonFindOrganization_Click);
            // 
            // buttonFindMask
            // 
            resources.ApplyResources(this.buttonFindMask, "buttonFindMask");
            this.buttonFindMask.Name = "buttonFindMask";
            this.buttonFindMask.UseVisualStyleBackColor = true;
            this.buttonFindMask.Click += new System.EventHandler(this.buttonFindMask_Click);
            // 
            // labelEDRPOU
            // 
            resources.ApplyResources(this.labelEDRPOU, "labelEDRPOU");
            this.labelEDRPOU.Name = "labelEDRPOU";
            // 
            // textBoxEDRPOU
            // 
            resources.ApplyResources(this.textBoxEDRPOU, "textBoxEDRPOU");
            this.textBoxEDRPOU.Name = "textBoxEDRPOU";
            // 
            // comboBoxUserStatus
            // 
            resources.ApplyResources(this.comboBoxUserStatus, "comboBoxUserStatus");
            this.comboBoxUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserStatus.FormattingEnabled = true;
            this.comboBoxUserStatus.Items.AddRange(new object[] {
            resources.GetString("comboBoxUserStatus.Items"),
            resources.GetString("comboBoxUserStatus.Items1")});
            this.comboBoxUserStatus.Name = "comboBoxUserStatus";
            // 
            // labelUserStatus
            // 
            resources.ApplyResources(this.labelUserStatus, "labelUserStatus");
            this.labelUserStatus.Name = "labelUserStatus";
            // 
            // labelUserINN
            // 
            resources.ApplyResources(this.labelUserINN, "labelUserINN");
            this.labelUserINN.Name = "labelUserINN";
            // 
            // textBoxUserINN
            // 
            resources.ApplyResources(this.textBoxUserINN, "textBoxUserINN");
            this.textBoxUserINN.Name = "textBoxUserINN";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewCustomers, "dataGridViewCustomers");
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellDoubleClick);
            this.dataGridViewCustomers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomers_CellMouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClearData
            // 
            resources.ApplyResources(this.buttonClearData, "buttonClearData");
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // buttonFindAllCustomers
            // 
            resources.ApplyResources(this.buttonFindAllCustomers, "buttonFindAllCustomers");
            this.buttonFindAllCustomers.Name = "buttonFindAllCustomers";
            this.buttonFindAllCustomers.UseVisualStyleBackColor = true;
            this.buttonFindAllCustomers.Click += new System.EventHandler(this.buttonFindAllCustomers_Click);
            // 
            // labelNameOrganization
            // 
            resources.ApplyResources(this.labelNameOrganization, "labelNameOrganization");
            this.labelNameOrganization.Name = "labelNameOrganization";
            // 
            // textBoxCustNameOrganization
            // 
            resources.ApplyResources(this.textBoxCustNameOrganization, "textBoxCustNameOrganization");
            this.textBoxCustNameOrganization.Name = "textBoxCustNameOrganization";
            // 
            // textBoxWorkPosition
            // 
            resources.ApplyResources(this.textBoxWorkPosition, "textBoxWorkPosition");
            this.textBoxWorkPosition.Name = "textBoxWorkPosition";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelRegion
            // 
            resources.ApplyResources(this.labelRegion, "labelRegion");
            this.labelRegion.Name = "labelRegion";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegion.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxRegion, "comboBoxRegion");
            this.comboBoxRegion.Name = "comboBoxRegion";
            // 
            // labelFIO
            // 
            resources.ApplyResources(this.labelFIO, "labelFIO");
            this.labelFIO.Name = "labelFIO";
            // 
            // textBoxFIO
            // 
            resources.ApplyResources(this.textBoxFIO, "textBoxFIO");
            this.textBoxFIO.Name = "textBoxFIO";
            // 
            // labelType
            // 
            resources.ApplyResources(this.labelType, "labelType");
            this.labelType.Name = "labelType";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCategory, "comboBoxCategory");
            this.comboBoxCategory.Name = "comboBoxCategory";
            // 
            // tabPageOrganizations
            // 
            this.tabPageOrganizations.Controls.Add(this.dataGridViewOrganizations);
            this.tabPageOrganizations.Controls.Add(this.buttonOrgCustomers);
            this.tabPageOrganizations.Controls.Add(this.buttonFindMaskOrg);
            this.tabPageOrganizations.Controls.Add(this.buttonOrgClearData);
            this.tabPageOrganizations.Controls.Add(this.textBoxOrgEDRPOY);
            this.tabPageOrganizations.Controls.Add(this.textBoxNameOrganization);
            this.tabPageOrganizations.Controls.Add(this.comboBoxOrgRegion);
            this.tabPageOrganizations.Controls.Add(this.label3);
            this.tabPageOrganizations.Controls.Add(this.buttonFindAllOrganizations);
            this.tabPageOrganizations.Controls.Add(this.label2);
            this.tabPageOrganizations.Controls.Add(this.comboBoxOrgCategory);
            this.tabPageOrganizations.Controls.Add(this.comboBoxOrgStatus);
            this.tabPageOrganizations.Controls.Add(this.buttonAddOrganization);
            this.tabPageOrganizations.Controls.Add(this.label4);
            this.tabPageOrganizations.Controls.Add(this.label5);
            this.tabPageOrganizations.Controls.Add(this.label6);
            resources.ApplyResources(this.tabPageOrganizations, "tabPageOrganizations");
            this.tabPageOrganizations.Name = "tabPageOrganizations";
            this.tabPageOrganizations.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrganizations
            // 
            this.dataGridViewOrganizations.AllowUserToAddRows = false;
            this.dataGridViewOrganizations.AllowUserToDeleteRows = false;
            this.dataGridViewOrganizations.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewOrganizations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dataGridViewOrganizations, "dataGridViewOrganizations");
            this.dataGridViewOrganizations.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewOrganizations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrganizations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganizations.Name = "dataGridViewOrganizations";
            this.dataGridViewOrganizations.ReadOnly = true;
            this.dataGridViewOrganizations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrganizations_CellDoubleClick);
            // 
            // buttonOrgCustomers
            // 
            resources.ApplyResources(this.buttonOrgCustomers, "buttonOrgCustomers");
            this.buttonOrgCustomers.Name = "buttonOrgCustomers";
            this.buttonOrgCustomers.UseVisualStyleBackColor = true;
            this.buttonOrgCustomers.Click += new System.EventHandler(this.buttonOrgCustomers_Click);
            // 
            // buttonFindMaskOrg
            // 
            resources.ApplyResources(this.buttonFindMaskOrg, "buttonFindMaskOrg");
            this.buttonFindMaskOrg.Name = "buttonFindMaskOrg";
            this.buttonFindMaskOrg.UseVisualStyleBackColor = true;
            this.buttonFindMaskOrg.Click += new System.EventHandler(this.buttonFindMaskOrg_Click);
            // 
            // buttonOrgClearData
            // 
            resources.ApplyResources(this.buttonOrgClearData, "buttonOrgClearData");
            this.buttonOrgClearData.Name = "buttonOrgClearData";
            this.buttonOrgClearData.UseVisualStyleBackColor = true;
            this.buttonOrgClearData.Click += new System.EventHandler(this.buttonOrgClearData_Click);
            // 
            // textBoxOrgEDRPOY
            // 
            resources.ApplyResources(this.textBoxOrgEDRPOY, "textBoxOrgEDRPOY");
            this.textBoxOrgEDRPOY.Name = "textBoxOrgEDRPOY";
            // 
            // textBoxNameOrganization
            // 
            resources.ApplyResources(this.textBoxNameOrganization, "textBoxNameOrganization");
            this.textBoxNameOrganization.Name = "textBoxNameOrganization";
            // 
            // comboBoxOrgRegion
            // 
            this.comboBoxOrgRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrgRegion.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxOrgRegion, "comboBoxOrgRegion");
            this.comboBoxOrgRegion.Name = "comboBoxOrgRegion";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // buttonFindAllOrganizations
            // 
            resources.ApplyResources(this.buttonFindAllOrganizations, "buttonFindAllOrganizations");
            this.buttonFindAllOrganizations.Name = "buttonFindAllOrganizations";
            this.buttonFindAllOrganizations.UseVisualStyleBackColor = true;
            this.buttonFindAllOrganizations.Click += new System.EventHandler(this.buttonFindAllOrganizations_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBoxOrgCategory
            // 
            this.comboBoxOrgCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrgCategory.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxOrgCategory, "comboBoxOrgCategory");
            this.comboBoxOrgCategory.Name = "comboBoxOrgCategory";
            // 
            // comboBoxOrgStatus
            // 
            resources.ApplyResources(this.comboBoxOrgStatus, "comboBoxOrgStatus");
            this.comboBoxOrgStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrgStatus.FormattingEnabled = true;
            this.comboBoxOrgStatus.Items.AddRange(new object[] {
            resources.GetString("comboBoxOrgStatus.Items"),
            resources.GetString("comboBoxOrgStatus.Items1")});
            this.comboBoxOrgStatus.Name = "comboBoxOrgStatus";
            // 
            // buttonAddOrganization
            // 
            resources.ApplyResources(this.buttonAddOrganization, "buttonAddOrganization");
            this.buttonAddOrganization.Name = "buttonAddOrganization";
            this.buttonAddOrganization.UseVisualStyleBackColor = true;
            this.buttonAddOrganization.Click += new System.EventHandler(this.buttonAddOrganization_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // FormSCL
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlFind);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSCL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlFind.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPageOrganizations.ResumeLayout(false);
            this.tabPageOrganizations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCLdbTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem DisonnectToolStripMenuItem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ToolStripMenuItem ConnectionInfoMYSQL;
        private System.Windows.Forms.BindingSource sCLdbTable1BindingSource;
        private System.Windows.Forms.BindingSource myCustomersBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridView;
        private System.Windows.Forms.ToolStripMenuItem МенюToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControlFind;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageOrganizations;
        private System.Windows.Forms.Button buttonFindAllOrganizations;
        private System.Windows.Forms.Button buttonAddOrganization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameOrganization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrgEDRPOY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrgStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOrgRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOrgCategory;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button buttonFindOrganization;
        private System.Windows.Forms.Button buttonFindMask;
        private System.Windows.Forms.Label labelEDRPOU;
        private System.Windows.Forms.TextBox textBoxEDRPOU;
        private System.Windows.Forms.ComboBox comboBoxUserStatus;
        private System.Windows.Forms.Label labelUserStatus;
        private System.Windows.Forms.Label labelUserINN;
        private System.Windows.Forms.TextBox textBoxUserINN;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Button buttonFindAllCustomers;
        private System.Windows.Forms.Label labelNameOrganization;
        private System.Windows.Forms.TextBox textBoxCustNameOrganization;
        private System.Windows.Forms.TextBox textBoxWorkPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonOrgCustomers;
        private System.Windows.Forms.Button buttonFindMaskOrg;
        private System.Windows.Forms.Button buttonOrgClearData;
        private System.Windows.Forms.DataGridView dataGridViewOrganizations;
        private System.Windows.Forms.ToolStripMenuItem очиститьБДToolStripMenuItem;
    }
}

