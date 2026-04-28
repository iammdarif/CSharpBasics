using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public enum LogLevel
    { 
        Basic,
        Verbose
    }
    public static class Logger
    {
        private static readonly string LogPath = AppDomain.CurrentDomain.BaseDirectory;

        private static StreamWriter logFile = null;
        public static void Log(string message)
        {

            try
            {
                FileInfo fi = new FileInfo("BasicCalculatorLog.txt");
                fi.IsReadOnly = false;

                logFile = new StreamWriter(Path.Combine(LogPath, "BasicCalculatorLog.txt"), append: true);

                logFile.WriteLine($"[{DateTime.Now.ToString()}] : {message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("warning: " + ex.Message);
                Console.ResetColor();
            }
            finally
            {
                logFile?.Close();
            }

        }

        public static void Log(Exception ex, LogLevel logLevel)
        {
            try
            {
                logFile = new StreamWriter(Path.Combine(LogPath, "BasicCalculatorLog.txt"), append: true);

                if (logLevel == LogLevel.Basic)
                {

                    logFile.WriteLine($"[{DateTime.Now.ToString()}] Type: {ex.GetType()} Message: {ex.Message}");
                }
                else if (logLevel == LogLevel.Verbose)
                {
                    logFile.WriteLine($"[{DateTime.Now.ToString()}] Type: {ex.GetType()} Message: {ex.Message} Trace: {ex.StackTrace}");
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("warning:: " + e.Message);
                Console.ResetColor();
            }
            finally
            { 
                logFile?.Close();
            }
            


        }
    }
}
