namespace AccessControlApp.Services
{
    internal sealed class UserActivityLogger
    {
        private static readonly UserActivityLogger instance = new UserActivityLogger();

        private readonly string logFilePath;

        private UserActivityLogger()
        {
            // Specify the path for the log file
            logFilePath = "./Logs/us_book.txt";
        }

        public static UserActivityLogger Instance
        {
            get { return instance; }
        }

        public void LogActivity(string username, string activity)
        {
            try
            {
                string logMessage = $"{DateTime.Now} - User: {username}, Activity: {activity}";

                // Append the log message to the log file
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging activity: {ex.Message}");
            }
        }
    }
}
