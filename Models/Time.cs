using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject.Models
{
    public class Time
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public Time()
        {
            hours = 12;
            minutes = 00;
        }
        public Time(int h, int m)
        {
                hours = h;
                minutes = m;
        }
        public void SetTime(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public void SetTime(Time newTime)
        {
            hours = newTime.hours;
            minutes = newTime.minutes;
        }
        public void RemoveHours(Time newTime)
        {
            hours -= newTime.hours;
            minutes -= newTime.minutes;
            if (minutes < 0)
            {
                hours--;
                minutes += 60;
            }
        }
        public void AddHours(Time newTime)
        {
            hours += newTime.hours;
            minutes += newTime.minutes;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            
        }
        public Time CombineTime(Time newTime)
        {
            int hour = hours + newTime.hours;
            int minute = minutes + newTime.minutes;
            if (minute >= 60)
            {
                hour++;
                minute -= 60;
            }
            return new Time(hour, minute);
        }
        public Time PercentTime(int percent)
        {
            decimal hour = this.hours + ((decimal)this.minutes / 60);
            decimal finalHours = hour * ((decimal)percent / 100);
            //truncate to get hours
            int resultH = (int)finalHours;
            //get decimal remainder and multiply by 60 and round
            int resultM = Convert.ToInt32((finalHours - (decimal)resultH) * 60);
            //return the new time
            return new Time(resultH, resultM);
        }

        public int CompareTo(Time time)
        {
            //if times are the same, return 0
            if (time.hours == this.hours && time.minutes == this.minutes)
                return 0;
            //if hours are the same but minutes is greater
            else if (this.hours == time.hours && this.minutes > time.minutes)
                return 1;
            //if hours are greater
            else if (this.hours > time.hours)
                return 1;
            //if hours are the same but minutes is less
            else if (this.hours == time.hours && this.minutes < time.minutes)
                return -1;
            //if hours are less
            else if (this.hours < time.hours)
                return -1;
            else
                return 0;
        }
        public String TestString()
        {
            return "Hours: " + hours + " Minutes: " + minutes;
        }
        public String ToString()
        {
            String final = "";
            String pm = "AM";
            int math = hours-12;
            if (hours > 12)
            {
                if (hours < 21)
                {
                    final += "0"+ math;
                    pm = "PM";
                }
                else
                {
                    final += math;
                    pm = "PM";
                }
            }
            else
            {
                if (hours < 10)
                {
                    final += "0" +  hours;
                }
                else if(hours == 12)
                {
                    final += "12";
                    pm = "PM";
                }
                else
                {
                    final += hours;
                }
            }
            if (minutes < 10)
            {
                final += ":0" + minutes + " " + pm;
            }
            else
            {
                final += ":" + minutes + " " + pm;
            }

            return final;

        }
    }
}
