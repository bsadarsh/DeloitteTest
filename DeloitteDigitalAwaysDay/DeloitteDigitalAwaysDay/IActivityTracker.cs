using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteDigitalAwaysDay
{
public interface IActivityTracker
    {
        string LineText { get; set; }
        string Name { get;}
        string LastPart { get;  }
        bool IsSprint { get;  }
        int Duration { get;  }
         bool IsBreakOverLapping { get;  }
         DateTime StartTime { get;  }
         DateTime EndTime { get;  }
         DateTime InitialSeed { get; set; }
         DateTime WriteToString(DateTime initialTime);
        
    }
}
