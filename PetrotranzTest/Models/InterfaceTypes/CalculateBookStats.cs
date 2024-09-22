using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.InterfaceTypes
{
    public class CalculateBookStats : ICalculateBookStats
    {
        public (int totalWords, int totalCharacters) Calculate(string bookPath)
        {
            return (0, 0);
        }
    }

}
