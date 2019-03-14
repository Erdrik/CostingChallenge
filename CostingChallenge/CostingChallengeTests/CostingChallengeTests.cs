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

    public class CostingChallengeTests
    {
        private Mock<IOrder> goodOrder;

        private Mock<IRateCard> goodRateCard;

        [SetUp]
        public void Setup()
        {
            this.goodOrder = new Mock<IOrder>();

            this.goodRateCard = new Mock<IRateCard>();
            this.goodRateCard.Setup(m => m.GetItemCost("Cabinet")).Returns(1000);
            this.goodRateCard.Setup(m => m.GetItemCost("Chamber")).Returns(200);
            this.goodRateCard.Setup(m => m.GetItemCost("Pot")).Returns(100);
        }

        [Test]
        public void UsingRateCard_WithOneNode_CalculatesCorrectly()
        {
            this.SetupOneNode();

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

            var calculator = new BasicOrderCalculator();

            var total = 0;
            Assert.DoesNotThrow(
                () =>
                {
                    total = calculator.OrderCostAccordingToRateCard(this.goodOrder.Object, this.goodRateCard.Object);
                });

            Assert.AreEqual(1300, total);
        }

        private void SetupOneNode()
        {
            var oneNode = new List<Node>
            {
                new Node("Cabinet"),
            };

            this.goodOrder.Setup(m => m.GetNodes()).Returns(oneNode);
        }

        private void SetupMultipleNodes()
        {
             var goodNodes = new List<Node>
            {
                new Node("Cabinet"),
                new Node("Chamber"),
                new Node("Pot"),
            };

            this.goodOrder.Setup(m => m.GetNodes()).Returns(goodNodes);
        }
    }
}