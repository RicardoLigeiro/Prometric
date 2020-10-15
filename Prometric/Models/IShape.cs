namespace Prometric.Models
{
    /// <summary>
    ///     Interface for the shapes
    /// </summary>
    public interface IShape
    {
        /// <summary>
        ///     Object name
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Area
        /// </summary>
        public double Area { get; }

        /// <summary>
        ///     Perimeter
        /// </summary>
        public string Perimeter { get; }
    }
}