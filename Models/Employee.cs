using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject.Models
{
    public class Employee
    {
        //passed in constructor
        public string name { get; set; }
        //The total hours worked by each employee
        private List<Time> unpaidHoursWorked = new List<Time>();
        //Time clocked in by employee for each day
        private List<Time> clockInTime = new List<Time>();
        //percent of the hours worked in a day owed by each advisor
        private List<int> advisorPercents = new List<int>();
        //The hours owed to the employee by each advisor
        private List<Time> hoursOwed = new List<Time>();
        //One to Four minutes have the possiblity to be unpayable, this i will print out on the calculation screen for each employee
        private int unpayableMinutes = 0;
        //final answers
        public List<List<Time>> finalClockInTimes = new List<List<Time>>();
        public List<List<Time>> finalClockOutTimes = new List<List<Time>>();

        //constructor to set all base variables
        public Employee(string NAME, List<Time> HOURSWORKED, List<Time> CLOCKIN, List<int> PERCENTS)
        {
            Console.WriteLine("Making new Employee Object");
            this.name = NAME;
            foreach(Time hours in HOURSWORKED)
            {
                unpaidHoursWorked.Add(hours);
                Console.WriteLine("unpaid hours worked "+ hours.TestString());
            }
            foreach (Time time in CLOCKIN)
            {
                clockInTime.Add(time);
                Console.WriteLine("clockin Time " + time.TestString());

            }
            foreach (int percent in PERCENTS)
            {
                advisorPercents.Add(percent);
                Console.WriteLine("percentage " +percent);

            }
            this.HoursOwedPerAdvior();

        }

        public void CalculateData()
        {
            Console.WriteLine("Entering CalculateData");
            //for each advisor

            for (int advisor = 0; advisor < 4; advisor++)
            {
                List<Time> clockInTemp = new List<Time>();
                List<Time> clockOutTemp = new List<Time>();
                Console.WriteLine("===================");
                Console.WriteLine("Advisor number " + advisor);
                //cycle through the 10 day period
                for (int day = 0; day < 10; day++)
                {
                    Console.WriteLine("------------");
                    Console.WriteLine("Day Number " + day);
                    Console.WriteLine("hours owed: " + hoursOwed[advisor].TestString());
                    Console.WriteLine("unpaid work hours: " + unpaidHoursWorked[day].TestString());
                    //if there are no hours owed, skip
                    if (hoursOwed[advisor].CompareTo(new Time(0, 0)) > 0)
                    {
                        Console.WriteLine("Entering hours owed > 0 if statment");
                        //if the ammount owed by the advisor is greater than the amount of hours for the employee for the day
                        //also makes sure day has not been paid for by another advisor
                        if (hoursOwed[advisor].CompareTo(unpaidHoursWorked[day]) >= 0 && unpaidHoursWorked[day].CompareTo(new Time(0, 0)) > 0)
                        {
                            Console.WriteLine("Entering hours owed > unpaid hours abd unpaid hours > 0 If");
                            //set clockin time to normal clock in time for the day
                            clockInTemp.Add(clockInTime[day]);
                            //set the clockout time to the clockin time plus the amoutn of hours worked for the day
                            //does not change clockin time
                            clockOutTemp.Add(clockInTime[day].CombineTime(unpaidHoursWorked[day]));
                            
                            //decrease the hours owed for the day by the hours worked for the day
                            hoursOwed[advisor].RemoveHours(unpaidHoursWorked[day]);
                            //signal that this whole day is paid for by nulling out the unpaid hours
                            unpaidHoursWorked[day] = new Time(0, 0);
                            Console.WriteLine("ClockInTemp: " + clockInTemp[day].TestString());
                            Console.WriteLine("ClockOutTemp: " + clockOutTemp[day].TestString());
                            Console.WriteLine("Exit If");

                        }
                        //if the amount owed by the advisor is less than the the total days hours
                        else if(unpaidHoursWorked[day].CompareTo(new Time(0, 0)) > 0)
                        {
                            Console.WriteLine("Entering  hours owed < unpaid hours and unpaid hours > 0 Else");
                            //set clock in time
                            Time temp = new Time(clockInTime[day].hours, clockInTime[day].minutes);
                            clockInTemp.Add(temp);
                            //set clock out time to remaining hours worked for advisor
                            clockOutTemp.Add(clockInTime[day].CombineTime(hoursOwed[advisor]));
                            //because this is less than unpaidHoursWorked we need to set the new clock in time for the clock out time
                            clockInTime[day].SetTime(clockInTime[day].CombineTime(hoursOwed[advisor]));
                            //decrease unpaid work hours for this day by amount paid by advisor
                            unpaidHoursWorked[day].RemoveHours(hoursOwed[advisor]);
                            //set the hours owed for the advisor to zero
                            hoursOwed[advisor].SetTime(0, 0);
                            Console.WriteLine("ClockInTemp: " + clockInTemp[day].TestString());
                            Console.WriteLine("ClockOutTemp: " + clockOutTemp[day].TestString());
                            Console.WriteLine("Exit else");

                        }
                        else
                        {
                            Console.WriteLine("Entering hours owed < 0 else statment");
                            //if we skip the day, we still need to set clock in times and out times 
                            //these are set to zero to show we skipped the day
                            clockInTemp.Add(new Time(0, 0));
                            clockOutTemp.Add(new Time(0, 0));
                            Console.WriteLine("ClockInTemp: " + clockInTemp[day].TestString());
                            Console.WriteLine("ClockOutTemp: " + clockOutTemp[day].TestString());
                        }

                        Console.WriteLine("Exit If");
                        Console.WriteLine("hours owed: " + hoursOwed[advisor].TestString());
                        Console.WriteLine("unpaid work hours: " + unpaidHoursWorked[day].TestString());
                    }
                    else
                    {
                        Console.WriteLine("Entering hours owed < 0 else statment");
                        //if we skip the day, we still need to set clock in times and out times 
                        //these are set to zero to show we skipped the day
                        clockInTemp.Add(new Time(0,0));
                        clockOutTemp.Add(new Time(0, 0));
                        Console.WriteLine("ClockInTemp: " + clockInTemp[day].TestString());
                        Console.WriteLine("ClockOutTemp: " + clockOutTemp[day].TestString());
                    }

                }
                finalClockInTimes.Add(clockInTemp);
                finalClockOutTimes.Add(clockOutTemp);
            }
            Console.WriteLine("Exiting Calculate Data");
        }



        //used in constructors
        private Time TotalHoursWorked()
        {
            Console.WriteLine("Entering TotalHoursWorked");

           Time result = new Time(0,0);
            foreach(Time num in unpaidHoursWorked)
            {
                result.AddHours(num);
            }
            Console.WriteLine("Exiting TotalHoursWorked with " + result.TestString());
            return result;
        }
        //sets the hours owed to the employee for each advisor
        private void HoursOwedPerAdvior()
        {
            Console.WriteLine("Entering HoursOwedPerAdvisor");
            Time totalHours = new Time(this.TotalHoursWorked().hours, this.TotalHoursWorked().minutes);
            //go through each advisors owed percentage
            int debug = 0;
            foreach (int percent in advisorPercents)
            {
                this.hoursOwed.Add(totalHours.PercentTime(percent));
                Console.WriteLine("Advisor " + debug + " owes " + hoursOwed[debug].TestString());
                debug++;
            }
            Console.WriteLine("Exiting HoursOwedPerAdvisor");
        }
    }
}
