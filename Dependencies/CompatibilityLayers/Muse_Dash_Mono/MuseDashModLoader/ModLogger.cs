using System.Diagnostics;
using MonkiiLoader;

namespace ModHelper
{
    public static class ModLogger
    {
        public static void Debug(object obj)
        {
            var frame = new StackTrace().GetFrame(1);
            var className = frame.GetMethod().ReflectedType.Name;
            var methodName = frame.GetMethod().Name;
            AddLog(className, methodName, obj);
        }

        public static void AddLog(string className, string methodName, object obj)
        {
            MonkiiLogger.Msg($"[{className}:{methodName}]: {obj}");
        }
    }
}