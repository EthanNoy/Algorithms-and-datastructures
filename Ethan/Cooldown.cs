using System;
namespace Ethan
{
    /// <summary>
    /// A Cooldown is an object that can be used to limit the frequency of an action.
    /// </summary>
    public class Cooldown
    {
        /// <summary>
        /// The minimum amount of time between actions.
        /// </summary>
        /// <value>The interval.</value>
        public float Interval
        {
            get;
            private set;
        }

        private float LastTimeUsed = float.NegativeInfinity;

        public Cooldown(float minimumInterval)
        {
            Interval = minimumInterval;
        }

        /// <summary>
        /// Gets the minimum amount of time between actions.
        /// </summary>
        /// <returns>The interval.</returns>
        public float GetInterval()
        {
            return Interval;
        }

        /// <summary>
        /// Sets the minimum amount of time between actions.
        /// Does not reset the cooldown.
        /// </summary>
        /// <param name="newInterval">New interval.</param>
        public void SetInterval(float newInterval)
        {
            Interval = newInterval;
        }

        /// <summary>
        /// Returns true if the Cooldown Action can be performed at the specified time.
        /// </summary>
        /// <returns>True if the action was successfuly, false otherwise.</returns>
        /// <param name="currentTime">Time we are attempting the action.</param>
        public bool Attempt(float currentTime)
        {
            if (currentTime >= Interval + LastTimeUsed){
                LastTimeUsed = currentTime;
                return true;
            }
            else{
                return false;

            }
        }

        /// <summary>
        /// Resets this cooldown, making it immediately usable.
        /// </summary>
        public void Reset()
        {
            LastTimeUsed = float.NegativeInfinity;
        }

        public float GetTimeUntilNextAction(float currentTime)
        {
            if (currentTime - LastTimeUsed > Interval)
            {
                return Interval;
            }
            else
            {
                return Interval - (currentTime - LastTimeUsed);
            }
        }

    }

}
