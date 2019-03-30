using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace Lektion2.UnitTests
{
    [TestFixture]
    class OwnStringTests
    {
        [Test]
        public void CharAt_WhenCalled_ReturnPositionOfChar()
        {
            // Arrange
            OwnString ownStr = new OwnString();
            char[] str = { 'h', 'e', 'l', 'l', 'o' };

            // Act
            int result = ownStr.CharAt(str, 'e');

            // Assert
            Assert.That(result, Is.EqualTo(1));

            
        }

        [Test]
        public void Length_WhenCalled_ReturnLengthOfOwnString()
        {
            // Arrange
            OwnString ownStr = new OwnString();
            char[] str = { 'h', 'e', 'l', 'l', 'o' };

            // Act
            int result = ownStr.Length(str);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        // [Values] teste med flere værdier som parameterized test

        [Test]
        public void SubString_WhenCalled_ReturnsSubStringOfOwnString()
        {
            // Arrange
            OwnString ownStr = new OwnString();
            char[] str = { 'h', 'e', 'l', 'l', 'o' };
            char[] expected = { 'e', 'l', 'l' };

            // Act
            char[] result = ownStr.SubString(str, 1, 3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));

            
        }

     

        [Test]
        public void ToLowerCase_WhenCalled_ReturnsStringInLower()
        {
            // A
            OwnString ownStr = new OwnString();
            char[] str = { 'H', 'E', 'L', 'L', 'O' };
            char[] expected = { 'h', 'e', 'l', 'l', 'o' };

            // A
            char[] result = ownStr.ToLowerCase(str);

            // A
            Assert.That(result, Is.EqualTo(expected));

        }

    }
}
