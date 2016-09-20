using System;

namespace _07_Timer
{
    internal class Timer
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;
        public int Seconds
        {
            get { return seconds; }
             set { seconds = value; }
        }
        public override string ToString()
        {
            minutes = seconds / 60;
            seconds = seconds - (minutes * 60);
            hours = minutes / 60;
            minutes = minutes - (hours * 60);
            string result = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            return result;
        }

        internal string Padded(int v)
        {
            
            string res = string.Format("{0:00}",v);
            return res;
        }
    }
}