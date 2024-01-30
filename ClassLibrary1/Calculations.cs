using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    public class Calculation
    {
        public void AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            TimeSpan currentTime = beginWorkingTime;

            List<string> freeTime = new List<string>();

            foreach (TimeSpan time in startTimes) 
            {
               if(currentTime.Add(TimeSpan.FromMinutes(consultationTime))< time)
               {
                    currentTime.Add(TimeSpan.FromMinutes(consultationTime));
                    freeTime.Add($"{currentTime:HH:mm}");
               } 
               else
            }






            
        }

/*        public class TimeInterval
        {
            public TimeSpan start { get; set; }
            public TimeSpan end { get; set; }

            public TimeInterval(TimeSpan start, int duration)
            {
                this.start = start;
                this.end = start.Add(TimeSpan.FromMinutes(duration)); 
            }
        }*/

      


    }
}
