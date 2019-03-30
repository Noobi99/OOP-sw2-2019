
using NUnit.Framework;

namespace Lektion2.UnitTests
{
    [TestFixture]
    class PersonTest
    {
        [Test]
        public void GetBodyMassIndex_NormalPerson_ReturnsRealisticBMI()
        {
            var person = new Person(){height = 1.75f, weight = 70};

            var result = person.GetBodyMassIndex();

            Assert.That(result, Is.InRange(22.84, 22.86));

            

        }

        [Test]
        public void GetClassification_CheckNormalWeight_ReturnsNormalWeight()
        {
            var person = new Person() {height = 1.75f, weight = 70, bmi = 22.86f };
            
            var result = person.GetClassification(person.bmi);

            Assert.That(result, Does.StartWith("Normal").IgnoreCase);
            Assert.That(result, Does.EndWith("weight").IgnoreCase);

        }

        [Test]
        public void GetClassification_CheckObesity_ReturnsUnderWeight()
        {
            var person = new Person() { height = 1.75f, weight = 120, bmi = 39.18f };

            var result = person.GetClassification(person.bmi);

            StringAssert.AreEqualIgnoringCase(result, "Obesity");
        }

        [Test]
        public void GetClassification_CheckUnderWeight_ReturnsUnderWeight()
        {
            var person = new Person() { height = 1.75f, weight = 40, bmi = 13.06f };

            var result = person.GetClassification(person.bmi);

            StringAssert.AreEqualIgnoringCase(result, "Underweight");
        }

        [Test]
        public void GetClassification_CheckOverWeight_ReturnsOverWeight()
        {
            var person = new Person() { height = 1.75f, weight = 90, bmi = 29.38f };

            var result = person.GetClassification(person.bmi);

            StringAssert.AreEqualIgnoringCase(result, "Overweight");
        }

    }
}
