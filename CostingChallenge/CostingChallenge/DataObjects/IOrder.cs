// <copyright file="IOrder.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.FileIO
{
    using System.Collections.Generic;
    using CostingChallenge.DataObjects;

    /// <summary>
    /// For getting the details of an order.
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Gets the nodes of this order.
        /// </summary>
        /// <returns>The nodes in this order.</returns>
        IEnumerable<Node> GetNodes();

        /// <summary>
        /// Gets the edges in this order.
        /// </summary>
        /// <returns>The edges in this order.</returns>
        IEnumerable<Edge> GetEdges();
    }
}
