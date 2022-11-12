namespace Unit04.Game.Casting
{
    // TODO: Implement the Artifact class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Actor class.

        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>

    
    public class Falling_object: Actor {

        private string message;

        private int _points;
    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Falling_object() {


        }

    // 3) Create the GetMessage() method. Use the following method comment.

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public string GetMessage() {
            return  message;
        }

        public int getPoints() {
            return _points;
        }

    // 4) Create the SetMessage(string message) method. Use the following method comment.

        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetMessage(string given_message) {
            message = given_message;
            
        }
        public void SetPoints(int points) {
            this._points = points;
        }
    }

}