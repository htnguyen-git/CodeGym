using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_LopVaDoiTuongCSharp
{
    class StopWatch
    {
        private DateTime startTime, endTime;
        public StopWatch()
        {
            startTime = DateTime.Now;
        }
        public void ShowTime()
        {
            Console.WriteLine(startTime);
        }
        public void StartTime()
        {
            startTime = DateTime.Now;
        }
        public void EndTime()
        {
            endTime = DateTime.Now;
        }
        public void GetElapsedTime()
        {
            TimeSpan intervalTime = endTime.Subtract(startTime);
            Console.WriteLine($"interval from start to end {intervalTime}");
        }
    }
}
