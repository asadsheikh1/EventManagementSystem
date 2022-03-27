
namespace EventManagementSystem
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDisplayCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomerInfo = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.labelBlock = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.labelCID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(855, 561);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(199, 56);
            this.btnAddCustomer.TabIndex = 18;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDisplayCustomer
            // 
            this.btnDisplayCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDisplayCustomer.Location = new System.Drawing.Point(1060, 561);
            this.btnDisplayCustomer.Name = "btnDisplayCustomer";
            this.btnDisplayCustomer.Size = new System.Drawing.Size(199, 56);
            this.btnDisplayCustomer.TabIndex = 19;
            this.btnDisplayCustomer.Text = "Display Customer";
            this.btnDisplayCustomer.UseVisualStyleBackColor = true;
            this.btnDisplayCustomer.Click += new System.EventHandler(this.btnDisplayCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1060, 623);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(199, 56);
            this.btnDeleteCustomer.TabIndex = 21;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // dataGridViewCustomerInfo
            // 
            this.dataGridViewCustomerInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerInfo.Location = new System.Drawing.Point(17, 192);
            this.dataGridViewCustomerInfo.Name = "dataGridViewCustomerInfo";
            this.dataGridViewCustomerInfo.RowHeadersWidth = 51;
            this.dataGridViewCustomerInfo.RowTemplate.Height = 29;
            this.dataGridViewCustomerInfo.Size = new System.Drawing.Size(792, 425);
            this.dataGridViewCustomerInfo.TabIndex = 22;
            this.dataGridViewCustomerInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomerInfo_RowHeaderMouseDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(318, 623);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 56);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Controls.Add(this.textBoxArea);
            this.groupBox1.Controls.Add(this.labelArea);
            this.groupBox1.Controls.Add(this.textBoxStreet);
            this.groupBox1.Controls.Add(this.labelStreet);
            this.groupBox1.Controls.Add(this.textBoxBlock);
            this.groupBox1.Controls.Add(this.labelBlock);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.textBoxDOB);
            this.groupBox1.Controls.Add(this.labelDOB);
            this.groupBox1.Controls.Add(this.textBoxLName);
            this.groupBox1.Controls.Add(this.labelLName);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.labelFName);
            this.groupBox1.Controls.Add(this.textBoxCID);
            this.groupBox1.Controls.Add(this.labelCID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(821, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 674);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(34, 582);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 56);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCity.Location = new System.Drawing.Point(152, 446);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(295, 32);
            this.textBoxCity.TabIndex = 35;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(88, 449);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(55, 23);
            this.labelCity.TabIndex = 34;
            this.labelCity.Text = "City:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxArea.Location = new System.Drawing.Point(152, 398);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(295, 32);
            this.textBoxArea.TabIndex = 33;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelArea.ForeColor = System.Drawing.Color.White;
            this.labelArea.Location = new System.Drawing.Point(80, 401);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(63, 23);
            this.labelArea.TabIndex = 32;
            this.labelArea.Text = "Area:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStreet.Location = new System.Drawing.Point(152, 350);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(295, 32);
            this.textBoxStreet.TabIndex = 31;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStreet.ForeColor = System.Drawing.Color.White;
            this.labelStreet.Location = new System.Drawing.Point(79, 353);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(64, 23);
            this.labelStreet.TabIndex = 30;
            this.labelStreet.Text = "Street";
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBlock.Location = new System.Drawing.Point(152, 302);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(295, 32);
            this.textBoxBlock.TabIndex = 29;
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBlock.ForeColor = System.Drawing.Color.White;
            this.labelBlock.Location = new System.Drawing.Point(72, 305);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(71, 23);
            this.labelBlock.TabIndex = 28;
            this.labelBlock.Text = "Block:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(152, 254);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(295, 32);
            this.textBoxPhone.TabIndex = 27;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(66, 257);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(77, 23);
            this.labelPhone.TabIndex = 26;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDOB.Location = new System.Drawing.Point(152, 206);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(295, 32);
            this.textBoxDOB.TabIndex = 25;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDOB.ForeColor = System.Drawing.Color.White;
            this.labelDOB.Location = new System.Drawing.Point(9, 209);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(134, 23);
            this.labelDOB.TabIndex = 24;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLName.Location = new System.Drawing.Point(152, 158);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(295, 32);
            this.textBoxLName.TabIndex = 23;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLName.ForeColor = System.Drawing.Color.White;
            this.labelLName.Location = new System.Drawing.Point(24, 161);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(119, 23);
            this.labelLName.TabIndex = 22;
            this.labelLName.Text = "Last Name:";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFName.Location = new System.Drawing.Point(152, 110);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(295, 32);
            this.textBoxFName.TabIndex = 21;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFName.ForeColor = System.Drawing.Color.White;
            this.labelFName.Location = new System.Drawing.Point(25, 113);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(118, 23);
            this.labelFName.TabIndex = 20;
            this.labelFName.Text = "First Name:";
            // 
            // textBoxCID
            // 
            this.textBoxCID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCID.Location = new System.Drawing.Point(152, 62);
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(295, 32);
            this.textBoxCID.TabIndex = 19;
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCID.ForeColor = System.Drawing.Color.White;
            this.labelCID.Location = new System.Drawing.Point(7, 65);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(136, 23);
            this.labelCID.TabIndex = 18;
            this.labelCID.Text = "Customer ID:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EventManagementSystem.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 162);
            this.panel1.TabIndex = 27;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1294, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewCustomerInfo);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnDisplayCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | Event Management System | Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDisplayCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomerInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxCID;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
    }
}