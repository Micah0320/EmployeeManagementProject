namespace dropbox14
{
    partial class AddHoursForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eidLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.eidTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hoursTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.eidTextBox);
            this.groupBox1.Controls.Add(this.hoursLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.eidLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hours Data";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // eidLabel
            // 
            this.eidLabel.AutoSize = true;
            this.eidLabel.Location = new System.Drawing.Point(141, 77);
            this.eidLabel.Name = "eidLabel";
            this.eidLabel.Size = new System.Drawing.Size(70, 13);
            this.eidLabel.TabIndex = 0;
            this.eidLabel.Text = "Employee ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(141, 146);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Employee Name:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(141, 219);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(79, 13);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "Hours Worked:";
            // 
            // eidTextBox
            // 
            this.eidTextBox.Enabled = false;
            this.eidTextBox.Location = new System.Drawing.Point(370, 77);
            this.eidTextBox.Name = "eidTextBox";
            this.eidTextBox.Size = new System.Drawing.Size(193, 20);
            this.eidTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(370, 139);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(193, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(370, 212);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(193, 20);
            this.hoursTextBox.TabIndex = 5;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(157, 336);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "&Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(365, 335);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(569, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Cl&ose and Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddHoursForm";
            this.Text = "Add Hours Form";
            this.Load += new System.EventHandler(this.AddHoursForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox eidTextBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label eidLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
    }
}