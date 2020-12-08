using System;

namespace VerifyThat
{
    public static class Verify
    {
        /// <summary>
        /// Equality comparer string-string for the That function.
        /// </summary>
        /// <remarks>
        /// LowerCase was used on purpose out of the following reasons
        /// 1. Uppercase (Equals) is used for Object.Equals().
        ///    For better readability the Verify class is used as static
        ///    using.
        /// 2. It is a verb in the sentence.
        /// 
        /// For both reasons take a look at the code sample from <see cref="Verify.That<T>(string s, Func<string, T, bool> g, T value)"/>
        /// </remarks>
        public static bool equals(string p1, string p2) => p1 == p2;

        /// <summary>
        /// Equality comparer string-int for the That function.
        /// <see cref="Verify.equals(string, string)"/>
        /// </summary>
        public static bool equals(string p1, int p2) => Int32.Parse(p1) == p2;

        /// <summary>
        /// Compare strings using a comparer function with T
        /// </summary>
        /// <example>
        /// <code>
        /// using VerifyThat;
        /// using static VerifyThat.Verify;
        ///
        /// Verify.That("1", equals, 1);
        /// </code>
        /// </example>
        public static bool That<T>(string s, Func<string, T, bool> g, T value) =>
            g(s, value);
    }
}
