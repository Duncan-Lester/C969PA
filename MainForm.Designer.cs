namespace C969PA
{
    partial class MainForm
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
            this.customersLabel = new System.Windows.Forms.Label();
            this.apptsLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.updCustomerButton = new System.Windows.Forms.Button();
            this.delCustomerButton = new System.Windows.Forms.Button();
            this.appCalendar = new System.Windows.Forms.DataGridView();
            this.delAppButton = new System.Windows.Forms.Button();
            this.updateAppButton = new System.Windows.Forms.Button();
            this.addAppButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appCalendar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Location = new System.Drawing.Point(208, 27);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(56, 13);
            this.customersLabel.TabIndex = 0;
            this.customersLabel.Text = "Customers";
            // 
            // apptsLabel
            // 
            this.apptsLabel.AutoSize = true;
            this.apptsLabel.Location = new System.Drawing.Point(918, 31);
            this.apptsLabel.Name = "apptsLabel";
            this.apptsLabel.Size = new System.Drawing.Size(66, 13);
            this.apptsLabel.TabIndex = 1;
            this.apptsLabel.Text = "Appointment";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(990, 31);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(49, 13);
            this.calendarLabel.TabIndex = 2;
            this.calendarLabel.Text = "Calendar";
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Location = new System.Drawing.Point(163, 15);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(61, 17);
            this.weekRadio.TabIndex = 3;
            this.weekRadio.Text = "Weekly";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Checked = true;
            this.monthRadio.Location = new System.Drawing.Point(86, 15);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(62, 17);
            this.monthRadio.TabIndex = 5;
            this.monthRadio.TabStop = true;
            this.monthRadio.Text = "Monthly";
            this.monthRadio.UseVisualStyleBackColor = true;
            this.monthRadio.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(1109, 552);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(244, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerGrid
            // 
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Location = new System.Drawing.Point(30, 54);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.Size = new System.Drawing.Size(447, 434);
            this.customerGrid.TabIndex = 7;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.LightGreen;
            this.addCustomerButton.Location = new System.Drawing.Point(82, 525);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(107, 23);
            this.addCustomerButton.TabIndex = 8;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updCustomerButton
            // 
            this.updCustomerButton.Location = new System.Drawing.Point(211, 525);
            this.updCustomerButton.Name = "updCustomerButton";
            this.updCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.updCustomerButton.TabIndex = 9;
            this.updCustomerButton.Text = "Update";
            this.updCustomerButton.UseVisualStyleBackColor = true;
            this.updCustomerButton.Click += new System.EventHandler(this.updCust_Click);
            // 
            // delCustomerButton
            // 
            this.delCustomerButton.BackColor = System.Drawing.Color.LightCoral;
            this.delCustomerButton.Location = new System.Drawing.Point(292, 525);
            this.delCustomerButton.Name = "delCustomerButton";
            this.delCustomerButton.Size = new System.Drawing.Size(128, 23);
            this.delCustomerButton.TabIndex = 10;
            this.delCustomerButton.Text = "Delete Customer";
            this.delCustomerButton.UseVisualStyleBackColor = false;
            this.delCustomerButton.Click += new System.EventHandler(this.delCust_Click);
            // 
            // appCalendar
            // 
            this.appCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appCalendar.Location = new System.Drawing.Point(552, 54);
            this.appCalendar.Name = "appCalendar";
            this.appCalendar.Size = new System.Drawing.Size(855, 434);
            this.appCalendar.TabIndex = 11;
            // 
            // delAppButton
            // 
            this.delAppButton.BackColor = System.Drawing.Color.LightCoral;
            this.delAppButton.Location = new System.Drawing.Point(1271, 511);
            this.delAppButton.Name = "delAppButton";
            this.delAppButton.Size = new System.Drawing.Size(75, 23);
            this.delAppButton.TabIndex = 14;
            this.delAppButton.Text = "Delete Apt";
            this.delAppButton.UseVisualStyleBackColor = false;
            this.delAppButton.Click += new System.EventHandler(this.delApp_Click);
            // 
            // updateAppButton
            // 
            this.updateAppButton.Location = new System.Drawing.Point(1190, 511);
            this.updateAppButton.Name = "updateAppButton";
            this.updateAppButton.Size = new System.Drawing.Size(75, 23);
            this.updateAppButton.TabIndex = 13;
            this.updateAppButton.Text = "Update";
            this.updateAppButton.UseVisualStyleBackColor = true;
            this.updateAppButton.Click += new System.EventHandler(this.updApp_Click);
            // 
            // addAppButton
            // 
            this.addAppButton.BackColor = System.Drawing.Color.LightGreen;
            this.addAppButton.Location = new System.Drawing.Point(1109, 511);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(75, 23);
            this.addAppButton.TabIndex = 12;
            this.addAppButton.Text = "Add Apt";
            this.addAppButton.UseVisualStyleBackColor = false;
            this.addAppButton.Click += new System.EventHandler(this.addApp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthRadio);
            this.groupBox1.Controls.Add(this.weekRadio);
            this.groupBox1.Location = new System.Drawing.Point(1148, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select entire row with arrow to update and delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1145, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select entire row with arrow to update and delete\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reports";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Appointment Types Per Month";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 57);
            this.button2.TabIndex = 20;
            this.button2.Text = "Consultant Schedules";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(846, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 57);
            this.button3.TabIndex = 21;
            this.button3.Text = "Appointments Per Customer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Refresh Customers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select a Name, then click Add for a new appointment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delAppButton);
            this.Controls.Add(this.updateAppButton);
            this.Controls.Add(this.addAppButton);
            this.Controls.Add(this.appCalendar);
            this.Controls.Add(this.delCustomerButton);
            this.Controls.Add(this.updCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.apptsLabel);
            this.Controls.Add(this.customersLabel);
            this.Name = "MainForm";
            this.Text = "Customer Appointment Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appCalendar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Label apptsLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button updCustomerButton;
        private System.Windows.Forms.Button delCustomerButton;
        private System.Windows.Forms.DataGridView appCalendar;
        private System.Windows.Forms.Button delAppButton;
        private System.Windows.Forms.Button updateAppButton;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
    }
}

