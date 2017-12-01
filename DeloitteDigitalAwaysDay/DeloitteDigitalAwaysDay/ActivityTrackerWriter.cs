using System;
using System.Collections.Generic;

namespace DeloitteDigitalAwaysDay
{

    /// <summary>
    /// Writing all the Activity 
    /// </summary>
    class ActivityTrackerWriter : IActivityTrackerWriter
    {
        public DateTime DayStartTime { get { return new DateTime(1, 1, 1, 9, 0, 0); } }

        public void WriterAllActivities(List<ActivityTracker> activities)
        {
            DateTime currentTime = DayStartTime;
            int teamCounter = 1;
            Console.WriteLine(String.Format("{0} {1} :", "Team", teamCounter));

            for (int i = 0; i < activities.Count; i++)
            {
                var activity = activities[i];
                currentTime = activity.WriteToString(currentTime);
                ActivityTracker nextActivity = null;
                if ((i + 1) < activities.Count)
                {
                    nextActivity = activities[i + 1];
                    nextActivity.InitialSeed = currentTime;
                }
                if (nextActivity == null && activity.EndTime > new DateTime(1, 1, 1, 16, 0, 0))
                {
                    Console.WriteLine(String.Format("{0} : {1}", currentTime.ToString("hh:mm tt"), "Staff Motivation Presentations"));
                }
                if (nextActivity != null && nextActivity.EndTime > new DateTime(1, 1, 1, 17, 0, 0)) //greater than 5 OClock
                {
                    teamCounter++;

                    Console.WriteLine(String.Format("{0} : {1}", currentTime.ToString("hh:mm tt"), "Staff Motivation Presentations"));
                    currentTime = DayStartTime; //new Team
                    Console.WriteLine(String.Format("{0} {1}", "Team", teamCounter));
                }
            }
        }
    }
}
