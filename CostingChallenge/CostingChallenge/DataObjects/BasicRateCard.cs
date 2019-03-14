// <copyright file="BasicRateCard.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.DataObjects
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation of a basic RateCard.
    /// </summary>
    public class BasicRateCard : IRateCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicRateCard"/> class.
        /// </summary>
        public BasicRateCard()
        {
            this.Items = new Dictionary<string, int>();
        }

        /// <summary>
        /// Gets or sets the items and their costs.
        /// </summary>
        private Dictionary<string, int> Items { get; set; }

        /// <inheritdoc/>
        public void AddItem(NodeType itemName, int cost)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void AddSpecificTrenchItem(NodeType sourceNode, NodeType targetNode, int cost)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void AddTrenchItem(EdgeType edge, int cost)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public int GetEdgeCost(Edge item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public int GetNodeCost(Node item)
        {
            throw new NotImplementedException();
        }
    }
}
