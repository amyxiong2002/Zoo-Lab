using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent an animal.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Animal
    {
        /// <summary>
        /// The age of the animal.
        /// </summary>
        public int Age;

        /// <summary>
        /// The gender the animal.
        /// </summary>
        public string Gender;

        /// <summary>
        /// The happiness level the animal.
        /// </summary>
        public int HappinessLevel;

        /// <summary>
        /// The name of the animal.
        /// </summary>
        public string Name;

        /// <summary>
        /// The type of the animal.
        /// </summary>
        public string Type;

        /// <summary>
        /// The weight of the animal (in pounds).
        /// </summary>
        public double Weight;

        /// <summary>
        /// A reference to the (unborn) baby animal.
        /// Always null for male animals. Null for mother animals that are not pregnant.
        /// </summary>
        public Animal Baby;

        /// <summary>
        /// Makes the animal pregnant.
        /// </summary>
        public void MakePregnant()
        {
            if (this.Gender == "Female" && !this.GetIsPregnant())
            {
                this.Baby = new Animal();

                this.Baby.Age = 0;
                this.Baby.Gender = "Male";
                this.Baby.Name = string.Empty;
                this.Baby.Type = this.Type;
            }

            this.Baby.Weight = this.Weight * 0.1;
        }

        /// <summary>
        /// Has the animal eat.
        /// </summary>
        /// <param name="food"> Determines type of food. </param>
        public void Eat(Food food)
          {
            double weightGain = food.Weight * 0.8;
            this.Weight += weightGain;

            if (this.Baby != null)
            {
                double babyWeightGain = food.Weight * 0.1;

                // Give some of the food to the animal's baby.
                this.Baby.Weight = this.Baby.Weight + babyWeightGain;
            }

            if (this.Type == "Dingo")
            {
                this.Bark();
            }
            else if (this.Type == "Platypus")
            {
                this.StashInPouch(food);
            }
        }

        /// <summary>
        /// Has the animal bark.
        /// </summary>
        public void Bark()
        {
            this.HappinessLevel = this.HappinessLevel + 2;
        }

        /// <summary>
        /// Has the animal stash food in their pouch.
        /// </summary>
        /// <param name="food"> Type of food stored. </param>
        public void StashInPouch(Food food)
        {
            this.HappinessLevel = this.HappinessLevel + 1;
        }

        /// <summary>
        /// Returns the maximum portion size the animal can eat.
        /// </summary>
        /// <returns> Return type is double. </returns>
        public double GetPortionSize()
        {
            return this.Weight * 0.02;
        }

        /// <summary>
        /// Gets the pregnant status from the animal.
        /// </summary>
        /// <returns> Return type is bool. </returns>
        public bool GetIsPregnant()
        {
            return this.Baby != null;
        }

        /// <summary>
        /// Feeds the new born.
        /// </summary>
        /// <param name="newborn"> The baby of the featured animal. </param>
        public void FeedNewborn(Animal newborn)
        {
            this.Weight -= newborn.Nurse(this);
        }

        /// <summary>
        /// Has the animal move.
        /// </summary>
        public void Move()
        {
            double weightLossAmount = this.Weight * 0.01;

            this.Weight = this.Weight - weightLossAmount;
        }

        /// <summary>
        /// Has the anima nurse the baby.
        /// </summary>
        /// <returns> The return type for Nurse is double. </returns>
        /// <param name="mother"> The mother is the feature animal. </param>
        public double Nurse(Animal mother)
        {
            double milkWeight = mother.Weight * 0.005;

            Food milk = new Food();

            milk.Weight = milkWeight;

            this.Eat(milk);

            return milkWeight;
        }

        /// <summary>
        /// Has the animal reproduce.
        /// </summary>
        /// <returns> The return type is Animal. </returns>
        public Animal Reproduce()
        {
            Animal baby = this.Baby;
            this.Baby = null;

            double weightLossAmount = baby.Weight * 1.1;

            this.Weight = this.Weight - weightLossAmount;

            this.Move();

            baby.Move();

            if (this.Type != "Platypus")
            {
                this.FeedNewborn(baby);
            }

            return baby;
        }
    }
}
