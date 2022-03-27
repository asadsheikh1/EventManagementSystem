
namespace EventManagementSystem
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.dataGridViewEventsInfo = new System.Windows.Forms.DataGridView();
            this.btnDisplayEvents = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEType = new System.Windows.Forms.ComboBox();
            this.textBoxETheme = new System.Windows.Forms.TextBox();
            this.labelEventTheme = new System.Windows.Forms.Label();
            this.textBoxEDescription = new System.Windows.Forms.TextBox();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.textBoxEPrice = new System.Windows.Forms.TextBox();
            this.labelEventPrice = new System.Windows.Forms.Label();
            this.textBoxEDate = new System.Windows.Forms.TextBox();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelEventType = new System.Windows.Forms.Label();
            this.textBoxEName = new System.Windows.Forms.TextBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.labelEID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEventsInfo
            // 
            this.dataGridViewEventsInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEventsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventsInfo.Location = new System.Drawing.Point(529, 238);
            this.dataGridViewEventsInfo.Name = "dataGridViewEventsInfo";
            this.dataGridViewEventsInfo.RowHeadersWidth = 51;
            this.dataGridViewEventsInfo.RowTemplate.Height = 29;
            this.dataGridViewEventsInfo.Size = new System.Drawing.Size(753, 520);
            this.dataGridViewEventsInfo.TabIndex = 23;
            this.dataGridViewEventsInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEventsInfo_RowHeaderMouseDoubleClick);
            // 
            // btnDisplayEvents
            // 
            this.btnDisplayEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayEvents.ForeColor = System.Drawing.Color.White;
            this.btnDisplayEvents.Location = new System.Drawing.Point(272, 602);
            this.btnDisplayEvents.Name = "btnDisplayEvents";
            this.btnDisplayEvents.Size = new System.Drawing.Size(199, 56);
            this.btnDisplayEvents.TabIndex = 24;
            this.btnDisplayEvents.Text = "Display Events";
            this.btnDisplayEvents.UseVisualStyleBackColor = true;
            this.btnDisplayEvents.Click += new System.EventHandler(this.btnDisplayEventPackages_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEvent.ForeColor = System.Drawing.Color.White;
            this.btnAddEvent.Location = new System.Drawing.Point(67, 602);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(199, 56);
            this.btnAddEvent.TabIndex = 26;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEvent.Location = new System.Drawing.Point(272, 664);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(199, 56);
            this.btnDeleteEvent.TabIndex = 27;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(67, 664);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 56);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEType);
            this.groupBox1.Controls.Add(this.textBoxETheme);
            this.groupBox1.Controls.Add(this.labelEventTheme);
            this.groupBox1.Controls.Add(this.textBoxEDescription);
            this.groupBox1.Controls.Add(this.labelEventDescription);
            this.groupBox1.Controls.Add(this.textBoxEPrice);
            this.groupBox1.Controls.Add(this.labelEventPrice);
            this.groupBox1.Controls.Add(this.textBoxEDate);
            this.groupBox1.Controls.Add(this.labelEventDate);
            this.groupBox1.Controls.Add(this.labelEventType);
            this.groupBox1.Controls.Add(this.textBoxEName);
            this.groupBox1.Controls.Add(this.labelEventName);
            this.groupBox1.Controls.Add(this.textBoxEID);
            this.groupBox1.Controls.Add(this.labelEID);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 669);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Our Events";
            // 
            // comboBoxEType
            // 
            this.comboBoxEType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEType.FormattingEnabled = true;
            this.comboBoxEType.Items.AddRange(new object[] {
            "Family",
            "Family & Friends",
            "Friends"});
            this.comboBoxEType.Location = new System.Drawing.Point(201, 183);
            this.comboBoxEType.Name = "comboBoxEType";
            this.comboBoxEType.Size = new System.Drawing.Size(295, 31);
            this.comboBoxEType.TabIndex = 72;
            // 
            // textBoxETheme
            // 
            this.textBoxETheme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxETheme.Location = new System.Drawing.Point(201, 440);
            this.textBoxETheme.Name = "textBoxETheme";
            this.textBoxETheme.Size = new System.Drawing.Size(295, 32);
            this.textBoxETheme.TabIndex = 71;
            // 
            // labelEventTheme
            // 
            this.labelEventTheme.AutoSize = true;
            this.labelEventTheme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEventTheme.ForeColor = System.Drawing.Color.White;
            this.labelEventTheme.Location = new System.Drawing.Point(52, 443);
            this.labelEventTheme.Name = "labelEventTheme";
            this.labelEventTheme.Size = new System.Drawing.Size(139, 23);
            this.labelEventTheme.TabIndex = 70;
            this.labelEventTheme.Text = "Event Theme:";
            // 
            // textBoxEDescription
            // 
            this.textBoxEDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEDescription.Location = new System.Drawing.Point(201, 326);
            this.textBoxEDescription.Multiline = true;
            this.textBoxEDescription.Name = "textBoxEDescription";
            this.textBoxEDescription.Size = new System.Drawing.Size(295, 100);
            this.textBoxEDescription.TabIndex = 69;
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEventDescription.ForeColor = System.Drawing.Color.White;
            this.labelEventDescription.Location = new System.Drawing.Point(8, 325);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(183, 23);
            this.labelEventDescription.TabIndex = 68;
            this.labelEventDescription.Text = "Event Description:";
            // 
            // textBoxEPrice
            // 
            this.textBoxEPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEPrice.Location = new System.Drawing.Point(201, 278);
            this.textBoxEPrice.Name = "textBoxEPrice";
            this.textBoxEPrice.Size = new System.Drawing.Size(295, 32);
            this.textBoxEPrice.TabIndex = 67;
            // 
            // labelEventPrice
            // 
            this.labelEventPrice.AutoSize = true;
            this.labelEventPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEventPrice.ForeColor = System.Drawing.Color.White;
            this.labelEventPrice.Location = new System.Drawing.Point(69, 278);
            this.labelEventPrice.Name = "labelEventPrice";
            this.labelEventPrice.Size = new System.Drawing.Size(122, 23);
            this.labelEventPrice.TabIndex = 66;
            this.labelEventPrice.Text = "Event Price:";
            // 
            // textBoxEDate
            // 
            this.textBoxEDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEDate.Location = new System.Drawing.Point(201, 230);
            this.textBoxEDate.Name = "textBoxEDate";
            this.textBoxEDate.Size = new System.Drawing.Size(295, 32);
            this.textBoxEDate.TabIndex = 65;
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEventDate.ForeColor = System.Drawing.Color.White;
            this.labelEventDate.Location = new System.Drawing.Point(71, 231);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(120, 23);
            this.labelEventDate.TabIndex = 64;
            this.labelEventDate.Text = "Event Date:";
            // 
            // labelEventType
            // 
            this.labelEventType.AutoSize = true;
            this.labelEventType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEventType.ForeColor = System.Drawing.Color.White;
            this.labelEventType.Location = new System.Drawing.Point(71, 184);
            this.labelEventType.Name = "labelEventType";
            this.labelEventType.Size = new System.Drawing.Size(120, 23);
            this.labelEventType.TabIndex = 63;
            this.labelEventType.Text = "Event Type:";
            // 
            // textBoxEName
            // 
            this.textBoxEName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEName.Location = new System.Drawing.Point(201, 135);
            this.textBoxEName.Name = "textBoxEName";
            this.textBoxEName.Size = new System.Drawing.Size(295, 32);
            this.textBoxEName.TabIndex = 62;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEventName.ForeColor = System.Drawing.Color.White;
            this.labelEventName.Location = new System.Drawing.Point(57, 137);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(134, 23);
            this.labelEventName.TabIndex = 61;
            this.labelEventName.Text = "Event Name:";
            // 
            // textBoxEID
            // 
            this.textBoxEID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEID.Location = new System.Drawing.Point(201, 87);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(295, 32);
            this.textBoxEID.TabIndex = 60;
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEID.ForeColor = System.Drawing.Color.White;
            this.labelEID.Location = new System.Drawing.Point(97, 90);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(94, 23);
            this.labelEID.TabIndex = 59;
            this.labelEID.Text = "Event ID:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EventManagementSystem.Properties.Resources.logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(529, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 208);
            this.panel1.TabIndex = 45;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1294, 781);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnDisplayEvents);
            this.Controls.Add(this.dataGridViewEventsInfo);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | Event Management System | Event";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventsInfo;
        private System.Windows.Forms.Button btnDisplayEvents;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxEType;
        private System.Windows.Forms.TextBox textBoxETheme;
        private System.Windows.Forms.Label labelEventTheme;
        private System.Windows.Forms.TextBox textBoxEDescription;
        private System.Windows.Forms.Label labelEventDescription;
        private System.Windows.Forms.TextBox textBoxEPrice;
        private System.Windows.Forms.Label labelEventPrice;
        private System.Windows.Forms.TextBox textBoxEDate;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.Label labelEventType;
        private System.Windows.Forms.TextBox textBoxEName;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.Panel panel1;
    }
}