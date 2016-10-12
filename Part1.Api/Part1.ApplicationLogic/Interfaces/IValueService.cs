using System.Collections.Generic;

namespace Part1.ApplicationLogic.Interfaces
{
    public interface IValueService
    {
        IEnumerable<string> GetValues();

        int GetValue(string id);

        string AddValue(int value);
    }
}