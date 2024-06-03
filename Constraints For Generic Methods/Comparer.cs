using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints_For_Generic_Methods
{
    internal class Comparer
    {
        public static bool AreEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }
    }
}
