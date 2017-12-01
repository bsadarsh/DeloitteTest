using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteDigitalAwaysDay
{
  public interface IActivityTrackerReader
    {
       List<ActivityTracker> ReadAllActivities(string FileName);
    }
}
