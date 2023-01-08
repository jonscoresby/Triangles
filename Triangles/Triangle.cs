using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    enum Side
    {
        scalene,
        isosceles,
        equilateral
    }

    enum Angle
    {
        right,
        acute,
        obtuse
    }
    internal class Triangle
    {
        
        double[] sides;
        double[] angles;
        bool isValid;
        Side sideClass;
        Angle angleClass;


        public Triangle(double a, double b, double c)
        {
            this.sides = new double[] {a,b,c};
            this.angles = calculateAngles();
            this.isValid = calculateValid();
            this.sideClass = calculateSideClass();
            this.angleClass = calculateAngleClass();
        }

        private double[] calculateAngles()
        {
            return new double[] {
                calculateAngle(this.sides[0], this.sides[1], this.sides[2]), 
                calculateAngle(this.sides[1], this.sides[0], this.sides[2]), 
                calculateAngle(this.sides[2], this.sides[0], this.sides[1])};
        }

        private double calculateAngle(double a, double b, double c)
        {
            return Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * 180 / Math.PI;
        }
        private bool calculateValid()
        {
            var sortedSides = new double[3];
            sides.CopyTo(sortedSides, 0);
            sortedSides.OrderBy((key) => key);

            return sortedSides[0] <= sortedSides[1] + sortedSides[2];
        }

        private Side calculateSideClass()
        {
            if (this.sides[0] == this.sides[1] && this.sides[1] == this.sides[2])
            {
                return Side.equilateral;
            }
            else if (this.sides[0] == this.sides[1] || this.sides[1] == this.sides[2] || this.sides[0] == this.sides[2])
            {
                return Side.isosceles;
            }
            else
            {
                return Side.scalene;
            }
        }

        private Angle calculateAngleClass()
        {
            if (this.angles.Max() > 90)
            {
                return Angle.obtuse;
            } 
            else if (this.angles.Max() < 90)
            {
                return Angle.acute;
            }
            else
            {
                return Angle.right;
            }
        }

        public override string ToString()
        {
            if (this.isValid)
            {
                return "an invalid triangle";
            }
            else
            {
                return "a valid " + angleClass + " " + sideClass + " triangle";
            }
        }
    }
}
