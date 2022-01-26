using System.Configuration;

namespace NUnitTestProject.Application.Helpers
{
    public class ConfigReader
    {
        public string GetProperty(string propertyName)
        {
            return ConfigurationManager.AppSettings[propertyName];
        }
    }
}
