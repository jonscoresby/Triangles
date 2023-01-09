using Triangles;

namespace TrianglesTest
{
    [TestClass]
    public class ValidTriangleTests
    {
        [TestMethod]
        public void ThirdSideTooLong_InvalidTriangle()
        {
            Triangle triangle = new Triangle(1, 1, 3);
            Assert.IsFalse(triangle.isValid);
        }

        [TestMethod]
        public void FirstSideTooLong_InvalidTriangle()
        {
            Triangle triangle = new Triangle(3, 1, 1);
            Assert.IsFalse(triangle.isValid);
        }

        [TestMethod]
        public void Zero_ValidTriangle()
        {
            Triangle triangle = new Triangle(0, 0, 0);
            Assert.IsFalse(triangle.isValid);
        }

        [TestMethod]
        public void OneSideZero_ValidTriangle()
        {
            Triangle triangle = new Triangle(0, 1, 1);
            Assert.IsFalse(triangle.isValid);
        }

        [TestMethod]
        public void Zero_InvalidTriangle()
        {
            Triangle triangle = new Triangle(0, 1, 0);
            Assert.IsFalse(triangle.isValid);
        }

        [TestMethod]
        public void ThreeDifferentSides_InvalidTriangle()
        {
            Triangle triangle = new Triangle(2, 1, 3);
            Assert.IsFalse(triangle.isValid);
        }

        [TestMethod]
        public void ThreeDifferentSides_ValidTriangle()
        {
            Triangle triangle = new Triangle(2, 1.001, 3);
            Assert.IsTrue(triangle.isValid);
        }
    }

    [TestClass]
    public class TriangleAnglesTests
    {
        [TestMethod]
        public void EqualateralTriangle_AllAngles60Degrees()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            foreach(double i in triangle.angles)
            {
                Console.WriteLine(i);
            }
            Assert.AreEqual(60, triangle.angles[0]);
            Assert.AreEqual(60, triangle.angles[1]);
            Assert.AreEqual(60, triangle.angles[2]);
        }

        [TestMethod]
        public void LargeEqualateralTriangle_AllAngles60Degrees()
        {
            Triangle triangle = new Triangle(1000, 1000, 1000);
            foreach (double i in triangle.angles)
            {
                Console.WriteLine(i);
            }
            Assert.AreEqual(60, triangle.angles[0]);
            Assert.AreEqual(60, triangle.angles[1]);
            Assert.AreEqual(60, triangle.angles[2]);
        }

        [TestMethod]
        public void RightTriangle_LargeSideHas90DegreeAngle()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            foreach (double i in triangle.angles)
            {
                Console.WriteLine(i);
            }
            Assert.AreEqual(90, triangle.angles[0]);
        }

        [TestMethod]
        public void GeneralAngleTest()
        {
            Triangle triangle = new Triangle(5.5, 9, 7.1);
            foreach (double i in triangle.angles)
            {
                Console.WriteLine(i);
            }
            Assert.AreEqual(37.66947, triangle.angles[0]);
            Assert.AreEqual(90.24943, triangle.angles[1]);
            Assert.AreEqual(52.0811, triangle.angles[2]);
        }
    }

    [TestClass]
    public class TriangleSideClassificationTests
    {
        [TestMethod]
        public void EqualateralTriangle_Equalateral()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.AreEqual(Side.equilateral, triangle.sideClass);
        }

        [TestMethod]
        public void LargeEqualateralTriangle_Equalateral()
        {
            Triangle triangle = new Triangle(1000, 1000, 1000);
            Assert.AreEqual(Side.equilateral, triangle.sideClass);
        }

        [TestMethod]
        public void FirstSideSmaller_Isoceles()
        {
            Triangle triangle = new Triangle(.999, 1, 1);
            Assert.AreEqual(Side.isosceles, triangle.sideClass);
        }

        [TestMethod]
        public void FirstSideLarger_Isoceles()
        {
            Triangle triangle = new Triangle(1.001, 1, 1);
            Assert.AreEqual(Side.isosceles, triangle.sideClass);
        }
        [TestMethod]
        public void ThirdSideSmaller_Isoceles()
        {
            Triangle triangle = new Triangle(1, 1, .999);
            Assert.AreEqual(Side.isosceles, triangle.sideClass);
        }

        [TestMethod]
        public void ThirdSideLarger_Isoceles()
        {
            Triangle triangle = new Triangle(1, 1, 1.001);
            Assert.AreEqual(Side.isosceles, triangle.sideClass);
        }

        [TestMethod]
        public void FirstSideSmallerThirdSideLarger_Scalene()
        {
            Triangle triangle = new Triangle(0.999, 1, 1.001);
            Assert.AreEqual(Side.scalene, triangle.sideClass);
        }

        [TestMethod]
        public void FirstSideLargerThirdSideSmaller_Scalene()
        {
            Triangle triangle = new Triangle(1.001, 1, 0.999);
            Assert.AreEqual(Side.scalene, triangle.sideClass);
        }
    }

    [TestClass]
    public class TriangleAngleClassificationTests
    {
        [TestMethod]
        public void EqualateralTriangle_Acute()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.AreEqual(Angle.acute, triangle.angleClass);
        }

        [TestMethod]
        public void LargeEqualateralTriangle_Acute()
        {
            Triangle triangle = new Triangle(1000, 1000, 1000);
            Assert.AreEqual(Angle.acute, triangle.angleClass);
        }

        [TestMethod]
        public void BasicPythagoreanTriplet_Right()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(Angle.right, triangle.angleClass);
        }

        [TestMethod]
        public void BasicPythagoreanTripletBackwards_Right()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.AreEqual(Angle.right, triangle.angleClass);
        }

        [TestMethod]
        public void HypotenuseSmaller_Acute()
        {
            Triangle triangle = new Triangle(3, 4, 4.999);
            Assert.AreEqual(Angle.acute, triangle.angleClass);
        }

        [TestMethod]
        public void HypotenuseLarger_Obtuse()
        {
            Triangle triangle = new Triangle(3, 4, 5.001);
            Assert.AreEqual(Angle.obtuse, triangle.angleClass);
        }

        [TestMethod]
        public void IsocelesRight_Right()
        {
            Triangle triangle = new Triangle(3, 3, Math.Sqrt(18));
            Assert.AreEqual(Angle.right, triangle.angleClass);
        }
    }
}