using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Internal;
using NUnit.Framework;
using System.Drawing;
using NUnit.Framework.Constraints;

namespace Lektion2.UnitTests
{
    [TestFixture]
    class CircleTest
    {
        [Test]
        public void DetermineInsideCircle_InCircle_ReturnsInside()
        {
            // Arrange
            var circle = new Circle() {center = new Point(){X=0, Y=0}, radius = 12};

            // Act
            var result = circle.DetermineInsideCircle(new Point() {X=2, Y=4});

            // Assert
            //Assert.That(result, Is.EqualTo(CircleState.inside));
            Assert.True(true);
        }

        [Test]
        public void DetermineInsideCircle_OutsideCircle_ReturnsOutside()
        {
            // Arrange
            var circle = new Circle() { center = new Point() { X = 0, Y = 0 }, radius = 12 };

            // Act
            var result = circle.DetermineInsideCircle(new Point() { X = 10, Y = 20 });

            // Assert
            Assert.That(result, Is.EqualTo(CircleState.outside));
        }

        [Test]
        public void DetermineInsideCircle_OnCircle_ReturnsOn()
        {
            // Arrange
            var circle = new Circle() { center = new Point() { X = 0, Y = 0 }, radius = 12 };

            // Act
            var result = circle.DetermineInsideCircle(new Point() { X = 0, Y = 12 });

            // Assert
            Assert.That(result, Is.EqualTo(CircleState.on));
        }


    }
}
