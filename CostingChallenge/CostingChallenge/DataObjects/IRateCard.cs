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
        /// <param name="nodeType">The name of the item.</param>
        /// <param name="cost">The cost of the item in this rate card.</param>
        void AddItem(NodeType nodeType, int cost);

        /// <summary>
        /// Adds a default cost to a given edge type.
        /// </summary>
        /// <param name="edgeType">The edge type.</param>
        /// <param name="cost">The cost of the edge.</param>
        void AddTrenchItem(EdgeType edgeType, int cost);

        /// <summary>
        /// Adds a specific cost to a given edge type.
        /// </summary>
        /// <param name="sourceNode">The given source node.</param>
        /// <param name="targetNode">The given target node.</param>
        /// <param name="cost">The cost of this given specific cost.</param>
        void AddSpecificTrenchItem(NodeType sourceNode, NodeType targetNode, int cost);

        /// <summary>
        /// Gets the cost of a given node in the rate card.
        /// </summary>
        /// <param name="item">The name of the node.</param>
        /// <returns>The cost of the node.</returns>
        int GetNodeCost(Node item);

        /// <summary>
        /// Gets the cost of a given edge in the rate card.
        /// </summary>
        /// <param name="item">The name of the edge.</param>
        /// <returns>The cost of the edge.</returns>
        int GetEdgeCost(Edge item);
    }
}
