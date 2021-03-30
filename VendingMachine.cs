using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// Names the VendingMachine class.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class VendingMachine
    {
        /// <summary>
        /// The price of food (per pound).
        /// </summary>
        public decimal FoodPricePerPound;

        /// <summary>
        /// The amount of food currently in stock (in pounds).
        /// </summary>
        public double FoodStock;

        /// <summary>
        /// The amount of money currently in the vending machine.
        /// </summary>
        public decimal MoneyBalance;

        /// <summary>
        /// Adds money to vending machine money balance.
        /// </summary>
        /// <param name="amount"> The amount of money added. </param>
        public void AddMoney(decimal amount)
        {
            this.MoneyBalance += amount;
        }

        /// <summary>
        /// Sells the food to visitors.
        /// </summary>
        /// <param name="payment"> Payment for the food sold. </param>
        /// <returns> Return type is Food. </returns>
        public Food SellFood(decimal payment)
        {
            double foodWeight;

            this.AddMoney(payment);

            foodWeight = (double)(payment * this.FoodPricePerPound);

            this.FoodStock = Math.Round(this.FoodStock - foodWeight, 2);

            Food food = new Food();

            food.Weight = foodWeight;

            return food;
        }

        /// <summary>
        /// Determines the food Cost.
        /// </summary>
        /// <param name="maxFoodWeight"> Max food weight. </param>
        /// <returns> Return type is decimal. </returns>
        public decimal DetermineFoodCost(double maxFoodWeight)
        {
            decimal maxFoodCost = (decimal)maxFoodWeight * this.FoodPricePerPound;

            // Round the food cost to the nearest hundredth.
            decimal foodCost = Math.Round(maxFoodCost, 2);

            return foodCost;
        }

        /// <summary>
        /// Adds a food bag into the vending machine.
        /// </summary>
        public void AddFoodBag()
        {
            this.FoodStock = Math.Min(this.FoodStock + 65.0, 250.0);
        }

        /// <summary>
        /// Tells whether the vending machine is full or not.
        /// </summary>
        /// <returns> Return type is bool. </returns>
        public bool IsFull()
        {
            if (this.FoodStock >= 250)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
