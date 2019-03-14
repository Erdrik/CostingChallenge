// <copyright file="XmlOrderFileReader.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CostingChallenge.FileIO
{
    using System;
    using System.Collections.Generic;
    using CostingChallenge.DataObjects;

    /// <summary>
    /// Reads an xml file and parses it for the order.
    /// </summary>
    public class XmlOrderFileReader : IOrder
    {
        /// <inheritdoc/>
        public IEnumerable<Edge> GetEdges()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IEnumerable<Node> GetNodes()
        {
            throw new NotImplementedException();
        }
    }
}
