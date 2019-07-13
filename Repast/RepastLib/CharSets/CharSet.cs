using System;
using System.Collections.Generic;
using System.Text;

namespace RepastLib.CharSets
{
        /// <summary>
        /// Base class for charsets to enable creating a 
        /// List<allowed charsets> _charsets; to easily generate
        /// random chars for passwords.
        /// </summary>
        public abstract class CharSet
        {
                int __minAsciiValue;
                int _maxAsciiValue;

                // has this set been used in generating the password?
                public bool SetUsed { get; set; } 
                public static Random _rnd = new Random();

                public CharSet(int min, int max)
                {
                        __minAsciiValue = min;
                        _maxAsciiValue = max;
                }

                /// <summary>
                /// Generate a random charactor in the specified range
                /// </summary>
                /// <returns>char as string, 
                /// so it's easier to add to password string
                /// </returns>
                public string GenerateRandomChar()
                {
                        int iChar = _rnd.Next(__minAsciiValue, _maxAsciiValue + 1);
                        char c = (char)iChar;
                        return c.ToString().Trim();
                }
        }
}
