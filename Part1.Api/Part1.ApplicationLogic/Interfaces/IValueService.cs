using System.Collections.Generic;

namespace Part1.ApplicationLogic.Interfaces
{
    public interface IValueService
    {
        IEnumerable<string> GetValues();

        string GetValue(int id);
    }
}