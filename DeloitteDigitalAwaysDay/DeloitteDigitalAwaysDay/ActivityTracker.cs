using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteDigitalAwaysDay
{
    public class ActivityTracker : IActivityTracker
    {
        public string LineText { get; set; }
        public string Name {
            get
            {
                return IsSprint ? LineText : LineText.Replace(LastPart, "");
            }
            
        }

        public int Duration
        {
            get { return IsSprint ? 15 : Int32.Parse(LastPart.ToLower().Replace("min", "")); }
        }
        public string LastPart
        {
            get
            {
                var linesSplitted = LineText.Split(new string[] { " " }, StringSplitOptions.None);
                return linesSplitted[linesSplitted.Length - 1];
            }
            
            
        }
        public bool IsSprint
        {
            get
            {
                return LineText.ToLower().Contains("sprint") ? true : false;
            }
        }
        public bool IsBreakOverLapping
        {
            get { return InitialSeed.AddMinutes(Duration) > new DateTime(1, 1, 1, 12, 0, 0) && InitialSeed.AddMinutes(Duration) < new DateTime(1, 1, 1, 13, 0, 0) ? true : false; }
            
        }
        public DateTime StartTime { get { return InitialSeed; }   }
        public DateTime EndTime { get { return StartTime.AddMinutes(Duration); }  }
        public DateTime InitialSeed { get; set; }

        public DateTime WriteToString(DateTime initialTime)
        {
            this.InitialSeed = initialTime;
            if (IsBreakOverLapping)
            {
                Console.WriteLine(String.Format("{0} : {1}", StartTime.ToString("hh:mm tt"), "Lunch Break 60min"));
                InitialSeed = InitialSeed.AddMinutes(60);
            }
            Console.WriteLine(String.Format("{0} : {1}", StartTime.ToString("hh:mm tt"), LineText));
            return EndTime;
        }
    }
}
