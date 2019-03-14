// <copyright file="Node.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.DataObjects
{
    /// <summary>
    /// The type of the node.
    /// </summary>
    public enum NodeType
    {
        /// <summary>
        /// The cabinet type.
        /// </summary>
        Cabinet,

        /// <summary>
        /// The chamber type.
        /// </summary>
        Chamber,

        /// <summary>
        /// The pot type.
        /// </summary>
        Pot,

        /// <summary>
        /// The trench type.
        /// </summary>
        Trench,
    }

    /// <summary>
    /// A node in an order.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="type">The given type.</param>
        public Node(NodeType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets the node's name.
        /// </summary>
        public NodeType Type { get; private set; }
    }
}
