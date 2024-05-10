namespace Dependency_Injection_Pattern.Models
{
    public class TextLogger : ILog
    {
        public string Log()
        {
            return "TextLogger is logged succesfully.";
        }
    }
}