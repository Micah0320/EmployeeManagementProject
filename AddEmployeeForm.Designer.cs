namespace dropbox14
{
    partial class AddEmployeeForm
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
            this.employeeBox = new System.Windows.Forms.GroupBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.eidTextBox = new System.Windows.Forms.TextBox();
            this.payLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.eidLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.employeeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeBox
            // 
            this.employeeBox.Controls.Add(this.payTextBox);
            this.employeeBox.Controls.Add(this.nameTextBox);
            this.employeeBox.Controls.Add(this.eidTextBox);
            this.employeeBox.Controls.Add(this.payLabel);
            this.employeeBox.Controls.Add(this.nameLabel);
            this.employeeBox.Controls.Add(this.eidLabel);
            this.employeeBox.Location = new System.Drawing.Point(13, 13);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(775, 339);
            this.employeeBox.TabIndex = 0;
            this.employeeBox.TabStop = false;
            this.employeeBox.Text = "New Employee";
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(287, 214);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(196, 20);
            this.payTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(287, 138);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // eidTextBox
            // 
            this.eidTextBox.Location = new System.Drawing.Point(287, 78);
            this.eidTextBox.Name = "eidTextBox";
            this.eidTextBox.Size = new System.Drawing.Size(196, 20);
            this.eidTextBox.TabIndex = 3;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Location = new System.Drawing.Point(72, 214);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(54, 13);
            this.payLabel.TabIndex = 2;
            this.payLabel.Text = "Pay Rate:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(72, 138);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Employee Name:";
            // 
            // eidLabel
            // 
            this.eidLabel.AutoSize = true;
            this.eidLabel.Location = new System.Drawing.Point(72, 78);
            this.eidLabel.Name = "eidLabel";
            this.eidLabel.Size = new System.Drawing.Size(70, 13);
            this.eidLabel.TabIndex = 0;
            this.eidLabel.Text = "Employee ID:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(88, 375);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(288, 375);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(471, 375);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.employeeBox);
            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee Form";
            this.employeeBox.ResumeLayout(false);
            this.employeeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeBox;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label eidLabel;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox eidTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
    }
}