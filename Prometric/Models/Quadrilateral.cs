using System;

namespace Prometric.Models
{
    /// <summary>
    ///     This represent a Quadrilateral
    /// </summary>
    public class Quadrilateral : IShape
    {
        #region Fields

        private readonly double _width;
        private readonly double _height;

        #endregion

        #region Ctor

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Quadrilateral(double width, double height)
        {
            if (width <= 0d) throw new ArgumentException("Width must be grater that 0");

            if (height <= 0d) throw new ArgumentException("Height must be grater that 0");

            _width = width;
            _height = height;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Object name
        /// </summary>
        public string Name => _width == _height ? "Square" : "Rectangle";

        /// <summary>
        ///     Area
        /// </summary>
        public double Area => _width * _height;

        /// <summary>
        ///     Perimeter
        /// </summary>
        public double Perimeter => Area * 2;

        #endregion
    }
}