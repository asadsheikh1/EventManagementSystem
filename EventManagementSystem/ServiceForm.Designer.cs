
namespace EventManagementSystem
{
    partial class ServiceForm
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
            this.dataGridViewTransportInfo = new System.Windows.Forms.DataGridView();
            this.btnDisplayService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSPrice = new System.Windows.Forms.TextBox();
            this.labelSPrice = new System.Windows.Forms.Label();
            this.textBoxSType = new System.Windows.Forms.TextBox();
            this.labelSType = new System.Windows.Forms.Label();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.labelSID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTransportInfo
            // 
            this.dataGridViewTransportInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransportInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransportInfo.Location = new System.Drawing.Point(576, 206);
            this.dataGridViewTransportInfo.Name = "dataGridViewTransportInfo";
            this.dataGridViewTransportInfo.RowHeadersWidth = 51;
            this.dataGridViewTransportInfo.RowTemplate.Height = 29;
            this.dataGridViewTransportInfo.Size = new System.Drawing.Size(706, 352);
            this.dataGridViewTransportInfo.TabIndex = 72;
            this.dataGridViewTransportInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTransportInfo_RowHeaderMouseDoubleClick);
            // 
            // btnDisplayService
            // 
            this.btnDisplayService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayService.ForeColor = System.Drawing.Color.White;
            this.btnDisplayService.Location = new System.Drawing.Point(265, 292);
            this.btnDisplayService.Name = "btnDisplayService";
            this.btnDisplayService.Size = new System.Drawing.Size(199, 56);
            this.btnDisplayService.TabIndex = 73;
            this.btnDisplayService.Text = "Display Service";
            this.btnDisplayService.UseVisualStyleBackColor = true;
            this.btnDisplayService.Click += new System.EventHandler(this.btnDisplayService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(60, 292);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(199, 56);
            this.btnAddService.TabIndex = 75;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteService.ForeColor = System.Drawing.Color.White;
            this.btnDeleteService.Location = new System.Drawing.Point(265, 354);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(199, 56);
            this.btnDeleteService.TabIndex = 76;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(60, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 56);
            this.btnBack.TabIndex = 86;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.textBoxSPrice);
            this.groupBox1.Controls.Add(this.btnDeleteService);
            this.groupBox1.Controls.Add(this.labelSPrice);
            this.groupBox1.Controls.Add(this.btnAddService);
            this.groupBox1.Controls.Add(this.btnDisplayService);
            this.groupBox1.Controls.Add(this.textBoxSType);
            this.groupBox1.Controls.Add(this.labelSType);
            this.groupBox1.Controls.Add(this.textBoxSID);
            this.groupBox1.Controls.Add(this.labelSID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 472);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Our Services";
            // 
            // textBoxSPrice
            // 
            this.textBoxSPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSPrice.Location = new System.Drawing.Point(187, 217);
            this.textBoxSPrice.Name = "textBoxSPrice";
            this.textBoxSPrice.Size = new System.Drawing.Size(295, 32);
            this.textBoxSPrice.TabIndex = 94;
            // 
            // labelSPrice
            // 
            this.labelSPrice.AutoSize = true;
            this.labelSPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSPrice.ForeColor = System.Drawing.Color.White;
            this.labelSPrice.Location = new System.Drawing.Point(44, 220);
            this.labelSPrice.Name = "labelSPrice";
            this.labelSPrice.Size = new System.Drawing.Size(141, 23);
            this.labelSPrice.TabIndex = 93;
            this.labelSPrice.Text = "Service Price:";
            // 
            // textBoxSType
            // 
            this.textBoxSType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSType.Location = new System.Drawing.Point(187, 165);
            this.textBoxSType.Name = "textBoxSType";
            this.textBoxSType.Size = new System.Drawing.Size(295, 32);
            this.textBoxSType.TabIndex = 92;
            // 
            // labelSType
            // 
            this.labelSType.AutoSize = true;
            this.labelSType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSType.ForeColor = System.Drawing.Color.White;
            this.labelSType.Location = new System.Drawing.Point(46, 168);
            this.labelSType.Name = "labelSType";
            this.labelSType.Size = new System.Drawing.Size(139, 23);
            this.labelSType.TabIndex = 91;
            this.labelSType.Text = "Service Type:";
            // 
            // textBoxSID
            // 
            this.textBoxSID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSID.Location = new System.Drawing.Point(187, 113);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(295, 32);
            this.textBoxSID.TabIndex = 90;
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSID.ForeColor = System.Drawing.Color.White;
            this.labelSID.Location = new System.Drawing.Point(72, 116);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(113, 23);
            this.labelSID.TabIndex = 89;
            this.labelSID.Text = "Service ID:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EventManagementSystem.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(576, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 171);
            this.panel1.TabIndex = 88;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1294, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTransportInfo);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | Event Management System | Service";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTransportInfo;
        private System.Windows.Forms.Button btnDisplayService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSPrice;
        private System.Windows.Forms.Label labelSPrice;
        private System.Windows.Forms.TextBox textBoxSType;
        private System.Windows.Forms.Label labelSType;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.Panel panel1;
    }
}