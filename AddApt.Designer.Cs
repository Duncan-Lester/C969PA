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
            this.label3 = new System.Windows.Forms.Label();
            this.startBox = new System.Windows.Forms.Label();
            this.endBox = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.addAptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meeting Date";
            // 
            // startBox
            // 
            this.startBox.AutoSize = true;
            this.startBox.Location = new System.Drawing.Point(13, 114);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(96, 13);
            this.startBox.TabIndex = 3;
            this.startBox.Text = "Meeting Start Time";
            // 
            // endBox
            // 
            this.endBox.AutoSize = true;
            this.endBox.Location = new System.Drawing.Point(13, 139);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(93, 13);
            this.endBox.TabIndex = 4;
            this.endBox.Text = "Meeting End Time";
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
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(128, 86);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(118, 20);
            this.dateBox.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 20);
            this.textBox5.TabIndex = 9;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "mm-dd-yyyy please";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "24 Hr HH:MM please";
            // 
            // AddApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 235);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAptButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startBox;
        private System.Windows.Forms.Label endBox;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button addAptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}