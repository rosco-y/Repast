using System;
using System.Collections.Generic;
using System.Text;

namespace RepastLib.CharSets
{

        /// <summary>
        /// ! " # $ % & ' ( ) + , - . /
        /// </summary>
        public class SpecialChars : CharSet
        {
                public SpecialChars() : base(33, 47)
                {

                }
        }
}
