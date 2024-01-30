namespace SF2022User_NN_Lib
{
    static public  class Calculations
    {
        static public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            TimeSpan currentTime = beginWorkingTime;
            List<string> freeTime = new List<string>();
            int position = 0;
            int maxPosition = startTimes.Length;

            try
            {
                while (currentTime < endWorkingTime)
                {
                    if (currentTime.Add(TimeSpan.FromMinutes(consultationTime)) <= startTimes[position])
                    {

                        freeTime.Add(currentTime.ToString() + "-" + currentTime.Add(TimeSpan.FromMinutes(consultationTime)).ToString());
                        currentTime = currentTime.Add(TimeSpan.FromMinutes(consultationTime));
                    }
                    else
                    {
                        currentTime = startTimes[position].Add(TimeSpan.FromMinutes(durations[position]));
                        position++;
                    }
                }
            }
            catch (Exception ex)
            {
                while (currentTime < endWorkingTime)
                {
                    freeTime.Add(currentTime.ToString() + "-" + currentTime.Add(TimeSpan.FromMinutes(consultationTime)).ToString());
                    currentTime = currentTime.Add(TimeSpan.FromMinutes(consultationTime));

                }
            }

            return freeTime.ToArray();

        }

    }
}
