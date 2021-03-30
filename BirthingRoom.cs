using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a birthing room.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class BirthingRoom
    {
        /// <summary>
        /// The current temperature of the birthing room. Tempurature Field of the BirthingRoom Class.
        /// </summary>
        public double Temperature;

        /// <summary>
        /// The mother animal which is to give birth. Mother Field of the BirthingRoom Class.
        /// </summary>
        public Employee Doctor;

        /// <summary>
        /// Has the mother give birth.
        /// </summary>
        /// <param name="mother"> The creature is the mother. </param>
        /// <returns> The return is Animal. </returns>
        public Animal BirthAnimal(Animal mother)
        {
            Animal baby = null;

            if ((mother != null) && (mother.GetIsPregnant()))
            {
              this.Doctor.DeliverAnimal(mother);
              this.Temperature = this.Temperature + 0.5;
            }

            baby = this.Doctor.DeliverAnimal(baby);

            return baby;
        }
    }
}
