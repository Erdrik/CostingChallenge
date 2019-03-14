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
            this.NodeCosts = new Dictionary<NodeType, int>();
            this.EdgeCosts = new Dictionary<EdgeType, int>();
        }

        /// <summary>
        /// Gets or sets the items and their costs.
        /// </summary>
        private Dictionary<NodeType, int> NodeCosts { get; set; }

        /// <summary>
        /// Gets or sets the items and their costs.
        /// </summary>
        private Dictionary<EdgeType, int> EdgeCosts { get; set; }

        /// <inheritdoc/>
        public void AddItem(NodeType nodeType, int cost)
        {
            if (this.NodeCosts.ContainsKey(nodeType))
            {
                throw new ArgumentException($"The item[{nodeType}] has already been added to this rate card with a cost of[{this.NodeCosts[nodeType]}].");
            }
            else
            {
                this.NodeCosts.Add(nodeType, cost);
            }
        }

        /// <inheritdoc/>
        public void AddSpecificTrenchItem(NodeType sourceNode, NodeType targetNode, int cost)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void AddTrenchItem(EdgeType edgeType, int cost)
        {
            if (this.EdgeCosts.ContainsKey(edgeType))
            {
                throw new ArgumentException($"The item[{edgeType}] has already been added to this rate card with a cost of[{this.EdgeCosts[edgeType]}].");
            }
            else
            {
                this.EdgeCosts.Add(edgeType, cost);
            }
        }

        /// <inheritdoc/>
        public int GetNodeCost(Node item)
        {
            if (this.NodeCosts.ContainsKey(item.Type))
            {
                return this.NodeCosts[item.Type];
            }
            else
            {
                throw new ArgumentException($"This rate card does not contain a cost for node type[{item.Type}].");
            }
        }

        /// <inheritdoc/>
        public int GetEdgeCost(Edge item)
        {
            if (this.EdgeCosts.ContainsKey(item.Type))
            {
                return this.EdgeCosts[item.Type];
            }
            else
            {
                throw new ArgumentException($"This rate card does not contain a cost for edge type[{item.Type}].");
            }
        }
    }
}
