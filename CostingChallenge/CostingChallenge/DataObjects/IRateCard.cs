// <copyright file="IRateCard.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.DataObjects
{
    using System.Collections.Generic;

    /// <summary>
    /// A rate card for determining the costs of orders.
    /// </summary>
    public interface IRateCard
    {
        /// <summary>
        /// Adds a new item to the rate card.
        /// </summary>
        /// <param name="itemName">The name of the item.</param>
        /// <param name="cost">The cost of the item in this rate card.</param>
        void AddItem(string itemName, int cost);

        /// <summary>
        /// Gets the cost of a given item in the rate card.
        /// </summary>
        /// <param name="itemName">The name of the item.</param>
        /// <returns>The cost of the item.</returns>
        int GetItemCost(string itemName);
    }
}
