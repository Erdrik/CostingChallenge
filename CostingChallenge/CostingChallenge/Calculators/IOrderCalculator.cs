// <copyright file="IOrderCalculator.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.DataObjects
{
    using CostingChallenge.FileIO;

    /// <summary>
    /// Calculates the costs for an order.
    /// </summary>
    public interface IOrderCalculator
    {
        /// <summary>
        /// Gets the total order's cost according to the given rate card.
        /// </summary>
        /// <param name="order">The given order.</param>
        /// <param name="rateCard">The given rate card.</param>
        /// <returns>The total order's cost.</returns>
        int OrderCostAccordingToRateCard(IOrder order, IRateCard rateCard);
    }
}
