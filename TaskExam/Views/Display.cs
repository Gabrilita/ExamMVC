using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExam.Views
{
    public class Display
    {
        public int HourOfExam { get; set; }
        public int MinuteOfExam { get; set; }
        public int HourOfArrival { get; set; }
        public string OutputNotice { get; set; }
        public int MinuteOfArrival { get; set; }

        public void Input()
        {
            Console.Write("Enter hour start of exam: ");
            HourOfExam = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes start of exam: ");
            MinuteOfExam = int.Parse(Console.ReadLine());
            Console.Write("Enter hour of arrival: ");
            HourOfArrival = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes of arrival: ");
            MinuteOfArrival = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(OutputNotice);
        }
    }
}
