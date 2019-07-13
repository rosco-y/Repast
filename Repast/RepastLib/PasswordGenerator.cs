using System;
using System.Collections.Generic;
using System.Text;
using RepastLib.CharSets;

namespace RepastLib
{
        public class PasswordGenerator
        {
                List<CharSet> _charsets;
                int _pwLen;
                Random _rnd;
                public PasswordGenerator(int pwLen,
                        bool lcAlpha,
                        bool numChars,
                        bool spec,
                        bool spec2,
                        bool spec3,
                        bool spec4,
                        bool UCAlpha)
                {
                        _rnd = new Random();
                        _pwLen = pwLen;

                        _charsets = new List<CharSet>();
                        if (lcAlpha)
                                _charsets.Add(new lcAlphaChars());
                        if (numChars)
                                _charsets.Add(new NumChars());
                        if (spec)
                                _charsets.Add(new SpecialChars());
                        if (spec2)
                                _charsets.Add(new SpecialChars2());
                        if (spec3)
                                _charsets.Add(new SpecialChars3());
                        if (spec4)
                                _charsets.Add(new SpecialChars4());
                        if (UCAlpha)
                                _charsets.Add(new UCAlphaChars());
                        
                }

                public string GeneratePassword()
                {
                        string password = string.Empty;
                        int iChars = 0;
                        int numSets = _charsets.Count;
                        while (iChars < _pwLen)
                        {
                                int iSet = _rnd.Next(numSets);
                                // returns char as string
                                password += _charsets[iSet].GenerateRandomChar();
                                iChars++;
                        }

                        return password;
                }
        }
}
