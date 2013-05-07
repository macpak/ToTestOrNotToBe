using System;

namespace ToTestOrNotToBe.Tasks.Task1
{
    public class OpenDayStatusChecker
    {
        public bool IsOpen()
        {
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            var endHour = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);

            return DateTime.Now >= startDate && DateTime.Now <= endHour;
        }
    }
}