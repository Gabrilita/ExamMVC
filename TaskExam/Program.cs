using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskExam.Controllers;

namespace TaskExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TaskExamActionController exam = new TaskExamActionController();

            }
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("ARGUMENT ECXEPTION");
            //}
            catch (FormatException)
            {

                Console.WriteLine("WRONG FORMAT");
            }
        }
    }
}
