using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExam.Models
{
    public class Exam
    {
        private int hourOfExam;
        private int minuteOfExam;
        private int hourOfArrival;
        private int minuteOfArrival;
        public string OutputNotice
        {
            get;
            set;
        }

        public int HourOfExam
        {
            get { return hourOfExam; }
            set
            {
                if (value < 0 || value >= 24)
                {
                    throw new ArgumentOutOfRangeException("---HOUR OF EXAM IS OUT OF RANGE---");
                }
                this.hourOfExam = value;
            }
        }
        public int MinuteOfExam
        {
            get { return minuteOfExam; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("---MINUTE OF EXAM IS OUT OF RANGE---");
                }
                this.minuteOfExam = value;
            }
        }
        public int HourOfArrival
        {
            get { return hourOfArrival; }
            set
            {
                if (value < 0 || value >= 24)
                {
                    throw new ArgumentOutOfRangeException("---HOUR OF ARRIVAL IS OUT OF RANGE---");
                }
                this.hourOfArrival = value;
            }
        }
        public int MinuteOfArrival
        {
            get { return minuteOfArrival; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("---MINUTE OF ARRIVAL IS OUT OF RANGE---");
                }
                this.minuteOfArrival = value;
            }
        }


        public string AreYouOnTimeLateOrEarly()
        {
            int hoursDifference = hourOfArrival - hourOfExam;
            int minutesDifference = minuteOfArrival - minuteOfExam;
            if (hoursDifference > 0)
            {

                if (minutesDifference < 0)
                {
                    hoursDifference = hoursDifference - 1;
                    minutesDifference = minutesDifference + 60;
                }
                if (hoursDifference <= 0)
                {
                    OutputNotice = $"\nLate\n{minutesDifference} minutes after the start\n";
                }
                else
                {
                    OutputNotice = $"\nLate\n{hoursDifference}:{minutesDifference} hours after the start\n";
                }
            }
            else
            {
                if (hoursDifference == 0)
                {
                    minutesDifference = minuteOfArrival - minuteOfExam;

                    if (minutesDifference > 0)
                    {
                        OutputNotice = $"\nLate\n{minutesDifference} minutes after the start\n";
                    }
                    else
                    if (minutesDifference >= -30 && minutesDifference < 0)
                    {
                        OutputNotice = $"\nOn Time\n{minutesDifference} minutes before the start\n";
                    }
                    else
                    {
                        OutputNotice = "\nOn time\n";
                    }
                }
                else
                {
                    hoursDifference = hourOfExam - hourOfArrival;
                    minutesDifference = minuteOfExam - minuteOfArrival;
                    if (minutesDifference < 0)
                    {
                        hoursDifference = hoursDifference - 1;
                        minutesDifference = minutesDifference + 60;
                    }                  
                    if (hoursDifference==0 &&(minutesDifference <= 30 && minutesDifference > 0))
                    {
                        OutputNotice = $"\nOn time\n{minutesDifference} minutes before the start\n";
                    }
                    else
                    if (hoursDifference<=0)
                    {
                        OutputNotice = $"\nEarly\n{minutesDifference} minutes before the start\n";

                    }
                    else
                    {
                        OutputNotice = $"\nEarly\n{hoursDifference}:{minutesDifference} hours before the start\n";
                    }
                }
            }
            return OutputNotice;
        }
    }
}
