// <copyright file="Edge.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.DataObjects
{
    /// <summary>
    /// The edge type.
    /// </summary>
    public enum EdgeType
    {
        /// <summary>
        /// A road type of edge.
        /// </summary>
        Road,

        /// <summary>
        /// A verge type of edge.
        /// </summary>
        Verge
    }

    /// <summary>
    /// An edge between two nodes in an order.
    /// </summary>
    public class Edge
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Edge"/> class.
        /// </summary>
        /// <param name="source">The given source node.</param>
        /// <param name="target">The given target node.</param>
        /// <param name="type">The edge's type.</param>
        /// <param name="distanceMetres">The distance between the source and target nodes in metres.</param>
        public Edge(Node source, Node target, EdgeType type, int distanceMetres)
        {
            this.Source = source;
            this.Target = target;
            this.Type = type;
            this.DistanceMetres = distanceMetres;
        }

        /// <summary>
        /// Gets the source - or beginning - of the edge.
        /// </summary>
        public Node Source { get; private set; }

        /// <summary>
        /// Gets the target - or end - of the edge.
        /// </summary>
        public Node Target { get; private set; }

        /// <summary>
        /// Gets the edge's type.
        /// </summary>
        public EdgeType Type { get; private set; }

        /// <summary>
        /// Gets the distance between the edge's source and target in metres.
        /// </summary>
        public int DistanceMetres { get; private set; }
    }
}
