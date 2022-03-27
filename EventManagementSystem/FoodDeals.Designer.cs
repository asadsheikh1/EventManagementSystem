
namespace EventManagementSystem
{
    partial class FoodDeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodDeals));
            this.dataGridViewDealInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDPrice = new System.Windows.Forms.TextBox();
            this.labelDPrice = new System.Windows.Forms.Label();
            this.textBoxDName = new System.Windows.Forms.TextBox();
            this.labelDName = new System.Windows.Forms.Label();
            this.textBoxDID = new System.Windows.Forms.TextBox();
            this.labelDID = new System.Windows.Forms.Label();
            this.btnDeleteDeal = new System.Windows.Forms.Button();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.btnDisplayDeal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDID2 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteDeal2 = new System.Windows.Forms.Button();
            this.btnAddDeal2 = new System.Windows.Forms.Button();
            this.btnDisplayDeal2 = new System.Windows.Forms.Button();
            this.labelDID2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.comboBoxFID = new System.Windows.Forms.ComboBox();
            this.labelFID = new System.Windows.Forms.Label();
            this.dataGridViewFoodDealInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodDealInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDealInfo
            // 
            this.dataGridViewDealInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDealInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDealInfo.Location = new System.Drawing.Point(497, 204);
            this.dataGridViewDealInfo.Name = "dataGridViewDealInfo";
            this.dataGridViewDealInfo.RowHeadersWidth = 51;
            this.dataGridViewDealInfo.RowTemplate.Height = 29;
            this.dataGridViewDealInfo.Size = new System.Drawing.Size(462, 351);
            this.dataGridViewDealInfo.TabIndex = 3;
            this.dataGridViewDealInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDealInfo_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDPrice);
            this.groupBox1.Controls.Add(this.labelDPrice);
            this.groupBox1.Controls.Add(this.textBoxDName);
            this.groupBox1.Controls.Add(this.labelDName);
            this.groupBox1.Controls.Add(this.textBoxDID);
            this.groupBox1.Controls.Add(this.labelDID);
            this.groupBox1.Controls.Add(this.btnDeleteDeal);
            this.groupBox1.Controls.Add(this.btnAddDeal);
            this.groupBox1.Controls.Add(this.btnDisplayDeal);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 362);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deals";
            // 
            // textBoxDPrice
            // 
            this.textBoxDPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDPrice.Location = new System.Drawing.Point(149, 146);
            this.textBoxDPrice.Name = "textBoxDPrice";
            this.textBoxDPrice.Size = new System.Drawing.Size(295, 32);
            this.textBoxDPrice.TabIndex = 138;
            // 
            // labelDPrice
            // 
            this.labelDPrice.AutoSize = true;
            this.labelDPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDPrice.ForeColor = System.Drawing.Color.White;
            this.labelDPrice.Location = new System.Drawing.Point(18, 149);
            this.labelDPrice.Name = "labelDPrice";
            this.labelDPrice.Size = new System.Drawing.Size(115, 23);
            this.labelDPrice.TabIndex = 137;
            this.labelDPrice.Text = "Deal Price:";
            // 
            // textBoxDName
            // 
            this.textBoxDName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDName.Location = new System.Drawing.Point(149, 97);
            this.textBoxDName.Name = "textBoxDName";
            this.textBoxDName.Size = new System.Drawing.Size(295, 32);
            this.textBoxDName.TabIndex = 136;
            // 
            // labelDName
            // 
            this.labelDName.AutoSize = true;
            this.labelDName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDName.ForeColor = System.Drawing.Color.White;
            this.labelDName.Location = new System.Drawing.Point(6, 100);
            this.labelDName.Name = "labelDName";
            this.labelDName.Size = new System.Drawing.Size(127, 23);
            this.labelDName.TabIndex = 135;
            this.labelDName.Text = "Deal Name:";
            // 
            // textBoxDID
            // 
            this.textBoxDID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDID.Location = new System.Drawing.Point(149, 48);
            this.textBoxDID.Name = "textBoxDID";
            this.textBoxDID.Size = new System.Drawing.Size(295, 32);
            this.textBoxDID.TabIndex = 134;
            // 
            // labelDID
            // 
            this.labelDID.AutoSize = true;
            this.labelDID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDID.ForeColor = System.Drawing.Color.White;
            this.labelDID.Location = new System.Drawing.Point(46, 51);
            this.labelDID.Name = "labelDID";
            this.labelDID.Size = new System.Drawing.Size(87, 23);
            this.labelDID.TabIndex = 133;
            this.labelDID.Text = "Deal ID:";
            // 
            // btnDeleteDeal
            // 
            this.btnDeleteDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteDeal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeal.Location = new System.Drawing.Point(26, 276);
            this.btnDeleteDeal.Name = "btnDeleteDeal";
            this.btnDeleteDeal.Size = new System.Drawing.Size(404, 56);
            this.btnDeleteDeal.TabIndex = 131;
            this.btnDeleteDeal.Text = "Delete Deal";
            this.btnDeleteDeal.UseVisualStyleBackColor = true;
            this.btnDeleteDeal.Click += new System.EventHandler(this.btnDeleteDeal_Click_1);
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDeal.ForeColor = System.Drawing.Color.White;
            this.btnAddDeal.Location = new System.Drawing.Point(26, 214);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(199, 56);
            this.btnAddDeal.TabIndex = 130;
            this.btnAddDeal.Text = "Add Deal";
            this.btnAddDeal.UseVisualStyleBackColor = true;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAddDeal_Click_1);
            // 
            // btnDisplayDeal
            // 
            this.btnDisplayDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayDeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayDeal.ForeColor = System.Drawing.Color.White;
            this.btnDisplayDeal.Location = new System.Drawing.Point(231, 214);
            this.btnDisplayDeal.Name = "btnDisplayDeal";
            this.btnDisplayDeal.Size = new System.Drawing.Size(199, 56);
            this.btnDisplayDeal.TabIndex = 129;
            this.btnDisplayDeal.Text = "Display Deal";
            this.btnDisplayDeal.UseVisualStyleBackColor = true;
            this.btnDisplayDeal.Click += new System.EventHandler(this.btnDisplayDeal_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EventManagementSystem.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 168);
            this.panel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDID2);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnDeleteDeal2);
            this.groupBox2.Controls.Add(this.btnAddDeal2);
            this.groupBox2.Controls.Add(this.btnDisplayDeal2);
            this.groupBox2.Controls.Add(this.labelDID2);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.labelQuantity);
            this.groupBox2.Controls.Add(this.comboBoxFID);
            this.groupBox2.Controls.Add(this.labelFID);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(497, 561);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 347);
            this.groupBox2.TabIndex = 133;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Deals";
            // 
            // textBoxDID2
            // 
            this.textBoxDID2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDID2.Location = new System.Drawing.Point(147, 88);
            this.textBoxDID2.Name = "textBoxDID2";
            this.textBoxDID2.Size = new System.Drawing.Size(295, 32);
            this.textBoxDID2.TabIndex = 148;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(36, 261);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 56);
            this.btnBack.TabIndex = 147;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnDeleteDeal2
            // 
            this.btnDeleteDeal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeal2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteDeal2.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeal2.Location = new System.Drawing.Point(241, 261);
            this.btnDeleteDeal2.Name = "btnDeleteDeal2";
            this.btnDeleteDeal2.Size = new System.Drawing.Size(199, 56);
            this.btnDeleteDeal2.TabIndex = 146;
            this.btnDeleteDeal2.Text = "Delete Deal";
            this.btnDeleteDeal2.UseVisualStyleBackColor = true;
            this.btnDeleteDeal2.Click += new System.EventHandler(this.btnDeleteDeal2_Click);
            // 
            // btnAddDeal2
            // 
            this.btnAddDeal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeal2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDeal2.ForeColor = System.Drawing.Color.White;
            this.btnAddDeal2.Location = new System.Drawing.Point(36, 199);
            this.btnAddDeal2.Name = "btnAddDeal2";
            this.btnAddDeal2.Size = new System.Drawing.Size(199, 56);
            this.btnAddDeal2.TabIndex = 145;
            this.btnAddDeal2.Text = "Add Deal";
            this.btnAddDeal2.UseVisualStyleBackColor = true;
            this.btnAddDeal2.Click += new System.EventHandler(this.btnAddDeal2_Click);
            // 
            // btnDisplayDeal2
            // 
            this.btnDisplayDeal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayDeal2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayDeal2.ForeColor = System.Drawing.Color.White;
            this.btnDisplayDeal2.Location = new System.Drawing.Point(241, 199);
            this.btnDisplayDeal2.Name = "btnDisplayDeal2";
            this.btnDisplayDeal2.Size = new System.Drawing.Size(199, 56);
            this.btnDisplayDeal2.TabIndex = 144;
            this.btnDisplayDeal2.Text = "Display Deal";
            this.btnDisplayDeal2.UseVisualStyleBackColor = true;
            this.btnDisplayDeal2.Click += new System.EventHandler(this.btnDisplayDeal2_Click);
            // 
            // labelDID2
            // 
            this.labelDID2.AutoSize = true;
            this.labelDID2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDID2.ForeColor = System.Drawing.Color.White;
            this.labelDID2.Location = new System.Drawing.Point(40, 91);
            this.labelDID2.Name = "labelDID2";
            this.labelDID2.Size = new System.Drawing.Size(87, 23);
            this.labelDID2.TabIndex = 142;
            this.labelDID2.Text = "Deal ID:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuantity.Location = new System.Drawing.Point(147, 136);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(295, 32);
            this.textBoxQuantity.TabIndex = 141;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(28, 141);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(99, 23);
            this.labelQuantity.TabIndex = 140;
            this.labelQuantity.Text = "Quantity:";
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
            this.comboBoxFID.Location = new System.Drawing.Point(147, 38);
            this.comboBoxFID.Name = "comboBoxFID";
            this.comboBoxFID.Size = new System.Drawing.Size(295, 31);
            this.comboBoxFID.TabIndex = 139;
            // 
            // labelFID
            // 
            this.labelFID.AutoSize = true;
            this.labelFID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFID.ForeColor = System.Drawing.Color.White;
            this.labelFID.Location = new System.Drawing.Point(36, 41);
            this.labelFID.Name = "labelFID";
            this.labelFID.Size = new System.Drawing.Size(91, 23);
            this.labelFID.TabIndex = 138;
            this.labelFID.Text = "Food ID:";
            // 
            // dataGridViewFoodDealInfo
            // 
            this.dataGridViewFoodDealInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFoodDealInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodDealInfo.Location = new System.Drawing.Point(26, 561);
            this.dataGridViewFoodDealInfo.Name = "dataGridViewFoodDealInfo";
            this.dataGridViewFoodDealInfo.RowHeadersWidth = 51;
            this.dataGridViewFoodDealInfo.RowTemplate.Height = 29;
            this.dataGridViewFoodDealInfo.Size = new System.Drawing.Size(465, 347);
            this.dataGridViewFoodDealInfo.TabIndex = 134;
            this.dataGridViewFoodDealInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFoodDealInfo_RowHeaderMouseDoubleClick);
            // 
            // FoodDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(982, 920);
            this.Controls.Add(this.dataGridViewFoodDealInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDealInfo);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodDeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | Event Management System | Food Deals";
            this.Load += new System.EventHandler(this.FoodDeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodDealInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDealInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDPrice;
        private System.Windows.Forms.Label labelDPrice;
        private System.Windows.Forms.TextBox textBoxDName;
        private System.Windows.Forms.Label labelDName;
        private System.Windows.Forms.TextBox textBoxDID;
        private System.Windows.Forms.Label labelDID;
        private System.Windows.Forms.Button btnDeleteDeal;
        private System.Windows.Forms.Button btnAddDeal;
        private System.Windows.Forms.Button btnDisplayDeal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteDeal2;
        private System.Windows.Forms.Button btnAddDeal2;
        private System.Windows.Forms.Button btnDisplayDeal2;
        private System.Windows.Forms.Label labelDID2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ComboBox comboBoxFID;
        private System.Windows.Forms.Label labelFID;
        private System.Windows.Forms.DataGridView dataGridViewFoodDealInfo;
        private System.Windows.Forms.TextBox textBoxDID2;
    }
}