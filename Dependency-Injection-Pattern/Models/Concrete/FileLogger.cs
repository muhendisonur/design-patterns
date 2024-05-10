
namespace Dependency_Injection_Pattern.Models
{
    public class FileLogger : ILog
    {
        public string Log()
        {
            return "FileLogger is logged succesfully.\n";
        }
    }
}