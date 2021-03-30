using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// Wallet of the guest.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Wallet
    {
        /// <summary>
        /// The amount of money currently contained within the wallet.
        /// </summary>
        public decimal MoneyBalance;

        /// <summary>
        /// Removes a specified amount of money from the wallet.
        /// </summary>
        /// <param name="amount"> The amount taken from the wallet. </param>
        /// <returns> Return type is decimal. </returns>
        public decimal RemoveMoney(decimal amount)
        {
            decimal amountRemoved;

            if (amount > 0.00m)
            {
                if (this.MoneyBalance >= amount)
                {
                    amountRemoved = amount;
                }
                else
                {
                    amountRemoved = this.MoneyBalance;
                }
            }
            else
            {
                amountRemoved = 0.00m;
            }

            this.MoneyBalance = this.MoneyBalance - amountRemoved;

            return amountRemoved;
        }
    }
}
