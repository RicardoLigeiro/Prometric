using System;

namespace Prometric.Models
{
    /// <summary>
    ///     This represents a Circle
    /// </summary>
    public class Circle : IShape
    {
        #region Ctor

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Circle(double radius)
        {
            if (radius <= 0d) throw new ArgumentException("Radius must be grater that 0");

            _radius = radius;
        }

        #endregion

        #region Fields

        private readonly double _pi = 3.14;
        private readonly double _radius;

        #endregion

        #region Properties

        /// <summary>
        ///     Object name
        /// </summary>
        public string Name => "Circle";

        /// <summary>
        ///     Area
        /// </summary>
        public double Area => _pi * _radius * _radius;

        /// <summary>
        ///     Perimeter
        /// </summary>
        public double Perimeter => 2 * _pi * _radius;

        #endregion
    }
}