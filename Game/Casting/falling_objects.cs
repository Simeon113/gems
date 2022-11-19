namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An object falling from the top of the screen</para>
    /// <para>
    /// The responsibility of a falling object is to keep track of a point value.
    /// </para>
    /// </summary>   
    public class Falling_object: Actor {
        private int _points;

        /// <summary>
        /// Constructs a new instance of falling_object.
        /// </summary>
        public Falling_object() {


        }

        /// <summary>
        /// Gets the artifact's points.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public int getPoints() {
            return _points;
        }

        /// <summary>
        /// Sets the falling object's points to the given value.
        /// </summary>
        /// <param name="points">The given mpoints.</param>
        public void SetPoints(int points) {
            this._points = points;
        }
    }

}