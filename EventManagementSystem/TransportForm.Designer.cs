
namespace EventManagementSystem
{
    partial class TransportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportForm));
            this.btnDisplayTransport = new System.Windows.Forms.Button();
            this.dataGridViewTransportInfo = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnAddTransport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFExpense = new System.Windows.Forms.TextBox();
            this.labelFuelExpense = new System.Windows.Forms.Label();
            this.textBoxMExpense = new System.Windows.Forms.TextBox();
            this.labelMaintenanceExpense = new System.Windows.Forms.Label();
            this.textBoxTSeater = new System.Windows.Forms.TextBox();
            this.textBoxTQuantity = new System.Windows.Forms.TextBox();
            this.labelTransportQuantity = new System.Windows.Forms.Label();
            this.textBoxTType = new System.Windows.Forms.TextBox();
            this.labelTransportType = new System.Windows.Forms.Label();
            this.labelTransportSeater = new System.Windows.Forms.Label();
            this.textBoxTPrice = new System.Windows.Forms.TextBox();
            this.labelTransportPrice = new System.Windows.Forms.Label();
            this.textBoxTID = new System.Windows.Forms.TextBox();
            this.labelTID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayTransport
            // 
            this.btnDisplayTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayTransport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayTransport.ForeColor = System.Drawing.Color.White;
            this.btnDisplayTransport.Location = new System.Drawing.Point(340, 555);
            this.btnDisplayTransport.Name = "btnDisplayTransport";
            this.btnDisplayTransport.Size = new System.Drawing.Size(199, 56);
            this.btnDisplayTransport.TabIndex = 27;
            this.btnDisplayTransport.Text = "Display Transport";
            this.btnDisplayTransport.UseVisualStyleBackColor = true;
            this.btnDisplayTransport.Click += new System.EventHandler(this.btnDisplayTransport_Click);
            // 
            // dataGridViewTransportInfo
            // 
            this.dataGridViewTransportInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransportInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransportInfo.Location = new System.Drawing.Point(641, 229);
            this.dataGridViewTransportInfo.Name = "dataGridViewTransportInfo";
            this.dataGridViewTransportInfo.RowHeadersWidth = 51;
            this.dataGridViewTransportInfo.RowTemplate.Height = 29;
            this.dataGridViewTransportInfo.Size = new System.Drawing.Size(617, 467);
            this.dataGridViewTransportInfo.TabIndex = 26;
            this.dataGridViewTransportInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTransportInfo_RowHeaderMouseDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(135, 617);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 56);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEvent.Location = new System.Drawing.Point(340, 617);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(199, 56);
            this.btnDeleteEvent.TabIndex = 47;
            this.btnDeleteEvent.Text = "Delete Transport";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnAddTransport
            // 
            this.btnAddTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTransport.ForeColor = System.Drawing.Color.White;
            this.btnAddTransport.Location = new System.Drawing.Point(135, 555);
            this.btnAddTransport.Name = "btnAddTransport";
            this.btnAddTransport.Size = new System.Drawing.Size(199, 56);
            this.btnAddTransport.TabIndex = 46;
            this.btnAddTransport.Text = "Add Transport";
            this.btnAddTransport.UseVisualStyleBackColor = true;
            this.btnAddTransport.Click += new System.EventHandler(this.btnAddTransport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFExpense);
            this.groupBox1.Controls.Add(this.labelFuelExpense);
            this.groupBox1.Controls.Add(this.textBoxMExpense);
            this.groupBox1.Controls.Add(this.labelMaintenanceExpense);
            this.groupBox1.Controls.Add(this.textBoxTSeater);
            this.groupBox1.Controls.Add(this.textBoxTQuantity);
            this.groupBox1.Controls.Add(this.labelTransportQuantity);
            this.groupBox1.Controls.Add(this.textBoxTType);
            this.groupBox1.Controls.Add(this.labelTransportType);
            this.groupBox1.Controls.Add(this.labelTransportSeater);
            this.groupBox1.Controls.Add(this.textBoxTPrice);
            this.groupBox1.Controls.Add(this.labelTransportPrice);
            this.groupBox1.Controls.Add(this.textBoxTID);
            this.groupBox1.Controls.Add(this.labelTID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(44, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 590);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Our Transport";
            // 
            // textBoxFExpense
            // 
            this.textBoxFExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFExpense.Location = new System.Drawing.Point(255, 373);
            this.textBoxFExpense.Name = "textBoxFExpense";
            this.textBoxFExpense.Size = new System.Drawing.Size(295, 32);
            this.textBoxFExpense.TabIndex = 85;
            // 
            // labelFuelExpense
            // 
            this.labelFuelExpense.AutoSize = true;
            this.labelFuelExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFuelExpense.ForeColor = System.Drawing.Color.White;
            this.labelFuelExpense.Location = new System.Drawing.Point(106, 376);
            this.labelFuelExpense.Name = "labelFuelExpense";
            this.labelFuelExpense.Size = new System.Drawing.Size(143, 23);
            this.labelFuelExpense.TabIndex = 84;
            this.labelFuelExpense.Text = "Fuel Expense:";
            // 
            // textBoxMExpense
            // 
            this.textBoxMExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMExpense.Location = new System.Drawing.Point(255, 325);
            this.textBoxMExpense.Name = "textBoxMExpense";
            this.textBoxMExpense.Size = new System.Drawing.Size(295, 32);
            this.textBoxMExpense.TabIndex = 83;
            // 
            // labelMaintenanceExpense
            // 
            this.labelMaintenanceExpense.AutoSize = true;
            this.labelMaintenanceExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaintenanceExpense.ForeColor = System.Drawing.Color.White;
            this.labelMaintenanceExpense.Location = new System.Drawing.Point(16, 328);
            this.labelMaintenanceExpense.Name = "labelMaintenanceExpense";
            this.labelMaintenanceExpense.Size = new System.Drawing.Size(233, 23);
            this.labelMaintenanceExpense.TabIndex = 82;
            this.labelMaintenanceExpense.Text = "Maintenance Expense:";
            // 
            // textBoxTSeater
            // 
            this.textBoxTSeater.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTSeater.Location = new System.Drawing.Point(255, 181);
            this.textBoxTSeater.Name = "textBoxTSeater";
            this.textBoxTSeater.Size = new System.Drawing.Size(295, 32);
            this.textBoxTSeater.TabIndex = 81;
            // 
            // textBoxTQuantity
            // 
            this.textBoxTQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTQuantity.Location = new System.Drawing.Point(255, 277);
            this.textBoxTQuantity.Name = "textBoxTQuantity";
            this.textBoxTQuantity.Size = new System.Drawing.Size(295, 32);
            this.textBoxTQuantity.TabIndex = 80;
            // 
            // labelTransportQuantity
            // 
            this.labelTransportQuantity.AutoSize = true;
            this.labelTransportQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransportQuantity.ForeColor = System.Drawing.Color.White;
            this.labelTransportQuantity.Location = new System.Drawing.Point(58, 280);
            this.labelTransportQuantity.Name = "labelTransportQuantity";
            this.labelTransportQuantity.Size = new System.Drawing.Size(191, 23);
            this.labelTransportQuantity.TabIndex = 79;
            this.labelTransportQuantity.Text = "Transport Quantity:";
            // 
            // textBoxTType
            // 
            this.textBoxTType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTType.Location = new System.Drawing.Point(255, 229);
            this.textBoxTType.Name = "textBoxTType";
            this.textBoxTType.Size = new System.Drawing.Size(295, 32);
            this.textBoxTType.TabIndex = 78;
            // 
            // labelTransportType
            // 
            this.labelTransportType.AutoSize = true;
            this.labelTransportType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransportType.ForeColor = System.Drawing.Color.White;
            this.labelTransportType.Location = new System.Drawing.Point(95, 232);
            this.labelTransportType.Name = "labelTransportType";
            this.labelTransportType.Size = new System.Drawing.Size(154, 23);
            this.labelTransportType.TabIndex = 77;
            this.labelTransportType.Text = "Transport Type:";
            // 
            // labelTransportSeater
            // 
            this.labelTransportSeater.AutoSize = true;
            this.labelTransportSeater.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransportSeater.ForeColor = System.Drawing.Color.White;
            this.labelTransportSeater.Location = new System.Drawing.Point(80, 184);
            this.labelTransportSeater.Name = "labelTransportSeater";
            this.labelTransportSeater.Size = new System.Drawing.Size(169, 23);
            this.labelTransportSeater.TabIndex = 76;
            this.labelTransportSeater.Text = "Transport Seater:";
            // 
            // textBoxTPrice
            // 
            this.textBoxTPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTPrice.Location = new System.Drawing.Point(255, 133);
            this.textBoxTPrice.Name = "textBoxTPrice";
            this.textBoxTPrice.Size = new System.Drawing.Size(295, 32);
            this.textBoxTPrice.TabIndex = 75;
            // 
            // labelTransportPrice
            // 
            this.labelTransportPrice.AutoSize = true;
            this.labelTransportPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransportPrice.ForeColor = System.Drawing.Color.White;
            this.labelTransportPrice.Location = new System.Drawing.Point(93, 136);
            this.labelTransportPrice.Name = "labelTransportPrice";
            this.labelTransportPrice.Size = new System.Drawing.Size(156, 23);
            this.labelTransportPrice.TabIndex = 74;
            this.labelTransportPrice.Text = "Transport Price:";
            // 
            // textBoxTID
            // 
            this.textBoxTID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTID.Location = new System.Drawing.Point(255, 85);
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.Size = new System.Drawing.Size(295, 32);
            this.textBoxTID.TabIndex = 73;
            // 
            // labelTID
            // 
            this.labelTID.AutoSize = true;
            this.labelTID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTID.ForeColor = System.Drawing.Color.White;
            this.labelTID.Location = new System.Drawing.Point(121, 88);
            this.labelTID.Name = "labelTID";
            this.labelTID.Size = new System.Drawing.Size(128, 23);
            this.labelTID.TabIndex = 72;
            this.labelTID.Text = "Transport ID:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EventManagementSystem.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(641, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 189);
            this.panel1.TabIndex = 64;
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1283, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnAddTransport);
            this.Controls.Add(this.btnDisplayTransport);
            this.Controls.Add(this.dataGridViewTransportInfo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | Event Management System | Transport";
            this.Load += new System.EventHandler(this.TransportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDisplayTransport;
        private System.Windows.Forms.DataGridView dataGridViewTransportInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnAddTransport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFExpense;
        private System.Windows.Forms.Label labelFuelExpense;
        private System.Windows.Forms.TextBox textBoxMExpense;
        private System.Windows.Forms.Label labelMaintenanceExpense;
        private System.Windows.Forms.TextBox textBoxTSeater;
        private System.Windows.Forms.TextBox textBoxTQuantity;
        private System.Windows.Forms.Label labelTransportQuantity;
        private System.Windows.Forms.TextBox textBoxTType;
        private System.Windows.Forms.Label labelTransportType;
        private System.Windows.Forms.Label labelTransportSeater;
        private System.Windows.Forms.TextBox textBoxTPrice;
        private System.Windows.Forms.Label labelTransportPrice;
        private System.Windows.Forms.TextBox textBoxTID;
        private System.Windows.Forms.Label labelTID;
        private System.Windows.Forms.Panel panel1;
    }
}