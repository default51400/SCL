namespace SingleCustomerList
{
    partial class FormChangeCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeCustomer));
            this.comboBoxNewCustRegion = new System.Windows.Forms.ComboBox();
            this.textBoxNewCustSurName = new System.Windows.Forms.TextBox();
            this.textBoxNewCustFirstName = new System.Windows.Forms.TextBox();
            this.textBoxNewCustLastName = new System.Windows.Forms.TextBox();
            this.textBoxNewCustUserIdINN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNewCustWorkPosit = new System.Windows.Forms.TextBox();
            this.textBoxNewCustOrgNameReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxNewCustOrgRC = new System.Windows.Forms.TextBox();
            this.textBoxNewCustDetail = new System.Windows.Forms.TextBox();
            this.buttonCustChange = new System.Windows.Forms.Button();
            this.buttonNewCustClear = new System.Windows.Forms.Button();
            this.toolTipAddCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNewCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBoxNewCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonNewCustAddFindOrgRC = new System.Windows.Forms.Button();
            this.groupBoxLoginFormChangeCustomer = new System.Windows.Forms.GroupBox();
            this.comboBoxNewCustCode = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxStatusChangeCustomer = new System.Windows.Forms.ComboBox();
            this.checkBoxFormLogin = new System.Windows.Forms.CheckBox();
            this.groupBoxLoginFormChangeCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNewCustRegion
            // 
            this.comboBoxNewCustRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewCustRegion.FormattingEnabled = true;
            this.comboBoxNewCustRegion.Items.AddRange(new object[] {
            "Дніпропетровська обл.",
            "Донецька обл."});
            this.comboBoxNewCustRegion.Location = new System.Drawing.Point(156, 46);
            this.comboBoxNewCustRegion.Name = "comboBoxNewCustRegion";
            this.comboBoxNewCustRegion.Size = new System.Drawing.Size(206, 21);
            this.comboBoxNewCustRegion.TabIndex = 0;
            this.comboBoxNewCustRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewCustRegion_SelectedIndexChanged);
            // 
            // textBoxNewCustSurName
            // 
            this.textBoxNewCustSurName.Location = new System.Drawing.Point(77, 12);
            this.textBoxNewCustSurName.Name = "textBoxNewCustSurName";
            this.textBoxNewCustSurName.Size = new System.Drawing.Size(288, 20);
            this.textBoxNewCustSurName.TabIndex = 1;
            // 
            // textBoxNewCustFirstName
            // 
            this.textBoxNewCustFirstName.Location = new System.Drawing.Point(77, 41);
            this.textBoxNewCustFirstName.Name = "textBoxNewCustFirstName";
            this.textBoxNewCustFirstName.Size = new System.Drawing.Size(288, 20);
            this.textBoxNewCustFirstName.TabIndex = 2;
            // 
            // textBoxNewCustLastName
            // 
            this.textBoxNewCustLastName.Location = new System.Drawing.Point(88, 70);
            this.textBoxNewCustLastName.Name = "textBoxNewCustLastName";
            this.textBoxNewCustLastName.Size = new System.Drawing.Size(277, 20);
            this.textBoxNewCustLastName.TabIndex = 3;
            // 
            // textBoxNewCustUserIdINN
            // 
            this.textBoxNewCustUserIdINN.Location = new System.Drawing.Point(143, 96);
            this.textBoxNewCustUserIdINN.MaxLength = 10;
            this.textBoxNewCustUserIdINN.Name = "textBoxNewCustUserIdINN";
            this.textBoxNewCustUserIdINN.Size = new System.Drawing.Size(222, 20);
            this.textBoxNewCustUserIdINN.TabIndex = 4;
            this.toolTipAddCustomer.SetToolTip(this.textBoxNewCustUserIdINN, "Вводить ИНН только цифрами, если у человека нет ИНН - вводится серия и номер пасс" +
        "порта. ( 10 цифр либо 2 буквы и 6 цифры )");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Регіон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Прізвище:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ім\'я:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "По батькові:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Код платника податків:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Посада:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Назва організації:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Код РК організації:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Додаткова інформація:";
            // 
            // textBoxNewCustWorkPosit
            // 
            this.textBoxNewCustWorkPosit.Location = new System.Drawing.Point(77, 149);
            this.textBoxNewCustWorkPosit.Name = "textBoxNewCustWorkPosit";
            this.textBoxNewCustWorkPosit.Size = new System.Drawing.Size(288, 20);
            this.textBoxNewCustWorkPosit.TabIndex = 6;
            // 
            // textBoxNewCustOrgNameReadOnly
            // 
            this.textBoxNewCustOrgNameReadOnly.Location = new System.Drawing.Point(121, 203);
            this.textBoxNewCustOrgNameReadOnly.MaxLength = 8;
            this.textBoxNewCustOrgNameReadOnly.Name = "textBoxNewCustOrgNameReadOnly";
            this.textBoxNewCustOrgNameReadOnly.ReadOnly = true;
            this.textBoxNewCustOrgNameReadOnly.Size = new System.Drawing.Size(244, 20);
            this.textBoxNewCustOrgNameReadOnly.TabIndex = 15;
            this.toolTipAddCustomer.SetToolTip(this.textBoxNewCustOrgNameReadOnly, "Вводить только ЕДРПОУ организации цифрами ( 8 цифр )");
            // 
            // textBoxNewCustOrgRC
            // 
            this.textBoxNewCustOrgRC.Location = new System.Drawing.Point(121, 175);
            this.textBoxNewCustOrgRC.Name = "textBoxNewCustOrgRC";
            this.textBoxNewCustOrgRC.Size = new System.Drawing.Size(204, 20);
            this.textBoxNewCustOrgRC.TabIndex = 7;
            // 
            // textBoxNewCustDetail
            // 
            this.textBoxNewCustDetail.Location = new System.Drawing.Point(181, 229);
            this.textBoxNewCustDetail.Name = "textBoxNewCustDetail";
            this.textBoxNewCustDetail.Size = new System.Drawing.Size(184, 20);
            this.textBoxNewCustDetail.TabIndex = 10;
            // 
            // buttonCustChange
            // 
            this.buttonCustChange.Location = new System.Drawing.Point(15, 457);
            this.buttonCustChange.Name = "buttonCustChange";
            this.buttonCustChange.Size = new System.Drawing.Size(374, 23);
            this.buttonCustChange.TabIndex = 11;
            this.buttonCustChange.Text = "Зберегти";
            this.buttonCustChange.UseVisualStyleBackColor = true;
            this.buttonCustChange.Click += new System.EventHandler(this.buttonCustChange_Click);
            // 
            // buttonNewCustClear
            // 
            this.buttonNewCustClear.Location = new System.Drawing.Point(261, 428);
            this.buttonNewCustClear.Name = "buttonNewCustClear";
            this.buttonNewCustClear.Size = new System.Drawing.Size(128, 23);
            this.buttonNewCustClear.TabIndex = 19;
            this.buttonNewCustClear.Text = "Очистити";
            this.buttonNewCustClear.UseVisualStyleBackColor = true;
            this.buttonNewCustClear.Click += new System.EventHandler(this.buttonNewCustClear_Click);
            // 
            // toolTipAddCustomer
            // 
            this.toolTipAddCustomer.AutomaticDelay = 200;
            this.toolTipAddCustomer.AutoPopDelay = 20000;
            this.toolTipAddCustomer.InitialDelay = 200;
            this.toolTipAddCustomer.ReshowDelay = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Категорія організації:";
            // 
            // comboBoxNewCategory
            // 
            this.comboBoxNewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewCategory.FormattingEnabled = true;
            this.comboBoxNewCategory.Location = new System.Drawing.Point(143, 19);
            this.comboBoxNewCategory.Name = "comboBoxNewCategory";
            this.comboBoxNewCategory.Size = new System.Drawing.Size(219, 21);
            this.comboBoxNewCategory.TabIndex = 9;
            this.comboBoxNewCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewCategory_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Телефон:";
            // 
            // maskedTextBoxNewCustPhone
            // 
            this.maskedTextBoxNewCustPhone.Location = new System.Drawing.Point(77, 123);
            this.maskedTextBoxNewCustPhone.Mask = "(999) 000-0000;AAAAAAAAAAAAAA (999) 000-0000;AAAAAAAAAAAAAA";
            this.maskedTextBoxNewCustPhone.Name = "maskedTextBoxNewCustPhone";
            this.maskedTextBoxNewCustPhone.Size = new System.Drawing.Size(288, 20);
            this.maskedTextBoxNewCustPhone.TabIndex = 5;
            // 
            // buttonNewCustAddFindOrgRC
            // 
            this.buttonNewCustAddFindOrgRC.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewCustAddFindOrgRC.Image")));
            this.buttonNewCustAddFindOrgRC.Location = new System.Drawing.Point(331, 175);
            this.buttonNewCustAddFindOrgRC.Name = "buttonNewCustAddFindOrgRC";
            this.buttonNewCustAddFindOrgRC.Size = new System.Drawing.Size(34, 20);
            this.buttonNewCustAddFindOrgRC.TabIndex = 8;
            this.buttonNewCustAddFindOrgRC.UseVisualStyleBackColor = true;
            this.buttonNewCustAddFindOrgRC.Click += new System.EventHandler(this.buttonNewCustAddFindOrgRC_Click);
            // 
            // groupBoxLoginFormChangeCustomer
            // 
            this.groupBoxLoginFormChangeCustomer.Controls.Add(this.comboBoxNewCustCode);
            this.groupBoxLoginFormChangeCustomer.Controls.Add(this.label12);
            this.groupBoxLoginFormChangeCustomer.Controls.Add(this.comboBoxNewCategory);
            this.groupBoxLoginFormChangeCustomer.Controls.Add(this.comboBoxNewCustRegion);
            this.groupBoxLoginFormChangeCustomer.Controls.Add(this.label1);
            this.groupBoxLoginFormChangeCustomer.Controls.Add(this.label10);
            this.groupBoxLoginFormChangeCustomer.Location = new System.Drawing.Point(3, 294);
            this.groupBoxLoginFormChangeCustomer.Name = "groupBoxLoginFormChangeCustomer";
            this.groupBoxLoginFormChangeCustomer.Size = new System.Drawing.Size(379, 107);
            this.groupBoxLoginFormChangeCustomer.TabIndex = 24;
            this.groupBoxLoginFormChangeCustomer.TabStop = false;
            this.groupBoxLoginFormChangeCustomer.Text = "Формування логіну";
            // 
            // comboBoxNewCustCode
            // 
            this.comboBoxNewCustCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewCustCode.FormattingEnabled = true;
            this.comboBoxNewCustCode.Location = new System.Drawing.Point(156, 75);
            this.comboBoxNewCustCode.Name = "comboBoxNewCustCode";
            this.comboBoxNewCustCode.Size = new System.Drawing.Size(206, 21);
            this.comboBoxNewCustCode.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Місто до якого відноситься:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Cтатус користувача:";
            // 
            // comboBoxStatusChangeCustomer
            // 
            this.comboBoxStatusChangeCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusChangeCustomer.FormattingEnabled = true;
            this.comboBoxStatusChangeCustomer.Items.AddRange(new object[] {
            "Діє",
            "Не діє"});
            this.comboBoxStatusChangeCustomer.Location = new System.Drawing.Point(243, 257);
            this.comboBoxStatusChangeCustomer.Name = "comboBoxStatusChangeCustomer";
            this.comboBoxStatusChangeCustomer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatusChangeCustomer.TabIndex = 26;
            // 
            // checkBoxFormLogin
            // 
            this.checkBoxFormLogin.AutoSize = true;
            this.checkBoxFormLogin.Location = new System.Drawing.Point(255, 284);
            this.checkBoxFormLogin.Name = "checkBoxFormLogin";
            this.checkBoxFormLogin.Size = new System.Drawing.Size(121, 17);
            this.checkBoxFormLogin.TabIndex = 27;
            this.checkBoxFormLogin.Text = "Задати інший логін";
            this.checkBoxFormLogin.UseVisualStyleBackColor = true;
            this.checkBoxFormLogin.CheckStateChanged += new System.EventHandler(this.checkBoxFormLogin_CheckStateChanged);
            // 
            // FormChangeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 488);
            this.Controls.Add(this.checkBoxFormLogin);
            this.Controls.Add(this.comboBoxStatusChangeCustomer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBoxLoginFormChangeCustomer);
            this.Controls.Add(this.buttonNewCustAddFindOrgRC);
            this.Controls.Add(this.maskedTextBoxNewCustPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNewCustDetail);
            this.Controls.Add(this.buttonNewCustClear);
            this.Controls.Add(this.buttonCustChange);
            this.Controls.Add(this.textBoxNewCustOrgRC);
            this.Controls.Add(this.textBoxNewCustOrgNameReadOnly);
            this.Controls.Add(this.textBoxNewCustWorkPosit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewCustUserIdINN);
            this.Controls.Add(this.textBoxNewCustLastName);
            this.Controls.Add(this.textBoxNewCustFirstName);
            this.Controls.Add(this.textBoxNewCustSurName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зміна інформації про користувача";
            this.groupBoxLoginFormChangeCustomer.ResumeLayout(false);
            this.groupBoxLoginFormChangeCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNewCustRegion;
        private System.Windows.Forms.TextBox textBoxNewCustSurName;
        private System.Windows.Forms.TextBox textBoxNewCustFirstName;
        private System.Windows.Forms.TextBox textBoxNewCustLastName;
        private System.Windows.Forms.TextBox textBoxNewCustUserIdINN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNewCustWorkPosit;
        private System.Windows.Forms.TextBox textBoxNewCustOrgNameReadOnly;
        private System.Windows.Forms.TextBox textBoxNewCustOrgRC;
        private System.Windows.Forms.TextBox textBoxNewCustDetail;
        private System.Windows.Forms.Button buttonCustChange;
        private System.Windows.Forms.Button buttonNewCustClear;
        private System.Windows.Forms.ToolTip toolTipAddCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxNewCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNewCustPhone;
        private System.Windows.Forms.Button buttonNewCustAddFindOrgRC;
        private System.Windows.Forms.GroupBox groupBoxLoginFormChangeCustomer;
        private System.Windows.Forms.ComboBox comboBoxNewCustCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxStatusChangeCustomer;
        private System.Windows.Forms.CheckBox checkBoxFormLogin;
    }
}