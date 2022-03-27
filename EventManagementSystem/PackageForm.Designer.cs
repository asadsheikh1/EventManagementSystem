
namespace EventManagementSystem
{
    partial class PackageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageForm));
            this.dataGridViewPackageInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCID = new System.Windows.Forms.ComboBox();
            this.labelCID = new System.Windows.Forms.Label();
            this.comboBoxPID = new System.Windows.Forms.ComboBox();
            this.labelPID = new System.Windows.Forms.Label();
            this.comboBoxSID = new System.Windows.Forms.ComboBox();
            this.labelSID = new System.Windows.Forms.Label();
            this.comboBoxFID = new System.Windows.Forms.ComboBox();
            this.labelFID = new System.Windows.Forms.Label();
            this.comboBoxTID = new System.Windows.Forms.ComboBox();
            this.labelTID = new System.Windows.Forms.Label();
            this.comboBoxEID = new System.Windows.Forms.ComboBox();
            this.labelEID = new System.Windows.Forms.Label();
            this.btnUpdatePackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnDisplayPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackageInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPackageInfo
            // 
            this.dataGridViewPackageInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPackageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackageInfo.Location = new System.Drawing.Point(14, 526);
            this.dataGridViewPackageInfo.Name = "dataGridViewPackageInfo";
            this.dataGridViewPackageInfo.RowHeadersWidth = 51;
            this.dataGridViewPackageInfo.RowTemplate.Height = 29;
            this.dataGridViewPackageInfo.Size = new System.Drawing.Size(1270, 368);
            this.dataGridViewPackageInfo.TabIndex = 46;
            this.dataGridViewPackageInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPackageInfo_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCID);
            this.groupBox1.Controls.Add(this.labelCID);
            this.groupBox1.Controls.Add(this.comboBoxPID);
            this.groupBox1.Controls.Add(this.labelPID);
            this.groupBox1.Controls.Add(this.comboBoxSID);
            this.groupBox1.Controls.Add(this.labelSID);
            this.groupBox1.Controls.Add(this.comboBoxFID);
            this.groupBox1.Controls.Add(this.labelFID);
            this.groupBox1.Controls.Add(this.comboBoxTID);
            this.groupBox1.Controls.Add(this.labelTID);
            this.groupBox1.Controls.Add(this.comboBoxEID);
            this.groupBox1.Controls.Add(this.labelEID);
            this.groupBox1.Controls.Add(this.btnUpdatePackage);
            this.groupBox1.Controls.Add(this.btnDeletePackage);
            this.groupBox1.Controls.Add(this.btnDisplayPackage);
            this.groupBox1.Controls.Add(this.btnAddPackage);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(161, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 321);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package";
            // 
            // comboBoxCID
            // 
            this.comboBoxCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCID.FormattingEnabled = true;
            this.comboBoxCID.Items.AddRange(new object[] {
            "Family",
            "Family & Friends",
            "Friends"});
            this.comboBoxCID.Location = new System.Drawing.Point(660, 130);
            this.comboBoxCID.Name = "comboBoxCID";
            this.comboBoxCID.Size = new System.Drawing.Size(295, 31);
            this.comboBoxCID.TabIndex = 200;
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCID.ForeColor = System.Drawing.Color.White;
            this.labelCID.Location = new System.Drawing.Point(518, 133);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(136, 23);
            this.labelCID.TabIndex = 199;
            this.labelCID.Text = "Customer ID:";
            // 
            // comboBoxPID
            // 
            this.comboBoxPID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPID.FormattingEnabled = true;
            this.comboBoxPID.Items.AddRange(new object[] {
            "Family",
            "Family & Friends",
            "Friends"});
            this.comboBoxPID.Location = new System.Drawing.Point(160, 135);
            this.comboBoxPID.Name = "comboBoxPID";
            this.comboBoxPID.Size = new System.Drawing.Size(295, 31);
            this.comboBoxPID.TabIndex = 198;
            // 
            // labelPID
            // 
            this.labelPID.AutoSize = true;
            this.labelPID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPID.ForeColor = System.Drawing.Color.White;
            this.labelPID.Location = new System.Drawing.Point(25, 138);
            this.labelPID.Name = "labelPID";
            this.labelPID.Size = new System.Drawing.Size(130, 23);
            this.labelPID.TabIndex = 197;
            this.labelPID.Text = "Package ID:";
            // 
            // comboBoxSID
            // 
            this.comboBoxSID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSID.FormattingEnabled = true;
            this.comboBoxSID.Items.AddRange(new object[] {
            "Family",
            "Family & Friends",
            "Friends"});
            this.comboBoxSID.Location = new System.Drawing.Point(660, 82);
            this.comboBoxSID.Name = "comboBoxSID";
            this.comboBoxSID.Size = new System.Drawing.Size(295, 31);
            this.comboBoxSID.TabIndex = 196;
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSID.ForeColor = System.Drawing.Color.White;
            this.labelSID.Location = new System.Drawing.Point(541, 85);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(113, 23);
            this.labelSID.TabIndex = 195;
            this.labelSID.Text = "Service ID:";
            // 
            // comboBoxFID
            // 
            this.comboBoxFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFID.FormattingEnabled = true;
            this.comboBoxFID.Items.AddRange(new object[] {
            "Family",
            "Family & Friends",
            "Friends"});
            this.comboBoxFID.Location = new System.Drawing.Point(660, 34);
            this.comboBoxFID.Name = "comboBoxFID";
            this.comboBoxFID.Size = new System.Drawing.Size(295, 31);
            this.comboBoxFID.TabIndex = 194;
            // 
            // labelFID
            // 
            this.labelFID.AutoSize = true;
            this.labelFID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFID.ForeColor = System.Drawing.Color.White;
            this.labelFID.Location = new System.Drawing.Point(563, 37);
            this.labelFID.Name = "labelFID";
            this.labelFID.Size = new System.Drawing.Size(91, 23);
            this.labelFID.TabIndex = 193;
            this.labelFID.Text = "Food ID:";
            // 
            // comboBoxTID
            // 
            this.comboBoxTID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTID.FormattingEnabled = true;
            this.comboBoxTID.Items.AddRange(new object[] {
            "Family",
            "Family & Friends",
            "Friends"});
            this.comboBoxTID.Location = new System.Drawing.Point(160, 87);
            this.comboBoxTID.Name = "comboBoxTID";
            this.comboBoxTID.Size = new System.Drawing.Size(295, 31);
            this.comboBoxTID.TabIndex = 192;
            // 
            // labelTID
            // 
            this.labelTID.AutoSize = true;
            this.labelTID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTID.ForeColor = System.Drawing.Color.White;
            this.labelTID.Location = new System.Drawing.Point(27, 90);
            this.labelTID.Name = "labelTID";
            this.labelTID.Size = new System.Drawing.Size(128, 23);
            this.labelTID.TabIndex = 191;
            this.labelTID.Text = "Transport ID:";
            // 
            // comboBoxEID
            // 
            this.comboBoxEID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEID.FormattingEnabled = true;
            this.comboBoxEID.Items.AddRange(new object[] {
            "Family",
            "Family & Friends",
            "Friends"});
            this.comboBoxEID.Location = new System.Drawing.Point(160, 39);
            this.comboBoxEID.Name = "comboBoxEID";
            this.comboBoxEID.Size = new System.Drawing.Size(295, 31);
            this.comboBoxEID.TabIndex = 190;
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEID.ForeColor = System.Drawing.Color.White;
            this.labelEID.Location = new System.Drawing.Point(61, 42);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(94, 23);
            this.labelEID.TabIndex = 189;
            this.labelEID.Text = "Event ID:";
            // 
            // btnUpdatePackage
            // 
            this.btnUpdatePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePackage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePackage.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePackage.Location = new System.Drawing.Point(288, 248);
            this.btnUpdatePackage.Name = "btnUpdatePackage";
            this.btnUpdatePackage.Size = new System.Drawing.Size(199, 56);
            this.btnUpdatePackage.TabIndex = 188;
            this.btnUpdatePackage.Text = "Update Package";
            this.btnUpdatePackage.UseVisualStyleBackColor = true;
            this.btnUpdatePackage.Click += new System.EventHandler(this.btnUpdatePackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePackage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePackage.ForeColor = System.Drawing.Color.White;
            this.btnDeletePackage.Location = new System.Drawing.Point(493, 248);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(199, 56);
            this.btnDeletePackage.TabIndex = 187;
            this.btnDeletePackage.Text = "Delete Package";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // btnDisplayPackage
            // 
            this.btnDisplayPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayPackage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayPackage.ForeColor = System.Drawing.Color.White;
            this.btnDisplayPackage.Location = new System.Drawing.Point(493, 186);
            this.btnDisplayPackage.Name = "btnDisplayPackage";
            this.btnDisplayPackage.Size = new System.Drawing.Size(199, 56);
            this.btnDisplayPackage.TabIndex = 186;
            this.btnDisplayPackage.Text = "Display Package";
            this.btnDisplayPackage.UseVisualStyleBackColor = true;
            this.btnDisplayPackage.Click += new System.EventHandler(this.btnDisplayPackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPackage.ForeColor = System.Drawing.Color.White;
            this.btnAddPackage.Location = new System.Drawing.Point(288, 186);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(199, 56);
            this.btnAddPackage.TabIndex = 185;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EventManagementSystem.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 185);
            this.panel1.TabIndex = 48;
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1294, 903);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewPackageInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | Event Management System | Package";
            this.Load += new System.EventHandler(this.PackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackageInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPackageInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCID;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.ComboBox comboBoxPID;
        private System.Windows.Forms.Label labelPID;
        private System.Windows.Forms.ComboBox comboBoxSID;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.ComboBox comboBoxFID;
        private System.Windows.Forms.Label labelFID;
        private System.Windows.Forms.ComboBox comboBoxTID;
        private System.Windows.Forms.Label labelTID;
        private System.Windows.Forms.ComboBox comboBoxEID;
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.Button btnUpdatePackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnDisplayPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Panel panel1;
    }
}