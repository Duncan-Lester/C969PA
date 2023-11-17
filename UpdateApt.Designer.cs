namespace C969PA
{
    partial class UpdateApt
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updAptButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.cancelButton.Location = new System.Drawing.Point(218, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updAptButton
            // 
            this.updAptButton.BackColor = System.Drawing.Color.LightGreen;
            this.updAptButton.Location = new System.Drawing.Point(88, 189);
            this.updAptButton.Name = "updAptButton";
            this.updAptButton.Size = new System.Drawing.Size(75, 23);
            this.updAptButton.TabIndex = 25;
            this.updAptButton.Text = "Update";
            this.updAptButton.UseVisualStyleBackColor = false;
            this.updAptButton.Click += new System.EventHandler(this.updAptButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(129, 55);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(118, 20);
            this.typeBox.TabIndex = 21;
            // 
            // customerBox
            // 
            this.customerBox.Location = new System.Drawing.Point(129, 25);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(118, 20);
            this.customerBox.TabIndex = 20;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(14, 134);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(93, 13);
            this.endLabel.TabIndex = 19;
            this.endLabel.Text = "Meeting End Time";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(14, 109);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(96, 13);
            this.startLabel.TabIndex = 18;
            this.startLabel.Text = "Meeting Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Meeting Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer";
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(129, 135);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimePicker.TabIndex = 29;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(129, 109);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimePicker.TabIndex = 30;
            // 
            // UpdateApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 231);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updAptButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateApt";
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updAptButton;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
    }
}