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
    public partial class Selection_Form : Form
    {
        /* TODO
         * Take Data from the check boxes
         * For each employee, Open a new payroll input form
         * Also open calculation form 
         * 
         * 
         */
        public Selection_Form()
        {
            InitializeComponent();
            for(int i = 0; i < Advisor_CheckBox.Items.Count; i++) {
                Advisor_CheckBox.SetItemChecked(i, true);
            }
            for (int i = 0; i < Employee_CheckBox.Items.Count; i++) {
                Employee_CheckBox.SetItemChecked(i, true);
            }
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
         
            //Create a list of names for the Advisors
            List<String> advisors = new List<String>();
            //Get all checked advisors and add them to list
            foreach(var item in Advisor_CheckBox.CheckedItems) {
                advisors.Add(item.ToString());
            }
            //get names first and add them to list
            List<String> employees = new List<String>();
            foreach (var item in Employee_CheckBox.CheckedItems) {
                employees.Add(item.ToString());
            }
            //Make form for checked employees
            Inputs_Form form = new Inputs_Form(employees, advisors);
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void Advisor_CheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
