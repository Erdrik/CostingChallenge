// <copyright file="BasicOrderCalculator.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.Calculators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CostingChallenge.DataObjects;
    using CostingChallenge.FileIO;

    /// <summary>
    /// A basic implementation for calculating orders based off of a rate card.
    /// </summary>
    public class BasicOrderCalculator : IOrderCalculator
    {
        /// <summary>
        /// Gets the order cost for the given order using the given rate card.
        /// </summary>
        /// <param name="order">The given order.</param>
        /// <param name="rateCard">The given rate card.</param>
        /// <returns>The order cost.</returns>
        public int OrderCostAccordingToRateCard(IOrder order, IRateCard rateCard)
        {
            throw new NotImplementedException();
        }
    }
}
