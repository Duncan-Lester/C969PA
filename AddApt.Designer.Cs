namespace C969PA
{
    partial class AddApt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startLAbel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.addAptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meeting Type";
            // 
            // startLAbel
            // 
            this.startLAbel.AutoSize = true;
            this.startLAbel.Location = new System.Drawing.Point(13, 114);
            this.startLAbel.Name = "startLAbel";
            this.startLAbel.Size = new System.Drawing.Size(96, 13);
            this.startLAbel.TabIndex = 3;
            this.startLAbel.Text = "Meeting Start Time";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(13, 139);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(93, 13);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "Meeting End Time";
            // 
            // customerBox
            // 
            this.customerBox.Location = new System.Drawing.Point(128, 30);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(118, 20);
            this.customerBox.TabIndex = 5;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(128, 60);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(118, 20);
            this.typeBox.TabIndex = 6;
            // 
            // addAptButton
            // 
            this.addAptButton.BackColor = System.Drawing.Color.LightGreen;
            this.addAptButton.Location = new System.Drawing.Point(87, 194);
            this.addAptButton.Name = "addAptButton";
            this.addAptButton.Size = new System.Drawing.Size(75, 23);
            this.addAptButton.TabIndex = 10;
            this.addAptButton.Text = "Add";
            this.addAptButton.UseVisualStyleBackColor = false;
            this.addAptButton.Click += new System.EventHandler(this.addAptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.cancelButton.Location = new System.Drawing.Point(217, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(128, 112);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimePicker.TabIndex = 31;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(128, 139);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimePicker.TabIndex = 32;
            // 
            // AddApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 235);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAptButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLAbel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddApt";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startLAbel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button addAptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
    }
}