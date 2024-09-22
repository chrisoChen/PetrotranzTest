using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.InterfaceTypes
{
    public class CalculateBookPages : ICalculateBookPages
    {
        /// <inheritdoc/>
        public double Calculate(int totalWords, int wordsPerPage)
        {
            return Math.Ceiling((double)totalWords / wordsPerPage);
        }
    }
}
