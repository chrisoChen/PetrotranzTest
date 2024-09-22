using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Interfaces
{
    public interface ICalculateBookPages
    {
        double Calculate(int totalWords, int wordsPerPage);
    }
}
