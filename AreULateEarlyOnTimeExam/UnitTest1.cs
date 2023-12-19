using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskExam.Controllers;
using TaskExam.Models;
using TaskExam.Views;

namespace AreULateEarlyOnTimeExam
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsExamHourBiggerThanHourOfArrival()
        {
            var exam = new Exam
            {
                HourOfExam = 13,
                MinuteOfExam = 20,
                HourOfArrival = 12,
                MinuteOfArrival = 30
            };
            var result = exam.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result, "\nEarly\n50 minutes before the start\n", "Dont work IsExamHourBiggerThanHourOfArrival exam");
            var exam2 = new Exam
            {
                HourOfExam = 11,
                MinuteOfExam = 30,
                HourOfArrival = 10,
                MinuteOfArrival = 55
            };
            var result2 = exam2.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result2, "\nEarly\n35 minutes before the start\n", "Dont work IsExamHourBiggerThanHourOfArrival exam2");
            var exam3 = new Exam
            {
                HourOfExam = 16,
                MinuteOfExam = 00,
                HourOfArrival = 15,
                MinuteOfArrival = 00
            };
            var result3 = exam3.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result3, "\nEarly\n1:0 hours before the start\n", "Dont work IsExamHourBiggerThanHourOfArrival exam3");
            var exam4 = new Exam
            {
                HourOfExam = 11,
                MinuteOfExam = 30,
                HourOfArrival = 10,
                MinuteOfArrival = 55
            };
            var result4 = exam4.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result4, "\nEarly\n35 minutes before the start\n", "Dont work IsExamHourBiggerThanHourOfArrival exam4");

        }
        [TestMethod]
        public void IsHourOfArrivalBiggerThanHourOfExam()
        {
            var exam = new Exam
            {
                HourOfExam = 10,
                MinuteOfExam = 20,
                HourOfArrival = 12,
                MinuteOfArrival = 30
            };
            var result = exam.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result, "\nLate\n2:10 hours after the start\n", "Dont work IsHourOfArrivalBiggerThanHourOfExam exam");
            var exam2 = new Exam
            {
                HourOfExam = 9,
                MinuteOfExam = 30,
                HourOfArrival = 9,
                MinuteOfArrival = 50
            };
            var result2 = exam2.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result2, "\nLate\n20 minutes after the start\n", "Dont work IsHourOfArrivalBiggerThanHourOfExam exam2");
            var exam3 = new Exam
            {
                HourOfExam = 9,
                MinuteOfExam = 00,
                HourOfArrival = 10,
                MinuteOfArrival = 30
            };
            var result3 = exam3.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result3, "\nLate\n1:30 hours after the start\n", "Dont work IsHourOfArrivalBiggerThanHourOfExam exam3");
            var exam4 = new Exam
            {
                HourOfExam = 11,
                MinuteOfExam = 30,
                HourOfArrival = 12,
                MinuteOfArrival = 29
            };
            var result4 = exam4.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result4, "\nLate\n59 minutes after the start\n", "Dont work IsHourOfArrivalBiggerThanHourOfExam exam4");
        }
        [TestMethod]
        public void AreYouONTime()
        {
            var exam = new Exam
            {
                HourOfExam = 15,
                MinuteOfExam = 00,
                HourOfArrival = 15,
                MinuteOfArrival = 00
            };
            var result = exam.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result, "\nOn time\n", "Dont work AreYouONTime exam");
            var exam2 = new Exam
            {
                HourOfExam = 9,
                MinuteOfExam = 00,
                HourOfArrival = 8,
                MinuteOfArrival = 30
            };
            var result2 = exam2.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result2, "\nOn time\n30 minutes before the start\n", "Dont work AreYouONTime exam2");
            var exam3 = new Exam
            {
                HourOfExam = 14,
                MinuteOfExam = 00,
                HourOfArrival = 13,
                MinuteOfArrival = 55
            };
            var result3 = exam3.AreYouOnTimeLateOrEarly();
            Assert.AreEqual(result3, "\nOn time\n5 minutes before the start\n", "Dont work AreYouONTime exam3");
        }

    }
}
