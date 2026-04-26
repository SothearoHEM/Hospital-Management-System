using System;

namespace Hospital_Management_System.Classes
{
    public static class GlobalEvents
    {
        public static event EventHandler DataUpdated;

        public static void OnDataUpdated()
        {
            DataUpdated?.Invoke(null, EventArgs.Empty);
        }
    }
}