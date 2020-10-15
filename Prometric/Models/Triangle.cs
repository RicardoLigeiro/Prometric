using System;

namespace Prometric.Models
{
    /// <summary>
    ///     This represents a Triangle
    /// </summary>
    public class Triangle : IShape
    {
        #region Fields

        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        #endregion

        #region Ctor

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0d) throw new ArgumentException("First side must be grater that 0");

            if (side2 <= 0d) throw new ArgumentException("Second side must be grater that 0");

            if (side3 <= 0d) throw new ArgumentException("Third side must be grater that 0");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Object name
        /// </summary>
        public string Name {
            get
            {
                if (_side1 == _side2 && _side2 == _side3) return "Equilateral";

                if (_side1 == _side2 || _side1 == _side3 || _side2 == _side3) return "Isosceles";

                return "Scalene";
            }
        }

        /// <summary>
        ///     Area
        /// </summary>
        public double Area => _side1 * _side2 * _side3 / 2;

        /// <summary>
        ///     Perimeter
        /// </summary>
        public double Perimeter => _side1 + _side2 + _side3;

        #endregion
    }
}