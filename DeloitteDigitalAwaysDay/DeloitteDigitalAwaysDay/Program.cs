using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteDigitalAwaysDay
{
    class Program 
    {
        static void Main(string[] args)
        {
            string FileNameWithPath = "d:\\TempFolder\\Temp.txt";
            Logic logic = new Logic(new ActivityTrackerReader(), new ActivityTrackerWriter(),FileNameWithPath);
            logic.ReadAndWrite();
        }
    }
}
