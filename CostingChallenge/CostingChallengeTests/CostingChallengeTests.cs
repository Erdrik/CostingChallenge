﻿// <copyright file="CostingChallengeTests.cs" company="Samuel Ballard-Adams">
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
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UsingRateCard_WithOneNode_CalculatesCorrectly()
        {
            var mockReader = new Mock<IOrder>();

            var nodes = new List<Node>
            {
                new Node("Cabinet")
            };

            mockReader.Setup(m => m.GetNodes()).Returns(nodes);

            var mockRateCard = new Mock<IRateCard>();
            mockRateCard.Setup(m => m.GetItemCost(It.IsAny<string>())).Returns(100);

            var calculator = new BasicOrderCalculator();

            var total = 0;
            Assert.DoesNotThrow(
                () =>
                {
                    total = calculator.OrderCostAccordingToRateCard(mockReader.Object, mockRateCard.Object);
                });

            Assert.AreEqual(100, total);
        }
    }
}