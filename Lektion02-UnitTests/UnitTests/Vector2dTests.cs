using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Internal;
using NUnit.Framework;
using System.Numerics;
using Lektion2;

namespace Lektion2.UnitTests
{
    /*
     Write a class to represent a 2d vector in the plane. Add an appropriate constructor and
       methods for addition and subtraction of vectors. Add methods to compute the scalar and
       cross product.
     
     */

    [TestFixture]
    class Vector2dTests
    {
        private Vector2 vec1;
        private Vector2 vec2;
        private Vector2D vectorMath;

        [SetUp]
        public void Setup()
        {
            // Arrange
            vec1 = new Vector2() { X = 2, Y = 3 };
            vec2 = new Vector2() { X = 5, Y = 5 };
            vectorMath = new Vector2D();
        }

        [Test]
        public void Addition_Vec1AddedWithVec2_ReturnsVecAplusB()
        {
            // Act
            Vector2 result = vectorMath.Add(vec1, vec2);

            // Assert
            Assert.That(result, Is.EqualTo(new Vector2(){X=7,Y=8}));
        }

        [Test]
        public void Subtraction_Vec1SubWithVec2_ReturnsVecAsubB()
        {
            // Act
            Vector2 result = vectorMath.Sub(vec1, vec2);

            // Assert
            Assert.That(result, Is.EqualTo(new Vector2() { X = -3, Y = -2 }));
        }

        [Test]
        public void ScalarProduct_Vec1ScalarVec2_ReturnScalerOfVec1AndVec2()
        {
            float result = vectorMath.Scalar(vec1, vec2);

            Assert.That(result, Is.EqualTo(25));
        }

        // Lav evt. cross product i fællesskab

    }
}
