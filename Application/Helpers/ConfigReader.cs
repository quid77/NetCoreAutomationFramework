using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

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
