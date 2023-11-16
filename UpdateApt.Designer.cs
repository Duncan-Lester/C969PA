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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updAptButton = new System.Windows.Forms.Button();
            this.endBox = new System.Windows.Forms.TextBox();
            this.startBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "24 Hr HH:MM please";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "mm-dd-yyyy please";
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
            // endBox
            // 
            this.endBox.Location = new System.Drawing.Point(129, 134);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(118, 20);
            this.endBox.TabIndex = 24;
            // 
            // startBox
            // 
            this.startBox.Location = new System.Drawing.Point(129, 108);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(118, 20);
            this.startBox.TabIndex = 23;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(129, 81);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(118, 20);
            this.dateBox.TabIndex = 22;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Meeting Date";
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
            // UpdateApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updAptButton);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateApt";
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updAptButton;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}