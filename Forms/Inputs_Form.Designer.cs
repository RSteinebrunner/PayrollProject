using System.Windows.Forms;

namespace PayrollProject.Forms
{
    partial class Inputs_Form
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.Finished_Button = new System.Windows.Forms.Button();
            this.Advisor1_Label = new System.Windows.Forms.Label();
            this.Advisor2_Label = new System.Windows.Forms.Label();
            this.Advisor3_Label = new System.Windows.Forms.Label();
            this.Advisor4_Label = new System.Windows.Forms.Label();
            this.Total_Label = new System.Windows.Forms.Label();
            this.Day1Picker = new System.Windows.Forms.DateTimePicker();
            this.Day1_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Day1Hours = new System.Windows.Forms.TextBox();
            this.Day2Picker = new System.Windows.Forms.DateTimePicker();
            this.Day2Hours = new System.Windows.Forms.TextBox();
            this.Day3Picker = new System.Windows.Forms.DateTimePicker();
            this.Day3Hours = new System.Windows.Forms.TextBox();
            this.Day4Picker = new System.Windows.Forms.DateTimePicker();
            this.Day4Hours = new System.Windows.Forms.TextBox();
            this.Day5Picker = new System.Windows.Forms.DateTimePicker();
            this.Day5Hours = new System.Windows.Forms.TextBox();
            this.Day6Picker = new System.Windows.Forms.DateTimePicker();
            this.Day6Hours = new System.Windows.Forms.TextBox();
            this.Day7Picker = new System.Windows.Forms.DateTimePicker();
            this.Day7Hours = new System.Windows.Forms.TextBox();
            this.Day8Picker = new System.Windows.Forms.DateTimePicker();
            this.Day8Hours = new System.Windows.Forms.TextBox();
            this.Day9Picker = new System.Windows.Forms.DateTimePicker();
            this.Day9Hours = new System.Windows.Forms.TextBox();
            this.Day10Picker = new System.Windows.Forms.DateTimePicker();
            this.Day10Hours = new System.Windows.Forms.TextBox();
            this.A1Percent = new System.Windows.Forms.NumericUpDown();
            this.A2Percent = new System.Windows.Forms.NumericUpDown();
            this.A3Percent = new System.Windows.Forms.NumericUpDown();
            this.A4Percent = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.Quicktime1 = new System.Windows.Forms.Label();
            this.Quicktime2 = new System.Windows.Forms.Label();
            this.Quicktime3 = new System.Windows.Forms.Label();
            this.ClockTime_Group = new System.Windows.Forms.GroupBox();
            this.HoursWorked_Group = new System.Windows.Forms.GroupBox();
            this.PercentPaid_Group = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.A1Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A4Percent)).BeginInit();
            this.ClockTime_Group.SuspendLayout();
            this.HoursWorked_Group.SuspendLayout();
            this.PercentPaid_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(208, 9);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(182, 25);
            this.Name_Label.TabIndex = 4;
            this.Name_Label.Text = "Employee Name";
            // 
            // Finished_Button
            // 
            this.Finished_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finished_Button.Location = new System.Drawing.Point(529, 361);
            this.Finished_Button.Name = "Finished_Button";
            this.Finished_Button.Size = new System.Drawing.Size(89, 28);
            this.Finished_Button.TabIndex = 3;
            this.Finished_Button.Text = "Finished";
            this.Finished_Button.UseVisualStyleBackColor = true;
            this.Finished_Button.Click += new System.EventHandler(this.Finished_Button_Click);
            // 
            // Advisor1_Label
            // 
            this.Advisor1_Label.AutoSize = true;
            this.Advisor1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor1_Label.Location = new System.Drawing.Point(8, 32);
            this.Advisor1_Label.Name = "Advisor1_Label";
            this.Advisor1_Label.Size = new System.Drawing.Size(74, 20);
            this.Advisor1_Label.TabIndex = 2;
            this.Advisor1_Label.Text = "Advisor 1";
            // 
            // Advisor2_Label
            // 
            this.Advisor2_Label.AutoSize = true;
            this.Advisor2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor2_Label.Location = new System.Drawing.Point(8, 63);
            this.Advisor2_Label.Name = "Advisor2_Label";
            this.Advisor2_Label.Size = new System.Drawing.Size(74, 20);
            this.Advisor2_Label.TabIndex = 2;
            this.Advisor2_Label.Text = "Advisor 2";
            // 
            // Advisor3_Label
            // 
            this.Advisor3_Label.AutoSize = true;
            this.Advisor3_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor3_Label.Location = new System.Drawing.Point(8, 95);
            this.Advisor3_Label.Name = "Advisor3_Label";
            this.Advisor3_Label.Size = new System.Drawing.Size(74, 20);
            this.Advisor3_Label.TabIndex = 2;
            this.Advisor3_Label.Text = "Advisor 3";
            // 
            // Advisor4_Label
            // 
            this.Advisor4_Label.AutoSize = true;
            this.Advisor4_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor4_Label.Location = new System.Drawing.Point(8, 125);
            this.Advisor4_Label.Name = "Advisor4_Label";
            this.Advisor4_Label.Size = new System.Drawing.Size(74, 20);
            this.Advisor4_Label.TabIndex = 2;
            this.Advisor4_Label.Text = "Advisor 4";
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label.Location = new System.Drawing.Point(87, 161);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(61, 20);
            this.Total_Label.TabIndex = 4;
            this.Total_Label.Text = "Total: 0";
            // 
            // Day1Picker
            // 
            this.Day1Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day1Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day1Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day1Picker.Location = new System.Drawing.Point(10, 26);
            this.Day1Picker.Name = "Day1Picker";
            this.Day1Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day1Picker.Size = new System.Drawing.Size(120, 26);
            this.Day1Picker.TabIndex = 0;
            this.Day1Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day1_Label
            // 
            this.Day1_Label.AutoSize = true;
            this.Day1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day1_Label.Location = new System.Drawing.Point(12, 82);
            this.Day1_Label.Name = "Day1_Label";
            this.Day1_Label.Size = new System.Drawing.Size(50, 20);
            this.Day1_Label.TabIndex = 5;
            this.Day1_Label.Text = "Day 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Day 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Day 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Day 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Day 6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Day 7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Day 8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Day 10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Day 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Day 9";
            // 
            // Day1Hours
            // 
            this.Day1Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day1Hours.Location = new System.Drawing.Point(6, 25);
            this.Day1Hours.Name = "Day1Hours";
            this.Day1Hours.Size = new System.Drawing.Size(131, 26);
            this.Day1Hours.TabIndex = 0;
            this.Day1Hours.Text = "0";
            this.Day1Hours.TextChanged += new System.EventHandler(this.Day1Hours_TextChanged);
            // 
            // Day2Picker
            // 
            this.Day2Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day2Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day2Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day2Picker.Location = new System.Drawing.Point(10, 57);
            this.Day2Picker.Name = "Day2Picker";
            this.Day2Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day2Picker.Size = new System.Drawing.Size(120, 26);
            this.Day2Picker.TabIndex = 1;
            this.Day2Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day2Hours
            // 
            this.Day2Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day2Hours.Location = new System.Drawing.Point(6, 56);
            this.Day2Hours.Name = "Day2Hours";
            this.Day2Hours.Size = new System.Drawing.Size(131, 26);
            this.Day2Hours.TabIndex = 1;
            this.Day2Hours.Text = "0";
            this.Day2Hours.TextChanged += new System.EventHandler(this.Day2Hours_TextChanged);
            // 
            // Day3Picker
            // 
            this.Day3Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day3Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day3Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day3Picker.Location = new System.Drawing.Point(10, 88);
            this.Day3Picker.Name = "Day3Picker";
            this.Day3Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day3Picker.Size = new System.Drawing.Size(120, 26);
            this.Day3Picker.TabIndex = 2;
            this.Day3Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day3Hours
            // 
            this.Day3Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day3Hours.Location = new System.Drawing.Point(6, 87);
            this.Day3Hours.Name = "Day3Hours";
            this.Day3Hours.Size = new System.Drawing.Size(131, 26);
            this.Day3Hours.TabIndex = 2;
            this.Day3Hours.Text = "0";
            this.Day3Hours.TextChanged += new System.EventHandler(this.Day3Hours_TextChanged);
            // 
            // Day4Picker
            // 
            this.Day4Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day4Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day4Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day4Picker.Location = new System.Drawing.Point(10, 119);
            this.Day4Picker.Name = "Day4Picker";
            this.Day4Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day4Picker.Size = new System.Drawing.Size(120, 26);
            this.Day4Picker.TabIndex = 3;
            this.Day4Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day4Hours
            // 
            this.Day4Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day4Hours.Location = new System.Drawing.Point(6, 118);
            this.Day4Hours.Name = "Day4Hours";
            this.Day4Hours.Size = new System.Drawing.Size(131, 26);
            this.Day4Hours.TabIndex = 3;
            this.Day4Hours.Text = "0";
            this.Day4Hours.TextChanged += new System.EventHandler(this.Day4Hours_TextChanged);
            // 
            // Day5Picker
            // 
            this.Day5Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day5Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day5Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day5Picker.Location = new System.Drawing.Point(10, 150);
            this.Day5Picker.Name = "Day5Picker";
            this.Day5Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day5Picker.Size = new System.Drawing.Size(120, 26);
            this.Day5Picker.TabIndex = 4;
            this.Day5Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day5Hours
            // 
            this.Day5Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day5Hours.Location = new System.Drawing.Point(6, 149);
            this.Day5Hours.Name = "Day5Hours";
            this.Day5Hours.Size = new System.Drawing.Size(131, 26);
            this.Day5Hours.TabIndex = 4;
            this.Day5Hours.Text = "0";
            this.Day5Hours.TextChanged += new System.EventHandler(this.Day5Hours_TextChanged);
            // 
            // Day6Picker
            // 
            this.Day6Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day6Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day6Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day6Picker.Location = new System.Drawing.Point(10, 181);
            this.Day6Picker.Name = "Day6Picker";
            this.Day6Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day6Picker.Size = new System.Drawing.Size(120, 26);
            this.Day6Picker.TabIndex = 5;
            this.Day6Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day6Hours
            // 
            this.Day6Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day6Hours.Location = new System.Drawing.Point(6, 180);
            this.Day6Hours.Name = "Day6Hours";
            this.Day6Hours.Size = new System.Drawing.Size(131, 26);
            this.Day6Hours.TabIndex = 5;
            this.Day6Hours.Text = "0";
            this.Day6Hours.TextChanged += new System.EventHandler(this.Day6Hours_TextChanged);
            // 
            // Day7Picker
            // 
            this.Day7Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day7Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day7Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day7Picker.Location = new System.Drawing.Point(10, 212);
            this.Day7Picker.Name = "Day7Picker";
            this.Day7Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day7Picker.Size = new System.Drawing.Size(120, 26);
            this.Day7Picker.TabIndex = 6;
            this.Day7Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day7Hours
            // 
            this.Day7Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day7Hours.Location = new System.Drawing.Point(6, 211);
            this.Day7Hours.Name = "Day7Hours";
            this.Day7Hours.Size = new System.Drawing.Size(131, 26);
            this.Day7Hours.TabIndex = 6;
            this.Day7Hours.Text = "0";
            this.Day7Hours.TextChanged += new System.EventHandler(this.Day7Hours_TextChanged);
            // 
            // Day8Picker
            // 
            this.Day8Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day8Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day8Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day8Picker.Location = new System.Drawing.Point(10, 243);
            this.Day8Picker.Name = "Day8Picker";
            this.Day8Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day8Picker.Size = new System.Drawing.Size(120, 26);
            this.Day8Picker.TabIndex = 7;
            this.Day8Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day8Hours
            // 
            this.Day8Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day8Hours.Location = new System.Drawing.Point(6, 242);
            this.Day8Hours.Name = "Day8Hours";
            this.Day8Hours.Size = new System.Drawing.Size(131, 26);
            this.Day8Hours.TabIndex = 7;
            this.Day8Hours.Text = "0";
            this.Day8Hours.TextChanged += new System.EventHandler(this.Day8Hours_TextChanged);
            // 
            // Day9Picker
            // 
            this.Day9Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day9Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day9Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day9Picker.Location = new System.Drawing.Point(10, 274);
            this.Day9Picker.Name = "Day9Picker";
            this.Day9Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day9Picker.Size = new System.Drawing.Size(120, 26);
            this.Day9Picker.TabIndex = 8;
            this.Day9Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day9Hours
            // 
            this.Day9Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day9Hours.Location = new System.Drawing.Point(6, 273);
            this.Day9Hours.Name = "Day9Hours";
            this.Day9Hours.Size = new System.Drawing.Size(131, 26);
            this.Day9Hours.TabIndex = 8;
            this.Day9Hours.Text = "0";
            this.Day9Hours.TextChanged += new System.EventHandler(this.Day9Hours_TextChanged);
            // 
            // Day10Picker
            // 
            this.Day10Picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day10Picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day10Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Day10Picker.Location = new System.Drawing.Point(10, 305);
            this.Day10Picker.Name = "Day10Picker";
            this.Day10Picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Day10Picker.Size = new System.Drawing.Size(120, 26);
            this.Day10Picker.TabIndex = 9;
            this.Day10Picker.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // Day10Hours
            // 
            this.Day10Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day10Hours.Location = new System.Drawing.Point(6, 304);
            this.Day10Hours.Name = "Day10Hours";
            this.Day10Hours.Size = new System.Drawing.Size(131, 26);
            this.Day10Hours.TabIndex = 9;
            this.Day10Hours.Text = "0";
            this.Day10Hours.TextChanged += new System.EventHandler(this.Day10Hours_TextChanged);
            // 
            // A1Percent
            // 
            this.A1Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1Percent.Location = new System.Drawing.Point(88, 32);
            this.A1Percent.Name = "A1Percent";
            this.A1Percent.Size = new System.Drawing.Size(94, 26);
            this.A1Percent.TabIndex = 0;
            this.A1Percent.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.A1Percent.ValueChanged += new System.EventHandler(this.A1Percent_ValueChanged);
            this.A1Percent.Enter += new System.EventHandler(this.A1Percent_Enter);
            // 
            // A2Percent
            // 
            this.A2Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2Percent.Location = new System.Drawing.Point(88, 64);
            this.A2Percent.Name = "A2Percent";
            this.A2Percent.Size = new System.Drawing.Size(94, 26);
            this.A2Percent.TabIndex = 1;
            this.A2Percent.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.A2Percent.ValueChanged += new System.EventHandler(this.A2Percent_ValueChanged);
            this.A2Percent.Enter += new System.EventHandler(this.A2Percent_Enter);
            // 
            // A3Percent
            // 
            this.A3Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3Percent.Location = new System.Drawing.Point(88, 96);
            this.A3Percent.Name = "A3Percent";
            this.A3Percent.Size = new System.Drawing.Size(94, 26);
            this.A3Percent.TabIndex = 2;
            this.A3Percent.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.A3Percent.ValueChanged += new System.EventHandler(this.A3Percent_ValueChanged);
            this.A3Percent.Enter += new System.EventHandler(this.A3Percent_Enter);
            // 
            // A4Percent
            // 
            this.A4Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4Percent.Location = new System.Drawing.Point(88, 128);
            this.A4Percent.Name = "A4Percent";
            this.A4Percent.Size = new System.Drawing.Size(94, 26);
            this.A4Percent.TabIndex = 3;
            this.A4Percent.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.A4Percent.ValueChanged += new System.EventHandler(this.A4Percent_ValueChanged);
            this.A4Percent.Enter += new System.EventHandler(this.A4Percent_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(406, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Quick Clock-In Time";
            // 
            // Quicktime1
            // 
            this.Quicktime1.AutoSize = true;
            this.Quicktime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quicktime1.Location = new System.Drawing.Point(406, 296);
            this.Quicktime1.Name = "Quicktime1";
            this.Quicktime1.Size = new System.Drawing.Size(68, 20);
            this.Quicktime1.TabIndex = 16;
            this.Quicktime1.Text = "8:00 AM";
            this.Quicktime1.Click += new System.EventHandler(this.Quicktime1_Click);
            // 
            // Quicktime2
            // 
            this.Quicktime2.AutoSize = true;
            this.Quicktime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quicktime2.Location = new System.Drawing.Point(406, 327);
            this.Quicktime2.Name = "Quicktime2";
            this.Quicktime2.Size = new System.Drawing.Size(68, 20);
            this.Quicktime2.TabIndex = 17;
            this.Quicktime2.Text = "8:30 AM";
            this.Quicktime2.Click += new System.EventHandler(this.Quicktime2_Click);
            // 
            // Quicktime3
            // 
            this.Quicktime3.AutoSize = true;
            this.Quicktime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quicktime3.Location = new System.Drawing.Point(406, 358);
            this.Quicktime3.Name = "Quicktime3";
            this.Quicktime3.Size = new System.Drawing.Size(68, 20);
            this.Quicktime3.TabIndex = 18;
            this.Quicktime3.Text = "9:00 AM";
            this.Quicktime3.Click += new System.EventHandler(this.Quicktime3_Click);
            // 
            // ClockTime_Group
            // 
            this.ClockTime_Group.Controls.Add(this.Day10Picker);
            this.ClockTime_Group.Controls.Add(this.Day9Picker);
            this.ClockTime_Group.Controls.Add(this.Day8Picker);
            this.ClockTime_Group.Controls.Add(this.Day7Picker);
            this.ClockTime_Group.Controls.Add(this.Day6Picker);
            this.ClockTime_Group.Controls.Add(this.Day5Picker);
            this.ClockTime_Group.Controls.Add(this.Day4Picker);
            this.ClockTime_Group.Controls.Add(this.Day3Picker);
            this.ClockTime_Group.Controls.Add(this.Day2Picker);
            this.ClockTime_Group.Controls.Add(this.Day1Picker);
            this.ClockTime_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockTime_Group.Location = new System.Drawing.Point(238, 54);
            this.ClockTime_Group.Name = "ClockTime_Group";
            this.ClockTime_Group.Size = new System.Drawing.Size(142, 341);
            this.ClockTime_Group.TabIndex = 1;
            this.ClockTime_Group.TabStop = false;
            this.ClockTime_Group.Text = "Clock In Time";
            // 
            // HoursWorked_Group
            // 
            this.HoursWorked_Group.Controls.Add(this.Day10Hours);
            this.HoursWorked_Group.Controls.Add(this.Day9Hours);
            this.HoursWorked_Group.Controls.Add(this.Day8Hours);
            this.HoursWorked_Group.Controls.Add(this.Day7Hours);
            this.HoursWorked_Group.Controls.Add(this.Day6Hours);
            this.HoursWorked_Group.Controls.Add(this.Day5Hours);
            this.HoursWorked_Group.Controls.Add(this.Day4Hours);
            this.HoursWorked_Group.Controls.Add(this.Day3Hours);
            this.HoursWorked_Group.Controls.Add(this.Day2Hours);
            this.HoursWorked_Group.Controls.Add(this.Day1Hours);
            this.HoursWorked_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorked_Group.Location = new System.Drawing.Point(77, 54);
            this.HoursWorked_Group.Name = "HoursWorked_Group";
            this.HoursWorked_Group.Size = new System.Drawing.Size(143, 341);
            this.HoursWorked_Group.TabIndex = 0;
            this.HoursWorked_Group.TabStop = false;
            this.HoursWorked_Group.Text = "Hours Worked";
            // 
            // PercentPaid_Group
            // 
            this.PercentPaid_Group.Controls.Add(this.A4Percent);
            this.PercentPaid_Group.Controls.Add(this.A3Percent);
            this.PercentPaid_Group.Controls.Add(this.A2Percent);
            this.PercentPaid_Group.Controls.Add(this.A1Percent);
            this.PercentPaid_Group.Controls.Add(this.Total_Label);
            this.PercentPaid_Group.Controls.Add(this.Advisor1_Label);
            this.PercentPaid_Group.Controls.Add(this.Advisor2_Label);
            this.PercentPaid_Group.Controls.Add(this.Advisor3_Label);
            this.PercentPaid_Group.Controls.Add(this.Advisor4_Label);
            this.PercentPaid_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentPaid_Group.Location = new System.Drawing.Point(398, 54);
            this.PercentPaid_Group.Name = "PercentPaid_Group";
            this.PercentPaid_Group.Size = new System.Drawing.Size(220, 188);
            this.PercentPaid_Group.TabIndex = 2;
            this.PercentPaid_Group.TabStop = false;
            this.PercentPaid_Group.Text = "Percent Paid";
            this.PercentPaid_Group.Enter += new System.EventHandler(this.PercentPaid_Group_Enter);
            // 
            // Inputs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 423);
            this.Controls.Add(this.PercentPaid_Group);
            this.Controls.Add(this.HoursWorked_Group);
            this.Controls.Add(this.ClockTime_Group);
            this.Controls.Add(this.Quicktime3);
            this.Controls.Add(this.Quicktime2);
            this.Controls.Add(this.Quicktime1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Day1_Label);
            this.Controls.Add(this.Finished_Button);
            this.Controls.Add(this.Name_Label);
            this.Name = "Inputs_Form";
            this.Text = "Inputs_Form";
            ((System.ComponentModel.ISupportInitialize)(this.A1Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A4Percent)).EndInit();
            this.ClockTime_Group.ResumeLayout(false);
            this.HoursWorked_Group.ResumeLayout(false);
            this.HoursWorked_Group.PerformLayout();
            this.PercentPaid_Group.ResumeLayout(false);
            this.PercentPaid_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button Finished_Button;
        private System.Windows.Forms.Label Advisor1_Label;
        private System.Windows.Forms.Label Advisor2_Label;
        private System.Windows.Forms.Label Advisor3_Label;
        private System.Windows.Forms.Label Advisor4_Label;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.DateTimePicker Day1Picker;
        private Label Day1_Label;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Day1Hours;
        private DateTimePicker Day2Picker;
        private TextBox Day2Hours;
        private DateTimePicker Day3Picker;
        private TextBox Day3Hours;
        private DateTimePicker Day4Picker;
        private TextBox Day4Hours;
        private DateTimePicker Day5Picker;
        private TextBox Day5Hours;
        private DateTimePicker Day6Picker;
        private TextBox Day6Hours;
        private DateTimePicker Day7Picker;
        private TextBox Day7Hours;
        private DateTimePicker Day8Picker;
        private TextBox Day8Hours;
        private DateTimePicker Day9Picker;
        private TextBox Day9Hours;
        private DateTimePicker Day10Picker;
        private TextBox Day10Hours;
        private NumericUpDown A1Percent;
        private NumericUpDown A2Percent;
        private NumericUpDown A3Percent;
        private NumericUpDown A4Percent;
        private Label label14;
        private Label Quicktime1;
        private Label Quicktime2;
        private Label Quicktime3;
        private GroupBox ClockTime_Group;
        private GroupBox HoursWorked_Group;
        private GroupBox PercentPaid_Group;
    }
}