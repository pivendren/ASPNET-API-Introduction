using Part1.ApplicationLogic.Interfaces;
using System.Collections.Generic;

namespace Part1.ApplicationLogic.Services
{
    public class ValueService : IValueService
    {
        public IEnumerable<string> GetValues()
        {
            return new string[] { "value1", "value2" };
        }

        public string GetValue(int id)
        {
            return "value";
        }
    }
}