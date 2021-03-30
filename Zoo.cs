using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a zoo.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Zoo
    {
        /// <summary>
        /// The maximum number of guests the zoo can accommodate at a given time.
        /// </summary>
        public int Capacity;

        /// <summary>
        /// The zoo's featured animal.
        /// </summary>
        public Animal FeaturedAnimal;

        /// <summary>
        /// The zoo's ladies' restroom.
        /// </summary>
        public Restroom LadiesRoom;

        /// <summary>
        /// The zoo's men's restroom.
        /// </summary>
        public Restroom MensRoom;

        /// <summary>
        /// The name of the zoo.
        /// </summary>
        public string Name;

        /// <summary>
        /// The zoo's ticket booth.
        /// </summary>
        public Booth TicketBooth;

        /// <summary>
        /// The zoo's room for birthing animals.
        /// </summary>
        public BirthingRoom BirthArea;

        /// <summary>
        /// The zoo's vending machine which allows guests to buy snacks for animals.
        /// </summary>
        public VendingMachine AnimalSnackMachine;

        /// <summary>
        /// The zoo's current visitor.
        /// </summary>
        public Guest Visitor;

        /// <summary>
        /// Births the animal.
        /// </summary>
        /// <returns> Animal is the return type. </returns>
        public Animal BirthAnimal()
        {
            if (this.FeaturedAnimal.GetIsPregnant() == true)
            {
                this.BirthArea.BirthAnimal(this.FeaturedAnimal);
            }

            Animal baby = this.BirthAnimal();

            if (baby != null)
            {
                baby = this.FeaturedAnimal;
            }

            return baby;
        }
    }
}
