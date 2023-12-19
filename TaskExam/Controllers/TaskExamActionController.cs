using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaskExam.Models;
using TaskExam.Views;

namespace TaskExam.Controllers
{
    public class TaskExamActionController
    {
        private Exam model = new Exam();
        private Display display = new Display();

        public TaskExamActionController()
        {
            display.Input();
            model.HourOfArrival = display.HourOfArrival;
            model.MinuteOfArrival = display.MinuteOfArrival;
            model.HourOfExam = display.HourOfExam;
            model.MinuteOfExam = display.MinuteOfExam;
            display.OutputNotice = model.AreYouOnTimeLateOrEarly();
           display.Output();
        }
    }
}
