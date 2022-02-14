using NUnit.Framework;
using PixelsPerInch;

namespace TestPixlePerInch
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public static void TestPixlePerInch_WhenWidth1__Height2_Diaglonal3_ReturnsPPI0_75()
        {
            //Arrange - prepare required data
            int width = 1;
            int height = 2;
            int diagonal = 3;

            //Act
            var result = PixelCalc.Calculate(width, height, diagonal);

            //Assert
            Assert.AreEqual(result.Ppi, 0.75);
        }

        [Test]
        public static void TestPixlePerInch_WhenWidth3__Height7_Diaglonal8_ReturnsNotNullObject()
        {
            //Arrange - prepare required data
            int width = 3;
            int height = 7;
            int diagonal = 8;

            //Act
            var result = PixelCalc.Calculate(width, height, diagonal);

            //Assert
            Assert.NotNull(result);
        }

        [Test]
        public static void TestPixlePerInch_WhenWidth6__Height1_Diaglonal5_ReturnsDiagonal6_08()
        {
            //Arrange - prepare required data
            int width = 6;
            int height = 1;
            int diagonal = 5;

            //Act
            var result = PixelCalc.Calculate(width, height, diagonal);

            //Assert
            Assert.AreEqual(result.Diagonal, 6.08);
        }


        [Test]
        public static void TestPixlePerInch_WhenWidth3__Height6_Diaglonal8_ReturnsDotPitchGreaterThan()
        {
            //Arrange - prepare required data
            int width = 3;
            int height = 6;
            int diagonal = 8;

            //Act
            var result = PixelCalc.Calculate(width, height, diagonal);

            //Assert
            Assert.Greater(result.DotPitch, 30);
        }

        [Test]
        public static void TestPixlePerInch_WhenWidth8__Height1_Diaglonal20_ReturnsDiagonalLessThan9()
        {
            //Arrange - prepare required data
            int width = 8;
            int height = 1;
            int diagonal = 20;

            //Act
            var result = PixelCalc.Calculate(width, height, diagonal);

            //Assert
            Assert.Less(result.Diagonal, 9);
        }

    }
}