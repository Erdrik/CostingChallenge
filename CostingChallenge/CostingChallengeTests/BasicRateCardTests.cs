// <copyright file="BasicRateCardTests.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

#pragma warning disable CS1591
#pragma warning disable SA1600

namespace CostingChallengeTests
{
    using CostingChallenge.DataObjects;
    using Moq;
    using NUnit.Framework;
    using System;

    public class BasicRateCardTests
    {
        [Test]
        public void CanAddItemsToRateCard()
        {
            var rateCard = new BasicRateCard();

            var values = Enum.GetValues(typeof(NodeType));

            var i = 0;
            foreach (var e in values)
            {
                var nodeType = (NodeType)e;
                rateCard.AddItem(nodeType, i);
                ++i;
            }

            i = 0;
            foreach (var e in values)
            {
                var nodeType = (NodeType)e;
                var testNode = new Node(nodeType);
                var cost = 0;
                Assert.DoesNotThrow(() => cost = rateCard.GetNodeCost(testNode));
                Assert.AreEqual(i, cost);
                ++i;
            }
        }

        [Test]
        public void CanAddTrenchItems()
        {
            var rateCard = new BasicRateCard();

            var values = Enum.GetValues(typeof(EdgeType));

            var i = 0;
            foreach (var e in values)
            {
                var edgeType = (EdgeType)e;
                rateCard.AddTrenchItem(edgeType, i);
                ++i;
            }

            var firstNode = new Node(NodeType.Cabinet);
            var secondNode = new Node(NodeType.Pot);

            i = 0;
            foreach (var e in values)
            {
                var edgeType = (EdgeType)e;
                var testEdge = new Edge(firstNode, secondNode, edgeType, 1);
                var cost = 0;
                Assert.DoesNotThrow(() => cost = rateCard.GetEdgeCost(testEdge));
                Assert.AreEqual(i, cost);
                ++i;
            }
        }

        [Test]
        public void SpecificEdgeCostCalculatedCorrectly()
        {
            var rateCard = new BasicRateCard();

            rateCard.AddSpecificTrenchItem(NodeType.Cabinet, NodeType.Pot, (x) => 20 * x.DistanceMetres);

            var firstNode = new Node(NodeType.Cabinet);
            var secondNode = new Node(NodeType.Pot);

            var testEdge = new Edge(firstNode, secondNode, EdgeType.Road, 5);
            var cost = 0;
            Assert.DoesNotThrow(() => cost = rateCard.GetEdgeCost(testEdge));
            Assert.AreEqual(100, cost);
        }
    }
}
