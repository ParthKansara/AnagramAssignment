using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramsAssignment.Services.Interfaces
{
    public interface IAnagramService
    {
        List<string> GetAnagrams(string input);

    }
}
