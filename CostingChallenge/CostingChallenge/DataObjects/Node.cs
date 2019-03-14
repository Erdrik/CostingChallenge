// <copyright file="Node.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.DataObjects
{
    /// <summary>
    /// A node in an order.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="name">The given name.</param>
        public Node(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the node's name.
        /// </summary>
        public string Name { get; private set; }
    }
}
