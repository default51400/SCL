namespace SingleCustomerList
{
    partial class FormFindOrgRC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindOrgRC));
            this.dataGridViewFindOrgRc = new System.Windows.Forms.DataGridView();
            this.textBoxNameOrganizationFormFindOrgRC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFormFindOrgRC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindOrgRc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFindOrgRc
            // 
            this.dataGridViewFindOrgRc.AllowUserToAddRows = false;
            this.dataGridViewFindOrgRc.AllowUserToDeleteRows = false;
            this.dataGridViewFindOrgRc.AllowUserToOrderColumns = true;
            this.dataGridViewFindOrgRc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindOrgRc.Location = new System.Drawing.Point(-1, 38);
            this.dataGridViewFindOrgRc.Name = "dataGridViewFindOrgRc";
            this.dataGridViewFindOrgRc.ReadOnly = true;
            this.dataGridViewFindOrgRc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFindOrgRc.Size = new System.Drawing.Size(921, 328);
            this.dataGridViewFindOrgRc.TabIndex = 3;
            this.dataGridViewFindOrgRc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFindOrgRc_CellDoubleClick);
            // 
            // textBoxNameOrganizationFormFindOrgRC
            // 
            this.textBoxNameOrganizationFormFindOrgRC.Location = new System.Drawing.Point(104, 9);
            this.textBoxNameOrganizationFormFindOrgRC.Name = "textBoxNameOrganizationFormFindOrgRC";
            this.textBoxNameOrganizationFormFindOrgRC.Size = new System.Drawing.Size(721, 20);
            this.textBoxNameOrganizationFormFindOrgRC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва організації:";
            // 
            // buttonFormFindOrgRC
            // 
            this.buttonFormFindOrgRC.Location = new System.Drawing.Point(831, 7);
            this.buttonFormFindOrgRC.Name = "buttonFormFindOrgRC";
            this.buttonFormFindOrgRC.Size = new System.Drawing.Size(75, 23);
            this.buttonFormFindOrgRC.TabIndex = 2;
            this.buttonFormFindOrgRC.Text = "Пошук";
            this.buttonFormFindOrgRC.UseVisualStyleBackColor = true;
            this.buttonFormFindOrgRC.Click += new System.EventHandler(this.buttonFormFindOrgRC_Click);
            // 
            // FormFindOrgRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 360);
            this.Controls.Add(this.buttonFormFindOrgRC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameOrganizationFormFindOrgRC);
            this.Controls.Add(this.dataGridViewFindOrgRc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFindOrgRC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Знайти реєстраційний код організації";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindOrgRc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFindOrgRc;
        private System.Windows.Forms.TextBox textBoxNameOrganizationFormFindOrgRC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFormFindOrgRC;
    }
}