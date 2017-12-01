using System.Collections.Generic;

namespace DeloitteDigitalAwaysDay
{
    /// <summary>
    /// 
    /// Read All Activity
    /// </summary>

    class ActivityTrackerReader : IActivityTrackerReader
    {
        public List<ActivityTracker> ReadAllActivities(string FileName)
        {
            List<ActivityTracker> activities = new List<ActivityTracker>();
            foreach (var lineItem in System.IO.File.ReadAllLines(FileName))
            {
                var activity = new ActivityTracker();
                activity.LineText = lineItem.Trim();
                activities.Add(activity);
            }
            return activities;
        }
    }
}
