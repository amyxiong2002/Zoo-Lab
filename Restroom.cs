using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a restroom.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Restroom
    {
        /// <summary>
        /// The maximum number of people allowed in the restroom at a given time.
        /// </summary>
        public int Capacity;

        /// <summary>
        /// The gender of the restroom.
        /// </summary>
        public string Gender;
    }
}
