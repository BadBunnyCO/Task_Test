using Xunit;
using MyClass;
namespace MyClassTest
{
    public class MyClassTest
    {
        [Fact]
        public void Rec_Tri_Test()
        {
            // arrange
            int a = 6;
            int b = 8;
            int c = 10;
            int expected = 24;

            //act
            double actual = Square.Triangle(a, b, c);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Tri_Test()
        {
            // arrange
            int a = 3;
            int b = 5;
            int c = 6;
            double expected = 7.48;

            //act
            double actual = Square.Triangle(a, b, c);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SM_Cirlce_Test()
        {
            // arrange
            int r = 1;
            double expected = 3.14;

            //act
            double actual = Square.Circle(r);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SM_Rec_Tri_Test()
        {
            // arrange
            int a = 6;
            int b = 8;
            int c = 10;
            int expected = 24;

            //act
            double actual = Square.SomeFigure(a, b, c);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SM_Tri_Test()
        {
            // arrange
            int a = 3;
            int b = 5;
            int c = 6;
            double expected = 7.48;

            //act
            double actual = Square.SomeFigure(a, b, c);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Cirlce_Test()
        {
            // arrange
            int r = 1;
            double expected = 3.14;

            //act
            double actual = Square.SomeFigure(r);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}