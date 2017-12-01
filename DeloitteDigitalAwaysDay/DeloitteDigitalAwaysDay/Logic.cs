using System;

namespace DeloitteDigitalAwaysDay
{

    /// <summary>
    /// Logic Start Here for Reading for File
    /// </summary>
    public class Logic
    {
        private IActivityTrackerReader _activityTrackerReader;
        private IActivityTrackerWriter _activityTrackerWriter;
        private string FileName;
        
        public Logic(IActivityTrackerReader activityTrackerReader,IActivityTrackerWriter activityTrackerWriter, string fileName)
        {
            this._activityTrackerReader = activityTrackerReader;
            this._activityTrackerWriter = activityTrackerWriter;
            this.FileName = fileName;
        }

        public void ReadAndWrite()
        {
             _activityTrackerWriter.WriterAllActivities(_activityTrackerReader.ReadAllActivities(FileName));
            Console.ReadLine();
        }
    }
}
