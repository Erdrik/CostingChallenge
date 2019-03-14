// <copyright file="CostingChallengeTests.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

// Unit tests should be self documenting!
#pragma warning disable CS1591
#pragma warning disable SA1600

namespace Tests
{
    using System.Collections.Generic;
    using CostingChallenge.Calculators;
    using CostingChallenge.DataObjects;
    using CostingChallenge.FileIO;
    using Moq;
    using NUnit.Framework;

    public class BasicOrderCalculatorTests
    {
        private Mock<IOrder> goodOrder;

        private Mock<IRateCard> goodRateCard;

        [SetUp]
        public void Setup()
        {
            this.goodOrder = new Mock<IOrder>();

            this.goodRateCard = new Mock<IRateCard>();
        }

        [Test]
        public void UsingRateCard_WithOneNode_CalculatesCorrectly()
        {
            this.SetupOneNode();
            this.SetupRateCardA();

            var calculator = new BasicOrderCalculator();

            var total = 0;
            Assert.DoesNotThrow(
                () =>
                {
                    total = calculator.OrderCostAccordingToRateCard(this.goodOrder.Object, this.goodRateCard.Object);
                });

            Assert.AreEqual(1000, total);
        }

        [Test]
        public void UsingRateCard_MultipleNodesDifferentValues_CalculatesCorrectly()
        {
            this.SetupMultipleNodes();
            this.SetupRateCardA();

            var calculator = new BasicOrderCalculator();

            var total = 0;
            Assert.DoesNotThrow(
                () =>
                {
                    total = calculator.OrderCostAccordingToRateCard(this.goodOrder.Object, this.goodRateCard.Object);
                });

            Assert.AreEqual(1300, total);
        }

        [Test]
        public void UsingRateCard_MultipleNodesAndEdges_CalculatesCorrectly()
        {
            this.SetupMultipleNodesAndEdges();
            this.SetupRateCardA();

            var calculator = new BasicOrderCalculator();

            var total = 0;
            Assert.DoesNotThrow(
                () =>
                {
                    total = calculator.OrderCostAccordingToRateCard(this.goodOrder.Object, this.goodRateCard.Object);
                });

            Assert.AreEqual(1650, total);
        }

        private void SetupOneNode()
        {
            var oneNode = new List<Node>
            {
                new Node(NodeType.Cabinet),
            };

            this.goodOrder.Setup(m => m.GetNodes()).Returns(oneNode);
        }

        private void SetupMultipleNodes()
        {
            var goodNodes = new List<Node>
            {
                new Node(NodeType.Cabinet),
                new Node(NodeType.Chamber),
                new Node(NodeType.Pot),
            };

            this.goodOrder.Setup(m => m.GetNodes()).Returns(goodNodes);
        }

        private void SetupMultipleNodesAndEdges()
        {
            var cabinet = new Node(NodeType.Cabinet);
            var chamber = new Node(NodeType.Chamber);
            var pot1 = new Node(NodeType.Pot);
            var pot2 = new Node(NodeType.Pot);

            var goodNodes = new List<Node>
            {
                cabinet,
                chamber,
                pot1,
                pot2,
            };

            this.goodOrder.Setup(m => m.GetNodes()).Returns(goodNodes);

            var goodEdges = new List<Edge>
            {
                new Edge(cabinet, chamber, EdgeType.Verge, 50),
                new Edge(pot1, chamber, EdgeType.Road, 50),
                new Edge(pot1, pot2, EdgeType.Road, 100),
            };

            this.goodOrder.Setup(m => m.GetEdges()).Returns(goodEdges);
        }

        private void SetupRateCardA()
        {
            this.goodRateCard.Setup(m => m.GetNodeCost(It.Is<Node>(x => x.Type == NodeType.Cabinet))).Returns(1000);
            this.goodRateCard.Setup(m => m.GetNodeCost(It.Is<Node>(x => x.Type == NodeType.Chamber))).Returns(200);
            this.goodRateCard.Setup(m => m.GetNodeCost(It.Is<Node>(x => x.Type == NodeType.Pot))).Returns(100);
            this.goodRateCard.Setup(m => m.GetEdgeCost(It.Is<Edge>(x => x.Type == EdgeType.Road))).Returns(100);
            this.goodRateCard.Setup(m => m.GetEdgeCost(It.Is<Edge>(x => x.Type == EdgeType.Verge))).Returns(50);
        }
    }
}