namespace PayrollProject.Forms
{
    partial class Selection_Form
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
            if (disposing && (components != null)) {
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
            this.Advisor_Label = new System.Windows.Forms.Label();
            this.Employee_Label = new System.Windows.Forms.Label();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Advisor_CheckBox = new System.Windows.Forms.CheckedListBox();
            this.Employee_CheckBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Advisor_Label
            // 
            this.Advisor_Label.AutoSize = true;
            this.Advisor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor_Label.Location = new System.Drawing.Point(10, 10);
            this.Advisor_Label.Name = "Advisor_Label";
            this.Advisor_Label.Size = new System.Drawing.Size(69, 20);
            this.Advisor_Label.TabIndex = 1;
            this.Advisor_Label.Text = "Advisors";
            // 
            // Employee_Label
            // 
            this.Employee_Label.AutoSize = true;
            this.Employee_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Label.Location = new System.Drawing.Point(217, 10);
            this.Employee_Label.Name = "Employee_Label";
            this.Employee_Label.Size = new System.Drawing.Size(87, 20);
            this.Employee_Label.TabIndex = 1;
            this.Employee_Label.Text = "Employees";
            // 
            // Submit_Button
            // 
            this.Submit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Button.Location = new System.Drawing.Point(264, 141);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(128, 42);
            this.Submit_Button.TabIndex = 3;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Advisor_CheckBox
            // 
            this.Advisor_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor_CheckBox.FormattingEnabled = true;
            this.Advisor_CheckBox.Items.AddRange(new object[] {
            "Andrew",
            "Bernd",
            "Brian",
            "Trent"});
            this.Advisor_CheckBox.Location = new System.Drawing.Point(14, 33);
            this.Advisor_CheckBox.Name = "Advisor_CheckBox";
            this.Advisor_CheckBox.Size = new System.Drawing.Size(171, 88);
            this.Advisor_CheckBox.TabIndex = 1;
            // 
            // Employee_CheckBox
            // 
            this.Employee_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_CheckBox.FormattingEnabled = true;
            this.Employee_CheckBox.Items.AddRange(new object[] {
            "Annette",
            "Tempest"});
            this.Employee_CheckBox.Location = new System.Drawing.Point(221, 33);
            this.Employee_CheckBox.Name = "Employee_CheckBox";
            this.Employee_CheckBox.Size = new System.Drawing.Size(171, 88);
            this.Employee_CheckBox.TabIndex = 2;
            // 
            // Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 202);
            this.Controls.Add(this.Employee_CheckBox);
            this.Controls.Add(this.Advisor_CheckBox);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Employee_Label);
            this.Controls.Add(this.Advisor_Label);
            this.Name = "Selection_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Advisor_Label;
        private System.Windows.Forms.Label Employee_Label;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.CheckedListBox Advisor_CheckBox;
        private System.Windows.Forms.CheckedListBox Employee_CheckBox;
    }
}

