using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitTestLab1;

namespace testdata
{
    public class Class1
    {
        [TestFixture]
        public class Class2
        {
            //Sonia Jayashankar Assignment
            [Test]
            public void ValidTriangle_Input60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;
                string expected = "The triangle is valid.";
                //Act   
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ValidTriangle_Input50and50_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 50;
                int secondAngle = 50;
                int thirdAngle = 70;
                string expected = "The triangle is valid.";
                //Act   
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

    }
}
