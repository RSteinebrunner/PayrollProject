using PayrollProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProject.Forms
{
    public partial class Inputs_Form : Form
    {
        List<string> employees = new List<string>();
        List<string> advisors = new List<string>();
        List<Employee> data = new List<Employee>();

        //so the first form can display the next forms
        public Inputs_Form(List<String> EmployeeNames, List<String> AdvisorNames)
        {
            InitializeComponent();
            foreach (string name in EmployeeNames)
            {
                employees.Add(name);
            }
            foreach(string name in AdvisorNames) {
                advisors.Add(name);
            }
            Name_Label.Text = employees.First();
            Advisor1_Label.Text = advisors[0];
            Advisor2_Label.Text = advisors[1];
            Advisor3_Label.Text = advisors[2];
            Advisor4_Label.Text = advisors[3];
            

        }
        public Inputs_Form(List<string> EmployeeNames, List<string> AdvisorNames, List<Employee> Data)
        {
            InitializeComponent();
            foreach (string name in EmployeeNames)
            {
                employees.Add(name);
            }
            foreach (string name in AdvisorNames)
            {
                advisors.Add(name);
            }
            foreach (Employee worker in Data)
            {
                data.Add(worker);
            }
            Name_Label.Text = employees.First();
            Advisor1_Label.Text = advisors[0];
            Advisor2_Label.Text = advisors[1];
            Advisor3_Label.Text = advisors[2];
            Advisor4_Label.Text = advisors[3];
           

        }


        private void Finished_Button_Click(object sender, EventArgs e)
        {
            if ((int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value) != 100)
            {
                MessageBox.Show("Total Percent must be 100");
                return;
            }
            //Get the data
            string name = employees[0];
            //get all hours worked
            List<Time> dailyHoursWorked = new List<Time>();
            dailyHoursWorked.Add(ConvertToTime(Day1Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day2Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day3Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day4Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day5Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day6Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day7Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day8Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day9Hours.Text));
            dailyHoursWorked.Add(ConvertToTime(Day10Hours.Text));
            List<Time> clockInTimes = new List<Time>();
            clockInTimes.Add(new Time(Day1Picker.Value.Hour, Day1Picker.Value.Minute));
            clockInTimes.Add(new Time(Day2Picker.Value.Hour, Day2Picker.Value.Minute));
            clockInTimes.Add(new Time(Day3Picker.Value.Hour, Day3Picker.Value.Minute));
            clockInTimes.Add(new Time(Day4Picker.Value.Hour, Day4Picker.Value.Minute));
            clockInTimes.Add(new Time(Day5Picker.Value.Hour, Day5Picker.Value.Minute));
            clockInTimes.Add(new Time(Day6Picker.Value.Hour, Day6Picker.Value.Minute));
            clockInTimes.Add(new Time(Day7Picker.Value.Hour, Day7Picker.Value.Minute));
            clockInTimes.Add(new Time(Day8Picker.Value.Hour, Day8Picker.Value.Minute));
            clockInTimes.Add(new Time(Day9Picker.Value.Hour, Day9Picker.Value.Minute));
            clockInTimes.Add(new Time(Day10Picker.Value.Hour, Day10Picker.Value.Minute));
            List<int> advisorPercent = new List<int>();
            advisorPercent.Add((int)A1Percent.Value);
            advisorPercent.Add((int)A2Percent.Value);
            advisorPercent.Add((int)A3Percent.Value);
            advisorPercent.Add((int)A4Percent.Value);

            //Set the data to the employee object
            Employee emp = new Employee(name, dailyHoursWorked, clockInTimes, advisorPercent);
            data.Add(emp);

            //if employees is not empty show next employee form
            employees.RemoveAt(0);
            if (employees.Count() > 0) {
                Inputs_Form form = new Inputs_Form(employees, advisors, data);
                this.Hide();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            //otherwise show calculation form
            else {
                Calculation_Form form = new Calculation_Form(data, advisors);
                this.Hide();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }

            
        }
        private Time ConvertToTime(string time)
        {
            decimal dTime = 0;
            try
            {
                 dTime = decimal.Parse(time);
            }
            catch
            {
                MessageBox.Show("Please enter a number only");
            }

            //truncate for hours
            int hours = (int)dTime;
            decimal dHours = 0;
            try
            {
                dHours = Convert.ToDecimal(hours);
            }
            catch
            {
                MessageBox.Show("Please enter a number only");
            }
            //find decimal remainder
            decimal remainder = dTime - dHours;
            //take decimal remainder and multiply by 60
            int minutes = Convert.ToInt32(remainder * 60);

            return new Time(hours, minutes);
        }

        private void Quicktime1_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2020, 02, 18, 8, 0, 0);
            Day1Picker.Value = date;
            Day2Picker.Value = date;
            Day3Picker.Value = date;
            Day4Picker.Value = date;
            Day5Picker.Value = date;
            Day6Picker.Value = date;
            Day7Picker.Value = date;
            Day8Picker.Value = date;
            Day9Picker.Value = date;
            Day10Picker.Value = date;

        }

        private void PercentPaid_Group_Enter(object sender, EventArgs e)
        {

        }

        private void Quicktime2_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2020, 02, 18, 8, 30, 0);
            Day1Picker.Value = date;
            Day2Picker.Value = date;
            Day3Picker.Value = date;
            Day4Picker.Value = date;
            Day5Picker.Value = date;
            Day6Picker.Value = date;
            Day7Picker.Value = date;
            Day8Picker.Value = date;
            Day9Picker.Value = date;
            Day10Picker.Value = date;
        }

        private void Quicktime3_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2020, 02, 18, 9, 0, 0);
            Day1Picker.Value = date;
            Day2Picker.Value = date;
            Day3Picker.Value = date;
            Day4Picker.Value = date;
            Day5Picker.Value = date;
            Day6Picker.Value = date;
            Day7Picker.Value = date;
            Day8Picker.Value = date;
            Day9Picker.Value = date;
            Day10Picker.Value = date;
        }

        private void A1Percent_Enter(object sender, EventArgs e)
        {
            A1Percent.Select(0, A1Percent.Text.Length);
        }
        private void A2Percent_Enter(object sender, EventArgs e)
        {
            A2Percent.Select(0, A2Percent.Text.Length);
        }
        private void A3Percent_Enter(object sender, EventArgs e)
        {
            A3Percent.Select(0, A3Percent.Text.Length);
        }
        private void A4Percent_Enter(object sender, EventArgs e)
        {
            A4Percent.Select(0, A4Percent.Text.Length);
        }
        private void A1Percent_ValueChanged(object sender, EventArgs e)
        {
            //find total value and value of other three fields
            int totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            int otherThree = (int)(A2Percent.Value + A3Percent.Value + A4Percent.Value);
            if (totalValue > 100) {
                A1Percent.Value = 100 - otherThree;
            }
            //recalculate total value
            totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            //adjust percent label
            Total_Label.Text = "Total: " + totalValue.ToString();
        }

        private void A2Percent_ValueChanged(object sender, EventArgs e)
        {
            int totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            int otherThree = (int)(A1Percent.Value + A3Percent.Value + A4Percent.Value);
            if (totalValue > 100) {
                A2Percent.Value = 100 - otherThree;
            }

            //recalculate total value
            totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            //adjust percent label
            Total_Label.Text = "Total: " + totalValue.ToString();
        }

        private void A3Percent_ValueChanged(object sender, EventArgs e)
        {
            int totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            int otherThree = (int)(A1Percent.Value + A2Percent.Value + A4Percent.Value);
            if (totalValue > 100) {
                A3Percent.Value = 100 - otherThree;
            }

            //recalculate total value
            totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            //adjust percent label
            Total_Label.Text = "Total: " + totalValue.ToString();
        }

        private void A4Percent_ValueChanged(object sender, EventArgs e)
        {
            int totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            int otherThree = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value);
            if (totalValue > 100) {
                A4Percent.Value = 100 - otherThree;
            }

            //recalculate total value
            totalValue = (int)(A1Percent.Value + A2Percent.Value + A3Percent.Value + A4Percent.Value);
            //adjust percent label
            Total_Label.Text = "Total: " + totalValue.ToString();
        }
        private void Day1Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day1Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day1Hours.Text = "";
            }
        }

        private void Day2Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day2Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day2Hours.Text = "";
            }
        }

        private void Day3Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day3Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day3Hours.Text = "";
            }
        }

        private void Day4Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day4Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day4Hours.Text = "";
            }
        }

        private void Day5Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day5Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day5Hours.Text = "";
            }
        }

        private void Day6Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day6Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day6Hours.Text = "";
            }
        }

        private void Day7Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day7Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day7Hours.Text = "";
            }
        }

        private void Day8Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day8Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day8Hours.Text = "";
            }
        }

        private void Day9Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day9Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day9Hours.Text = "";
            }
        }

        private void Day10Hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(Day10Hours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value only");
                Day10Hours.Text = "";
            }
        }
    }
}
