using System;
using System.Collections.Generic;

namespace Ethan
{
    /// <summary>
    /// A stats counter counts the number of events that occur for players in a game.
    /// </summary>
    public class StatsCounter
    {

        private Dictionary<string, int> goals;

        public StatsCounter(){

            goals = new Dictionary<string, int>();

        }

        /// <summary>
        /// Registers that the specified player just scored a goal.
        /// </summary>
        /// <param name="playerName">Player name.</param>
        public void RegisterGoalScored(string playerName) {

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the goal count for the specified player.
        /// </summary>
        /// <returns>The goals.</returns>
        /// <param name="playerName">Player name.</param>
        public int GetGoals(string playerName)
        {
            throw new NotImplementedException();
        }



    }
}
