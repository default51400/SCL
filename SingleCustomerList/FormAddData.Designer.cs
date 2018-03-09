namespace SingleCustomerList
{
    partial class FormAddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddData));
            this.label1FormAddData = new System.Windows.Forms.Label();
            this.textBoxFormAddData = new System.Windows.Forms.TextBox();
            this.buttonOkFormAddData = new System.Windows.Forms.Button();
            this.checkBoxFormAddData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1FormAddData
            // 
            this.label1FormAddData.AutoSize = true;
            this.label1FormAddData.Location = new System.Drawing.Point(13, 13);
            this.label1FormAddData.Name = "label1FormAddData";
            this.label1FormAddData.Size = new System.Drawing.Size(192, 13);
            this.label1FormAddData.TabIndex = 0;
            this.label1FormAddData.Text = "Введіть номер свідоцства нотаріуса:";
            // 
            // textBoxFormAddData
            // 
            this.textBoxFormAddData.Location = new System.Drawing.Point(16, 30);
            this.textBoxFormAddData.Name = "textBoxFormAddData";
            this.textBoxFormAddData.Size = new System.Drawing.Size(125, 20);
            this.textBoxFormAddData.TabIndex = 1;
            // 
            // buttonOkFormAddData
            // 
            this.buttonOkFormAddData.Location = new System.Drawing.Point(147, 29);
            this.buttonOkFormAddData.Name = "buttonOkFormAddData";
            this.buttonOkFormAddData.Size = new System.Drawing.Size(58, 23);
            this.buttonOkFormAddData.TabIndex = 2;
            this.buttonOkFormAddData.Text = "Додати";
            this.buttonOkFormAddData.UseVisualStyleBackColor = true;
            this.buttonOkFormAddData.Click += new System.EventHandler(this.buttonOkFormAddData_Click);
            // 
            // checkBoxFormAddData
            // 
            this.checkBoxFormAddData.AutoSize = true;
            this.checkBoxFormAddData.Location = new System.Drawing.Point(16, 56);
            this.checkBoxFormAddData.Name = "checkBoxFormAddData";
            this.checkBoxFormAddData.Size = new System.Drawing.Size(124, 17);
            this.checkBoxFormAddData.TabIndex = 3;
            this.checkBoxFormAddData.Text = "Помічник нотаріуса";
            this.checkBoxFormAddData.UseVisualStyleBackColor = true;
            // 
            // FormAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 85);
            this.Controls.Add(this.checkBoxFormAddData);
            this.Controls.Add(this.buttonOkFormAddData);
            this.Controls.Add(this.textBoxFormAddData);
            this.Controls.Add(this.label1FormAddData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додаткова інформація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1FormAddData;
        private System.Windows.Forms.TextBox textBoxFormAddData;
        private System.Windows.Forms.Button buttonOkFormAddData;
        private System.Windows.Forms.CheckBox checkBoxFormAddData;
    }
}