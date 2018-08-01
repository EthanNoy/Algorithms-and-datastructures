using System;
using System.Collections.Generic;


namespace Ethan
{
    public static class ArraysAndStrings
    {

        /// <summary>
        /// Checks if the given string is spelled the same way forwards and backwards.
        /// </summary>
        /// <returns><c>true</c>, if the string is a palindrome, <c>false</c> otherwise.</returns>
        /// <param name="word">Word to check.</param>
        public static bool IsPalindrome(string word)
        {

            int s = 0;
            for (int e = word.Length - 1; e > 0; e--)
            {
                if (e == s)
                {   // if e and s are at the same place in the word
                    // there is no need to continue
                    // because we have already gone through the list
                    break;
                }
                else if (word[e] == ' ')
                {
                    // If e is an empty character than we skip over ++ing s
                    // because there is no need to move s, only e
                    continue;
                }
                else if (word[s] == ' ')
                {
                    // We have to ++ both e and s but e shouldn't be moving
                    e++;
                    s++;
                    continue;
                }
                else if (word[s] != word[e])
                {
                    // If at any point neither e nor s are spaces, and they are not the same letter,
                    // the given word cannot be a palindrome
                    return false;
                }
                s++;
            }

            return true;
        }

        // input: 'rpcket', {'rocket league', 'the long dark', 'ancient future', 'rambo'}
        public static string BestMatch(string entry, List<string> dictionary)
        {

            List<int> Score = new List<int>();

            for (int i = 0; i < dictionary.Count; i++)
            {

                int thisScore = 0;

                // entry

                // dictionary[i]

                // Contains(data, thingToLookFor)

                if (Contains(dictionary[i], entry))
                {
                    return dictionary[i];
                }

                for (int g = 0; g < entry.Length; g++)
                {
                    if (Contains(dictionary[i], entry.Substring(g, 1)))
                    {
                        thisScore++;
                    }
                }

                // calculate the score

                // add it to the list of scores

                Score.Add(thisScore);

            }

            int Biggest_Position = 0;

            for (int s = 0; s < Score.Count; s++)
            {
                if (Score[s] > Score[Biggest_Position])
                {
                    Biggest_Position = s;
                }
            }

            return dictionary[Biggest_Position];

        }

        public static bool Contains(string source, string key)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source.Length - i < key.Length)
                    return false;

                // looks for first letter of key in source
                if (source[i] == key[0])
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (source[i + j] != key[j])
                        {
                            break;
                        }
                        else if (j == key.Length - 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static List<string> prefixes(string word)
        {

            List<string> results = new List<string>();

            for (int i = 1; i <= word.Length; i++)
            {
                results.Add(word.Substring(0, i));
            }

            return results;

        }

        public static List<string> rotations(string word)
        {
            List<string> results = new List<string>();

            for (int i = 1; i <= word.Length; i++)
            {
                results.Add(word.Substring(i, word.Length - i) + word.Substring(0, i));

            }

            return results;

        }

        // O(L * R)
        public static bool SameSet(int[] left, int[] right)
        {

            if (left.Length == right.Length)
            {

                for (int i = 0; i < right.Length; i++)
                {
                    int Left_Current = left[i];

                    for (int e = right.Length - 1; e >= 0; e--)
                    {
                        if (right[e] == Left_Current)
                        {
                            break;
                        }
                        else if (e == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        // O(L)
        public static bool SameSetLinear(int[] left, int[] right)
        {

            if (left.Length != right.Length)
                return false;

            int max = 0;

            for (int i = 0; i < left.Length; i++)
            {
                if (max < left[i])
                    max = left[i];
            }

            bool[] values = new bool[max + 1];

            for (int i = 0; i < left.Length; i++)
            {
                values[left[i]] = true;
            }

            for (int i = 0; i < right.Length; i++)
            {
                if (right[i] > max)
                    return false;
                if (!values[right[i]])
                    return false;
            }

            return true;
        }


        public static bool ArraysRotated(int[] left, int[] right)
        {
            if (left.Length == right.Length)
            {

                int rightStart = -1;

                for (int i = 0; i < right.Length; i++)
                {

                    //find a matching pair
                    if (left[0] == right[i])
                    {
                        rightStart = i;
                        break;
                    }

                }

                // now, two things could have happened:
                // 1 - didn't find a match
                // 2 - found match

                if (rightStart == -1)
                    return false;

                // loop through both lists to ensure match

                int r = rightStart;

                for (int l = 0; l < left.Length; l++)
                {

                    if (left[l] != right[r])
                        return false;

                    r++;

                    if (r >= right.Length)
                    {
                        r = 0;
                    }

                }

                return true;

            }
            return false;
        }

        public static bool ArraysEqual(int[] A_, int[] B_)
        {
            if (A_ != null && B_ != null)
            {
                if (A_.Length == B_.Length)
                {
                    for (int i = 0; i < A_.Length; i++)
                    {
                        if (A_[i] != B_[i])
                        {
                            return false;
                        }

                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
