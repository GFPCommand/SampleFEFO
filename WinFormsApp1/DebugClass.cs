using System.Diagnostics;

namespace Debugger
{
    static class DebugClass
    {
        public static void WriteDebugDataToFile(object? data, string path = "C:\\debug.txt")
        {
            List<string> sendData = new List<string>();

            sendData.Add(data.ToString());

            if (File.Exists(path))
                File.Create(path);
            else
                File.WriteAllLines(path, sendData);
        }

        public static bool CheckNullValue(object sender){
            if (sender == null)
            {
                return true;
            }

            return false;
        }

        public static void StackTraceLog(string path = "C:\\stack_trace.txt")
        {
            List<string> sendData = new List<string>();

            StackTrace stackTrace = new StackTrace();

            sendData.Add(stackTrace.ToString());

            if (File.Exists(path))
                File.Create(path);
            else
                File.WriteAllLines(path, sendData);
        }

        public static void WriteExceptionsToFile(object? ex, string path = "C:\\exceptions.txt")
        {
            List<string> exceptions = new List<string>();

            exceptions.Add(ex.ToString());

            if (File.Exists(path))
                File.Create(path);
            else
                File.WriteAllLines(path, exceptions);
        }
    }
}
