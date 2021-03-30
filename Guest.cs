using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// Guest at the zoo.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Guest
    {
        /// <summary>
        /// The age of the guest.
        /// </summary>
        public int Age;

        /// <summary>
        /// The name of the guest.
        /// </summary>
        public string Name;

        /// <summary>
        /// The guest's purse.
        /// </summary>
        public Wallet Wallet;

        /// <summary>
        /// Gets the money balance.
        /// </summary>
        /// <returns> The return type is decimal.</returns>
        public decimal GetMoneyBalance()
        {
            return this.Wallet.MoneyBalance;
        }

        /// <summary>
        /// Removes money from the wallet.
        /// </summary>
        /// <param name="amount"> the amount taken from the wallet. </param>
        /// <returns> The return is decimal. </returns>
        public decimal RemoveMoney(decimal amount)
        {
            decimal amountRemoved = this.Wallet.RemoveMoney(amount);

            return amountRemoved;

            this.Wallet.RemoveMoney(amount);
            this.GetMoneyBalance();
        }

        /// <summary>
        /// FeedAnimal method that feeds the animal food.
        /// </summary>
        /// <param name="animal"> Determines what animal is being fed. </param>
        /// <param name="animalSnackMachine"> Determines what food is fed to the animal.</param>
        public void FeedAnimal(Animal animal, VendingMachine animalSnackMachine)
        {
            double maxFoodWeight = animal.GetPortionSize();

            decimal foodCost = animalSnackMachine.DetermineFoodCost(maxFoodWeight);

            decimal foodPayment = this.RemoveMoney(foodCost);

            Food food = animalSnackMachine.SellFood(foodCost);

            if (this.GetMoneyBalance() >= foodCost)
            {
                this.RemoveMoney(foodCost);
                animalSnackMachine.SellFood(foodPayment);
                animal.Eat(food);
            }
        }
    }
}
