using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteDigitalAwaysDay
{
  public  interface IActivityTrackerWriter
    {
        DateTime DayStartTime
        {
            get;
        }
        void WriterAllActivities(List<ActivityTracker> activities);
    }
}
