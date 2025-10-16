using System;
using System.IO;

namespace MindfulnessApp
{
    // Base class representing shared properties and behaviors for all activities
    public abstract class Activity
    {
        private string _name;
        private string _description;
        private int _durationSeconds;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name => _name;
        public string Description => _description;

        public int DurationSeconds
        {
            get => _durationSeconds;
            set => _durationSeconds = Math.Max(1, value); // never less than 1 second
        }

        /// <summary>
        /// Logs the completion of an activity by a user.
        /// </summary>
        /// <param name="username">The current logged-in user's name.</param>
        protected void LogSession(string username)
        {
            try
            {
                string file = "activity_log.txt";
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string line = $"{username}|{_name}|{_durationSeconds}|{timestamp}";
                File.AppendAllText(file, line + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Optional: You can show an error if logging fails
                Console.WriteLine($"Error logging session: {ex.Message}");
            }
        }

        /// <summary>
        /// Called when the activity completes successfully.
        /// Logs automatically when provided with a username.
        /// </summary>
        public void CompleteAndLog(string username)
        {
            LogSession(username);
        }
    }
}
