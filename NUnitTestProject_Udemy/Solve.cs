﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Udemy
{
    class Solve
    {
        public static Tuple<double, double> Quadratic(double a, double b, double c)
        {
            var disc = b * b - 4 * a * c;
            if (disc < 0)
            {
                throw new Exception("Cannot solve with complex roots");
            }
            else
            {
                var root = Math.Sqrt(disc);
                return Tuple.Create(
                    (-b + root) / 2 / a,
                    (-b - root) / 2 / a);
            }
        }
    }

    public class EquationTests
    {
        [Test]
        public void QuadraticTest()
        {
            var result = Solve.Quadratic(1, 10, 16);
        }
        [Test]
        public void QuadraticTestUnCoveredTest()
        {
            Assert.Throws<Exception>(() => Solve.Quadratic(1, 10, 100));
        }
    }
}
