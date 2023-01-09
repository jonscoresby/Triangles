using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public enum Side
    {
        scalene,
        isosceles,
        equilateral
    }

    public enum Angle
    {
        right,
        acute,
        obtuse
    }
    public class Triangle
    {
        
        public double[] sides;
        public double[] angles;
        public bool isValid;
        public Side sideClass;
        public Angle angleClass;


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
            return Math.Round(Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * 180 / Math.PI, 5);
        }

        private bool calculateValid()
        {
            var sortedSides = new double[3];
            this.sides.CopyTo(sortedSides, 0);
            Array.Sort(sortedSides);

            return sortedSides[2] < sortedSides[0] + sortedSides[1];
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
                return "a valid " + angleClass + " " + sideClass + " triangle";
                
            }
            else
            {
                return "an invalid triangle";
            }
        }
    }
}
