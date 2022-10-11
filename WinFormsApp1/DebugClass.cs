using System.Diagnostics;

namespace Debugger
{
    static class DebugClass
    {
        public static void WriteDebugDataToFile(object? data, string path = "debug.txt")
        {
            if (!File.Exists(path))
                File.Create(path);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
        }

        public static bool CheckNullValue(object sender)
        {
            if (sender == null)
            {
                return true;
            }

            return false;
        }

        public static void StackTraceLog(string path = "stack_trace.txt")
        {
            StackTrace stackTrace = new StackTrace();

            if (!File.Exists(path))
                File.Create(path);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(stackTrace.ToString());
            }
        }

        public static void WriteExceptionsToFile(object? ex, string path = "exceptions.txt")
        {
            if (!File.Exists(path))
                File.Create(path);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(ex.ToString());
            }
        }
    }
}
