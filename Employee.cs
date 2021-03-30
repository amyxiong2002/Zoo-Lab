using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent an employee.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Employee
    {
        /// <summary>
        /// The name of the employee.
        /// </summary>
        public string Name;

        /// <summary>
        /// The employee's identification number.
        /// </summary>
        public int Number;

        /// <summary>
        /// Has the doctor deliver the mother's baby.
        /// </summary>
        /// <param name="mother"> The animal giving birth. </param>
        /// <returns> The return is Animal. </returns>
        public Animal DeliverAnimal(Animal mother)
        {
            Animal baby = mother.Reproduce();
            baby.Name = "Baby";

            return baby;
        }

        /// <summary>
        /// Has the employee fill the vending machine.
        /// </summary>
        /// <param name="machine"> States which machine. </param>
        public void FillVendingMachine(VendingMachine machine)
        {
            while (!machine.IsFull())
            {
                machine.AddFoodBag();
            }
        }
    }
}
