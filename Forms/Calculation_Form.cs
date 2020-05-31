using PayrollProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProject.Forms
{
    public partial class Calculation_Form : Form
    {
        List<Employee> data = new List<Employee>();
        List<string> advisors = new List<string>();

        public Calculation_Form(List<Employee> Data, List<String> AdvisorNames)
        {

            InitializeComponent();
            this.AutoSize = true;
            foreach (Employee worker in Data)
            {
                data.Add(worker);
            }
            foreach (string name in AdvisorNames)
            {
                advisors.Add(name);
            }
            showData();
        }

        public void showData()
        {

            Console.WriteLine("Entering getData");
            //for each employee there is
            for (int g = 0; g < data.Count; g++)
            {
                data[g].CalculateData();
                Console.WriteLine(data[g].name);
                
                //flow layout panel
                FlowLayoutPanel ClockInFlow = new FlowLayoutPanel();
                ClockInFlow.Location = new System.Drawing.Point(12, 20);
                ClockInFlow.Size = new System.Drawing.Size(200, 350);
                ClockInFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
                ClockInFlow.TabIndex = 0;
                ClockInFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                ClockInFlow.AutoSize = true;
                Label Title = new Label();
                Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Title.Text = "Clock In Time";
                Title.Size = new System.Drawing.Size(200, 25);
                ClockInFlow.Controls.Add(Title);

                //flow layout panel
                FlowLayoutPanel ClockOutFlow = new FlowLayoutPanel();
                ClockOutFlow.Location = new System.Drawing.Point(240, 20);
                ClockOutFlow.Size = new System.Drawing.Size(200, 350);
                ClockOutFlow.TabIndex = 0;
                ClockOutFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
                ClockOutFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                ClockOutFlow.AutoSize = true;
                Label Title2 = new Label();
                Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Title2.Text = "Clock Out Time";
                Title2.Size = new System.Drawing.Size(200, 25);
                ClockOutFlow.Controls.Add(Title2);

                //make a group box for employee
                GroupBox employee = new GroupBox();
                employee.Controls.Add(ClockInFlow);
                employee.Controls.Add(ClockOutFlow);
                employee.Location = new System.Drawing.Point(12 + (500*g), 12);
                employee.Size = new System.Drawing.Size(454, 450);
                employee.TabIndex = 0;
                employee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                employee.AutoSize = true;
                employee.TabStop = false;
                employee.Text = data[g].name;

                this.Controls.Add(employee);

                //go through all advisors
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Advisor " + i);
                    //show clock in times
                    for (int j = 0; j < 10; j++)
                    {
                        //make the label
                        if (data[g].finalClockInTimes[i][j].CompareTo(new Time(0, 0)) != 0)
                        {
                            Label time = new Label();
                            time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            time.Text = "Day " + (j + 1) + ": " + advisors[i] + ": " + data[g].finalClockInTimes[i][j].ToString();
                            time.Size = new System.Drawing.Size(225, 20);
                            //time.Location = new Point(6, (j + 1) * 32);
                            ClockInFlow.Controls.Add(time);
                            Console.WriteLine(j + "Day| Clock in Times: " + data[g].finalClockInTimes[i][j].ToString());
                            Label gap = new Label();
                            gap.Text = "  ";
                            gap.Size = new System.Drawing.Size(225, 10);
                            ClockInFlow.Controls.Add(gap);

                        }
                    }

                    //show clock out times
                    for (int j = 0; j < 10; j++)
                    {
                        //make the label
                        if (data[g].finalClockOutTimes[i][j].CompareTo(new Time(0, 0)) != 0)
                        {
                            Label time = new Label();
                            time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            time.Text = "Day " + (j + 1) + ": " + advisors[i] + ": " + data[g].finalClockOutTimes[i][j].ToString();
                            time.Size = new System.Drawing.Size(225, 20);
                            //time.Location = new Point(6, (j + 1) * 32);
                            ClockOutFlow.Controls.Add(time);
                            Console.WriteLine(j + "Day| Clock out Times: " + data[g].finalClockOutTimes[i][j].ToString());
                            Label gap = new Label();
                            gap.Text = "  ";
                            gap.Size = new System.Drawing.Size(225, 10);
                            ClockOutFlow.Controls.Add(gap);
                        }
                    }
                }
            }

        }

    }

}


